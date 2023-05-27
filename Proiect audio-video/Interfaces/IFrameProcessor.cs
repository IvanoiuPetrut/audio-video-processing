using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_audio_video.Interfaces
{
    public interface IFrameProcessor
    {
        Image<Bgr, byte> ProcessFrame(Image<Bgr, byte> frame);
    }
}
