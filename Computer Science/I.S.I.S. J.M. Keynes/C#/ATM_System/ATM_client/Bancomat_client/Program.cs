using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Bancomat_client
{
    class Program
    {
        static void Main(string[] args)
        {
            Client c = new Client();
            Thread thC = new Thread(new ThreadStart(c.Attività));
            thC.Name = "Cliente";
            thC.Start();
        }
    }
}
