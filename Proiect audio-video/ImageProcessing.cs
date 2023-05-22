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
        private int frameNumber { get; set; }
        private int processValue { get; set; }
        public Image<Bgr, byte> ConvertToGrayscale(Image<Bgr, byte> image)
        {
            return image.Convert<Gray, byte>().Convert<Bgr, byte>();
        }

        public Image<Bgr, byte> ExtractRed(Image<Bgr, byte> image)
        {
            Image<Bgr, byte> outputImage = new Image<Bgr, byte>(image.Size);
            image.CopyTo(outputImage);
            var data = outputImage.Data;
            for (int i = 0; i < outputImage.Width; i++)
            {
                for (int j = 0; j < outputImage.Height; j++)
                {
                    data[j, i, 0] = 0;
                    data[j, i, 1] = 0;
                }
            }

            return outputImage;
        }

        public Image<Bgr, byte> ExtractGreen(Image<Bgr, byte> image)
        {
            Image<Bgr, byte> outputImage = new Image<Bgr, byte>(image.Size);
            image.CopyTo(outputImage);
            var data = outputImage.Data;
            for (int i = 0; i < outputImage.Width; i++)
            {
                for (int j = 0; j < outputImage.Height; j++)
                {
                    data[j, i, 0] = 0;
                    data[j, i, 2] = 0;
                }
            }

            return outputImage;
        }

        public Image<Bgr, byte> ExtractBlue(Image<Bgr, byte> image)
        {
            Image<Bgr, byte> outputImage = new Image<Bgr, byte>(image.Size);
            image.CopyTo(outputImage);
            var data = outputImage.Data;
            for (int i = 0; i < outputImage.Width; i++)
            {
                for (int j = 0; j < outputImage.Height; j++)
                {
                    data[j, i, 1] = 0;
                    data[j, i, 2] = 0;
                }
            }

            return outputImage;
        }

        public Image<Bgr, byte> Carousel(Image<Bgr, byte> image)
        {
            int a = frameNumber;
            int step = frameNumber % 4;
            switch (step)
            {
                case 0:
                    return ExtractRed(image);
                case 1:
                    return ExtractGreen(image);
                case 2:
                    return ExtractBlue(image);
                case 3:
                    return ConvertToGrayscale(image);
                default:
                    return image;
            }
        }
        public Image<Bgr, byte> BrightnessCorrection(Image<Bgr, byte> image)
        {
            int value = 30;
            Image<Bgr, byte> outputImage = new Image<Bgr, byte>(image.Size);
            image.CopyTo(outputImage);
            var data = outputImage.Data;
            for (int i = 0; i < outputImage.Width; i++)
            {
                for (int j = 0; j < outputImage.Height; j++)
                {
                    data[j, i, 0] = (byte)Math.Min(255, data[j, i, 0] + value);
                    data[j, i, 1] = (byte)Math.Min(255, data[j, i, 1] + value);
                    data[j, i, 2] = (byte)Math.Min(255, data[j, i, 2] + value);
                }
            }

            return outputImage;
        }
    }
}
