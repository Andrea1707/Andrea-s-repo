using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Bancomat_server
{
    public class File_manager
    {
        public static void Save_Utente(List<Utente> a)
        {
            try
            {
                XmlSerializer serializzatore = new XmlSerializer(a.GetType());
                Stream flusso = new FileStream("User_list.xml", FileMode.OpenOrCreate);
                serializzatore.Serialize(flusso, a);
                flusso.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Errore:"+ e.ToString());
            }
        }
        public static List<Utente> Read_list_Utente()
        {
            List<Utente> ele = new List<Utente>();
            try
            {
                XmlSerializer serializzatore = new XmlSerializer(typeof(List<Utente>));
                Stream flusso = new FileStream("User_list.xml", FileMode.Open);
                ele = (List<Utente>)serializzatore.Deserialize(flusso);
                flusso.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Errore: "+ e.ToString()+"\n");
            }
            return ele;
        }




        public static void Save_Record(List<Record_transazione> a)
        {
            try
            {
                XmlSerializer serializzatore = new XmlSerializer(a.GetType());
                Stream flusso = new FileStream("Record_list.xml", FileMode.OpenOrCreate);
                serializzatore.Serialize(flusso, a);
                flusso.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Errore: "+ e.ToString());
            }
        }
        public static List<Record_transazione> Read_list_Record()
        {
            List<Record_transazione> ele = new List<Record_transazione>();
            try
            {
                XmlSerializer serializzatore = new XmlSerializer(typeof(List<Record_transazione>));
                Stream flusso = new FileStream("Record_list.xml", FileMode.Open);
                ele = (List<Record_transazione>)serializzatore.Deserialize(flusso);
                flusso.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Errore: "+ e.ToString());
            }
            return ele;
        }
    }
}
