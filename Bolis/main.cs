using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Bolis
{
    public partial class main : Form
    {
        public const string User = "Luca";
        P2P p2p = new P2P("192.168.81.255");
        static public string x;
        static public string y;

        public main()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e) //Fügt Block zu "Bolis" hinzu 
        {
            if(MessageBox.Show($"Willst du Wirklich {txtBetrag.Text} Bolis an {txtEmpfaenger.Text} senden?", "Wirklich Senden?",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes){
                p2p.Send($"MasterNode.Program.Bolis.AddBlock(new Block(DateTime.Now, null, \"{{sender:\\\"{User}\\\",receiver:\\\"{txtEmpfaenger.Text}\\\",amount:{txtBetrag.Text}}}\"));");
                txtBetrag.Text = "";
                txtEmpfaenger.Text = "";
            }
        }

        private void txtBetrag_Click(object sender, EventArgs e)
        {
            txtBetrag.Text = "";
        }

        private void btnUeberweisen_Click(object sender, EventArgs e)
        {
            ResetTxt();
            panelUeberweisungen.Visible = true;
            panelKontostand.Visible = true;
            panelTransaktion.Visible = false;
            btnueberweisen.BackColor = Color.FromArgb(60,60,60);
            btnTransaktionen.BackColor = Color.FromArgb(45, 45, 48);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtEmpfaenger.Text = "";
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

        private void btntransaktionen_Click(object sender, EventArgs e)
        {
            ResetTxt();
            panelUeberweisungen.Visible = true;
            panelKontostand.Visible = true;
            panelTransaktion.Visible = true;
            btnTransaktionen.BackColor = Color.FromArgb(60, 60, 60);
            btnueberweisen.BackColor = Color.FromArgb(45, 45, 48);

            btnTransAkt_Click(sender, e);
        }

        private void btnTransAkt_Click(object sender, EventArgs e)
        {
            //txtTransaktionen.Text = Bolis.GetTransaktions(User);
            p2p.Send($"MasterNode.Program.Bolis.GetTransaktions(\"{User}\")");

            Thread.Sleep(100);
            txtTransaktionen.Text = y;
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
            txtUsername.Text = User;
        }

        private void txtEmpfaenger_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void ResetTxt()
        {
            txtKontostand.Text = "";
            txtBetrag.Text = "";
            txtEmpfaenger.Text = "";
            txtTransaktionen.Text = "";
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
            txtTransaktionen.Text = y;
            Thread.Sleep(500);
        }
    }
}
