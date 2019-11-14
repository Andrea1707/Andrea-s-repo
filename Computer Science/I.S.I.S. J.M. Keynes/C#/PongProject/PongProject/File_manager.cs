using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Serialization;

namespace PongProject
{
    class File_manager
    {
        public static void Save_user(List<Utente> a)
        {
            try
            {
                XmlSerializer serializzatore = new XmlSerializer(a.GetType());
                Stream flusso = new FileStream("user_list.xml", FileMode.OpenOrCreate);
                serializzatore.Serialize(flusso, a);
                flusso.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public static List<Utente> read_list()
        {
            List<Utente> ele = new List<Utente>();
            try
            {
                XmlSerializer serializzatore = new XmlSerializer(typeof(List<Utente>));
                Stream flusso = new FileStream("user_list.xml", FileMode.Open);
                ele = (List<Utente>)serializzatore.Deserialize(flusso);
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

