using System;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace miner
{
    class Program
    {
        static string Hash;
        static int randomNr;
        static int dif;
        static string wallet;

        delegate void AddMessage(string message);

        const int port = 54545;
        const string broadcastAddress = "255.255.255.255";

        static UdpClient receivingClient;
        static UdpClient sendingClient;

        static Thread receivingThread;


        static void Main(string[] args)
        {
            ThreadStart getdif = new ThreadStart(GetDif); //Erstelle neuen Thread (GETDIF)
            Thread dif = new Thread(getdif);


            Console.Write("Dein Wallet: ");
            wallet = Console.ReadLine();

            InitializeSender();
            InitializeReceiver();
            Console.ReadKey();

            dif.Start();
        
            StartMiner();



        }

        public static void StartMiner()
        {
            Random rnd = new Random();
            SHA256 sha256 = SHA256.Create();

            while (true) //mining Script -- Mehr als Demontstration, Keine Leistungsoptimierung
            {
                for (int i = 0; i < 100000; i++)
                {
                    randomNr = rnd.Next(0, 999999999);
                    Hash = Convert.ToBase64String(sha256.ComputeHash(Encoding.ASCII.GetBytes(Convert.ToString(randomNr))));
#if DEBUG
                    Console.WriteLine(Convert.ToString(dif) + " " + Convert.ToString(randomNr) + " " + Hash);             
#endif
                    if (Hash.Substring(0, dif) == String.Concat(Enumerable.Repeat("0", dif))) { break; }

                }
#if DEBUG
                Console.ReadKey();
#endif
                Thread check = new Thread(() => CheckNr(randomNr));
                check.Start();
            }

        }

        public static void GetDif()
        {
            while (true) //Dummy -- Funktionalität kommt noch
            {
                dif = 3;
                Thread.Sleep(5000);
            }

        }

        public static void CheckNr(int Nr) //Dummy -- Funktionalität kommt noch
        {
            
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
            Console.WriteLine(message);
        }

        static void Send(string toSend)
        {
            byte[] data = Encoding.ASCII.GetBytes(toSend);
            sendingClient.Send(data, data.Length);
        }
    }
}

