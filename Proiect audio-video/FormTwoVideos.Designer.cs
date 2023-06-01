namespace Proiect_audio_video
{
    partial class FormTwoVideos
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
            menuStrip1 = new MenuStrip();
            openTwoVideoToolStripMenuItem = new ToolStripMenuItem();
            oneVideoFormToolStripMenuItem = new ToolStripMenuItem();
            pictureBoxVideoStream = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxVideoStream).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { openTwoVideoToolStripMenuItem, oneVideoFormToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1040, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // openTwoVideoToolStripMenuItem
            // 
            openTwoVideoToolStripMenuItem.Name = "openTwoVideoToolStripMenuItem";
            openTwoVideoToolStripMenuItem.Size = new Size(129, 24);
            openTwoVideoToolStripMenuItem.Text = "Open two video";
            // 
            // oneVideoFormToolStripMenuItem
            // 
            oneVideoFormToolStripMenuItem.Name = "oneVideoFormToolStripMenuItem";
            oneVideoFormToolStripMenuItem.Size = new Size(131, 24);
            oneVideoFormToolStripMenuItem.Text = "One Video Form";
            oneVideoFormToolStripMenuItem.Click += oneVideoFormToolStripMenuItem_Click;
            // 
            // pictureBoxVideoStream
            // 
            pictureBoxVideoStream.BackColor = SystemColors.ControlDark;
            pictureBoxVideoStream.Location = new Point(12, 48);
            pictureBoxVideoStream.Margin = new Padding(3, 4, 3, 4);
            pictureBoxVideoStream.Name = "pictureBoxVideoStream";
            pictureBoxVideoStream.Size = new Size(771, 624);
            pictureBoxVideoStream.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxVideoStream.TabIndex = 2;
            pictureBoxVideoStream.TabStop = false;
            // 
            // FormTwoVideos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1040, 747);
            Controls.Add(pictureBoxVideoStream);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormTwoVideos";
            Text = "Two Videos Blending";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxVideoStream).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem openTwoVideoToolStripMenuItem;
        private ToolStripMenuItem oneVideoFormToolStripMenuItem;
        private PictureBox pictureBoxVideoStream;
    }
}