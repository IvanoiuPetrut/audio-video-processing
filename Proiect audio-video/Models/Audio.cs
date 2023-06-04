using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_audio_video.Models
{
    public class Audio
    {
        private WaveOutEvent outputDevice;
        private AudioFileReader audioFile;

        public void Play(string filePath)
        {
            Stop();

            outputDevice = new WaveOutEvent();
            outputDevice.PlaybackStopped += OnPlaybackStopped;

            audioFile = new AudioFileReader(filePath);
            outputDevice.Init(audioFile);
            outputDevice.Play();
        }

        public void Stop()
        {
            if (outputDevice != null)
            {
                outputDevice.Stop();
                outputDevice.Dispose();
                outputDevice = null;
            }

            if (audioFile != null)
            {
                audioFile.Dispose();
                audioFile = null;
            }
        }

        private void OnPlaybackStopped(object sender, StoppedEventArgs args)
        {
            Stop();
        }

        public void Dispose()
        {
            Stop();
        }
    }
}
