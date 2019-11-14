using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace PongProject
{
    public class Sound
    {
        public static void PlayFile_osteo()
        {
            
            var a =new SoundPlayer (PongProject.Properties.Resources.osteo);
            a.PlaySync();

            
        }
        public static void PlayFile_menu(bool k)
        {
            var a = new SoundPlayer(PongProject.Properties.Resources.RSHA);
            if (k == true)
            {
                
                a.PlayLooping();
            }
            else
            {
                a.Stop();
            }

        }
    }
}
