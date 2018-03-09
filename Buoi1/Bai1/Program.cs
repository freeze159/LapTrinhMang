using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;

namespace Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            IPAddress[] ips;
            string hostname = Dns.GetHostName();
            ips = Dns.GetHostAddresses(hostname);
            Console.WriteLine("GetHostAddresses ({0}) return ", hostname);
            foreach (IPAddress ip in ips)
            {
                Console.WriteLine("     {0}", ip);
            }
            
            
            

        }
    }
}
