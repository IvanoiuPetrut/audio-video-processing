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
    public class ScaleImage : IFrameProcessor
    {
        private double scaleFactor;

        public ScaleImage(double scaleFactor)
        {
            this.scaleFactor = scaleFactor;
        }

        public void SetScaleFactor(double scaleFactor)
        {
            this.scaleFactor = scaleFactor;
        }
        public Image<Bgr, byte> ProcessFrame(Image<Bgr, byte> image)
        {
            Image<Bgr, byte> resizedImage = image.Resize(scaleFactor, Emgu.CV.CvEnum.Inter.Cubic);
            Image<Bgr, byte> outputImage = new Image<Bgr, byte>(image.Size);

            int x = (resizedImage.Width - image.Width) / 2;
            int y = (resizedImage.Height - image.Height) / 2;

            Rectangle roi = new Rectangle(x, y, image.Width, image.Height);
            resizedImage.ROI = roi;

            resizedImage.CopyTo(outputImage);

            return outputImage;
        }
    }
}
