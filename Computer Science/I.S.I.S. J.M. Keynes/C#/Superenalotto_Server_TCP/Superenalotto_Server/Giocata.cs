using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superenalotto_Server
{
    public class Giocata
    {
        string username { get; set; }
        string numero_1 { get; set; }
        string numero_2 { get; set; }
        string numero_3 { get; set; }
        string numero_4 { get; set; }
        string numero_5 { get; set; }
        string numero_6 { get; set; }


        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3} {4} {5}",username,numero_1,numero_2,numero_3,numero_4,numero_5,numero_6);
        }



        public Giocata()
        {



        }

        public Giocata(string a,string b,string c, string d, string e, string f, string g)
        {
            username=a;
            numero_1=b;
            numero_2=c;
            numero_3=d;
            numero_4=e;
            numero_5=f;
            numero_6=g;

        }
        public static void giocata(string a)
        {
            char[] delimiterChars = { ',',':'};
            string[] utente = a.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);
            Giocata temp = new Giocata(utente[0], utente[1], utente[2], utente[3], utente[4], utente[5], utente[6]);
            List<Giocata> temp2 = Gestione_file.Read();
            temp2.Add(temp);
            Gestione_file.Save(temp2);




        }
    }
}
