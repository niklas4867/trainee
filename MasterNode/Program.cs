using System;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace MasterNode
{
    class Program
    {
        delegate void AddMessage(string message);
        static Random rnd = new Random();
        const int port = 54545;
        const string broadcastAddress = "255.255.255.255";
        static public int lastNumber;
        static public int lastNumber2;
        static UdpClient receivingClient;
        static UdpClient sendingClient;

        static Thread receivingThread;

        static void Main(string[] args)
        {
            InitializeSender();
            InitializeReceiver();
            Console.ReadKey();
            
            
        }

        static private void InitializeSender()

        {

            sendingClient = new UdpClient(broadcastAddress, port);
            sendingClient.EnableBroadcast = true;
        }

        static private void InitializeReceiver()
        {
            receivingClient = new UdpClient(port);

            ThreadStart start = new ThreadStart(Receiver);
            receivingThread = new Thread(start);
            receivingThread.IsBackground = true;
            receivingThread.Start();
        }


        static private void Receiver()
        {
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Any, port);
            AddMessage messageDelegate = MessageReceived;

            while (true)
            {
                byte[] data = receivingClient.Receive(ref endPoint);
                string message = Encoding.ASCII.GetString(data);
                messageDelegate(message);
            }
        }

        static private void MessageReceived(string message)
        {
            string x = message.Substring(message.Length - 4);
            if(x == Convert.ToString(lastNumber) || x == Convert.ToString(lastNumber2)) { return; }
            message = message.Substring(0, message.Length - 4);
#if DEBUG
            Console.WriteLine(message);
#endif
            ResponseMessage(message);
            
        }

        static void Send(string toSend)
        {
            lastNumber2 = lastNumber;
            lastNumber = rnd.Next(1000, 9999);
            toSend = toSend + Convert.ToString(lastNumber);
            byte[] data = Encoding.ASCII.GetBytes(toSend);
            sendingClient.Send(data, data.Length);
        }

        static public void ResponseMessage(string message)
        {
            
        }
    }
}
