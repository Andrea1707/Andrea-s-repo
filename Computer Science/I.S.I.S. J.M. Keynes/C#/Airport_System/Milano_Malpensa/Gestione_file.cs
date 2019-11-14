using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Serialization;

namespace Milano_Malpensa
{
    class Gestione_file
    {
        public static void Save(List<Passeggero> a)
        {
            try
            {
                XmlSerializer serializzatore = new XmlSerializer(a.GetType());
                Stream flusso = new FileStream("Lista_passeggeri.xml",FileMode.OpenOrCreate);
                serializzatore.Serialize(flusso, a);
                flusso.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        public static List<Passeggero> Read()
        {
            List<Passeggero> ele = new List<Passeggero>();
            try
            {
                XmlSerializer serializzatore = new XmlSerializer(typeof(List<Passeggero>));
                Stream flusso = new FileStream("Lista_passeggeri.xml", FileMode.Open);
                ele = (List<Passeggero>)serializzatore.Deserialize(flusso);
                flusso.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            return ele;
        }


    }
}
