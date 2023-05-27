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
    public class ColorSpaceAdjuster : IFrameProcessor
    {
        private double redValue;
        private double greenValue;
        private double blueValue;
        public ColorSpaceAdjuster(double redValue, double greenValue, double blueValue)
        {
            this.redValue = redValue;
            this.greenValue = greenValue;
            this.blueValue = blueValue;
        }

        public void SetRedValue(double redValue)
        {
            this.redValue = redValue;
        }

        public void SetGreenValue(double greenValue)
        {
            this.greenValue = greenValue;
        }

        public void SetBlueValue(double blueValue)
        {
            this.blueValue = blueValue;
        }

        public Image<Bgr, byte> ProcessFrame(Image<Bgr, byte> image)
        {
            Image<Bgr, Byte> outputImage = new Image<Bgr, byte>(image.Size);
            image.CopyTo(outputImage);
            var data = outputImage.Data;
            for (int i = 0; i < outputImage.Width; i++)
            {
                for (int j = 0; j < outputImage.Height; j++)
                {
                    data[j, i, 0] = (byte)(data[j, i, 0] * blueValue);
                    data[j, i, 1] = (byte)(data[j, i, 1] * greenValue);
                    data[j, i, 2] = (byte)(data[j, i, 2] * redValue);
                }
            }
            return outputImage;
        }
    }
}
