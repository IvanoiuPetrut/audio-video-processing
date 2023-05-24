using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using Emgu.CV;

namespace Proiect_audio_video
{
    public partial class Form1 : Form
    {
        VideoProcessing.VideoProcessor videoProcessor;
        ImageProcessing imageProcessing;
        RegionOfInterestSelector ROI = new RegionOfInterestSelector();
        bool isVideoPlaying = false;
        public Form1()
        {
            InitializeComponent();
        }

        private async Task StartVideoProcessing()
        {
            Progress<VideoProcessingProgress> progress = new Progress<VideoProcessingProgress>();
            progress.ProgressChanged += (sender, package) =>
            {
                pictureBoxVideoStream.Image = package.Frame.ToBitmap();
                imageProcessing.SetFrameNumber(package.FrameNo);
            };

            await videoProcessor.PlayVideo(progress, labelVideoStreamFrameCount, progressBarVideoStream);
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            videoProcessor.LoadVideo(pictureBoxVideoStream, progressBarVideoStream);
        }

        Progress<Mat> progress = new Progress<Mat>();



        private async void btnPlayVideo_Click(object sender, EventArgs e)
        {
            if (isVideoPlaying)
            {
                videoProcessor.StopVideo();
                isVideoPlaying = false;
                btnPlayVideo.Text = "Play Video";
            }
            else
            {
                isVideoPlaying = true;
                btnPlayVideo.Text = "Stop Video";
                await StartVideoProcessing();
            }
        }

        private void pictureBoxVideoStream_MouseDown(object sender, MouseEventArgs e)
        {
            ROI.StartSelection(e.Location);
        }

        private void pictureBoxVideoStream_MouseMove(object sender, MouseEventArgs e)
        {
            if (pictureBoxVideoStream == null)
            {
                return;
            }

            ROI.UpdateSelection(e.Location);
            Refresh();
        }

        private void pictureBoxVideoStream_MouseUp(object sender, MouseEventArgs e)
        {
            ROI.EndSelection(e.Location);
            videoProcessor.SetROI(ROI.Rect);

        }

        private void pictureBoxVideoStream_Paint(object sender, PaintEventArgs e)
        {
            ROI.DrawSelection(e.Graphics);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            videoProcessor = new VideoProcessing.VideoProcessor(pictureBoxVideoStream.Width, pictureBoxVideoStream.Height);
            imageProcessing = new ImageProcessing();
        }

        private void radioButtonGrayscale_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonGrayscale.Checked)
            {
                videoProcessor.SetProcessingFunction(imageProcessing.ConvertToGrayscale);
            }
        }

        private void radioButtonExtractRed_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonExtractRed.Checked)
            {
                videoProcessor.SetProcessingFunction(imageProcessing.ExtractRed);
            }
        }

        private void radioButtonExtractGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonExtractGreen.Checked)
            {
                videoProcessor.SetProcessingFunction(imageProcessing.ExtractGreen);
            }
        }

        private void radioButtonExtractBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonExtractBlue.Checked)
            {
                videoProcessor.SetProcessingFunction(imageProcessing.ExtractBlue);
            }
        }

        private void radioButtonCarousel_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonCarousel.Checked)
            {
                videoProcessor.SetProcessingFunction(imageProcessing.Carousel);
            }
        }

        private void radioButtonBrightness_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonBrightness.Checked)
            {
                videoProcessor.SetProcessingFunction(imageProcessing.BrightnessCorrection);
            }
        }

        private void radioButtonGammaCorrection_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonGammaCorrection.Checked)
            {
                videoProcessor.SetProcessingFunction(imageProcessing.GammaCorrection);
            }
        }

        private void textBoxProcessValue_TextChanged(object sender, EventArgs e)
        {
            if (textBoxProcessValue.Text != "")
            {
                imageProcessing.SetProcessValue(double.Parse(textBoxProcessValue.Text));
            }
        }

        private void radioButtonBackgroundSubtraction_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonBackgroundSubtraction.Checked)
            {
                videoProcessor.SetProcessingFunction(imageProcessing.BackgroundSubtraction);
            }
        }

        private void radioButtonScale_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonScale.Checked)
            {
                videoProcessor.SetProcessingFunction(imageProcessing.Scale);
            }
        }

        private void numericUpDownScaleFactor_ValueChanged(object sender, EventArgs e)
        {
            imageProcessing.SetScaleFactor((double)numericUpDownScaleFactor.Value);
        }
    }
}