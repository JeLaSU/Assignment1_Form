using System.Runtime.InteropServices;
using System.Text;

namespace Assignment1_Form
{
    class MusicPlayer
    {
        [DllImport("winmm.dll")]
        private static extern long mciSendString(string Command, StringBuilder lpstrReturnString, int uReturnLength, int hwndCallback);

        public void open(string file)
        {
            string command = "open \"" + file + "\" type MPEGVideo alias MyMp3";
            mciSendString(command, null, 0, 0);
        }

        public void play()
        {
            string command = "play MyMp3";
            mciSendString(command, null, 0, 0);
        }

        public void stop()
        {
            string command = "stop MyMp3";
            mciSendString(command, null, 0, 0);
        }
    }
}
