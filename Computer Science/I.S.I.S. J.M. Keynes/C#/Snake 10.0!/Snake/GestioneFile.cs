using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Serialization;

namespace Snake
{
    class GestioneFile
    {
        private static FileInfo fileInfo = new FileInfo(Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments) + @"\Snake\punteggio.xml");
        public static string percorso = fileInfo.FullName;

        public static void SalvaXML(Punteggio p)
        {
            fileInfo.Directory.Create();

            List<Punteggio> myList = LeggiXml();
            if (myList == null)
            {
                myList = new List<Punteggio>();
            }
            myList.Add(p);

            try
            {
                using (FileStream flusso = new FileStream(percorso, FileMode.Create))
                {
                    XmlSerializer serializzatore = new XmlSerializer(typeof(List<Punteggio>));
                    serializzatore.Serialize(flusso, myList);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Errore: " + e);
            }
        }

        public static List<Punteggio> LeggiXml()
        {
            List<Punteggio> elenco = null;

            try
            {
                if (File.Exists(percorso))
                {
                    using (FileStream flusso = new FileStream(percorso, FileMode.Open))
                    {
                        XmlSerializer serializzatore = new XmlSerializer(typeof(List<Punteggio>));
                        elenco = (List<Punteggio>)serializzatore.Deserialize(flusso);
                    }
                }
                else
                {
                    elenco = new List<Punteggio>();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Errore: " + e);
            }

            return elenco;
        }
    }
}
