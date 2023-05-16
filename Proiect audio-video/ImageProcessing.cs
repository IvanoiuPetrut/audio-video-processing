using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using Emgu.CV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV.Reg;

namespace Proiect_audio_video
{
    public class ImageProcessing
    {
        public Image<Bgr, byte> ConvertToGrayscale(Image<Bgr, byte> image)
        {
            return image.Convert<Gray, byte>().Convert<Bgr, byte>();
        }
    }
}
