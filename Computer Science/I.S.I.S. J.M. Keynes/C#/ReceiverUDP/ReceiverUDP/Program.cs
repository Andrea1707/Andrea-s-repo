using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Diagnostics;
using System.Text;

namespace ReceiverUDP
{
    class Program
    {
        static void Main(string[] args)
        {
            UdpClient receivingUdpClient = new UdpClient(53477);
            IPEndPoint IpRemoto = new IPEndPoint(IPAddress.Any, 0);

            try
            {
                Console.WriteLine("In attesa di datagram...\n");
                byte[] bytes_filename = receivingUdpClient.Receive(ref IpRemoto);
                byte[] bytes_file = receivingUdpClient.Receive(ref IpRemoto);
                string filename = Encoding.ASCII.GetString(bytes_filename);
                FileStream fileStream = new FileStream(filename, FileMode.Create);
                BinaryWriter binaryWriter = new BinaryWriter(fileStream);
                binaryWriter.Write(bytes_file);
                binaryWriter.Close();
                fileStream.Close();
                Console.WriteLine("Questo datagram di " + bytes_file.Length + " byte è stato inviato dall'Ip " + IpRemoto.Address.ToString() + " e porta " + IpRemoto.Port.ToString());
                Process.Start(filename);
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}