using Emgu.CV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_audio_video.ProgressPayloads
{
    public class VideoProcessingProgress
    {
        public Mat? Frame { get; set; }
        public int FrameNo { get; set; }
        public int TotalFrameNumber { get; set; }
    }
}
