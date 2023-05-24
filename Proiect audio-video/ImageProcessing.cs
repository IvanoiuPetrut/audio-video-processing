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
        private int frameNumber;
        private double processValue;
        private double scaleFactor;
        private VideoCapture _cameraCapture;
        private Image<Bgr, byte> newBackgroundImage;
        private IBackgroundSubtractor _fgDetector;

        public ImageProcessing()
        {
            frameNumber = 0;
            processValue = 30;
            scaleFactor = 1;
            _cameraCapture = new VideoCapture();
            _fgDetector = new BackgroundSubtractorMOG2();
            //Application.Idle += ProcessFrame;
        }
        public void SetFrameNumber(int frameNumber)
        {
            this.frameNumber = frameNumber;
        }

        public void SetProcessValue(double processValue)
        {
            this.processValue = processValue;
        }

        public void SetScaleFactor(double scaleFactor)
        {
            this.scaleFactor = scaleFactor;
        }
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
            Image<Bgr, byte> outputImage = new Image<Bgr, byte>(image.Size);
            image.CopyTo(outputImage);
            var data = outputImage.Data;
            for (int i = 0; i < outputImage.Width; i++)
            {
                for (int j = 0; j < outputImage.Height; j++)
                {
                    data[j, i, 0] = (byte)Math.Min(255, data[j, i, 0] + processValue);
                    data[j, i, 1] = (byte)Math.Min(255, data[j, i, 1] + processValue);
                    data[j, i, 2] = (byte)Math.Min(255, data[j, i, 2] + processValue);
                }
            }

            return outputImage;
        }

        public Image<Bgr, byte> GammaCorrection(Image<Bgr, byte> image)
        {
            Image<Bgr, byte> outputImage = new Image<Bgr, byte>(image.Size);
            image.CopyTo(outputImage);
            var data = outputImage.Data;
            for (int i = 0; i < outputImage.Width; i++)
            {
                for (int j = 0; j < outputImage.Height; j++)
                {
                    data[j, i, 0] = (byte)Math.Min(255, Math.Pow(data[j, i, 0], 1.0 / processValue));
                    data[j, i, 1] = (byte)Math.Min(255, Math.Pow(data[j, i, 1], 1.0 / processValue));
                    data[j, i, 2] = (byte)Math.Min(255, Math.Pow(data[j, i, 2], 1.0 / processValue));
                }
            }
            return outputImage;
        }

        public Image<Bgr, byte> BackgroundSubtraction(Image<Bgr, byte> image)
        {
            Mat frame = _cameraCapture.QueryFrame();
            Image<Bgr, byte> frameImage = frame.ToImage<Bgr, byte>();

            Mat foregroundMask = new Mat();
            _fgDetector.Apply(frame, foregroundMask);
            var foregroundMaskImage = foregroundMask.ToImage<Gray, byte>();
            foregroundMaskImage = foregroundMaskImage.Not();

            var copyOfNewBackgroundImage = newBackgroundImage.Resize(foregroundMaskImage.Width, foregroundMaskImage.Height, Inter.Lanczos4);
            copyOfNewBackgroundImage = copyOfNewBackgroundImage.Copy(foregroundMaskImage);

            foregroundMaskImage = foregroundMaskImage.Not();
            frameImage = frameImage.Copy(foregroundMaskImage);

            frameImage = frameImage.Or(copyOfNewBackgroundImage);

            return frameImage;
        }

        public Image<Bgr, byte> Scale(Image<Bgr, byte> image)
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
