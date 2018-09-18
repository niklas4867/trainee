using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Diagnostics;
#if DEBUG
using System.Runtime.InteropServices;
#endif
namespace Bloackchain_V1
{
    public partial class main : Form
    {
        public Blockchain Bolis = new Blockchain();

        public main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }

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

            public void AddBlock(Block block) //Fügt Block hinzu (Zu Blockchain)
            {
                Block latestBlock = GetLatestBlock();
                block.Index = latestBlock.Index + 1;
                block.PreviousHash = latestBlock.Hash;
                block.Hash = block.CalculateHash();
                Chain.Add(block);
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
            public int GetMoney(string Name) //Fragt Kontostand ab
            {
                int x = 0;
                for (int i = 1; i < Chain.Count; i++)
                {
                    string[] a = Chain[i].Data.Split(new[] { "{sender:",",receiver:",",amount:","}"}, StringSplitOptions.RemoveEmptyEntries);
                    if (a[0]==Name)
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
        }

        private void btn1_Click(object sender, EventArgs e) //Fügt Block zu "Bolis" hinzu 
        {
            Bolis.AddBlock(new Block(DateTime.Now, null, "{" + String.Format("sender:{0},receiver:{1},amount:{2:i}",txtSender.Text,txtEmpfaenger.Text,txtBetrag.Text)+"}"));
#if DEBUG
            Debug.WriteLine(Convert.ToString(Bolis.GetLatestBlock().Index) + " " + Convert.ToString(Bolis.GetLatestBlock().Data) + " " + Convert.ToString(Bolis.GetLatestBlock().Hash)); //Daten des letzten Blocks in die Konsole (Debugging)
#endif

        }

        private void btnCheck_Click(object sender, EventArgs e) //Ruft die Überprüffunktion auf
        {
            if (Bolis.IsValid())
            {
                MessageBox.Show("Die Blockchain ist Valid");
            }
            else
            {
                MessageBox.Show("Achtung! Die Blockchain ist Invalid");
            }
        }

        private void btnTestName_Click(object sender, EventArgs e) //Fragt Kontostandfunktion auf
        {
            MessageBox.Show($"Der Kontostand von {txtName.Text} beträgt: {Bolis.GetMoney(txtName.Text)} Bolis");
        }
    }
}
