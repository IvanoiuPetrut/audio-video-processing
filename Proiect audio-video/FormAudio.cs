﻿using Proiect_audio_video.AudioProcessors;
using Proiect_audio_video.Models;
using Proiect_audio_video.Utilities;
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
        Audio audio = new Audio();
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

        private void openAudioFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<string> audioFiles = SelectAudioFiles.SelectFiles();
            listBoxAudio.Items.Clear();
            listBoxAudio.Items.AddRange(audioFiles.ToArray());

        }

        private void btnPlayAudio_Click(object sender, EventArgs e)
        {
            if (listBoxAudio.Items != null)
            {
                string audioFile = listBoxAudio.SelectedItem.ToString();
                audio.Play(audioFile);
            }
        }

        private void btnMixAudio_Click(object sender, EventArgs e)
        {
            if (listBoxAudio.Items != null)
            {
                List<string> audioFiles = new List<string>();
                List<float> volumes = new List<float>();
                foreach ((string audioFile, int index) in listBoxAudio.Items.Cast<string>().Select((path, index) => (path, index)))
                {
                    labelTest.Text = labelTest.Text + " " + audioFile + "";
                    audioFiles.Add(audioFile);
                    if (index % 2 == 0)
                    {
                        volumes.Add(0.45f);
                    }
                    else
                    {
                        volumes.Add(0.20f);
                    }
                }
                string outputFile = "outputMix.wav";
                MixAudio.Mix(audioFiles, volumes, outputFile);
                audio.Play(outputFile);
            }
        }

        private void btnConcatenateAudio_Click(object sender, EventArgs e)
        {
            if (listBoxAudio.Items != null)
            {
                List<string> audioFiles = new List<string>();
                foreach (string audioFile in listBoxAudio.Items)
                {
                    audioFiles.Add(audioFile);
                }
                string outputFile = "outputConcatenateCrossFade.wav";
                ConcatenateAudio.ConcatenateAudioFilesWithCrossFade(outputFile, audioFiles.ToArray());
                audio.Play(outputFile);
            }
        }

        private void btnPitchUp_Click(object sender, EventArgs e)
        {
            if (listBoxAudio.Items != null)
            {
                string audioFile = listBoxAudio.SelectedItem.ToString();
                string outputFile = "outputPitchUp.wav";
                PitchAudio.Pitch(audioFile, outputFile, 2.0f);
                audio.Play(outputFile);
            }
        }

        private void btnPitchDown_Click(object sender, EventArgs e)
        {
            if (listBoxAudio.Items != null)
            {
                string audioFile = listBoxAudio.SelectedItem.ToString();
                string outputFile = "outputPitchDown.wav";
                PitchAudio.Pitch(audioFile, outputFile, 0.5f);
                audio.Play(outputFile);
            }
        }

        private void btnCombineAudiovideo_Click(object sender, EventArgs e)
        {
            if (listBoxAudio.Items != null || listBoxVideo.Items != null)
            {
                string audioFile = listBoxAudio.SelectedItem.ToString();
                string videoFile = listBoxVideo.SelectedItem.ToString();
                string outputFile = "outputCombineAudioVideo.mp4";
                labelTest.Text = audioFile + " " + videoFile + " " + outputFile;
                AddAudioToVideo.Add(videoFile, audioFile, outputFile);
            }
        }

        private void openVideoFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<string> videoFiles = OpenFiles.Open("Video Files|*.mp4;*.avi;*.mkv;*.mov;*.wmv|All Files|*.*");
            listBoxVideo.Items.Clear();
            listBoxVideo.Items.AddRange(videoFiles.ToArray());
        }
    }
}
