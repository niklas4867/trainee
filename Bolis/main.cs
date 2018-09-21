using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using System.Drawing;

namespace Bolis
{
    public partial class main : Form
    {
        public Blockchain Bolis = new Blockchain(); // ----------- Die Klassen wurden zu "Classes.cs" verschoben ------------ //
        public const string User = "TestUser";
        public main()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e) //Fügt Block zu "Bolis" hinzu 
        {
            Bolis.AddBlock(new Block(DateTime.Now, null, "{" + String.Format("sender:{0},receiver:{1},amount:{2:i}", User, txtEmpfaenger.Text, txtBetrag.Text) + "}"));

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
            MessageBox.Show($"Der Kontostand von {User} beträgt: {Bolis.GetMoney(User)} Bolis");
        }

        private void txtBetrag_Click(object sender, EventArgs e)
        {
            txtBetrag.Text = "";
        }

        private void btnueberweisen_Click(object sender, EventArgs e)
        {
            panelUeberweisungen.Visible = true;
            panelKontostand.Visible = false;
            panelTransaktion.Visible = true;
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnKontostand_Click(object sender, EventArgs e)
        {
            btnTestName_Click(sender, e);
            panelUeberweisungen.Visible = false;
            panelKontostand.Visible = true;
            panelTransaktion.Visible = false;
            btnKontostand.BackColor = Color.FromArgb(60, 60, 60);
            btnueberweisen.BackColor = Color.FromArgb(45,45,48);
            btnTransaktionen.BackColor = Color.FromArgb(45,45,48);
        }

        private void btnUeberweisen_Click(object sender, EventArgs e)
        {
            panelUeberweisungen.Visible = true;
            panelKontostand.Visible = false;
            panelTransaktion.Visible = false;
            btnueberweisen.BackColor = Color.FromArgb(60,60,60);
            btnTransaktionen.BackColor = Color.FromArgb(45, 45, 48);
            btnKontostand.BackColor = Color.FromArgb(45, 45, 48);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtEmpfaenger.Text = "";
            txtBetrag.Text = "";

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void txtEmpfaenger_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSender_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

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
            panelUeberweisungen.Visible = false;
            panelKontostand.Visible = false;
            panelTransaktion.Visible = true;
            btnTransaktionen.BackColor = Color.FromArgb(60, 60, 60);
            btnueberweisen.BackColor = Color.FromArgb(45, 45, 48);
            btnKontostand.BackColor = Color.FromArgb(45, 45, 48);
        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        private void txtTransaktionen_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTransAkt_Click(object sender, EventArgs e)
        {
            txtTransaktionen.Text = Bolis.GetTransaktions(User);
        }
        static public void ResponseMessage(string message)
        {
            Debug.WriteLine("Blockchian");
            BC.Add(new Blockchain());
            JsonConvert.PopulateObject(JsonConvert.SerializeObject(main.Bolis, Formatting.Indented), BC[BC.Count]);
            Debug.WriteLine(JsonConvert.SerializeObject(BC[BC.Count]), Formatting.Indented);
        }
    }
}
