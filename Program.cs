using System;
using System.Net;
using System.Net.Sockets;

namespace Port_scan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter ip");
            string ip = Console.ReadLine();
            Console.WriteLine("enter max port");
            int port = int.Parse(Console.ReadLine());
            IPAddress address = IPAddress.Parse(ip);
            Console.WriteLine("Trying all ports");
            for(int i = 1; i <= port; i++){
                Console.Write("\r{0}/{1}   ", i, port);
                Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                try{
                    s.Connect(new IPEndPoint(address, i));
                    Console.WriteLine("Port " + i + " accepted connection");
                }catch(Exception ex){
                    
                }
                finally{
                    s.Close();
                }
            }
            Console.WriteLine("Finished");
            return;
        }
    }
}
