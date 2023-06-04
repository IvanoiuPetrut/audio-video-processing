using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using Emgu.CV;
using Proiect_audio_video.Players;
using Proiect_audio_video.ImageProcessors;
using Proiect_audio_video.Utilities;
using Proiect_audio_video.ProgressPayloads;
using Proiect_audio_video.Enums;

namespace Proiect_audio_video
{
    public partial class Form1 : Form
    {
        RegionOfInterestSelector ROI = new RegionOfInterestSelector();
        Carousel carousel = new Carousel(0);
        GrayScaleConvertor grayScaleConvertor = new GrayScaleConvertor();
        ColorSpaceAdjuster colorSpaceAdjuster = new ColorSpaceAdjuster(1, 1, 1);
        BrightnessAdjuster brightnessAdjuster = new BrightnessAdjuster(1, 0);
        GammaCorrectionApplier gammaCorrectionApplier = new GammaCorrectionApplier(1);
        ScaleImage scaleImage = new ScaleImage(1);
        RotateImage rotateImage = new RotateImage(0);

        SingleVideoPlayer singleVideoPlayer;
        TransitionVideoPlayer transitionVideoPlayer;
        VideoInVideoPlayer videoInVideoPlayer;

        PlayerType playerType;

        public Form1()
        {
            InitializeComponent();
        }

        private async Task StartVideoProcessing()
        {
            Progress<VideoProcessingProgress> progress = new Progress<VideoProcessingProgress>();
            progress.ProgressChanged += (sender, package) =>
            {
                var a = package.TotalFrameNumber;
                pictureBoxVideoStream.Image = package.Frame.ToBitmap();
                labelVideoStreamFrameCount.Text = $"Frame: {package.FrameNo}/{package.TotalFrameNumber}";
                progressBarVideoStream.Value = package.FrameNo;
                carousel.SetFrameNumber(package.FrameNo);
                if (package.FrameNo == 2)
                {
                    progressBarVideoStream.Maximum = package.TotalFrameNumber;
                }
            };

            if (playerType == PlayerType.SingleVideoPlayer)
            {
                await singleVideoPlayer.PlayVideo(progress);
            }
            else if (playerType == PlayerType.TransitionVideoPlayer)
            {
                await transitionVideoPlayer.PlayVideo(progress);
            }
            else if (playerType == PlayerType.VideoInVideoPlayer)
            {
                await videoInVideoPlayer.PlayVideo(progress);
            }
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            playerType = PlayerType.SingleVideoPlayer;
            singleVideoPlayer.LoadVideo();
        }

        private async void btnPlayVideo_Click(object sender, EventArgs e)
        {
            await StartVideoProcessing();
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
            if (playerType == PlayerType.SingleVideoPlayer)
            {
                singleVideoPlayer.SetROI(ROI.Rect);
            }
            else if (playerType == PlayerType.VideoInVideoPlayer)
            {
                videoInVideoPlayer.SetROI(ROI.Rect);
            }

        }

        private void pictureBoxVideoStream_Paint(object sender, PaintEventArgs e)
        {
            ROI.DrawSelection(e.Graphics);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            transitionVideoPlayer = new TransitionVideoPlayer(pictureBoxVideoStream.Width, pictureBoxVideoStream.Height);
            singleVideoPlayer = new SingleVideoPlayer(pictureBoxVideoStream.Width, pictureBoxVideoStream.Height);
            videoInVideoPlayer = new VideoInVideoPlayer(pictureBoxVideoStream.Width, pictureBoxVideoStream.Height);
        }

        private void radioButtonGrayscale_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonGrayscale.Checked)
            {
                singleVideoPlayer.SetProcessingFunction(grayScaleConvertor.ProcessFrame);
            }
        }

        private void radioButtonExtractRed_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonExtractRed.Checked)
            {
                colorSpaceAdjuster.SetRedValue(1);
                colorSpaceAdjuster.SetGreenValue(0);
                colorSpaceAdjuster.SetBlueValue(0);
                singleVideoPlayer.SetProcessingFunction(colorSpaceAdjuster.ProcessFrame);
            }
        }

        private void radioButtonExtractGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonExtractGreen.Checked)
            {
                colorSpaceAdjuster.SetRedValue(0);
                colorSpaceAdjuster.SetGreenValue(1);
                colorSpaceAdjuster.SetBlueValue(0);
                singleVideoPlayer.SetProcessingFunction(colorSpaceAdjuster.ProcessFrame);
            }
        }

        private void radioButtonExtractBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonExtractBlue.Checked)
            {
                colorSpaceAdjuster.SetRedValue(0);
                colorSpaceAdjuster.SetGreenValue(0);
                colorSpaceAdjuster.SetBlueValue(1);
                singleVideoPlayer.SetProcessingFunction(colorSpaceAdjuster.ProcessFrame);
            }
        }

        private void radioButtonCarousel_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonCarousel.Checked)
            {
                singleVideoPlayer.SetProcessingFunction(carousel.ProcessFrame);
            }
        }

        private void radioButtonBrightness_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonBrightness.Checked)
            {
                singleVideoPlayer.SetProcessingFunction(brightnessAdjuster.ProcessFrame);
            }
        }

        private void radioButtonGammaCorrection_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonGammaCorrection.Checked)
            {
                singleVideoPlayer.SetProcessingFunction(gammaCorrectionApplier.ProcessFrame);
            }
        }

        private void textBoxProcessValue_TextChanged(object sender, EventArgs e)
        {
            if (textBoxProcessValue.Text != "")
            {
            }
        }

        private void radioButtonBackgroundSubtraction_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonBackgroundSubtraction.Checked)
            {
            }
        }

        private void radioButtonAdjustColorSpace_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonAdjustColorSpace.Checked)
            {
                singleVideoPlayer.SetProcessingFunction(colorSpaceAdjuster.ProcessFrame);
            }
        }

        private void trackBarRed_Scroll(object sender, EventArgs e)
        {
            colorSpaceAdjuster.SetRedValue(trackBarRed.Value / 10);
        }

        private void trackBarGreen_Scroll(object sender, EventArgs e)
        {
            colorSpaceAdjuster.SetGreenValue(trackBarGreen.Value / 10);
        }

        private void trackBarBlue_Scroll(object sender, EventArgs e)
        {
            colorSpaceAdjuster.SetBlueValue(trackBarBlue.Value / 10);
        }

        private void radioButtonScale_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonScale.Checked)
            {
                singleVideoPlayer.SetProcessingFunction(scaleImage.ProcessFrame);
            }
        }

        private void numericUpDownScaleFactor_ValueChanged(object sender, EventArgs e)
        {
            scaleImage.SetScaleFactor((double)numericUpDownScaleFactor.Value);
        }

        private void numericUpRotateFactor_ValueChanged(object sender, EventArgs e)
        {
            rotateImage.SetRotationAngle((double)numericUpRotateFactor.Value);
        }

        private void radioButtonRotate_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonRotate.Checked)
            {
                singleVideoPlayer.SetProcessingFunction(rotateImage.ProcessFrame);
            }
        }

        private void progressBarVideoStream_Click(object sender, EventArgs e)
        {
            var mousePosition = MousePosition;
            mousePosition = progressBarVideoStream.PointToClient(mousePosition);
            var value = mousePosition.X * progressBarVideoStream.Maximum / progressBarVideoStream.Width;
            progressBarVideoStream.Value = value;
            labelVideoStreamFrameCount.Text = $"Frame: {progressBarVideoStream.Value}/{progressBarVideoStream.Maximum}";
            //videoProcessor.SetFrameNumber(progressBarVideoStream.Value);
        }

        private void numericUpDownAlphaBrightness_ValueChanged(object sender, EventArgs e)
        {
            brightnessAdjuster.SetAlpha((double)numericUpDownAlphaBrightness.Value);
        }

        private void numericUpDownBetaBrightness_ValueChanged(object sender, EventArgs e)
        {
            brightnessAdjuster.SetBeta((double)numericUpDownBetaBrightness.Value);
        }

        private void numericUpDownGamma_ValueChanged(object sender, EventArgs e)
        {
            gammaCorrectionApplier.SetGamma((double)numericUpDownGamma.Value);
        }
        private void openTwoVideosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            playerType = PlayerType.TransitionVideoPlayer;
            transitionVideoPlayer.LoadVideo();
        }

        private void videoInVideoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            playerType = PlayerType.VideoInVideoPlayer;
            videoInVideoPlayer.LoadVideo();
        }

        private void audioFormToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormAudio formAudio = new FormAudio();
            formAudio.Show();
            this.Hide();
        }
    }
}