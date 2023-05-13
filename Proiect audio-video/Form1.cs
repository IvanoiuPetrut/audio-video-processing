namespace Proiect_audio_video
{
    public partial class Form1 : Form
    {
        VideoProcessing.VideoProcessor videoProcessor = new VideoProcessing.VideoProcessor();
        bool isPlaying = false;
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
            if (isPlaying)
            {
                videoProcessor.StopVideo();
                isPlaying = false;
                btnPlayVideo.Text = "Play Video";
            }
            else
            {
                isPlaying = true;
                btnPlayVideo.Text = "Stop Video";
                await videoProcessor.PlayVideo(pictureBoxVideoStream, labelVideoStreamFrameCount, progressBarVideoStream);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}