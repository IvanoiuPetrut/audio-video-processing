namespace Proiect_audio_video
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            openFileToolStripMenuItem = new ToolStripMenuItem();
            pictureBoxVideoStream = new PictureBox();
            progressBarVideoStream = new ProgressBar();
            btnPlayVideo = new Button();
            labelVideoStreamFrameCount = new Label();
            radioButtonGrayscale = new RadioButton();
            radioButtonExtractRed = new RadioButton();
            radioButtonExtractGreen = new RadioButton();
            radioButtonExtractBlue = new RadioButton();
            radioButtonCarousel = new RadioButton();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxVideoStream).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { openFileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(983, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // openFileToolStripMenuItem
            // 
            openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            openFileToolStripMenuItem.Size = new Size(67, 20);
            openFileToolStripMenuItem.Text = "Open file";
            openFileToolStripMenuItem.Click += openFileToolStripMenuItem_Click;
            // 
            // pictureBoxVideoStream
            // 
            pictureBoxVideoStream.BackColor = SystemColors.ControlDark;
            pictureBoxVideoStream.Location = new Point(12, 39);
            pictureBoxVideoStream.Name = "pictureBoxVideoStream";
            pictureBoxVideoStream.Size = new Size(675, 468);
            pictureBoxVideoStream.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxVideoStream.TabIndex = 1;
            pictureBoxVideoStream.TabStop = false;
            pictureBoxVideoStream.Paint += pictureBoxVideoStream_Paint;
            pictureBoxVideoStream.MouseDown += pictureBoxVideoStream_MouseDown;
            pictureBoxVideoStream.MouseMove += pictureBoxVideoStream_MouseMove;
            pictureBoxVideoStream.MouseUp += pictureBoxVideoStream_MouseUp;
            // 
            // progressBarVideoStream
            // 
            progressBarVideoStream.Location = new Point(12, 529);
            progressBarVideoStream.Name = "progressBarVideoStream";
            progressBarVideoStream.Size = new Size(675, 23);
            progressBarVideoStream.TabIndex = 2;
            // 
            // btnPlayVideo
            // 
            btnPlayVideo.Location = new Point(710, 39);
            btnPlayVideo.Name = "btnPlayVideo";
            btnPlayVideo.Size = new Size(107, 36);
            btnPlayVideo.TabIndex = 3;
            btnPlayVideo.Text = "Play Video";
            btnPlayVideo.UseVisualStyleBackColor = true;
            btnPlayVideo.Click += btnPlayVideo_Click;
            // 
            // labelVideoStreamFrameCount
            // 
            labelVideoStreamFrameCount.AutoSize = true;
            labelVideoStreamFrameCount.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelVideoStreamFrameCount.Location = new Point(845, 48);
            labelVideoStreamFrameCount.Name = "labelVideoStreamFrameCount";
            labelVideoStreamFrameCount.Size = new Size(84, 21);
            labelVideoStreamFrameCount.TabIndex = 4;
            labelVideoStreamFrameCount.Text = "FPS Count";
            // 
            // radioButtonGrayscale
            // 
            radioButtonGrayscale.AutoSize = true;
            radioButtonGrayscale.Location = new Point(710, 112);
            radioButtonGrayscale.Name = "radioButtonGrayscale";
            radioButtonGrayscale.Size = new Size(75, 19);
            radioButtonGrayscale.TabIndex = 6;
            radioButtonGrayscale.TabStop = true;
            radioButtonGrayscale.Text = "Grayscale";
            radioButtonGrayscale.UseVisualStyleBackColor = true;
            radioButtonGrayscale.CheckedChanged += radioButtonGrayscale_CheckedChanged;
            // 
            // radioButtonExtractRed
            // 
            radioButtonExtractRed.AutoSize = true;
            radioButtonExtractRed.Location = new Point(710, 137);
            radioButtonExtractRed.Name = "radioButtonExtractRed";
            radioButtonExtractRed.Size = new Size(84, 19);
            radioButtonExtractRed.TabIndex = 7;
            radioButtonExtractRed.TabStop = true;
            radioButtonExtractRed.Text = "Extract Red";
            radioButtonExtractRed.UseVisualStyleBackColor = true;
            // 
            // radioButtonExtractGreen
            // 
            radioButtonExtractGreen.AutoSize = true;
            radioButtonExtractGreen.Location = new Point(710, 162);
            radioButtonExtractGreen.Name = "radioButtonExtractGreen";
            radioButtonExtractGreen.Size = new Size(95, 19);
            radioButtonExtractGreen.TabIndex = 8;
            radioButtonExtractGreen.TabStop = true;
            radioButtonExtractGreen.Text = "Extract Green";
            radioButtonExtractGreen.UseVisualStyleBackColor = true;
            // 
            // radioButtonExtractBlue
            // 
            radioButtonExtractBlue.AutoSize = true;
            radioButtonExtractBlue.Location = new Point(710, 187);
            radioButtonExtractBlue.Name = "radioButtonExtractBlue";
            radioButtonExtractBlue.Size = new Size(87, 19);
            radioButtonExtractBlue.TabIndex = 9;
            radioButtonExtractBlue.TabStop = true;
            radioButtonExtractBlue.Text = "Extract Blue";
            radioButtonExtractBlue.UseVisualStyleBackColor = true;
            // 
            // radioButtonCarousel
            // 
            radioButtonCarousel.AutoSize = true;
            radioButtonCarousel.Location = new Point(710, 212);
            radioButtonCarousel.Name = "radioButtonCarousel";
            radioButtonCarousel.Size = new Size(71, 19);
            radioButtonCarousel.TabIndex = 10;
            radioButtonCarousel.TabStop = true;
            radioButtonCarousel.Text = "Carousel";
            radioButtonCarousel.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(983, 574);
            Controls.Add(radioButtonCarousel);
            Controls.Add(radioButtonExtractBlue);
            Controls.Add(radioButtonExtractGreen);
            Controls.Add(radioButtonExtractRed);
            Controls.Add(radioButtonGrayscale);
            Controls.Add(labelVideoStreamFrameCount);
            Controls.Add(btnPlayVideo);
            Controls.Add(progressBarVideoStream);
            Controls.Add(pictureBoxVideoStream);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Editare Audio-Video";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxVideoStream).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem openFileToolStripMenuItem;
        private PictureBox pictureBoxVideoStream;
        private ProgressBar progressBarVideoStream;
        private Button btnPlayVideo;
        private Label labelVideoStreamFrameCount;
        private RadioButton radioButtonGrayscale;
        private RadioButton radioButtonExtractRed;
        private RadioButton radioButtonExtractGreen;
        private RadioButton radioButtonExtractBlue;
        private RadioButton radioButtonCarousel;
    }
}