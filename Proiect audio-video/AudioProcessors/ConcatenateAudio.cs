using NAudio.Wave.SampleProviders;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_audio_video.AudioProcessors
{
    public class ConcatenateAudio
    {
        public static void ConcatenateAudioFilesWithCrossFade(string outputFile, params string[] audioFiles)
        {
            var fadeInOutProviders = new List<FadeInOutSampleProvider>();

            for (int i = 0; i < audioFiles.Length; i++)
            {
                var reader = new AudioFileReader(audioFiles[i]);
                var fadeInOutProvider = new FadeInOutSampleProvider(reader, false);
                fadeInOutProviders.Add(fadeInOutProvider);
            }

            var playlist = new ConcatenatingSampleProvider(fadeInOutProviders);
            WaveFileWriter.CreateWaveFile16(outputFile, playlist);
        }
    }
}
