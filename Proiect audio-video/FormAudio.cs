using Proiect_audio_video.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_audio_video
{
    public partial class FormAudio : Form
    {
        public FormAudio()
        {
            InitializeComponent();
        }

        private void videoFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        public List<string> SelectAudioFiles()
        {
            List<string> audioFiles = new List<string>();

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "Audio Files|*.mp3;*.wav;*.ogg|All Files|*.*";

            DialogResult dialogResult = openFileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                audioFiles.AddRange(openFileDialog.FileNames);
            }

            return audioFiles;
        }

        public void DisplayAudioFiles(List<string> audioFiles)
        {
            // Assuming you have a ListBox control named "listBoxAudioFiles" on your form
            listBoxAudio.Items.Clear();
            listBoxAudio.Items.AddRange(audioFiles.ToArray());
        }
        private void openAudioFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<string> audioFiles = SelectAudioFiles();
            DisplayAudioFiles(audioFiles);
        }

        private void btnPlayAudio_Click(object sender, EventArgs e)
        {
            //get selected audio from listbox
            string audioFile = listBoxAudio.SelectedItem.ToString();
            Audio audio = new Audio();
            audio.Play(audioFile);
        }
    }
}
