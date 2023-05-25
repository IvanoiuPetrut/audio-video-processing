using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_audio_video.Interfaces
{
    public delegate Image<Bgr, byte> ImageProcessingFunction(Image<Bgr, byte> image);
    public interface IVideoProcessor
    {
        void SetROI(Rectangle roi);
        void SetProcessingFunction(ImageProcessingFunction function);
    }
}
