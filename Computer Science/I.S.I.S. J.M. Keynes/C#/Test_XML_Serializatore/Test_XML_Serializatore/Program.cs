using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Test_XML_Serializatore
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Studente> elenco = new List<Studente>();
                elenco.Add(new Studente("Ciro", 23, "Varese"));
                elenco.Add(new Studente("Ci", 25, "Varese"));
                elenco.Add(new Studente("C", 22, "Varese"));
                elenco.Add(new Studente("Cir", 20, "Varese"));
                elenco.Add(new Studente("A", 29, "Varese"));
                elenco.Add(new Studente("b", 21, "Varese"));
                                                                                             //Studente a = new Studente("R", 23, "Varese");



            Stream flusso = new FileStream("archivio.xml", FileMode.OpenOrCreate);
            XmlSerializer serializzatore = new XmlSerializer(elenco.GetType());              //Stream flusso = new FileStream("archivio.xml",FileMode.OpenOrCreate);
                                                                                        //XmlSerializer serializzatore = new XmlSerializer(a.GetType());
            serializzatore.Serialize(flusso, elenco);
            flusso.Close();

            flusso = new FileStream("archivio.xml", FileMode.OpenOrCreate);

            List<Studente> st = (List<Studente>)serializzatore.Deserialize(flusso);

            foreach(Studente s in st)
            {

                Console.WriteLine(s.Nome + " " + s.Eta);
                Console.ReadKey();

            }

            
            
        }
    }
}
