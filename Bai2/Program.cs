using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;

namespace Bai2
{
    class Program
    {
        static void GetIp(string hostname)
        {
            
            IPAddress[] listIP = Dns.GetHostAddresses(hostname);
            foreach (IPAddress ip in listIP)
            {
                Console.WriteLine("         {0} ", ip);
            }
        }
        static string GetHostName(string ip)
        {
            IPHostEntry entry = Dns.GetHostEntry(ip);
            if (entry!=null)
            {
                return entry.HostName;
            }
            return "Khong tim thay";
        }
        static void Main(string[] args)
        {
            Console.Write("Nhap ten mien can phan giai: ");
            string hostname = Console.ReadLine();
            GetIp(hostname);
            string ip = "172.16.0.213";
            Console.WriteLine(GetHostName(ip));
        }
    }
}
