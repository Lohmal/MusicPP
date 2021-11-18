using System;
using System.IO;
using System.Media;

namespace MusicPP
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        private static void MusicPPLoop(string f)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;
            string fullpath = "";
            string b = "";
            for (int x = 0; x < path.Length; x++)
            {
                if (path[x] == '\\')
                {
                    fullpath += "\\";
                    b = fullpath;
                    fullpath += f;
                    if (File.Exists(fullpath))
                    {
                        break;
                    }
                    fullpath = b;
                }
                else
                {
                    fullpath += path[x];
                }
            }
            var soundPlayer = new SoundPlayer();
            soundPlayer.SoundLocation = fullpath;
            soundPlayer.PlayLooping();
        }
        private static void MusicPP(string f)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;
            string fullpath = "";
            string b = "";
            for (int x = 0; x < path.Length; x++)
            {
                if (path[x] == '\\')
                {
                    fullpath += "\\";
                    b = fullpath;
                    fullpath += f;
                    if (File.Exists(fullpath))
                    {
                        break;
                    }
                    fullpath = b;
                }
                else
                {
                    fullpath += path[x];
                }
            }
            var soundPlayer = new SoundPlayer();
            soundPlayer.SoundLocation = fullpath;
            soundPlayer.Play();
        }
    }
}
