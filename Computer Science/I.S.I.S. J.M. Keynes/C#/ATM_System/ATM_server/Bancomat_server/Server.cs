using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Bancomat_server
{
    class Server
    {
        private TcpClient dati;
        private int numClient;
        public Server(TcpClient dati, int i)
        {
            this.dati = dati; this.numClient = i;
            Thread th = new Thread(new ThreadStart(this.Attività));
            th.Start();
            //il thread si autolancia        
        }
        public void Attività()
        {
            bool operazione = false;
            Byte[] buf = new byte[256];
            //buffer ricezione messaggio
            String msgIn = null;
            byte[] msgOut;
            NetworkStream s = dati.GetStream();
            int i;
            while ((i = s.Read(buf, 0, buf.Length)) != 0) //finchè ci sono dati            
            {
                //ascolto rete
                msgIn = System.Text.Encoding.ASCII.GetString(buf, 0, i);

                char[] delimiterChars = { ',', ';', '\n', '\r' };
                string[] utente = msgIn.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);

                Utente a = new Utente(Int64.Parse(utente[0]), Int32.Parse(utente[2]));
                int prelievo = Int32.Parse(utente[1]);
                List<Utente> temp = File_manager.Read_list_Utente();


                foreach (Utente p in temp)
                {
                    if (a.numero_carta == p.numero_carta && a.pin == p.pin)
                    {
                        if (p.saldo - prelievo >= 0)
                        {
                            operazione = true;
                            if (File.Exists("Record_list.xml"))
                            {
                                List<Record_transazione> h = File_manager.Read_list_Record();
                                long totale = prelievo;
                                foreach (Record_transazione k in h)
                                {
                                    if (k.numero_carta == p.numero_carta)
                                    {
                                        string now = DateTime.Now.ToString("d / M / yyyy");

                                        if (now == k.data_prelievo.ToString("d / M / yyyy") && k.esito == true)
                                        {
                                            
                                            totale += Math.Abs(k.importo_prelievo);
                                            if (totale > 500)
                                            {
                                                operazione = false;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }            //Controllo dei 500$ giornalieri




                    if (operazione == true)
                    {
                        Utente nuovo = new Utente(p.cognome, p.nome, p.numero_carta, p.saldo - prelievo, p.pin);
                        List<Utente> n = File_manager.Read_list_Utente();

                        List<Utente> finale = new List<Utente>();
                        foreach (Utente k in n)
                        {
                            if (k.numero_carta != a.numero_carta)
                            {
                                finale.Add(k);
                            }
                        }
                        finale.Add(nuovo);
                        File.Delete("User_list.xml");
                        File_manager.Save_Utente(finale);
                    }

                    if (File.Exists("Record_list.xml"))
                    {
                        List<Record_transazione> temp2 = File_manager.Read_list_Record();
                        Record_transazione record = new Record_transazione(a.numero_carta, DateTime.Now, -prelievo, operazione);
                        temp2.Add(record);
                        File_manager.Save_Record(temp2);
                    }
                    else
                    {
                        List<Record_transazione> temp2 = new List<Record_transazione>();
                        Record_transazione record = new Record_transazione(a.numero_carta, DateTime.Now, -prelievo, operazione);
                        temp2.Add(record);
                        File_manager.Save_Record(temp2);
                    }

                }







                if (operazione == true)
                {
                    msgOut = System.Text.Encoding.ASCII.GetBytes("Operazione eseguita con successo!");
                    s.Write(msgOut, 0, msgOut.Length);
                }
                else
                {
                    msgOut = System.Text.Encoding.ASCII.GetBytes("Operazione rifiutata!");
                    s.Write(msgOut, 0, msgOut.Length);
                }

            }
            s.Close();
            dati.Close();
        }
    }
}

