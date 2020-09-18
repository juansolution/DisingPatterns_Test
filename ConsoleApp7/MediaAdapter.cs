using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class MediaAdapter : IMediaPlayer
    {
        
        private IAdvancedMediaPlayer advancedMediaPlayer;

        public MediaAdapter(string audioType)
        {
            switch (audioType)
            {
                case "vlc":
                    advancedMediaPlayer = new VlcPlayer();
                    break;
                case "mp4":
                    advancedMediaPlayer = new Mp4Player();
                    break;
                default:
                    throw new NotImplementedException();

            }

        }

        public void play(string audioType, string fileName)
        {
            switch (audioType)
            {
                case "vlc":
                    advancedMediaPlayer.playVlc(fileName);
                    break;
                case "mp4":
                    advancedMediaPlayer.playMp4(fileName);
                    break;
                default:
                    throw new NotImplementedException();
            }
           
        }
    }
}
