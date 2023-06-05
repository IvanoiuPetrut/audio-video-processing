using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_audio_video.Utilities
{
    public class SelectAudioFiles
    {
        static public List<string> SelectFiles()
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
    }
}
