using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace tcp_superenalottoo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                String msgOut = "";
                Console.WriteLine("Inserisci il nome utente: ");
                msgOut = Console.ReadLine()+";";
                Console.WriteLine("Inserisci i numeri da giocare:");
                for(int i = 0; i < 6; i++)
                {
                    string c;
                    int a;
                    do
                    {

                        c = Console.ReadLine();
                        a = Int32.Parse(c);
                    } while (a > 48 || a < 57);
                }


                byte[] bufOut = System.Text.Encoding.ASCII.GetBytes(msgOut);
                TcpClient c = new TcpClient(Dns.GetHostName(), 10101);
                NetworkStream st = c.GetStream();
                st.Write(bufOut, 0, bufOut.Length);
                Console.WriteLine(Thread.CurrentThread.Name + "  spedito>>  " + msgOut);
                byte[] bufIn = new Byte[256];
                String msgIn = String.Empty;
                Int32 bytes = st.Read(bufIn, 0, bufIn.Length);
                msgIn = System.Text.Encoding.ASCII.GetString(bufIn, 0, bytes);
                Console.WriteLine(Thread.CurrentThread.Name + "  ricevuto<<  " + msgIn);
                Console.ReadKey();
                st.Close();
                c.Close();
            }

            catch (ArgumentNullException e)
            {
                Console.WriteLine("ArgumentNullException:  {0}", e);
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException:  {0}", e);
            }
        }
    }
}
