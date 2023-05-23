﻿namespace Proiect_audio_video
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
            radioButtonBrightness = new RadioButton();
            textBoxProcessValue = new TextBox();
            label1 = new Label();
            radioButtonGammaCorrection = new RadioButton();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            trackBarRed = new TrackBar();
            trackBarGreen = new TrackBar();
            trackBarBlue = new TrackBar();
            radioButtonAdjustColorSpace = new RadioButton();
            radioButtonScale = new RadioButton();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxVideoStream).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarRed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarGreen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarBlue).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { openFileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(1123, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // openFileToolStripMenuItem
            // 
            openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            openFileToolStripMenuItem.Size = new Size(84, 24);
            openFileToolStripMenuItem.Text = "Open file";
            openFileToolStripMenuItem.Click += openFileToolStripMenuItem_Click;
            // 
            // pictureBoxVideoStream
            // 
            pictureBoxVideoStream.BackColor = SystemColors.ControlDark;
            pictureBoxVideoStream.Location = new Point(14, 52);
            pictureBoxVideoStream.Margin = new Padding(3, 4, 3, 4);
            pictureBoxVideoStream.Name = "pictureBoxVideoStream";
            pictureBoxVideoStream.Size = new Size(771, 624);
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
            progressBarVideoStream.Location = new Point(14, 705);
            progressBarVideoStream.Margin = new Padding(3, 4, 3, 4);
            progressBarVideoStream.Name = "progressBarVideoStream";
            progressBarVideoStream.Size = new Size(771, 31);
            progressBarVideoStream.TabIndex = 2;
            // 
            // btnPlayVideo
            // 
            btnPlayVideo.Location = new Point(811, 52);
            btnPlayVideo.Margin = new Padding(3, 4, 3, 4);
            btnPlayVideo.Name = "btnPlayVideo";
            btnPlayVideo.Size = new Size(122, 48);
            btnPlayVideo.TabIndex = 3;
            btnPlayVideo.Text = "Play Video";
            btnPlayVideo.UseVisualStyleBackColor = true;
            btnPlayVideo.Click += btnPlayVideo_Click;
            // 
            // labelVideoStreamFrameCount
            // 
            labelVideoStreamFrameCount.AutoSize = true;
            labelVideoStreamFrameCount.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelVideoStreamFrameCount.Location = new Point(966, 64);
            labelVideoStreamFrameCount.Name = "labelVideoStreamFrameCount";
            labelVideoStreamFrameCount.Size = new Size(106, 28);
            labelVideoStreamFrameCount.TabIndex = 4;
            labelVideoStreamFrameCount.Text = "FPS Count";
            // 
            // radioButtonGrayscale
            // 
            radioButtonGrayscale.AutoSize = true;
            radioButtonGrayscale.Location = new Point(811, 149);
            radioButtonGrayscale.Margin = new Padding(3, 4, 3, 4);
            radioButtonGrayscale.Name = "radioButtonGrayscale";
            radioButtonGrayscale.Size = new Size(93, 24);
            radioButtonGrayscale.TabIndex = 6;
            radioButtonGrayscale.TabStop = true;
            radioButtonGrayscale.Text = "Grayscale";
            radioButtonGrayscale.UseVisualStyleBackColor = true;
            radioButtonGrayscale.CheckedChanged += radioButtonGrayscale_CheckedChanged;
            // 
            // radioButtonExtractRed
            // 
            radioButtonExtractRed.AutoSize = true;
            radioButtonExtractRed.Location = new Point(811, 183);
            radioButtonExtractRed.Margin = new Padding(3, 4, 3, 4);
            radioButtonExtractRed.Name = "radioButtonExtractRed";
            radioButtonExtractRed.Size = new Size(105, 24);
            radioButtonExtractRed.TabIndex = 7;
            radioButtonExtractRed.TabStop = true;
            radioButtonExtractRed.Text = "Extract Red";
            radioButtonExtractRed.UseVisualStyleBackColor = true;
            radioButtonExtractRed.CheckedChanged += radioButtonExtractRed_CheckedChanged;
            // 
            // radioButtonExtractGreen
            // 
            radioButtonExtractGreen.AutoSize = true;
            radioButtonExtractGreen.Location = new Point(811, 216);
            radioButtonExtractGreen.Margin = new Padding(3, 4, 3, 4);
            radioButtonExtractGreen.Name = "radioButtonExtractGreen";
            radioButtonExtractGreen.Size = new Size(118, 24);
            radioButtonExtractGreen.TabIndex = 8;
            radioButtonExtractGreen.TabStop = true;
            radioButtonExtractGreen.Text = "Extract Green";
            radioButtonExtractGreen.UseVisualStyleBackColor = true;
            radioButtonExtractGreen.CheckedChanged += radioButtonExtractGreen_CheckedChanged;
            // 
            // radioButtonExtractBlue
            // 
            radioButtonExtractBlue.AutoSize = true;
            radioButtonExtractBlue.Location = new Point(811, 249);
            radioButtonExtractBlue.Margin = new Padding(3, 4, 3, 4);
            radioButtonExtractBlue.Name = "radioButtonExtractBlue";
            radioButtonExtractBlue.Size = new Size(108, 24);
            radioButtonExtractBlue.TabIndex = 9;
            radioButtonExtractBlue.TabStop = true;
            radioButtonExtractBlue.Text = "Extract Blue";
            radioButtonExtractBlue.UseVisualStyleBackColor = true;
            radioButtonExtractBlue.CheckedChanged += radioButtonExtractBlue_CheckedChanged;
            // 
            // radioButtonCarousel
            // 
            radioButtonCarousel.AutoSize = true;
            radioButtonCarousel.Location = new Point(811, 283);
            radioButtonCarousel.Margin = new Padding(3, 4, 3, 4);
            radioButtonCarousel.Name = "radioButtonCarousel";
            radioButtonCarousel.Size = new Size(87, 24);
            radioButtonCarousel.TabIndex = 10;
            radioButtonCarousel.TabStop = true;
            radioButtonCarousel.Text = "Carousel";
            radioButtonCarousel.UseVisualStyleBackColor = true;
            radioButtonCarousel.CheckedChanged += radioButtonCarousel_CheckedChanged;
            // 
            // radioButtonBrightness
            // 
            radioButtonBrightness.AutoSize = true;
            radioButtonBrightness.Location = new Point(811, 360);
            radioButtonBrightness.Margin = new Padding(3, 4, 3, 4);
            radioButtonBrightness.Name = "radioButtonBrightness";
            radioButtonBrightness.Size = new Size(171, 24);
            radioButtonBrightness.TabIndex = 11;
            radioButtonBrightness.TabStop = true;
            radioButtonBrightness.Text = "Brightness Correction";
            radioButtonBrightness.UseVisualStyleBackColor = true;
            radioButtonBrightness.CheckedChanged += radioButtonBrightness_CheckedChanged;
            // 
            // textBoxProcessValue
            // 
            textBoxProcessValue.Location = new Point(919, 320);
            textBoxProcessValue.Name = "textBoxProcessValue";
            textBoxProcessValue.Size = new Size(101, 27);
            textBoxProcessValue.TabIndex = 12;
            textBoxProcessValue.Text = "0";
            textBoxProcessValue.TextChanged += textBoxProcessValue_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(811, 323);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 13;
            label1.Text = "Process Value";
            // 
            // radioButtonGammaCorrection
            // 
            radioButtonGammaCorrection.AutoSize = true;
            radioButtonGammaCorrection.Location = new Point(811, 392);
            radioButtonGammaCorrection.Margin = new Padding(3, 4, 3, 4);
            radioButtonGammaCorrection.Name = "radioButtonGammaCorrection";
            radioButtonGammaCorrection.Size = new Size(155, 24);
            radioButtonGammaCorrection.TabIndex = 14;
            radioButtonGammaCorrection.TabStop = true;
            radioButtonGammaCorrection.Text = "Gamma Correction";
            radioButtonGammaCorrection.UseVisualStyleBackColor = true;
            radioButtonGammaCorrection.CheckedChanged += radioButtonGammaCorrection_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(812, 434);
            label2.Name = "label2";
            label2.Size = new Size(18, 20);
            label2.TabIndex = 15;
            label2.Text = "R";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(811, 469);
            label3.Name = "label3";
            label3.Size = new Size(19, 20);
            label3.TabIndex = 16;
            label3.Text = "G";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(811, 505);
            label4.Name = "label4";
            label4.Size = new Size(18, 20);
            label4.TabIndex = 17;
            label4.Text = "B";
            // 
            // trackBarRed
            // 
            trackBarRed.Location = new Point(858, 425);
            trackBarRed.Name = "trackBarRed";
            trackBarRed.Size = new Size(236, 56);
            trackBarRed.TabIndex = 18;
            trackBarRed.TickStyle = TickStyle.None;
            trackBarRed.Value = 10;
            trackBarRed.Scroll += trackBarRed_Scroll;
            // 
            // trackBarGreen
            // 
            trackBarGreen.Location = new Point(858, 461);
            trackBarGreen.Name = "trackBarGreen";
            trackBarGreen.Size = new Size(236, 56);
            trackBarGreen.TabIndex = 19;
            trackBarGreen.TickStyle = TickStyle.None;
            trackBarGreen.Value = 10;
            trackBarGreen.Scroll += trackBarGreen_Scroll;
            // 
            // trackBarBlue
            // 
            trackBarBlue.Location = new Point(858, 502);
            trackBarBlue.Name = "trackBarBlue";
            trackBarBlue.Size = new Size(236, 56);
            trackBarBlue.TabIndex = 20;
            trackBarBlue.TickStyle = TickStyle.None;
            trackBarBlue.Value = 10;
            trackBarBlue.Scroll += trackBarBlue_Scroll;
            // 
            // radioButtonAdjustColorSpace
            // 
            radioButtonAdjustColorSpace.AutoSize = true;
            radioButtonAdjustColorSpace.Location = new Point(811, 555);
            radioButtonAdjustColorSpace.Margin = new Padding(3, 4, 3, 4);
            radioButtonAdjustColorSpace.Name = "radioButtonAdjustColorSpace";
            radioButtonAdjustColorSpace.Size = new Size(156, 24);
            radioButtonAdjustColorSpace.TabIndex = 21;
            radioButtonAdjustColorSpace.TabStop = true;
            radioButtonAdjustColorSpace.Text = "Adjust Color Space";
            radioButtonAdjustColorSpace.UseVisualStyleBackColor = true;
            radioButtonAdjustColorSpace.CheckedChanged += radioButtonAdjustColorSpace_CheckedChanged;
            // 
            // radioButtonScale
            // 
            radioButtonScale.AutoSize = true;
            radioButtonScale.Location = new Point(812, 587);
            radioButtonScale.Margin = new Padding(3, 4, 3, 4);
            radioButtonScale.Name = "radioButtonScale";
            radioButtonScale.Size = new Size(65, 24);
            radioButtonScale.TabIndex = 22;
            radioButtonScale.TabStop = true;
            radioButtonScale.Text = "Scale";
            radioButtonScale.UseVisualStyleBackColor = true;
            radioButtonScale.CheckedChanged += radioButtonScale_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1123, 765);
            Controls.Add(radioButtonScale);
            Controls.Add(radioButtonAdjustColorSpace);
            Controls.Add(trackBarBlue);
            Controls.Add(trackBarGreen);
            Controls.Add(trackBarRed);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(radioButtonGammaCorrection);
            Controls.Add(label1);
            Controls.Add(textBoxProcessValue);
            Controls.Add(radioButtonBrightness);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "34eswd";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxVideoStream).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarRed).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarGreen).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarBlue).EndInit();
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
        private RadioButton radioButtonBrightness;
        private TextBox textBoxProcessValue;
        private Label label1;
        private RadioButton radioButtonGammaCorrection;
        private Label label2;
        private Label label3;
        private Label label4;
        private TrackBar trackBarRed;
        private TrackBar trackBarGreen;
        private TrackBar trackBarBlue;
        private RadioButton radioButtonAdjustColorSpace;
        private RadioButton radioButtonScale;
    }
}