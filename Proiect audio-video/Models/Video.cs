using Emgu.CV;
using Emgu.CV.CvEnum;
using Proiect_audio_video.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_audio_video.Models
{
    public class Video : IVideoPlayer
    {
        private VideoCapture? capture;
        private int TotalFrames;
        private double Fps;
        private int FrameNumber;
        private bool IsReadingFrame;

        public int getTotalFrames()
        {
            return TotalFrames;
        }
        public int GetCurrentFrameNumber()
        {
            return FrameNumber;
        }

        public void LoadVideo()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                capture = new VideoCapture(ofd.FileName);
                TotalFrames = (int)capture.Get(CapProp.FrameCount);
                Fps = capture.Get(CapProp.Fps);
                FrameNumber = 1;
            }
        }

        public async Task<Mat?> PlayVideo()
        {
            if (capture == null)
            {
                return null;
            }
            IsReadingFrame = true;
            return await Task.Run(() => ReadAllFrames());
        }

        public void PauseVideo()
        {
            IsReadingFrame = false;
        }

        private async Task<Mat?> ReadAllFrames()
        {
            while (IsReadingFrame)
            {
                var frame = capture.QueryFrame();
                if (frame == null)
                {
                    break;
                }
                FrameNumber++;
                await Task.Delay(TimeSpan.FromMilliseconds(1000 / Fps));
                return frame;
            }
            return null;
        }
    }
}
