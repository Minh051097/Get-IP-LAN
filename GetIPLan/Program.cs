using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace GetIPLan
{
    class Program
    {
        static void Main(string[] args)
        {
            string strHostIP = Dns.GetHostName();
            Console.WriteLine("Host IP: "+ strHostIP);

            IPHostEntry iphentry = Dns.GetHostByName(strHostIP);

            int Ips = 0;
            foreach (IPAddress ipaddress in iphentry.AddressList)
            {
                Console.WriteLine("IP#" + ++Ips + ":" + ipaddress.ToString());
            }

        }
    }
}
