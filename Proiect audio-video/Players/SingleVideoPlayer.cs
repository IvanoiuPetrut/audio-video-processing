using Emgu.CV;
using Proiect_audio_video.Interfaces;
using Proiect_audio_video.Models;
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
        private ImageProcessingFunction processingFunction;

        public SingleVideoPlayer(int videoStreamWidth, int videoStreamHeight)
        {
            currentVideo = new Video();
            ROI = new Rectangle(0, 0, videoStreamWidth, videoStreamHeight);
        }

        public void SetProcessingFunction(ImageProcessingFunction function)
        {
            processingFunction = function;
        }

        public void SetROI(Rectangle roi)
        {
            ROI = roi;
        }

        public void LoadVideo()
        {
            currentVideo.LoadVideo();
        }

        public async Task PlayVideo(IProgress<VideoProcessingProgress> progress)
        {
            Mat? frame = await currentVideo.PlayVideo();
            progress.Report(new VideoProcessingProgress()
            {
                Frame = frame,
                FrameNo = currentVideo.GetCurrentFrameNumber(),
                TotalFrameNumber = currentVideo.getTotalFrames()
            });
        }

        public void PauseVideo()
        {
            currentVideo.PauseVideo();
        }
    }
}
