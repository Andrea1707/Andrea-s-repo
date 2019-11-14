using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Punteggio
    {
        public string Nome { get; set; }
        public int Punt { get; set; }
        public DateTime Data { get; set; }

        public Punteggio()
        {

        }
        public Punteggio(string n, int p, DateTime d)
        {
            Nome = n;
            Punt = p;
            Data = d;
        }

        public override string ToString()
        {
            return string.Format("{0}  {1}  {2}", Data, Nome, Punt);
        }

    }
}
