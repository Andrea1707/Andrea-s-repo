using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace Bancomat_server
{
    class Program
    {
        static void Main(string[] args)
        {
            bool server = false;
            bool sospeso = false;
            Thread thread1 = new Thread(new ThreadStart(Apertura_Server));

            do
            {
                int selezione;
                do
                {
                    Console.WriteLine("\nOnline Banking 1.0!\n" +
                        "\nSeleziona l'azione da compiere: \n" +
                        "1.Avvia il server\n" +
                        "2.Ferma il server\n"+
                        "3.Instanzia un nuovo utente\n" +
                        "4.Visualizza tutti gli utenti\n" +
                        "5.Visualizza tutti i record\n" +
                        "6.Esci dal programma\n");
                    Console.Write("Seleziona l'opzione: ");
                    selezione =Convert.ToInt32(Console.ReadLine());
                    System.Console.Clear();


                } while (selezione < 1 || selezione > 6);
                switch (selezione)
                {

                    case 1:
                        {
                            if (server == false)
                            {
                                Console.WriteLine("------------------------------------------------------------------------------");
                                Console.WriteLine("Server avviato!");
                                Console.WriteLine("------------------------------------------------------------------------------");
                                if (sospeso == false)
                                {
                                    thread1.Start();
                                    server = true;
                                }
                                else
                                {
                                    thread1.Resume();
                                }

                            }
                            else
                            {
                                Console.WriteLine("------------------------------------------------------------------------------");
                                Console.WriteLine("Server gia' avviato!");
                                Console.WriteLine("------------------------------------------------------------------------------");
                            }
                            break;

                        }
                    case 2:
                        {
                            if (server == true)
                            {
                                thread1.Interrupt();
                                server = true;
                                sospeso = true;
                                Console.WriteLine("------------------------------------------------------------------------------");
                                Console.WriteLine("Server stoppato!");
                                Console.WriteLine("------------------------------------------------------------------------------");
                            }
                            else
                            {
                                Console.WriteLine("------------------------------------------------------------------------------");

                                Console.WriteLine("Il server non e' avviato!");
                                Console.WriteLine("------------------------------------------------------------------------------");
                            }
                            break;
                        }

                    case 3:
                        {
                            bool verifica = true;
                            long MAX_NUMBER = 99999999999;
                            string cognome;
                            string nome;
                            long carta;
                            long saldo;
                            int pin;

                            Console.WriteLine("Registra una nuova utenza: ");
                            Console.Write("\n");
                            
                            do
                            {
                                Console.Write("Inserisci il cognome: ");           //Manacano i controlli
                                cognome = Console.ReadLine();
                                Console.Write("\n");
                            } while (cognome == "");
                            
                            do {
                                Console.Write("Inserisci il nome: ");
                                nome = Console.ReadLine();
                                Console.Write("\n");
                            } while (nome == "");

                            do
                            {
                                Console.Write("Inserisci il numero carta: ");
                                string c = Console.ReadLine();
                                carta = long.Parse(c);
                                Console.Write("\n");
                            } while (carta <= 0 || carta >= MAX_NUMBER);

                            do
                            {
                                Console.Write("Inserisci il pin: ");
                                pin = Convert.ToInt32(Console.ReadLine());
                                Console.Write("\n");
                            } while (pin < 0 || pin >= 9999);

                            do
                            {
                                Console.WriteLine("Inserisci il saldo:\n");
                                saldo = Convert.ToInt32(Console.ReadLine());
                                Console.Write("\n");
                            } while (saldo < 0);


                            if (!File.Exists("User_list.xml"))
                            {
                                List<Utente> b = new List<Utente>();
                                b.Add(new Utente(cognome, nome, carta, saldo, pin));
                                File_manager.Save_Utente(b);
                            }
                            else
                            {

                                List<Utente> utentes = File_manager.Read_list_Utente();
                                Utente a= new Utente(cognome, nome, carta, saldo, pin);
                                

                                foreach (Utente p in utentes)
                                {
                                    if (p.numero_carta == a.numero_carta)
                                    {
                                        Console.WriteLine("------------------------------------------------------------------------------");
                                        Console.WriteLine("Errore: La carta e' gia' presente nel sistema.");
                                        Console.WriteLine("------------------------------------------------------------------------------");
                                        verifica = false;
                                    }
                                }
                                if (verifica == true)
                                {
                                    utentes.Add(a);
                                    File_manager.Save_Utente(utentes);
                                }
                            }

                            break;
                        }

                    case 4:
                        {
                            if (!File.Exists("User_list.xml"))
                            {
                                Console.WriteLine("------------------------------------------------------------------------------");
                                Console.WriteLine("Nessun utente registrato");
                                Console.WriteLine("------------------------------------------------------------------------------");
                            }
                            else
                            {

                                Console.WriteLine("N:. Cognome, Nome, Numero Carta, Saldo;");
                                Console.WriteLine("------------------------------------------------------------------------------");
                                List<Utente> tmp = File_manager.Read_list_Utente();
                                int i = 0;
                                foreach (Utente p in tmp)
                                {
                                    i++;
                                    Console.WriteLine(i + ". " + p.cognome + ", " + p.nome + ", " + p.numero_carta + ", " + p.saldo + ";\n");
                                }
                                Console.WriteLine("------------------------------------------------------------------------------");
                            }
                            break;
                        }

                    case 5:
                        {
                            if (!File.Exists("Record_list.xml"))
                            {
                                Console.WriteLine("Nessuna transazione effettuata.\n\n");
                            }
                            else
                            {
                                Console.WriteLine("N. Numero carta, Data prelievo (d/m/y), Importo prelievo, Esito;");
                                Console.WriteLine("------------------------------------------------------------------------------");
                                List<Record_transazione> tmp = File_manager.Read_list_Record();
                                int i = 0;
                                foreach (Record_transazione p in tmp)
                                {
                                    i++;
                                    string esito = "Fallito";
                                    if (p.esito == true)
                                    {
                                        esito = "Accettato";
                                    }
                                    int day = p.data_prelievo.Day;
                                    int month = p.data_prelievo.Month;
                                    int year = p.data_prelievo.Year;
                                    

                                    Console.WriteLine(i + ". " + p.numero_carta + ", " + day + "/" + month + "/" + year + ", " + p.importo_prelievo + ", " + esito + ";\n");
                                }
                                Console.WriteLine("------------------------------------------------------------------------------");
                            }
                            break;
                        }

                    case 6:
                        {
                            System.Environment.Exit(0);
                            
                            break;
                        }
                }
            } while (true);
        }

        public static void Apertura_Server()
        {
            IPAddress[] ip = Dns.GetHostAddresses(Dns.GetHostName());
            TcpListener s = null;
            int contaClient = 0;
            //conta i client seviti            
            s = new TcpListener(ip[0], 10100);
            s.Start();
            while (true)
            {
                TcpClient dati = s.AcceptTcpClient();
                contaClient++;
                new Server(dati, contaClient);
            }
        }
    }
}
