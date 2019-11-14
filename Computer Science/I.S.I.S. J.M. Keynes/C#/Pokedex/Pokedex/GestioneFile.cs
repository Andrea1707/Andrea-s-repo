using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
namespace Pokededex
{
    static class GestioneFile
    {
        public static void SaveXml_Pokemon(List<Pokemon> ele)
        {
            try
            {
                XmlSerializer serializzatore = new XmlSerializer(ele.GetType());
                Stream flusso = new FileStream("pokemon.xml", FileMode.Truncate);
                serializzatore.Serialize(flusso, ele);
                flusso.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Errore");
            }
        }

        public static List<Pokemon> LeggiXML_pokemon()
        {
            List<Pokemon> ele = new List<Pokemon>();
            try
            {
                XmlSerializer serializzatore = new XmlSerializer(typeof(List<Pokemon>));
                Stream flusso = new FileStream("pokemon.xml", FileMode.Open);
                ele =(List<Pokemon>) serializzatore.Deserialize(flusso);
                flusso.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Errore");
            }
            return ele;
        }


    }
}
