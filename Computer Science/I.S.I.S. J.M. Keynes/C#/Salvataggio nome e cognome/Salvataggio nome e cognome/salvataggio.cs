using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salvataggio_nome_e_cognome
{
    class salvataggio
    {
        public static void salva(string punt, string nome)                                       //salvataggio
        {
            System.IO.StreamWriter scrittore = new StreamWriter("lista_utenti.txt", true);      //Apre connessione 
            scrittore.WriteLine(nome + "," + punt + ";");                                       //scrive
            scrittore.Close();                                                                  //chiude connessione 
        }
        

    }



}
