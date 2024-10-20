using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;

namespace vd2
{
    class Program
    {
        static void Main(string[] args)
        {
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint LocalEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1234);
            try
            {
                sck.Connect(LocalEndPoint);
            }
            catch
            {
                Console.Write("Unable to connect to remote point");
                Main(args);
            }
            Console.Write("Enter Text: ");
            string text = Console.ReadLine();
            byte[] data = Encoding.ASCII.GetBytes(text);

            sck.Send(data);
            Console.Write("Data sent!\r\n");
            Console.Write("press any key to continue....");
            Console.Read();
            sck.Close();
        }
    }
}
