using System.Net;
using System.Net.Sockets;
using System.Text;

class Program{
    public class syncSocketClient{
        public static void StartClient(){

            byte[] bytes = new byte[1024];
            try
            {
                var hostname = Dns.GetHostName();
                IPHostEntry ipHost  = Dns.GetHostEntry(hostname);
                System.Console.WriteLine("Host: " +hostname);
                IPAddress ipad = ipHost.AddressList[0];
                IPEndPoint remoteEP = new IPEndPoint(ipad,45323);

                Socket sender = new Socket(ipad.AddressFamily,SocketType.Stream,ProtocolType.Tcp);
                try
                {
                    sender.Connect(remoteEP);
                    System.Console.WriteLine("Socket connected");
                    sender.RemoteEndPoint.ToString();
                    byte[] msg = Encoding.ASCII.GetBytes("Just a test");
                    int byteSent = sender.Send(msg);
                    int byteRec = sender.Receive(bytes);
                    System.Console.WriteLine("Echoed teste: "+Encoding.ASCII.GetString(bytes,0,byteRec));
                    //release
                    sender.Shutdown(SocketShutdown.Both);
                    sender.Close();
                }
                catch (ArgumentNullException e )
                {
                    System.Console.WriteLine(e.Message);
                    throw;
                }
                catch (SocketException e )
                {
                    System.Console.WriteLine(e.Message);
                    throw;
                }
                catch (Exception e )
                {
                    System.Console.WriteLine(e.Message);
                    throw;
                }
                
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.Message);
                
                throw;
            }
        }

    }

    static void Main(string[] args){
        System.Console.WriteLine("press any key");
        Console.ReadLine();
        syncSocketClient.StartClient();
        Console.ReadLine();
    }


}