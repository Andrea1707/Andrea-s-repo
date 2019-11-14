using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
namespace Superenalotto_Server
{
    class Gestione_file
    {
        public static void Save(List<Giocata> a)
        {
            try
            {
                XmlSerializer serializzatore = new XmlSerializer(a.GetType());
                Stream flusso = new FileStream("Giocate.xml", FileMode.Create);
                serializzatore.Serialize(flusso, a);
                flusso.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }




        public static List<Giocata> Read()
        {
            List<Giocata> ele = new List<Giocata>();
            try
            {
                XmlSerializer serializzatore = new XmlSerializer(typeof(List<Giocata>));
                Stream flusso = new FileStream("Giocate.xml", FileMode.OpenOrCreate);
                ele = (List<Giocata>)serializzatore.Deserialize(flusso);
                flusso.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            return ele;
        }



    }
}
