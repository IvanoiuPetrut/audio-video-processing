using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_audio_video.AudioProcessors
{
    public class MixMultipleAudioFiles
    {
        public static void MixAudioFiles(List<string> filePaths, List<float> volumes, string outputFile)
        {
            AudioFileReader[] audioFileReaders = new AudioFileReader[filePaths.Count];
            foreach ((string audioFile, int index) in filePaths.Select((path, index) => (path, index)))
            {
                audioFileReaders[index] = new AudioFileReader(audioFile);
                audioFileReaders[index].Volume = volumes[index];
            }

            var mixer = new MixingSampleProvider(audioFileReaders);
            WaveFileWriter.CreateWaveFile16(outputFile, mixer);
        }
    }
}
