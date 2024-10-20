using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace vd1
{
    class Program
    {
        public class SyncSocketClient
        {
           public static void StartClient()
           {
                byte[] bytes = new byte[1024];
                try
                {
                    var hostName = Dns.GetHostName();
                    IPHostEntry iphost = Dns.GetHostEntry(hostName);
                    Console.WriteLine($"Host: {hostName})");
                    IPAddress ip = iphost.AddressList[0];
                    IPEndPoint remoteEP = new IPEndPoint(ip, 43665);
                    
                    Socket sender = new Socket(ip.AddressFamily, SocketType.Stream,ProtocolType.Tcp);
                    try
                    {
                        sender.Connect(remoteEP);
                        Console.WriteLine("socket connected");
                        sender.RemoteEndPoint.ToString();
                        byte[] msg = Encoding.ASCII.GetBytes("This is just a test");
                        int byteSent = sender.Send(msg);
                        int byteRec = sender.Receive(bytes);
                        Console.WriteLine($"Echoed test {Encoding.ASCII.GetString(bytes,0,byteRec)}");

                        ///relase
                        sender.Shutdown(SocketShutdown.Both);
                        sender.Close();
                    }
                    catch (ArgumentException e)
                    {
                        Console.WriteLine(e.Message);
                        throw;
                    }
                    catch(SocketException e){
                        Console.WriteLine(e.Message);
                    }
                    catch(Exception e){
                        Console.WriteLine(e.Message);
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
           }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("press any key to cont....");
            Console.ReadLine();
            SyncSocketClient.StartClient();
            Console.ReadLine();

        }


    }
}