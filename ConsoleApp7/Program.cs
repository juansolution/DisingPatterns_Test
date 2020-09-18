using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            AudioPlayer audioPlayer = new AudioPlayer();
            audioPlayer.play("mp3", "beyond the horizon.mp3");
            audioPlayer.play("mp4", "beyond the horizon.mp4");
            audioPlayer.play("vlc", "beyond the horizon.vlc");
            audioPlayer.play("avi", "beyond the horizon.avi");
            
        }
    }
}
