namespace Bolis
{
    partial class main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.btnCheck = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panelUeberweisungen = new System.Windows.Forms.Panel();
            this.panelTransaktion = new System.Windows.Forms.FlowLayoutPanel();
            this.txtBetrag = new System.Windows.Forms.TextBox();
            this.txtEmpfaenger = new System.Windows.Forms.TextBox();
            this.panelKontostand = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKontostand = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.Label();
            this.txtTransaktionen = new System.Windows.Forms.RichTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnTransaktionen = new System.Windows.Forms.Button();
            this.btnKontostand = new System.Windows.Forms.Button();
            this.btnueberweisen = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.btnTransAkt = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btnTestName = new System.Windows.Forms.Button();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.panelUeberweisungen.SuspendLayout();
            this.panelTransaktion.SuspendLayout();
            this.panelKontostand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(837, 773);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(291, 62);
            this.btnCheck.TabIndex = 100;
            this.btnCheck.Text = "Überprüfe Integrität";
            this.btnCheck.UseVisualStyleBackColor = true;
            // 
            // panelUeberweisungen
            // 
            this.panelUeberweisungen.Controls.Add(this.panelTransaktion);
            this.panelUeberweisungen.Controls.Add(this.txtBetrag);
            this.panelUeberweisungen.Controls.Add(this.button4);
            this.panelUeberweisungen.Controls.Add(this.button3);
            this.panelUeberweisungen.Controls.Add(this.txtEmpfaenger);
            this.panelUeberweisungen.Controls.Add(this.btn2);
            this.panelUeberweisungen.Controls.Add(this.btn1);
            this.panelUeberweisungen.Location = new System.Drawing.Point(0, 0);
            this.panelUeberweisungen.Name = "panelUeberweisungen";
            this.panelUeberweisungen.Size = new System.Drawing.Size(1260, 435);
            this.panelUeberweisungen.TabIndex = 108;
            this.panelUeberweisungen.Visible = false;
            // 
            // panelTransaktion
            // 
            this.panelTransaktion.Controls.Add(this.pictureBox6);
            this.panelTransaktion.Controls.Add(this.pictureBox4);
            this.panelTransaktion.Controls.Add(this.pictureBox7);
            this.panelTransaktion.Controls.Add(this.pictureBox8);
            this.panelTransaktion.Controls.Add(this.pictureBox9);
            this.panelTransaktion.Controls.Add(this.pictureBox10);
            this.panelTransaktion.Controls.Add(this.pictureBox11);
            this.panelTransaktion.Controls.Add(this.pictureBox12);
            this.panelTransaktion.Controls.Add(this.txtTransaktionen);
            this.panelTransaktion.Controls.Add(this.btnTransAkt);
            this.panelTransaktion.Location = new System.Drawing.Point(0, 3);
            this.panelTransaktion.Name = "panelTransaktion";
            this.panelTransaktion.Size = new System.Drawing.Size(1252, 435);
            this.panelTransaktion.TabIndex = 120;
            this.panelTransaktion.Visible = false;
            // 
            // txtBetrag
            // 
            this.txtBetrag.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtBetrag.Location = new System.Drawing.Point(670, 134);
            this.txtBetrag.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.txtBetrag.Name = "txtBetrag";
            this.txtBetrag.Size = new System.Drawing.Size(200, 44);
            this.txtBetrag.TabIndex = 2;
            this.txtBetrag.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBetrag_KeyPress);
            // 
            // txtEmpfaenger
            // 
            this.txtEmpfaenger.Location = new System.Drawing.Point(357, 134);
            this.txtEmpfaenger.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.txtEmpfaenger.Name = "txtEmpfaenger";
            this.txtEmpfaenger.Size = new System.Drawing.Size(196, 44);
            this.txtEmpfaenger.TabIndex = 1;
            this.txtEmpfaenger.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmpfaenger_KeyPress);
            // 
            // panelKontostand
            // 
            this.panelKontostand.Controls.Add(this.panelUeberweisungen);
            this.panelKontostand.Controls.Add(this.pictureBox5);
            this.panelKontostand.Controls.Add(this.label1);
            this.panelKontostand.Controls.Add(this.btnTestName);
            this.panelKontostand.Controls.Add(this.txtKontostand);
            this.panelKontostand.Location = new System.Drawing.Point(0, 234);
            this.panelKontostand.Name = "panelKontostand";
            this.panelKontostand.Size = new System.Drawing.Size(1260, 435);
            this.panelKontostand.TabIndex = 109;
            this.panelKontostand.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(534, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 37);
            this.label1.TabIndex = 3;
            // 
            // txtKontostand
            // 
            this.txtKontostand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtKontostand.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKontostand.Location = new System.Drawing.Point(530, 136);
            this.txtKontostand.Name = "txtKontostand";
            this.txtKontostand.ReadOnly = true;
            this.txtKontostand.Size = new System.Drawing.Size(182, 37);
            this.txtKontostand.TabIndex = 109;
            this.txtKontostand.TabStop = false;
            // 
            // txtUsername
            // 
            this.txtUsername.AutoSize = true;
            this.txtUsername.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.White;
            this.txtUsername.Location = new System.Drawing.Point(73, 23);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(0, 27);
            this.txtUsername.TabIndex = 111;
            // 
            // txtTransaktionen
            // 
            this.txtTransaktionen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtTransaktionen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTransaktionen.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTransaktionen.ForeColor = System.Drawing.Color.White;
            this.txtTransaktionen.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtTransaktionen.Location = new System.Drawing.Point(342, 59);
            this.txtTransaktionen.Name = "txtTransaktionen";
            this.txtTransaktionen.ReadOnly = true;
            this.txtTransaktionen.Size = new System.Drawing.Size(550, 351);
            this.txtTransaktionen.TabIndex = 1;
            this.txtTransaktionen.TabStop = false;
            this.txtTransaktionen.Text = "";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Bolis.Properties.Resources.user;
            this.pictureBox2.Location = new System.Drawing.Point(15, 15);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(63, 39);
            this.pictureBox2.TabIndex = 110;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Bolis.Properties.Resources.bar1;
            this.pictureBox3.Location = new System.Drawing.Point(394, 148);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(454, 12);
            this.pictureBox3.TabIndex = 107;
            this.pictureBox3.TabStop = false;
            // 
            // btnTransaktionen
            // 
            this.btnTransaktionen.BackColor = System.Drawing.Color.Transparent;
            this.btnTransaktionen.BackgroundImage = global::Bolis.Properties.Resources.transaktionen;
            this.btnTransaktionen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTransaktionen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTransaktionen.FlatAppearance.BorderSize = 0;
            this.btnTransaktionen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.btnTransaktionen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnTransaktionen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransaktionen.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransaktionen.ForeColor = System.Drawing.Color.Transparent;
            this.btnTransaktionen.Location = new System.Drawing.Point(685, 166);
            this.btnTransaktionen.Name = "btnTransaktionen";
            this.btnTransaktionen.Size = new System.Drawing.Size(170, 40);
            this.btnTransaktionen.TabIndex = 105;
            this.btnTransaktionen.TabStop = false;
            this.btnTransaktionen.UseVisualStyleBackColor = false;
            this.btnTransaktionen.Click += new System.EventHandler(this.btntransaktionen_Click);
            // 
            // btnKontostand
            // 
            this.btnKontostand.BackColor = System.Drawing.Color.Transparent;
            this.btnKontostand.BackgroundImage = global::Bolis.Properties.Resources.kontostand;
            this.btnKontostand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnKontostand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKontostand.FlatAppearance.BorderSize = 0;
            this.btnKontostand.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.btnKontostand.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnKontostand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKontostand.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKontostand.ForeColor = System.Drawing.Color.White;
            this.btnKontostand.Location = new System.Drawing.Point(533, 166);
            this.btnKontostand.Name = "btnKontostand";
            this.btnKontostand.Size = new System.Drawing.Size(150, 40);
            this.btnKontostand.TabIndex = 105;
            this.btnKontostand.TabStop = false;
            this.btnKontostand.UseVisualStyleBackColor = false;
            this.btnKontostand.Click += new System.EventHandler(this.btnKontostand_Click);
            // 
            // btnueberweisen
            // 
            this.btnueberweisen.BackColor = System.Drawing.Color.Transparent;
            this.btnueberweisen.BackgroundImage = global::Bolis.Properties.Resources.ueberweisen3;
            this.btnueberweisen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnueberweisen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnueberweisen.FlatAppearance.BorderSize = 0;
            this.btnueberweisen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.btnueberweisen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnueberweisen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnueberweisen.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnueberweisen.ForeColor = System.Drawing.Color.Transparent;
            this.btnueberweisen.Location = new System.Drawing.Point(385, 166);
            this.btnueberweisen.Name = "btnueberweisen";
            this.btnueberweisen.Size = new System.Drawing.Size(146, 40);
            this.btnueberweisen.TabIndex = 105;
            this.btnueberweisen.TabStop = false;
            this.btnueberweisen.UseVisualStyleBackColor = false;
            this.btnueberweisen.Click += new System.EventHandler(this.btnUeberweisen_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::Bolis.Properties.Resources.asdasdasd;
            this.pictureBox1.Location = new System.Drawing.Point(476, 28);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(290, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 104;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Location = new System.Drawing.Point(3, 3);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(303, 50);
            this.pictureBox6.TabIndex = 3;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Bolis.Properties.Resources.datum;
            this.pictureBox4.Location = new System.Drawing.Point(312, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(105, 50);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::Bolis.Properties.Resources.uhrzeit;
            this.pictureBox7.Location = new System.Drawing.Point(423, 3);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(105, 50);
            this.pictureBox7.TabIndex = 3;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::Bolis.Properties.Resources.betrag2;
            this.pictureBox8.Location = new System.Drawing.Point(534, 3);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(105, 50);
            this.pictureBox8.TabIndex = 3;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::Bolis.Properties.Resources.sender3;
            this.pictureBox9.Location = new System.Drawing.Point(645, 3);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(105, 50);
            this.pictureBox9.TabIndex = 3;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::Bolis.Properties.Resources.empfänger;
            this.pictureBox10.Location = new System.Drawing.Point(756, 3);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(127, 50);
            this.pictureBox10.TabIndex = 3;
            this.pictureBox10.TabStop = false;
            // 
            // btnTransAkt
            // 
            this.btnTransAkt.FlatAppearance.BorderSize = 0;
            this.btnTransAkt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnTransAkt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnTransAkt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransAkt.Image = global::Bolis.Properties.Resources.refresh;
            this.btnTransAkt.Location = new System.Drawing.Point(898, 59);
            this.btnTransAkt.Name = "btnTransAkt";
            this.btnTransAkt.Size = new System.Drawing.Size(43, 43);
            this.btnTransAkt.TabIndex = 1;
            this.btnTransAkt.UseVisualStyleBackColor = true;
            this.btnTransAkt.Click += new System.EventHandler(this.btnTransAkt_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImage = global::Bolis.Properties.Resources.betrag1;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(695, 83);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(150, 40);
            this.button4.TabIndex = 115;
            this.button4.TabStop = false;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = global::Bolis.Properties.Resources.empfaenger2;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(380, 83);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 40);
            this.button3.TabIndex = 116;
            this.button3.TabStop = false;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // btn2
            // 
            this.btn2.FlatAppearance.BorderSize = 0;
            this.btn2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.Color.White;
            this.btn2.Image = global::Bolis.Properties.Resources.cross_v3;
            this.btn2.Location = new System.Drawing.Point(924, 135);
            this.btn2.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(43, 43);
            this.btn2.TabIndex = 4;
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click_1);
            // 
            // btn1
            // 
            this.btn1.BackgroundImage = global::Bolis.Properties.Resources.checkmark1;
            this.btn1.FlatAppearance.BorderSize = 0;
            this.btn1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Location = new System.Drawing.Point(880, 135);
            this.btn1.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(43, 43);
            this.btn1.TabIndex = 3;
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Bolis.Properties.Resources.dein_kontostand;
            this.pictureBox5.Location = new System.Drawing.Point(530, 83);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(182, 39);
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // btnTestName
            // 
            this.btnTestName.FlatAppearance.BorderSize = 0;
            this.btnTestName.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnTestName.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnTestName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTestName.Image = global::Bolis.Properties.Resources.refresh;
            this.btnTestName.Location = new System.Drawing.Point(723, 130);
            this.btnTestName.Name = "btnTestName";
            this.btnTestName.Size = new System.Drawing.Size(43, 43);
            this.btnTestName.TabIndex = 1;
            this.btnTestName.UseVisualStyleBackColor = true;
            this.btnTestName.Click += new System.EventHandler(this.btnTestName_Click);
            // 
            // pictureBox11
            // 
            this.pictureBox11.Location = new System.Drawing.Point(889, 3);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(265, 50);
            this.pictureBox11.TabIndex = 3;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.Location = new System.Drawing.Point(3, 59);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(333, 50);
            this.pictureBox12.TabIndex = 3;
            this.pictureBox12.TabStop = false;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnTransaktionen);
            this.Controls.Add(this.btnKontostand);
            this.Controls.Add(this.btnueberweisen);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.panelKontostand);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.MaximizeBox = false;
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bolis";
            this.Activated += new System.EventHandler(this.main_Activated);
            this.panelUeberweisungen.ResumeLayout(false);
            this.panelUeberweisungen.PerformLayout();
            this.panelTransaktion.ResumeLayout(false);
            this.panelKontostand.ResumeLayout(false);
            this.panelKontostand.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCheck;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnueberweisen;
        private System.Windows.Forms.Button btnKontostand;
        private System.Windows.Forms.Button btnTransaktionen;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panelUeberweisungen;
        private System.Windows.Forms.Panel panelKontostand;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtEmpfaenger;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.TextBox txtBetrag;
        private System.Windows.Forms.FlowLayoutPanel panelTransaktion;
        private System.Windows.Forms.Button btnTransAkt;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTestName;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label txtUsername;
        public System.Windows.Forms.TextBox txtKontostand;
        public System.Windows.Forms.RichTextBox txtTransaktionen;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox12;
    }
}

