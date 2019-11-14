using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PongProject
{
    public class Utente
    {
        public string username { get; set; }
        public string password { get; set; }
        public int vittorie { get; set; }
        public int sconfitte { get; set; }

        public Utente()
        {

        }

        public Utente(string a,string b)
        {
            username = a;
            password = b;
            vittorie = 0;
            sconfitte = 0;

        }

    }
}
