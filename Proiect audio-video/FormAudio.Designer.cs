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
            btnPitchUp = new Button();
            btnCombineAudiovideo = new Button();
            labelTest = new Label();
            btnPitchDown = new Button();
            menuStrip1.SuspendLayout();
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
            btnMixAudio.Click += btnMixAudio_Click;
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
            btnConcatenateAudio.Click += btnConcatenateAudio_Click;
            // 
            // btnPitchUp
            // 
            btnPitchUp.Location = new Point(390, 269);
            btnPitchUp.Margin = new Padding(3, 4, 3, 4);
            btnPitchUp.Name = "btnPitchUp";
            btnPitchUp.Size = new Size(122, 48);
            btnPitchUp.TabIndex = 10;
            btnPitchUp.Text = "Pitch Up";
            btnPitchUp.UseVisualStyleBackColor = true;
            btnPitchUp.Click += btnPitchUp_Click;
            // 
            // btnCombineAudiovideo
            // 
            btnCombineAudiovideo.Location = new Point(390, 399);
            btnCombineAudiovideo.Margin = new Padding(3, 4, 3, 4);
            btnCombineAudiovideo.Name = "btnCombineAudiovideo";
            btnCombineAudiovideo.Size = new Size(122, 48);
            btnCombineAudiovideo.TabIndex = 14;
            btnCombineAudiovideo.Text = "Combine Audio Video";
            btnCombineAudiovideo.UseVisualStyleBackColor = true;
            // 
            // labelTest
            // 
            labelTest.AutoSize = true;
            labelTest.Location = new Point(573, 73);
            labelTest.Name = "labelTest";
            labelTest.Size = new Size(33, 20);
            labelTest.TabIndex = 15;
            labelTest.Text = "test";
            // 
            // btnPitchDown
            // 
            btnPitchDown.Location = new Point(390, 337);
            btnPitchDown.Margin = new Padding(3, 4, 3, 4);
            btnPitchDown.Name = "btnPitchDown";
            btnPitchDown.Size = new Size(122, 48);
            btnPitchDown.TabIndex = 16;
            btnPitchDown.Text = "Pitch Down";
            btnPitchDown.UseVisualStyleBackColor = true;
            btnPitchDown.Click += btnPitchDown_Click;
            // 
            // FormAudio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(856, 536);
            Controls.Add(btnPitchDown);
            Controls.Add(labelTest);
            Controls.Add(btnCombineAudiovideo);
            Controls.Add(btnPitchUp);
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
        private Button btnPitchUp;
        private Button btnCombineAudiovideo;
        private Label labelTest;
        private Button btnPitchDown;
    }
}