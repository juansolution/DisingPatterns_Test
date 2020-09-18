using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class VlcPlayer : IAdvancedMediaPlayer
    {
        public void playMp4(string fileName)
        {
            
            
        }

        public void playVlc(string fileName)
        {
            Console.WriteLine("Playing vlc file. Name:" + fileName);
        }
    }
}
