using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Motorizzazione
{
    class Salvataggio
    {
        public static void salva(string a, string b, string c, string d, string e)
        {
            System.IO.StreamWriter scrittore = new StreamWriter("lista_veicoli.txt", true);
            scrittore.WriteLine(a + "," + b + "," + c + "," + d + "," + e + ";");
            scrittore.Close();
        }
    }
}
