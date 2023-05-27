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
    public class RotateImage : IFrameProcessor
    {
        private double rotationAngle;

        public RotateImage(double rotationAngle)
        {
            this.rotationAngle = rotationAngle;
        }

        public void SetRotationAngle(double rotationAngle)
        {
            this.rotationAngle = rotationAngle;
        }

        public Image<Bgr, byte> ProcessFrame(Image<Bgr, byte> image)
        {
            Image<Bgr, byte> outputImage = new Image<Bgr, byte>(image.Size);
            image.CopyTo(outputImage);
            outputImage = outputImage.Rotate(rotationAngle, new Bgr(0, 0, 0), true);
            return outputImage;
        }
    }
}
