using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokededex
{
    public class Pokemon
    {
        public string Path_name { get; set; }
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public double Forza { get; set; }
        public Pokemon()
        {
            Path_name = "";
        }
        public Pokemon(string p,string n,string t, double f)
        {
            Nome = n;
            Forza = f;
            Tipo = t;
            Path_name = p;
        }
    }
}
