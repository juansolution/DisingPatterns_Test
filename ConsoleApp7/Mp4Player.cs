using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class Mp4Player : IAdvancedMediaPlayer
    {
        public void playMp4(string fileName)
        {
            Console.WriteLine("Playing mp4 file. Name:" + fileName);
        }

        public void playVlc(string fileName)
        {
            throw new NotImplementedException();
        }
    }
}
