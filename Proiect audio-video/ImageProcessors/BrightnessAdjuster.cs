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
    public class BrightnessAdjuster : IFrameProcessor
    {
        private double beta;
        private double alpha;

        public BrightnessAdjuster(double beta, double alpha)
        {
            this.beta = beta;
            this.alpha = alpha;
        }

        public void SetBeta(double beta)
        {
            this.beta = beta;
        }

        public void SetAlpha(double alpha)
        {
            this.alpha = alpha;
        }

        public Image<Bgr, byte> ProcessFrame(Image<Bgr, byte> image)
        {
            Image<Bgr, byte> multipliedImage = image.Mul(alpha) + beta;
            return multipliedImage;
        }
    }
}
