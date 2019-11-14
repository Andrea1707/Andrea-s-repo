using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milano_Malpensa
{
    public class Passeggero
    {
        public string last_name { get; set; }
        public string first_name { get; set; }
        public DateTime? data { get; set; }
        public string Nationality { get; set; }

        public Passeggero(string l,string f,DateTime? d,string nat)
        {
            last_name = l;
            first_name = f;
            data = d;
            Nationality = nat;
        }
        public Passeggero()
        {

        }
    }
   

}
