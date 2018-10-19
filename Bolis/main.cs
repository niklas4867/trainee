using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace Bolis
{
    public partial class main : Form
    {
        public const string User = "User1";
        public const string OtherUser = "User2";
        P2P p2p = new P2P("192.168.81.255");
        static public string x;
        static public string y;

        public main()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e) //Fügt Block zu "Bolis" hinzu 
        {
            p2p.Send($"MasterNode.Program.Bolis.AddBlock(new Block(DateTime.Now, null, \"{{sender:\\\"{User}\\\",receiver:\\\"{OtherUser}\\\",amount:{txtBetrag.Text}}}\"));");
            txtBetrag.Text = "";
            if (textBox2.Text.Contains("@") && checkBox1.Checked)
            {
                using (StreamWriter outputFile = File.AppendText("Mail.txt"))
                {
                    outputFile.WriteLine(textBox2.Text);
                }
            }
        }

        private void txtBetrag_Click(object sender, EventArgs e)
        {
            txtBetrag.Text = "";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtBetrag.Text = "";

        }

        private void btnueberweisen_MouseHover(object sender, EventArgs e)
        {
            btnueberweisen.BackColor = Color.FromArgb(45, 45, 48);
        }

        private void btnueberweisen_MouseLeave(object sender, EventArgs e)
        {
            btnueberweisen.BackColor = Color.FromArgb(45, 45, 48);
        }

        private void btnTransAkt_Click(object sender, EventArgs e)
        {
            //txtTransaktionen.Text = Bolis.GetTransaktions(User);
            p2p.Send($"MasterNode.Program.Bolis.GetTransaktions(\"{User}\")");

            Thread.Sleep(100);
            if (y != "" && y != "Ð") 
            {

                dataGridView1.Rows.Clear();
                foreach (string kys in y.Split(Convert.ToChar("Ð")))
                {
                    if(kys == "") { continue; }

                    string[] k = kys.Split(Convert.ToChar("╠"));
                    dataGridView1.Rows.Add(k);


                }
            }
            
        }

        static public void ResponseMessage(string message)
        {
            if (message.Substring(0, $"SetTra{User}".Length) == $"SetTra{User}")
            {
                y = message.Substring($"SetTra{User}".Length);
            }
        }

        private void main_Activated(object sender, EventArgs e)
        {
            panelUeberweisungen.Visible = true;
            panelKontostand.Visible = true;
            panelTransaktion.Visible = false;
            btnueberweisen.BackColor = Color.FromArgb(60, 60, 60);
        }

        private void txtEmpfaenger_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void ResetTxt()
        {
            txtKontostand.Text = "";
            txtBetrag.Text = "";
            dataGridView1.Rows.Clear();
            x = "";
            y = "";
        }

        private void btn2_Click_1(object sender, EventArgs e)
        {
            ResetTxt();
        }

        private void ChangeTxT()
        {
            txtKontostand.Text = x;
            dataGridView1.Rows.Clear();
            Thread.Sleep(500);
        }

        private void btnueberweisen_Click_1(object sender, EventArgs e)
        {
            ResetTxt();
            btnTransaktionen.ForeColor = Color.White;
            btnueberweisen.ForeColor = Color.Lime;
            panelUeberweisungen.Visible = true;
            panelKontostand.Visible = true;
            panelTransaktion.Visible = false;
            txtBetrag.Visible = true;
            label2.Visible = true;
            btnueberweisen.BackColor = Color.FromArgb(60, 60, 60);
            btnTransaktionen.BackColor = Color.FromArgb(45, 45, 48);
        }

        private void btnTransaktionen_Click_1(object sender, EventArgs e)
        {
            ResetTxt();
            btnueberweisen.ForeColor = Color.White;
            btnTransaktionen.ForeColor = Color.Lime;
            panelUeberweisungen.Visible = true;
            panelKontostand.Visible = true;
            panelTransaktion.Visible = true;
            txtBetrag.Visible = false;
            label2.Visible = false;
            btnTransaktionen.BackColor = Color.FromArgb(60, 60, 60);
            btnueberweisen.BackColor = Color.FromArgb(45, 45, 48);

            btnTransAkt_Click(sender, e);
        }

        private void btnsnd_Click_1(object sender, EventArgs e)
        {
           if (textBox2.Text.Contains("@")&& checkBox1.Checked)
            {
                using (StreamWriter outputFile = File.AppendText("Mail.txt"))
                {
                    outputFile.WriteLine(textBox2.Text);
                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
