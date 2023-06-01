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
            twoVideosToolStripMenuItem = new ToolStripMenuItem();
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
            radioButtonBackgroundSubtraction = new RadioButton();
            radioButtonScale = new RadioButton();
            radioButtonRotate = new RadioButton();
            numericUpDownScaleFactor = new NumericUpDown();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            trackBarRed = new TrackBar();
            trackBarGreen = new TrackBar();
            trackBarBlue = new TrackBar();
            radioButtonAdjustColorSpace = new RadioButton();
            numericUpRotateFactor = new NumericUpDown();
            numericUpDownGamma = new NumericUpDown();
            numericUpDownAlphaBrightness = new NumericUpDown();
            Alpha = new Label();
            label5 = new Label();
            numericUpDownBetaBrightness = new NumericUpDown();
            openTwoVideosToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxVideoStream).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownScaleFactor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarRed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarGreen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarBlue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpRotateFactor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownGamma).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAlphaBrightness).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBetaBrightness).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { openFileToolStripMenuItem, twoVideosToolStripMenuItem, openTwoVideosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(1347, 30);
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
            // twoVideosToolStripMenuItem
            // 
            twoVideosToolStripMenuItem.Name = "twoVideosToolStripMenuItem";
            twoVideosToolStripMenuItem.Size = new Size(137, 24);
            twoVideosToolStripMenuItem.Text = "Two Videos Form";
            twoVideosToolStripMenuItem.Click += twoVideosToolStripMenuItem_Click;
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
            progressBarVideoStream.Click += progressBarVideoStream_Click;
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
            textBoxProcessValue.Location = new Point(993, 323);
            textBoxProcessValue.Name = "textBoxProcessValue";
            textBoxProcessValue.Size = new Size(100, 27);
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
            // radioButtonBackgroundSubtraction
            // 
            radioButtonBackgroundSubtraction.AutoSize = true;
            radioButtonBackgroundSubtraction.Location = new Point(810, 581);
            radioButtonBackgroundSubtraction.Margin = new Padding(3, 4, 3, 4);
            radioButtonBackgroundSubtraction.Name = "radioButtonBackgroundSubtraction";
            radioButtonBackgroundSubtraction.Size = new Size(189, 24);
            radioButtonBackgroundSubtraction.TabIndex = 15;
            radioButtonBackgroundSubtraction.TabStop = true;
            radioButtonBackgroundSubtraction.Text = "Background Subtraction";
            radioButtonBackgroundSubtraction.UseVisualStyleBackColor = true;
            radioButtonBackgroundSubtraction.CheckedChanged += radioButtonBackgroundSubtraction_CheckedChanged;
            // 
            // radioButtonScale
            // 
            radioButtonScale.AutoSize = true;
            radioButtonScale.Location = new Point(810, 613);
            radioButtonScale.Margin = new Padding(3, 4, 3, 4);
            radioButtonScale.Name = "radioButtonScale";
            radioButtonScale.Size = new Size(65, 24);
            radioButtonScale.TabIndex = 22;
            radioButtonScale.TabStop = true;
            radioButtonScale.Text = "Scale";
            radioButtonScale.UseVisualStyleBackColor = true;
            radioButtonScale.CheckedChanged += radioButtonScale_CheckedChanged;
            // 
            // radioButtonRotate
            // 
            radioButtonRotate.AutoSize = true;
            radioButtonRotate.Location = new Point(811, 652);
            radioButtonRotate.Margin = new Padding(3, 4, 3, 4);
            radioButtonRotate.Name = "radioButtonRotate";
            radioButtonRotate.Size = new Size(74, 24);
            radioButtonRotate.TabIndex = 17;
            radioButtonRotate.TabStop = true;
            radioButtonRotate.Text = "Rotate";
            radioButtonRotate.UseVisualStyleBackColor = true;
            radioButtonRotate.CheckedChanged += radioButtonRotate_CheckedChanged;
            // 
            // numericUpDownScaleFactor
            // 
            numericUpDownScaleFactor.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDownScaleFactor.Location = new Point(944, 612);
            numericUpDownScaleFactor.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownScaleFactor.Name = "numericUpDownScaleFactor";
            numericUpDownScaleFactor.Size = new Size(150, 27);
            numericUpDownScaleFactor.TabIndex = 19;
            numericUpDownScaleFactor.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownScaleFactor.ValueChanged += numericUpDownScaleFactor_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(811, 435);
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
            trackBarRed.Size = new Size(235, 56);
            trackBarRed.TabIndex = 18;
            trackBarRed.TickStyle = TickStyle.None;
            trackBarRed.Value = 10;
            trackBarRed.Scroll += trackBarRed_Scroll;
            // 
            // trackBarGreen
            // 
            trackBarGreen.Location = new Point(858, 461);
            trackBarGreen.Name = "trackBarGreen";
            trackBarGreen.Size = new Size(235, 56);
            trackBarGreen.TabIndex = 19;
            trackBarGreen.TickStyle = TickStyle.None;
            trackBarGreen.Value = 10;
            trackBarGreen.Scroll += trackBarGreen_Scroll;
            // 
            // trackBarBlue
            // 
            trackBarBlue.Location = new Point(858, 501);
            trackBarBlue.Name = "trackBarBlue";
            trackBarBlue.Size = new Size(235, 56);
            trackBarBlue.TabIndex = 20;
            trackBarBlue.TickStyle = TickStyle.None;
            trackBarBlue.Value = 10;
            trackBarBlue.Scroll += trackBarBlue_Scroll;
            // 
            // radioButtonAdjustColorSpace
            // 
            radioButtonAdjustColorSpace.AutoSize = true;
            radioButtonAdjustColorSpace.Location = new Point(810, 549);
            radioButtonAdjustColorSpace.Margin = new Padding(3, 4, 3, 4);
            radioButtonAdjustColorSpace.Name = "radioButtonAdjustColorSpace";
            radioButtonAdjustColorSpace.Size = new Size(156, 24);
            radioButtonAdjustColorSpace.TabIndex = 21;
            radioButtonAdjustColorSpace.TabStop = true;
            radioButtonAdjustColorSpace.Text = "Adjust Color Space";
            radioButtonAdjustColorSpace.UseVisualStyleBackColor = true;
            radioButtonAdjustColorSpace.CheckedChanged += radioButtonAdjustColorSpace_CheckedChanged;
            // 
            // numericUpRotateFactor
            // 
            numericUpRotateFactor.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpRotateFactor.Location = new Point(944, 652);
            numericUpRotateFactor.Maximum = new decimal(new int[] { 360, 0, 0, 0 });
            numericUpRotateFactor.Name = "numericUpRotateFactor";
            numericUpRotateFactor.Size = new Size(150, 27);
            numericUpRotateFactor.TabIndex = 23;
            numericUpRotateFactor.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpRotateFactor.ValueChanged += numericUpRotateFactor_ValueChanged;
            // 
            // numericUpDownGamma
            // 
            numericUpDownGamma.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDownGamma.Location = new Point(993, 389);
            numericUpDownGamma.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownGamma.Name = "numericUpDownGamma";
            numericUpDownGamma.Size = new Size(150, 27);
            numericUpDownGamma.TabIndex = 24;
            numericUpDownGamma.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownGamma.ValueChanged += numericUpDownGamma_ValueChanged;
            // 
            // numericUpDownAlphaBrightness
            // 
            numericUpDownAlphaBrightness.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDownAlphaBrightness.Location = new Point(1062, 360);
            numericUpDownAlphaBrightness.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownAlphaBrightness.Name = "numericUpDownAlphaBrightness";
            numericUpDownAlphaBrightness.Size = new Size(81, 27);
            numericUpDownAlphaBrightness.TabIndex = 25;
            numericUpDownAlphaBrightness.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownAlphaBrightness.ValueChanged += numericUpDownAlphaBrightness_ValueChanged;
            // 
            // Alpha
            // 
            Alpha.AutoSize = true;
            Alpha.Location = new Point(993, 362);
            Alpha.Name = "Alpha";
            Alpha.Size = new Size(48, 20);
            Alpha.TabIndex = 26;
            Alpha.Text = "Alpha";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1149, 364);
            label5.Name = "label5";
            label5.Size = new Size(39, 20);
            label5.TabIndex = 27;
            label5.Text = "Beta";
            // 
            // numericUpDownBetaBrightness
            // 
            numericUpDownBetaBrightness.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDownBetaBrightness.Location = new Point(1194, 364);
            numericUpDownBetaBrightness.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownBetaBrightness.Name = "numericUpDownBetaBrightness";
            numericUpDownBetaBrightness.Size = new Size(81, 27);
            numericUpDownBetaBrightness.TabIndex = 28;
            numericUpDownBetaBrightness.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownBetaBrightness.ValueChanged += numericUpDownBetaBrightness_ValueChanged;
            // 
            // openTwoVideosToolStripMenuItem
            // 
            openTwoVideosToolStripMenuItem.Name = "openTwoVideosToolStripMenuItem";
            openTwoVideosToolStripMenuItem.Size = new Size(139, 24);
            openTwoVideosToolStripMenuItem.Text = "Open Two Videos";
            openTwoVideosToolStripMenuItem.Click += openTwoVideosToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1347, 765);
            Controls.Add(numericUpDownBetaBrightness);
            Controls.Add(label5);
            Controls.Add(Alpha);
            Controls.Add(numericUpDownAlphaBrightness);
            Controls.Add(numericUpDownGamma);
            Controls.Add(numericUpRotateFactor);
            Controls.Add(numericUpDownScaleFactor);
            Controls.Add(radioButtonRotate);
            Controls.Add(radioButtonBackgroundSubtraction);
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
            Text = "Video edit";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxVideoStream).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownScaleFactor).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarRed).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarGreen).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarBlue).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpRotateFactor).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownGamma).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAlphaBrightness).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBetaBrightness).EndInit();
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
        private RadioButton radioButtonBackgroundSubtraction;
        private RadioButton radioButtonScale;
        private RadioButton radioButtonRotate;
        private NumericUpDown numericUpDownScaleFactor;
        private Label label2;
        private Label label3;
        private Label label4;
        private TrackBar trackBarRed;
        private TrackBar trackBarGreen;
        private TrackBar trackBarBlue;
        private RadioButton radioButtonAdjustColorSpace;
        private NumericUpDown numericUpRotateFactor;
        private NumericUpDown numericUpDownGamma;
        private NumericUpDown numericUpDownAlphaBrightness;
        private Label Alpha;
        private Label label5;
        private NumericUpDown numericUpDownBetaBrightness;
        private ToolStripMenuItem twoVideosToolStripMenuItem;
        private ToolStripMenuItem openTwoVideosToolStripMenuItem;
    }
}