using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
namespace Bancomat_client
{
    class Client
    {
        public void Attività()
        {
            try
            {
                String msgOut="";
                string NumeroCarta="";
                string NC="";
                int n=1;
                int k = 0;
                string Pin="";
                string Importo="";
                int imp = 0;
                bool j = false;
                bool y = true;
                
                
                NC = Controllo(NumeroCarta);
                Console.Write("\nLettura carta...\n");
                Console.Write("\ninserisci l'importo da prelevare\n");
                Importo = Console.ReadLine();
                try
                {
                    imp = Int32.Parse(Importo);
                    y = false;
                }
                catch (Exception e)
                {
                    Console.Write("L'importo può essere solo numerico");

                }
                while (j == false && y == true)
                {
                    Console.Write("\ninserisci l'importo da prelevare\n");
                    Importo = Console.ReadLine();
                    imp = Int32.Parse(Importo);
                    if (imp < 10 || imp > 500)
                    {
                        Console.Write("\nImporto non valido\n");
                        Importo = "";
                    }
                    else
                        j = true;
                }

                Pin = ControlloPin(Pin);

                //msgOut = Console.ReadLine();
                msgOut = (NC + "," + Importo + "," + Pin + ";");
                byte[] bufOut = System.Text.Encoding.ASCII.GetBytes(msgOut);  //blocco di byte da inviare

                TcpClient c = new TcpClient(Dns.GetHostName(), 10100);   //richiesta connessione con host del server (localhost) porta 10101
                NetworkStream st = c.GetStream();    //stream per transito dati                
                st.Write(bufOut, 0, bufOut.Length);  //invio dati 

                byte[] bufIn = new Byte[256];
                String msgIn = String.Empty;

                Int32 bytes = st.Read(bufIn, 0, bufIn.Length);   //blocco di byte ricevuti                
                msgIn = System.Text.Encoding.ASCII.GetString(bufIn, 0, bytes);
                Console.WriteLine("Esito: " + msgIn);


                Console.Write("Premere un tasto per terminare...");
                Console.ReadKey();
                st.Close();
                c.Close();
            }
            catch (ArgumentNullException e)   //hostname è null            
            {
                Console.WriteLine("ArgumentNullException: {0}", e);
            }
            catch (SocketException e)   //connessione fallita            
            {
                Console.WriteLine("SocketException: {0}", e);
            }
        }
        public string Controllo(string NumeroCarta )
        {
            string NC="";
            bool n= false;
            int k = 0;
                while (n == false)
                {
                n = false;
                k = 0;
                NC = "";
                Console.Write("\ninserisci il numero della carta (11 cifre)\n");
                NumeroCarta = Console.ReadLine();
                k = NumeroCarta.Length;
                NC = NumeroCarta;
                byte[] asciiBytes = Encoding.ASCII.GetBytes(NumeroCarta);
                    foreach (byte element in asciiBytes)
                     if (element < 58 && element > 47 && k==11)
                     {
                     n = true; 
                     }  
                }
        return NC;
        }

        public string ControlloPin(string Pin)
        {
            string PC = "";
            bool n = false;
            int k = 0;
            while (n == false)
            {
                n = false;
                k = 0;
                PC = "";
                Console.Write("\ninserisci il pin della carta (4 cifre)\n");
                Pin = Console.ReadLine();
                k = Pin.Length;
                PC = Pin;
                byte[] asciiBytes = Encoding.ASCII.GetBytes(Pin);
                foreach (byte element in asciiBytes)
                    if (element < 58 && element > 47 && k == 4)
                    {
                        n = true;
                    }
            }
            return PC;
        }

    }
}
