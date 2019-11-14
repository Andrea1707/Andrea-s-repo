using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bancomat_server
{
    public class Utente
    {
        public long numero_carta { get; set; }
        public int pin { get; set; }
        public long saldo { get; set; }
        public string nome { get; set; }
        public string cognome { get; set; }

        public Utente()
        {
        }

        public Utente(string a,string b, long c, long d, int e)
        {
            cognome = a;
            nome = b;
            numero_carta = c;
            saldo = d;
            pin = e;
        }

        public Utente(long a,int b)
        {
            numero_carta = a;
            pin = b;
        }




    }
}
