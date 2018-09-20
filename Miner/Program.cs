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
        static int dif;
        static string wallet;

        static P2P p2p = new P2P();


        static void Main(string[] args)
        {
            ThreadStart getdif = new ThreadStart(GetDif); //Erstelle neuen Thread (GETDIF)
            Thread dif = new Thread(getdif);
            

            Console.Write("Dein Wallet: ");
            wallet = Console.ReadLine();
            dif.Start();
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
                        Thread check = new Thread(() => CheckNr(randomNr));
                        check.Start();

                    }

              
            }

        }

        public static void GetDif()
        {
            dif = 3;
            while (true) //Dummy -- Funktionalität kommt noch
            {
                
                Thread.Sleep(5000);
            }

        }

        public static void CheckNr(int Nr) //In Arbeit
        {
            p2p.Send($"MasterNode.Program.CheckNr({Nr},\"{wallet}\" );");
        }

        static public void ResponseMessage(string message)
        {

        }
    }
}

