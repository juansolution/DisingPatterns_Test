using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public interface IAdvancedMediaPlayer
    {
        void playVlc(string fileName);
        void playMp4(string fileName);

    }
}
