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
    public delegate Image<Bgr, byte> ImageProcessingFunction(Image<Bgr, byte> image);

    public class VideoProcessor
    {
        private VideoCapture? capture;
        private int TotalFrame;
        private double Fps;
        private int FrameNo;
        private bool IsReadingFrame;
        public bool playCarousel = false;
        private Rectangle ROI;
        private ImageProcessingFunction processingFunction;

        public VideoProcessor(int videoStreamWidth, int videoStreamHeight)
        {
            ROI = new Rectangle(0, 0, videoStreamWidth, videoStreamHeight);
        }

        public void SetROI(Rectangle roi)
        {
            ROI = roi;
        }
        public void SetProcessingFunction(ImageProcessingFunction function)
        {
            processingFunction = function;
        }
        public void LoadVideo()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                capture = new VideoCapture(ofd.FileName);

                TotalFrame = (int)capture.Get(CapProp.FrameCount);
                Fps = capture.Get(CapProp.Fps);
                FrameNo = 1;
            }
        }

        public async Task PlayVideo(IProgress<VideoProcessingProgress> progress)
        {
            if (capture == null)
            {
                return;
            }

            IsReadingFrame = true;
            await Task.Run(() => ReadAllFrames(progress));
        }

        public void StopVideo()
        {
            IsReadingFrame = false;
        }

        private Mat processFrame(Mat frame, ImageProcessingFunction imageProcessingFunction)
        {
            Image<Bgr, byte> image = frame.ToImage<Bgr, byte>();
            image.ROI = ROI;
            var imageROI = image.Copy();
            Image<Bgr, byte> newImageROI;
            newImageROI = imageProcessingFunction(imageROI);
            image.ROI = Rectangle.Empty;
            image.ROI = ROI;
            newImageROI.CopyTo(image);
            image.ROI = Rectangle.Empty;
            return image.Mat;
        }

        private async void ReadAllFrames(IProgress<VideoProcessingProgress> progress)
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
                if (processingFunction == null)
                {
                    m = mat;
                }
                else
                {
                    m = processFrame(mat, processingFunction);
                }

                progress.Report(new VideoProcessingProgress()
                {
                    Frame = m,
                    FrameNo = FrameNo,
                    TotalFrameNumber = TotalFrame
                });

                await Task.Delay(1000 / Convert.ToInt16(Fps));
               
            }
        }
    }
}
