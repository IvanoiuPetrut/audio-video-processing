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
    public class TransitionVideoPlayer : IVideoProcessor
    {
        private Video firstVideo;
        private Video secondVideo;
        private bool isPlaying = false;
        private int fadeFrames = 25;

        public TransitionVideoPlayer(int videoStreamWidth, int videoStreamHeight)
        {
            firstVideo = new Video();
            secondVideo = new Video();
        }

        public void SetProcessingFunction(ImageProcessingFunction function)
        {
            throw new NotImplementedException();
        }

        public void SetROI(Rectangle roi)
        {
            throw new NotImplementedException();
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
                if (firstVideo.GetCurrentFrameNumber() <= firstVideo.getTotalFrames() - 10)
                {
                    await ProcessNormalFrame(progress);
                }
                else if (firstVideo.GetCurrentFrameNumber() > firstVideo.getTotalFrames() - fadeFrames && firstVideo.GetCurrentFrameNumber() < firstVideo.getTotalFrames())
                {
                    await ProcessFadeFrame(progress);
                }
                else if (firstVideo.GetCurrentFrameNumber() == firstVideo.getTotalFrames())
                {
                    await ProcessLastFrame(progress);
                }
            }
        }

        private async Task ProcessNormalFrame(IProgress<VideoProcessingProgress> progress)
        {
            var frame = firstVideo.GetCurrentFrame();
            if (frame != null)
            {
                progress.Report(new VideoProcessingProgress()
                {
                    Frame = frame,
                    FrameNo = firstVideo.GetCurrentFrameNumber(),
                    TotalFrameNumber = firstVideo.getTotalFrames()
                });

                int fps = firstVideo.GetFps();
                await Task.Delay(1000 / fps);
            }
        }

        private async Task ProcessFadeFrame(IProgress<VideoProcessingProgress> progress)
        {
            var frameFirstVideo = firstVideo.GetCurrentFrame();
            var frameSecondVideo = secondVideo.GetCurrentFrame();
            if (frameFirstVideo != null && frameSecondVideo != null)
            {
                Image<Bgr, byte> firstImage = frameFirstVideo.ToImage<Bgr, byte>();
                Image<Bgr, byte> secondImage = frameSecondVideo.ToImage<Bgr, byte>();
                double alpha = (firstVideo.GetCurrentFrameNumber() - (firstVideo.getTotalFrames() - fadeFrames)) / (double)fadeFrames;
                Image<Bgr, byte> blendedImage = firstImage.AddWeighted(secondImage, 1 - alpha, alpha, 0);

                progress.Report(new VideoProcessingProgress()
                {
                    Frame = blendedImage.Mat,
                    FrameNo = firstVideo.GetCurrentFrameNumber(),
                    TotalFrameNumber = firstVideo.getTotalFrames()
                });

                int fps = firstVideo.GetFps();
                await Task.Delay(1000 / fps);
            }
        }

        private async Task ProcessLastFrame(IProgress<VideoProcessingProgress> progress)
        {
            var frame = secondVideo.GetCurrentFrame();
            if (frame != null)
            {
                progress.Report(new VideoProcessingProgress()
                {
                    Frame = frame,
                    FrameNo = secondVideo.GetCurrentFrameNumber(),
                    TotalFrameNumber = secondVideo.getTotalFrames()
                });

                int fps = secondVideo.GetFps();
                await Task.Delay(1000 / fps);
            }
        }
    }
}
