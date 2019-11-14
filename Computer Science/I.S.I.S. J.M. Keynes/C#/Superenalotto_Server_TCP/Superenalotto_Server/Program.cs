using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Superenalotto_Server
{
    
    class Program
    {
        static void Main(string[] args)
        {
            IPAddress[] sIp = Dns.GetHostAddresses(Dns.GetHostName());
            TcpListener s = null;
            try
            {
                s = new TcpListener(sIp[0], 10101);
                s.Start();
                Byte[] buf = new Byte[1024];
                string msgIn = null;


                while (true)
                {
                    Console.Write(Thread.CurrentThread.Name + "  in  attesa  di  connessione...  \n");
                    TcpClient dati = s.AcceptTcpClient();
                    NetworkStream st = dati.GetStream();
                    Console.WriteLine(Thread.CurrentThread.Name + "  Connesso!");
                    int i;
                    while ((i = st.Read(buf, 0, buf.Length)) != 0)
                    {
                        msgIn = System.Text.Encoding.ASCII.GetString(buf, 0, i);
                        Console.WriteLine(Thread.CurrentThread.Name + "  ricevuto<<  " + msgIn);
                        Giocata.giocata(msgIn);
                        string conferma = "messaggio ricevuto!";
                        conferma = conferma.ToUpper();
                        byte[] msg = System.Text.Encoding.ASCII.GetBytes(conferma);
                        st.Write(msg, 0, msg.Length);
                        Console.WriteLine(Thread.CurrentThread.Name + "  spedito>>" + msgIn);
                    }
                    st.Close();
                    dati.Close();
                }
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException:  {0}", e);
            }
            finally
            {
                s.Stop();
            }
        }
    }
}
