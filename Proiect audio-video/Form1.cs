namespace Proiect_audio_video
{
    public partial class Form1 : Form
    {
        VideoProcessing.VideoProcessor videoProcessor = new VideoProcessing.VideoProcessor();
        RegionOfInterestSelector ROI = new RegionOfInterestSelector();
        bool isVideoPlaying = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            videoProcessor.LoadVideo(pictureBoxVideoStream, progressBarVideoStream);
        }

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
                await videoProcessor.PlayVideo(pictureBoxVideoStream, labelVideoStreamFrameCount, progressBarVideoStream);
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
        }

        private void pictureBoxVideoStream_Paint(object sender, PaintEventArgs e)
        {
            ROI.DrawSelection(e.Graphics);
        }
    }
}