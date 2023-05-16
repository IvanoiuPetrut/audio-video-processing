using Emgu.CV.CvEnum;
using Emgu.CV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV.Structure;

namespace Proiect_audio_video.VideoProcessing
{
    public class VideoProcessor
    {
        private VideoCapture? capture;
        private int TotalFrame;
        private double Fps;
        private int FrameNo;
        private bool IsReadingFrame;
        private Rectangle ROI;
        private ImageProcessing imageProcessing;
        public VideoProcessor(int videoStreamWidth, int videoStreamHeight)
        {
            imageProcessing = new ImageProcessing();
            ROI = new Rectangle(0, 0, videoStreamWidth, videoStreamHeight);
        }

        public void SetROI(Rectangle roi)
        {
            ROI = roi;
        }
        public void LoadVideo(PictureBox pictureBox, ProgressBar progressBar)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                capture = new VideoCapture(ofd.FileName);
                Mat m = new Mat();
                capture.Read(m);
                pictureBox.Image = m.ToBitmap();

                TotalFrame = (int)capture.Get(CapProp.FrameCount);
                Fps = capture.Get(CapProp.Fps);
                FrameNo = 1;

                progressBar.Minimum = 1;
                progressBar.Maximum = TotalFrame;
                progressBar.Value = 1;
            }
        }

        public async Task PlayVideo(PictureBox pictureBox, Label label, ProgressBar progressBar)
        {
            if (capture == null)
            {
                return;
            }

            IsReadingFrame = true;
            await Task.Run(() => ReadAllFrames(pictureBox, label, progressBar));
        }

        public void StopVideo()
        {
            IsReadingFrame = false;
        }

        private delegate Image<Bgr, byte> ImageProcessingFunction(Image<Bgr, byte> image);
        private Mat processFrame(Mat frame, ImageProcessingFunction imageProcessingFunction)
        {
            Image<Bgr, byte> image = frame.ToImage<Bgr, byte>();
            image.ROI = ROI;
            var imageROI = image.Copy();
            var newImageROI = imageProcessingFunction(imageROI);
            image.ROI = Rectangle.Empty;
            image.ROI = ROI;
            newImageROI.CopyTo(image);
            image.ROI = Rectangle.Empty;
            return image.Mat;
        }

        private async void ReadAllFrames(PictureBox pictureBox, Label label, ProgressBar progressBar)
        {
            Mat m = new Mat();
            while (IsReadingFrame == true && FrameNo < TotalFrame)
            {
                FrameNo += 1;
                var mat = capture?.QueryFrame();
                if (mat == null)
                {
                    return;
                }
                var image = processFrame(mat, imageProcessing.ConvertToGrayscale);

                pictureBox.Image = image.ToBitmap();

                await Task.Delay(1000 / Convert.ToInt16(Fps));
                label.Invoke((MethodInvoker)delegate ()
                {
                    label.Text = FrameNo.ToString() + "/" + TotalFrame.ToString();
                });
                progressBar.Invoke((MethodInvoker)delegate ()
                {
                    progressBar.Value = FrameNo;
                });
            }
        }
    }
}
