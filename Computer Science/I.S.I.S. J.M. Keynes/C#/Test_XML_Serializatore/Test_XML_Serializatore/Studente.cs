using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_XML_Serializatore
{
    public class Studente
    {
        string nome, resi;
        int eta;
        public string Nome { get { return nome; } set { nome = value; } }
        public int Eta { get { return eta; } set { eta = value; } }
        public string Residenza { get { return resi; } set { resi = value; } }
        public Studente() { }
        public Studente(string n, int e,string resi)
        {
            Nome = n;
            Eta = e;
            Residenza = resi;

        }
    }
}
