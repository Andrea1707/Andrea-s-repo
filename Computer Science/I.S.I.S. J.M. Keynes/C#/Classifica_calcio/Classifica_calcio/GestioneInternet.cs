using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Classifica_calcio
{
    class GestioneInternet
    {
        public static string GetInternet(string path)
        {
            string html = "";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(path);

            //WebProxy prox = new WebProxy("192.168.0.1", 8080);
            //prox.Credentials = new NetworkCredential("5BI", "Bicicletta");
            //request.Proxy = prox;

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            return new StreamReader(response.GetResponseStream()).ReadToEnd();
        }
        public static List<InfoSquadra> OttieniDati()
        {
            List<InfoSquadra> infos = new List<InfoSquadra>();
            string html = "";
            if (!File.Exists("Datigrezzi.txt"))
            {
                StreamReader reader = new StreamReader("Datigrezzi.txt");
                html = reader.ReadToEnd();
            }
            else
            {
                html = GetInternet("http://www.corrieredellosport.it/live/classifica-serie-a.html?cookieAccept");
                new StreamWriter("Datigrezzi.txt").Write(html);
            }


            return null;

        }
        public static List<string> GetImg(string html)
        {
            List<string> pats = new List<string>();
            string[] pezzi = html.Split(new string[] { "img width=\"40\" src=\"" }, StringSplitOptions.None);
            return null;
        }
    }
}
