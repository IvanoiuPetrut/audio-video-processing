using Emgu.CV.CvEnum;
using Emgu.CV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_audio_video.VideoProcessing
{
    public class VideoProcessor
    {
        private VideoCapture? capture;
        private int TotalFrame;
        private double Fps;
        private int FrameNo;
        private bool IsReadingFrame;
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

            // Disable the play button while the video is playing
            // playButton.Enabled = false;

            // Start playing the video
            IsReadingFrame = true;
            await Task.Run(() => ReadAllFrames(pictureBox, label, progressBar));

            // Re-enable the play button when the video is finished
            // playButton.Enabled = true;
        }

        public void StopVideo()
        {
            IsReadingFrame = false;
        }

        private async void ReadAllFrames(PictureBox pictureBox, Label label, ProgressBar progressBar)
        {
            Mat m = new Mat();
            while (IsReadingFrame == true && FrameNo < TotalFrame)
            {
                FrameNo += 1;
                var mat = capture?.QueryFrame();
                pictureBox.Image = mat.ToBitmap();
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
