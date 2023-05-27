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
    internal class GammaCorrectionApplier : IFrameProcessor
    {
        private double gamma;

        public GammaCorrectionApplier(double gamma)
        {
            this.gamma = gamma;
        }

        public void SetGamma(double gamma)
        {
            this.gamma = gamma;
        }

        public Image<Bgr, byte> ProcessFrame(Image<Bgr, byte> image)
        {
            image._GammaCorrect(gamma);
            return image;
        }
    }
}
