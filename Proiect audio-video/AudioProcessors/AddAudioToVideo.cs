using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_audio_video.AudioProcessors
{
    public class AddAudioToVideo
    {
        public static void Add(string inputVideoPath, string inputAudioPath, string outputVideoPath)
        {
            Process process = new Process();
            process.StartInfo.FileName = "ffmpeg";
            process.StartInfo.Arguments = $"-i {inputVideoPath} -i {inputAudioPath} -c:v copy -c:a aac -map 0:v:0 -map 1:a:0 -shortest {outputVideoPath}";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.Start();
            process.WaitForExit();
        }
    }
}
