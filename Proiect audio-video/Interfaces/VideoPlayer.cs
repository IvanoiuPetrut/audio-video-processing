using Emgu.CV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_audio_video.Interfaces
{
    public interface IVideoPlayer
    {
        void LoadVideo();
        Task<Mat?> PlayVideo();
        void PauseVideo();
    }
}
