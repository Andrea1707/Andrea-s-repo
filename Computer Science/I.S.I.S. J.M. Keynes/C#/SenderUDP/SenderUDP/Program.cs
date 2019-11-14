using System;
using System.IO;
using System.Net.Sockets;
using System.Text;

namespace SenderUDP
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string filename = "immagine.jpg";
                FileStream fileStream = new FileStream(filename, FileMode.Open);
                BinaryReader binaryReader = new BinaryReader(fileStream);
                byte[] bytes_filename = Encoding.ASCII.GetBytes(filename);
                byte[] bytes_file = binaryReader.ReadBytes((int)fileStream.Length);
                Console.WriteLine("Il file è grande " + bytes_file.Length + " byte\n");
                fileStream.Close();
                binaryReader.Close();
                UdpClient udpClient = new UdpClient();
                udpClient.Send(bytes_filename, bytes_filename.Length, "localhost", 53477);
                udpClient.Send(bytes_file, bytes_file.Length, "localhost", 53477);
                udpClient.Close();
                Console.WriteLine("Inviato");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
