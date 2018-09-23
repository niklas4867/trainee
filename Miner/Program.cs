using System;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Net.Sockets;
using System.Threading;

namespace miner
{
    class Program
    {
        static string Hash;
        static int randomNr;
        static int dif = 9;
        static string wallet;
        static P2P p2p = new P2P("192.168.1.255", 54544);


        static void Main(string[] args)
        {

            Console.Write("Dein Wallet: ");
            wallet = Console.ReadLine();
            
#if DEBUG
            //Console.ReadKey();
#endif
            StartMiner();

        }

        public static void StartMiner()
        {
            Random rnd = new Random();
            SHA256 sha256 = SHA256.Create();

            while (true) //mining Script -- Mehr als Demontstration, Keine Leistungsoptimierung
            {
                    randomNr = rnd.Next(0, 999999999);
                    Hash = Convert.ToBase64String(sha256.ComputeHash(Encoding.ASCII.GetBytes(Convert.ToString(randomNr))));
#if DEBUG
                    //Console.WriteLine(Convert.ToString(dif) + " " + Convert.ToString(randomNr) + " " + Hash);             
#endif
                    if (Hash.Substring(0, dif) == String.Concat(Enumerable.Repeat("0", dif)))
                    {
#if DEBUG
                    Console.WriteLine(Convert.ToString(dif) + " " + Convert.ToString(randomNr) + " " + Hash);
                    //Console.ReadKey();

#endif
                    Console.WriteLine("Neuer Block: " + Convert.ToString(dif) + " " + Convert.ToString(randomNr) + " " + Hash);
                    Thread check = new Thread(() => CheckNr(randomNr));
                    check.Start();
                    Thread.Sleep(2000);
                    }

              
            }

        }

        public static void CheckNr(int Nr)
        {
            p2p.Send($"MasterNode.Program.CheckNr({Nr},\"{wallet}\" );");
        }

        static public void ResponseMessage(string message)
        {
            //Console.WriteLine("P2P In: " + message);
            if(message.Substring(0,6) == "SetDif")
            {
                dif = Convert.ToInt32(message.Substring(6));
            }
        }
    }
}

