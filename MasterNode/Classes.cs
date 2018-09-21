using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;

namespace MasterNode
{
    public class Block
    {
        public int Index { get; set; }
        public DateTime TimeStamp { get; set; }
        public string PreviousHash { get; set; }
        public string Hash { get; set; }
        public string Data { get; set; }

        public Block(DateTime timeStamp, string previousHash, string data)
        {
            Index = 0;
            TimeStamp = timeStamp;
            PreviousHash = previousHash;
            Data = data;
            Hash = CalculateHash();
        }

        public string CalculateHash() //Berechnung Hash -> Internet
        {
            SHA256 sha256 = SHA256.Create();

            byte[] inputBytes = Encoding.ASCII.GetBytes($"{TimeStamp}-{PreviousHash ?? ""}-{Data}");
            byte[] outputBytes = sha256.ComputeHash(inputBytes);

            return Convert.ToBase64String(outputBytes);
        }
    }

    public class Blockchain
    {
        public IList<Block> Chain { set; get; }

        public Blockchain()
        {
            InitializeChain();
        }

        public void InitializeChain() //Inizialisierung Blockchain
        {
            Chain = new List<Block>();
            Chain.Add(new Block(DateTime.Now, null, "{}"));
        }

        public Block GetLatestBlock() //Returnd den neusten Block
        {
            return Chain[Chain.Count - 1];
        }

        public string AddBlock(Block block) //Fügt Block hinzu (Zu Blockchain)
        {
            Block latestBlock = GetLatestBlock();
            block.Index = latestBlock.Index + 1;
            block.PreviousHash = latestBlock.Hash;
            block.Hash = block.CalculateHash();
            Chain.Add(block);
#if DEBUG
            Debug.WriteLine(Convert.ToString(GetLatestBlock().Index) + " " + Convert.ToString(GetLatestBlock().Data) + " " + Convert.ToString(GetLatestBlock().Hash));
#endif
            return "Done";
        }

        public bool IsValid() //Überprüft alle Hash der Kette mit den nachfolgenden (Blockchain prinzip)
        {
            for (int i = 1; i < Chain.Count; i++)
            {
                Block currentBlock = Chain[i];
                Block previousBlock = Chain[i - 1];

                if (currentBlock.Hash != currentBlock.CalculateHash())
                {
                    return false;
                }

                if (currentBlock.PreviousHash != previousBlock.Hash)
                {
                    return false;
                }
            }
            return true;
        }
        public int GetMoney(string Name) //Fragt Kontostand ab -- Nicht Endlösung
        {
            int x = 0;
            for (int i = 1; i < Chain.Count; i++)
            {
                string[] a = Chain[i].Data.Split(new[] { "{sender:", ",receiver:", ",amount:", "}" }, StringSplitOptions.RemoveEmptyEntries);
                if (a[0] == Name)
                {
                    x = x - Convert.ToInt32(a[2]);
                }
                if (a[1] == Name)
                {
                    x = x + Convert.ToInt32(a[2]);
                }
            }
            return x;
        }
        public string GetTransaktions(string Name)
        {
            string x = "";
            for (int i = 1; i < Chain.Count; i++)
            {
                string[] a = Chain[i].Data.Split(new[] { "{sender:", ",receiver:", ",amount:", "}" }, StringSplitOptions.RemoveEmptyEntries);
                if (a[0] == Name || a[1] == Name)
                {
                    x = x + $"Datum: {Chain[i].TimeStamp}, Sender: {a[0]}, Empfänger: {a[1]}, Betrag: {a[2]}\n";
                }
            }
            return x;


        }
    }
}
