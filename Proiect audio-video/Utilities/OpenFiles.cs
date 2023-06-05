using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_audio_video.Utilities
{
    public class OpenFiles
    {
        static public List<string> Open(string filter)
        {
            List<string> files = new List<string>();

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = filter;

            DialogResult dialogResult = openFileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                files.AddRange(openFileDialog.FileNames);
            }

            return files;
        }
    }
}
