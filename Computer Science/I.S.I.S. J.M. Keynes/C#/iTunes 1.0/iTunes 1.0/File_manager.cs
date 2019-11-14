using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace iTunes_1._0
{
    class File_manager
    {
        public static void Save_music(List<music> a)
        {
            try
            {
                XmlSerializer serializzatore = new XmlSerializer(a.GetType());
                Stream flusso = new FileStream("music_list.xml", FileMode.OpenOrCreate);
                serializzatore.Serialize(flusso, a);
                flusso.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Errore");
            }
        }
        public static List<music> read_list()
        {
            List<music> ele = new List<music>();
            try
            {
                XmlSerializer serializzatore = new XmlSerializer(typeof(List<music>));
                Stream flusso = new FileStream("music_list.xml", FileMode.Open);
                ele = (List<music>)serializzatore.Deserialize(flusso);
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
