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
        public int TotalFrames;
        private double Fps;
        public int FrameNumber;
        public int getTotalFrames()
        {
            return TotalFrames;
        }
        public int GetCurrentFrameNumber()
        {
            return FrameNumber;
        }

        public int GetFps()
        {
            return (int)Fps;
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

        public Mat GetCurrentFrame()
        {
            if(FrameNumber == TotalFrames)
            {
                return null;
            }

            var frame = capture.QueryFrame();

            if (frame == null)
            {
                return null;
            }

            FrameNumber++;
            return frame;
        }
    }
}
