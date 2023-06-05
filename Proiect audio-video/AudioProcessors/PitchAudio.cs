using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_audio_video.AudioProcessors
{
    public class PitchAudio
    {
        public static void Pitch(string inputFile, string outputFile, float pitchFactor)
        {
            using (var reader = new MediaFoundationReader(inputFile))
            {
                var pitch = new SmbPitchShiftingSampleProvider(reader.ToSampleProvider());
                pitch.PitchFactor = pitchFactor;
                WaveFileWriter.CreateWaveFile16(outputFile, pitch);
            }
        }
    }
}
