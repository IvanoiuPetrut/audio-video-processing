using Emgu.CV;
using Emgu.CV.Structure;
using Proiect_audio_video.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_audio_video.ImageProcessors
{
    public class GrayScaleConvertor : IFrameProcessor
    {
        public Image<Bgr, byte> ProcessFrame(Image<Bgr, byte> image)
        {
            return image.Convert<Gray, byte>().Convert<Bgr, byte>();
        }
    }
}
