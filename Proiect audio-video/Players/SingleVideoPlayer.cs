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
    public class SingleVideoPlayer : IVideoProcessor
    {
        private Video currentVideo;
        private Rectangle ROI;
        private ImageProcessingFunction ProcessingFunction;
        private bool isPlaying = false;

        public SingleVideoPlayer(int videoStreamWidth, int videoStreamHeight)
        {
            currentVideo = new Video();
            ROI = new Rectangle(0, 0, videoStreamWidth, videoStreamHeight);
        }

        public void SetProcessingFunction(ImageProcessingFunction function)
        {
            ProcessingFunction = function;
        }

        public void SetROI(Rectangle roi)
        {
            ROI = roi;
        }

        public void SetIsPlaying(bool isPlaying)
        {
            this.isPlaying = isPlaying;
        }

        public bool GetIsPlaying()
        {
            return isPlaying;
        }

        public void LoadVideo()
        {
            currentVideo.LoadVideo();
        }

        public async Task PlayVideo(IProgress<VideoProcessingProgress> progress)
        {
            isPlaying = true;
            await Task.Run(() => ReadAllFrames(progress));
        }

        public void PauseVideo()
        {
            isPlaying = false;
        }
        private async Task ReadAllFrames(IProgress<VideoProcessingProgress> progress)
        {
            while (isPlaying)
            {
                var frame = currentVideo.GetCurrentFrame();
                if (frame == null)
                {
                    isPlaying = false;
                    break;
                }
                var processedFrame = ProcessFrame(frame, ROI);
                progress.Report(new VideoProcessingProgress()
                {
                    Frame = processedFrame,
                    FrameNo = currentVideo.GetCurrentFrameNumber(),
                    TotalFrameNumber = currentVideo.getTotalFrames()
                });
                int Fps = currentVideo.GetFps();
                await Task.Delay(1000 / Fps);
            }

        }

        private Mat ProcessFrame(Mat frame, Rectangle ROI)
        {
            if (ProcessingFunction == null)
            {
                return frame;
            }

            Image<Bgr, byte> image = frame.ToImage<Bgr, byte>();
            image.ROI = ROI;
            var imageROI = image.Copy();
            Image<Bgr, byte> newImageROI;
            newImageROI = ProcessingFunction(imageROI);
            image.ROI = Rectangle.Empty;
            image.ROI = ROI;
            newImageROI.CopyTo(image);
            image.ROI = Rectangle.Empty;
            return image.Mat;
        }
    }
}
