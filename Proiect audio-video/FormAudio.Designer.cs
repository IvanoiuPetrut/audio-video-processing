namespace Proiect_audio_video
{
    partial class FormAudio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBoxAudio = new ListBox();
            menuStrip1 = new MenuStrip();
            openAudioFilesToolStripMenuItem = new ToolStripMenuItem();
            openVideoFilesToolStripMenuItem = new ToolStripMenuItem();
            videoFormToolStripMenuItem = new ToolStripMenuItem();
            listBoxVideo = new ListBox();
            labelAudioFiles = new Label();
            labelVideoFiles = new Label();
            btnPlayAudio = new Button();
            btnMixAudio = new Button();
            btnConcatenateAudio = new Button();
            btnAlternateAudio = new Button();
            labelPitch = new Label();
            numericUpDownPitchLevel = new NumericUpDown();
            btnCombineAudiovideo = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPitchLevel).BeginInit();
            SuspendLayout();
            // 
            // listBoxAudio
            // 
            listBoxAudio.FormattingEnabled = true;
            listBoxAudio.ItemHeight = 20;
            listBoxAudio.Items.AddRange(new object[] { "test1", "test2" });
            listBoxAudio.Location = new Point(12, 70);
            listBoxAudio.Name = "listBoxAudio";
            listBoxAudio.SelectionMode = SelectionMode.MultiExtended;
            listBoxAudio.Size = new Size(356, 204);
            listBoxAudio.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { openAudioFilesToolStripMenuItem, openVideoFilesToolStripMenuItem, videoFormToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(856, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // openAudioFilesToolStripMenuItem
            // 
            openAudioFilesToolStripMenuItem.Name = "openAudioFilesToolStripMenuItem";
            openAudioFilesToolStripMenuItem.Size = new Size(136, 24);
            openAudioFilesToolStripMenuItem.Text = "Open Audio Files";
            openAudioFilesToolStripMenuItem.Click += openAudioFilesToolStripMenuItem_Click;
            // 
            // openVideoFilesToolStripMenuItem
            // 
            openVideoFilesToolStripMenuItem.Name = "openVideoFilesToolStripMenuItem";
            openVideoFilesToolStripMenuItem.Size = new Size(135, 24);
            openVideoFilesToolStripMenuItem.Text = "Open Video Files";
            // 
            // videoFormToolStripMenuItem
            // 
            videoFormToolStripMenuItem.Name = "videoFormToolStripMenuItem";
            videoFormToolStripMenuItem.Size = new Size(100, 24);
            videoFormToolStripMenuItem.Text = "Video Form";
            videoFormToolStripMenuItem.Click += videoFormToolStripMenuItem_Click;
            // 
            // listBoxVideo
            // 
            listBoxVideo.FormattingEnabled = true;
            listBoxVideo.ItemHeight = 20;
            listBoxVideo.Location = new Point(12, 320);
            listBoxVideo.Name = "listBoxVideo";
            listBoxVideo.SelectionMode = SelectionMode.MultiExtended;
            listBoxVideo.Size = new Size(356, 204);
            listBoxVideo.TabIndex = 2;
            // 
            // labelAudioFiles
            // 
            labelAudioFiles.AutoSize = true;
            labelAudioFiles.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelAudioFiles.Location = new Point(22, 36);
            labelAudioFiles.Name = "labelAudioFiles";
            labelAudioFiles.Size = new Size(112, 28);
            labelAudioFiles.TabIndex = 5;
            labelAudioFiles.Text = "Audio Files";
            // 
            // labelVideoFiles
            // 
            labelVideoFiles.AutoSize = true;
            labelVideoFiles.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelVideoFiles.Location = new Point(23, 289);
            labelVideoFiles.Name = "labelVideoFiles";
            labelVideoFiles.Size = new Size(111, 28);
            labelVideoFiles.TabIndex = 6;
            labelVideoFiles.Text = "Video Files";
            // 
            // btnPlayAudio
            // 
            btnPlayAudio.Location = new Point(390, 67);
            btnPlayAudio.Margin = new Padding(3, 4, 3, 4);
            btnPlayAudio.Name = "btnPlayAudio";
            btnPlayAudio.Size = new Size(122, 48);
            btnPlayAudio.TabIndex = 7;
            btnPlayAudio.Text = "Play Audio";
            btnPlayAudio.UseVisualStyleBackColor = true;
            btnPlayAudio.Click += btnPlayAudio_Click;
            // 
            // btnMixAudio
            // 
            btnMixAudio.Location = new Point(390, 129);
            btnMixAudio.Margin = new Padding(3, 4, 3, 4);
            btnMixAudio.Name = "btnMixAudio";
            btnMixAudio.Size = new Size(122, 48);
            btnMixAudio.TabIndex = 8;
            btnMixAudio.Text = "Mix Audio";
            btnMixAudio.UseVisualStyleBackColor = true;
            // 
            // btnConcatenateAudio
            // 
            btnConcatenateAudio.Location = new Point(390, 198);
            btnConcatenateAudio.Margin = new Padding(3, 4, 3, 4);
            btnConcatenateAudio.Name = "btnConcatenateAudio";
            btnConcatenateAudio.Size = new Size(122, 48);
            btnConcatenateAudio.TabIndex = 9;
            btnConcatenateAudio.Text = "Concatenate Audio";
            btnConcatenateAudio.UseVisualStyleBackColor = true;
            // 
            // btnAlternateAudio
            // 
            btnAlternateAudio.Location = new Point(390, 269);
            btnAlternateAudio.Margin = new Padding(3, 4, 3, 4);
            btnAlternateAudio.Name = "btnAlternateAudio";
            btnAlternateAudio.Size = new Size(122, 48);
            btnAlternateAudio.TabIndex = 10;
            btnAlternateAudio.Text = "Alternate Audio";
            btnAlternateAudio.UseVisualStyleBackColor = true;
            // 
            // labelPitch
            // 
            labelPitch.AutoSize = true;
            labelPitch.Location = new Point(515, 267);
            labelPitch.Name = "labelPitch";
            labelPitch.Size = new Size(76, 20);
            labelPitch.TabIndex = 12;
            labelPitch.Text = "Pitch level";
            // 
            // numericUpDownPitchLevel
            // 
            numericUpDownPitchLevel.Location = new Point(518, 288);
            numericUpDownPitchLevel.Name = "numericUpDownPitchLevel";
            numericUpDownPitchLevel.Size = new Size(150, 27);
            numericUpDownPitchLevel.TabIndex = 13;
            // 
            // btnCombineAudiovideo
            // 
            btnCombineAudiovideo.Location = new Point(390, 338);
            btnCombineAudiovideo.Margin = new Padding(3, 4, 3, 4);
            btnCombineAudiovideo.Name = "btnCombineAudiovideo";
            btnCombineAudiovideo.Size = new Size(122, 48);
            btnCombineAudiovideo.TabIndex = 14;
            btnCombineAudiovideo.Text = "Combine Audio Video";
            btnCombineAudiovideo.UseVisualStyleBackColor = true;
            // 
            // FormAudio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(856, 536);
            Controls.Add(btnCombineAudiovideo);
            Controls.Add(numericUpDownPitchLevel);
            Controls.Add(labelPitch);
            Controls.Add(btnAlternateAudio);
            Controls.Add(btnConcatenateAudio);
            Controls.Add(btnMixAudio);
            Controls.Add(btnPlayAudio);
            Controls.Add(labelVideoFiles);
            Controls.Add(labelAudioFiles);
            Controls.Add(listBoxVideo);
            Controls.Add(listBoxAudio);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormAudio";
            Text = "FormAudio";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPitchLevel).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxAudio;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem openAudioFilesToolStripMenuItem;
        private ToolStripMenuItem openVideoFilesToolStripMenuItem;
        private ToolStripMenuItem videoFormToolStripMenuItem;
        private ListBox listBoxVideo;
        private Label labelAudioFiles;
        private Label labelVideoFiles;
        private Button btnPlayAudio;
        private Button btnMixAudio;
        private Button btnConcatenateAudio;
        private Button btnAlternateAudio;
        private Label labelPitch;
        private NumericUpDown numericUpDownPitchLevel;
        private Button btnCombineAudiovideo;
    }
}