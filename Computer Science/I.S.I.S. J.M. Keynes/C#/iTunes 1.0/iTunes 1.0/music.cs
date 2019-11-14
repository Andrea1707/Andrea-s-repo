using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iTunes_1._0
{
    public class music
    {
        public string image_path { get; set; }
        public string Name { get; set; }
        public string Artist { get; set; }
        public string Genere { get; set; }
        public string file_path { get; set; }
        public music()
        { }


        public music(string img,string n,string a,string g,string audio)
        {
            image_path = img;
            Name = n;
            Artist = a;
            Genere = g;
            file_path = audio;
        }
    }
}
