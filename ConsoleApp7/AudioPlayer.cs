
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class AudioPlayer : IMediaPlayer
    {
        private MediaAdapter mediaAdapter;
        public void play(string audioType, string fileName)
        {
            switch (audioType)
            {
                case "mp3":
                    Console.WriteLine("Playing mp3 file name:" + fileName);
                    break;
                case "vlc":
                case "mp4":
                    mediaAdapter = new MediaAdapter(audioType);
                    mediaAdapter.play(audioType, fileName);
                    break;
                
                default:
                    Console.WriteLine("Invalid media." + audioType + "format not supported");
                    break;
            }
        }
    }
}
