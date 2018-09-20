using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace Bolis
{
    public partial class main : Form
    {
        static public Blockchain Bolis = new Blockchain(); // ----------- Die Klassen wurden zu "Classes.cs" verschoben ------------ //
        static List<Blockchain> BC = new List<Blockchain>();
        private BCPusher bcpusher = new BCPusher();
        public main()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e) //Fügt Block zu "Bolis" hinzu 
        {
            Bolis.AddBlock(new Block(DateTime.Now, null, "{" + String.Format("sender:{0},receiver:{1},amount:{2:i}", txtSender.Text, txtEmpfaenger.Text, txtBetrag.Text) + "}"));
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

        private void txtBetrag_Click(object sender, EventArgs e)
        {
            txtBetrag.Text = "";
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MessageBox.Show($"Der Kontostand von {txtName.Text} beträgt: {Bolis.GetMoney(txtName.Text)} Bolis");
            }
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
