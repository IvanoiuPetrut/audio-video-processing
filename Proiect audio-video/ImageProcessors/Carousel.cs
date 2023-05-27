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
    public class Carousel : IFrameProcessor
    {
        private int frameNumber;
        ColorSpaceAdjuster colorSpaceAdjuster;
        GrayScaleConvertor grayScaleConvertor;
        public Carousel(int frameNumber)
        {
            this.frameNumber = frameNumber;
            colorSpaceAdjuster = new ColorSpaceAdjuster(1, 1, 1);
            grayScaleConvertor = new GrayScaleConvertor();
        }

        public void SetFrameNumber(int frameNumber)
        {
            this.frameNumber = frameNumber;
        }

        public Image<Bgr, byte> ProcessFrame(Image<Bgr, byte> image)
        {
            int step = frameNumber % 4;
            switch (step)
            {
                case 0:
                    colorSpaceAdjuster.SetRedValue(1);
                    colorSpaceAdjuster.SetGreenValue(0);
                    colorSpaceAdjuster.SetBlueValue(0);
                    image = colorSpaceAdjuster.ProcessFrame(image);
                    break;
                case 1:
                    colorSpaceAdjuster.SetRedValue(0);
                    colorSpaceAdjuster.SetGreenValue(1);
                    colorSpaceAdjuster.SetBlueValue(0);
                    image = colorSpaceAdjuster.ProcessFrame(image);
                    break;
                case 2:
                    colorSpaceAdjuster.SetRedValue(0);
                    colorSpaceAdjuster.SetGreenValue(0);
                    colorSpaceAdjuster.SetBlueValue(1);
                    image = colorSpaceAdjuster.ProcessFrame(image);
                    break;
                case 3:
                    image = grayScaleConvertor.ProcessFrame(image);
                    break;
            }
            return image;
        }
    }
}
