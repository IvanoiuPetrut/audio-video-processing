using Emgu.CV;
using Emgu.CV.Structure;
using Proiect_audio_video.Interfaces;
using Proiect_audio_video.Models;
using Proiect_audio_video.ProgressPayloads;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_audio_video.Players
{
    public class VideoInVideoPlayer : IVideoProcessor
    {
        private Video firstVideo;
        private Video secondVideo;
        private Rectangle roi;
        private bool isPlaying = false;

        public VideoInVideoPlayer(int videoStreamWidth, int videoStreamHeight)
        {
            firstVideo = new Video();
            secondVideo = new Video();
            roi = new Rectangle(0, 0, videoStreamWidth, videoStreamHeight);
        }

        public void LoadVideo()
        {
            firstVideo.LoadVideo();
            secondVideo.LoadVideo();
        }

        public async Task PlayVideo(IProgress<VideoProcessingProgress> progress)
        {
            isPlaying = true;
            await Task.Run(() => ReadAllFrames(progress));
        }

        private async Task ReadAllFrames(IProgress<VideoProcessingProgress> progress)
        {
            while (isPlaying)
            {
                var firstVideoFrame = firstVideo.GetCurrentFrame();
                var secondVideoFrame = secondVideo.GetCurrentFrame();

                if (firstVideoFrame == null || secondVideoFrame == null)
                {
                    isPlaying = false;
                    break;
                }

                //put second frame in ROI of first frame
                Image<Bgr, byte> firstImage = firstVideoFrame.ToImage<Bgr, byte>();
                firstImage.ROI = roi;
                Image<Bgr, byte> secondImage = secondVideoFrame.ToImage<Bgr, byte>();
                secondImage = secondImage.Resize(roi.Width, roi.Height, Emgu.CV.CvEnum.Inter.Linear);
                secondImage.CopyTo(firstImage);
                firstImage.ROI = Rectangle.Empty;

                progress.Report(new VideoProcessingProgress()
                {
                    Frame = firstImage.Mat,
                    FrameNo = firstVideo.GetCurrentFrameNumber(),
                    TotalFrameNumber = firstVideo.getTotalFrames()
                });

                int Fps = firstVideo.GetFps();
                await Task.Delay(1000 / Fps);
            }
        }

        public void SetProcessingFunction(ImageProcessingFunction function)
        {
            throw new NotImplementedException();
        }

        public void SetROI(Rectangle roi)
        {
            this.roi = roi;
        }
    }
}
