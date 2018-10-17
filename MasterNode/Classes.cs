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

        public string CalculateHash() //Berechnung Hash
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

        public void AddBlock(Block block) //Fügt Block hinzu (Zu Blockchain)
        {
            Block latestBlock = GetLatestBlock();
            block.Index = latestBlock.Index + 1;
            block.PreviousHash = latestBlock.Hash;
            block.Hash = block.CalculateHash();
            Chain.Add(block);
#if DEBUG
            Console.WriteLine(Convert.ToString(GetLatestBlock().Index) + " " + Convert.ToString(GetLatestBlock().Data) + " " + Convert.ToString(GetLatestBlock().Hash));
#endif
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
        public string GetTransaktions(string Name)
        {
            string x = "";
            for (int i = 1; i < Chain.Count; i++)
            {
                string[] a = Chain[i].Data.Split(new[] { "{sender:", ",receiver:", ",amount:", "}" }, StringSplitOptions.RemoveEmptyEntries);
                if (a[0] == $"\"{Name}\"" || a[1] == $"\"{Name}\"" || a[0] == Name || a[1] == Name)
                {
                    x = x + $"{Convert.ToString(Chain[i].TimeStamp).Substring(0, Convert.ToString(Chain[i].TimeStamp).Length - 9)}   {Convert.ToString(Chain[i].TimeStamp).Substring(Convert.ToString(Chain[i].TimeStamp).Length - 9)}     {a[2]}      { a[0].Substring(1, a[0].Length - 2)}     { a[1].Substring(1, a[1].Length - 2)}\n";
                }
            }
            return $"SetTra{Name}{x}";

        }
    }
}
