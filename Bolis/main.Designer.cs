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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.btnCheck = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panelUeberweisungen = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panelTransaktion = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Timestamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nachricht = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phash = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Chash = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTransAkt = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtBetrag = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelKontostand = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTestName = new System.Windows.Forms.Button();
            this.txtKontostand = new System.Windows.Forms.TextBox();
            this.btnueberweisen = new System.Windows.Forms.Button();
            this.btnTransaktionen = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelUeberweisungen.SuspendLayout();
            this.panelTransaktion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.panelKontostand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.panelUeberweisungen.Controls.Add(this.textBox1);
            this.panelUeberweisungen.Controls.Add(this.panelTransaktion);
            this.panelUeberweisungen.Controls.Add(this.txtBetrag);
            this.panelUeberweisungen.Controls.Add(this.btn1);
            this.panelUeberweisungen.Controls.Add(this.pictureBox8);
            this.panelUeberweisungen.Controls.Add(this.textBox2);
            this.panelUeberweisungen.Controls.Add(this.checkBox1);
            this.panelUeberweisungen.Location = new System.Drawing.Point(0, -307);
            this.panelUeberweisungen.Name = "panelUeberweisungen";
            this.panelUeberweisungen.Size = new System.Drawing.Size(1260, 742);
            this.panelUeberweisungen.TabIndex = 108;
            this.panelUeberweisungen.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(394, 133);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(164, 44);
            this.textBox1.TabIndex = 121;
            this.textBox1.Text = "Nachricht";
            // 
            // panelTransaktion
            // 
            this.panelTransaktion.Controls.Add(this.pictureBox6);
            this.panelTransaktion.Controls.Add(this.label6);
            this.panelTransaktion.Controls.Add(this.label7);
            this.panelTransaktion.Controls.Add(this.label8);
            this.panelTransaktion.Controls.Add(this.label9);
            this.panelTransaktion.Controls.Add(this.pictureBox11);
            this.panelTransaktion.Controls.Add(this.pictureBox12);
            this.panelTransaktion.Controls.Add(this.dataGridView1);
            this.panelTransaktion.Controls.Add(this.btnTransAkt);
            this.panelTransaktion.Controls.Add(this.pictureBox2);
            this.panelTransaktion.Location = new System.Drawing.Point(0, 307);
            this.panelTransaktion.Name = "panelTransaktion";
            this.panelTransaktion.Size = new System.Drawing.Size(1252, 569);
            this.panelTransaktion.TabIndex = 120;
            this.panelTransaktion.Visible = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Location = new System.Drawing.Point(3, 3);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(183, 50);
            this.pictureBox6.TabIndex = 3;
            this.pictureBox6.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(192, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 29);
            this.label6.TabIndex = 4;
            this.label6.Text = "TIMESTAMP      ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Window;
            this.label7.Location = new System.Drawing.Point(364, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(283, 29);
            this.label7.TabIndex = 5;
            this.label7.Text = "NACHRICHT                                   ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Window;
            this.label8.Location = new System.Drawing.Point(653, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(194, 29);
            this.label8.TabIndex = 6;
            this.label8.Text = "CURRENT HASH  ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Window;
            this.label9.Location = new System.Drawing.Point(853, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(192, 29);
            this.label9.TabIndex = 7;
            this.label9.Text = "PREVIOUS HASH";
            // 
            // pictureBox11
            // 
            this.pictureBox11.Location = new System.Drawing.Point(1051, 3);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(183, 50);
            this.pictureBox11.TabIndex = 3;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.Location = new System.Drawing.Point(3, 59);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(183, 50);
            this.pictureBox12.TabIndex = 3;
            this.pictureBox12.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Timestamp,
            this.Nachricht,
            this.Phash,
            this.Chash});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.dataGridView1.Location = new System.Drawing.Point(192, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(861, 294);
            this.dataGridView1.TabIndex = 134;
            // 
            // Timestamp
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Timestamp.DefaultCellStyle = dataGridViewCellStyle2;
            this.Timestamp.HeaderText = "Timestamp";
            this.Timestamp.Name = "Timestamp";
            this.Timestamp.ReadOnly = true;
            this.Timestamp.Width = 170;
            // 
            // Nachricht
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nachricht.DefaultCellStyle = dataGridViewCellStyle3;
            this.Nachricht.HeaderText = "Nachricht";
            this.Nachricht.Name = "Nachricht";
            this.Nachricht.ReadOnly = true;
            this.Nachricht.Width = 295;
            // 
            // Phash
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phash.DefaultCellStyle = dataGridViewCellStyle4;
            this.Phash.HeaderText = "Phash";
            this.Phash.Name = "Phash";
            this.Phash.ReadOnly = true;
            this.Phash.Width = 199;
            // 
            // Chash
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chash.DefaultCellStyle = dataGridViewCellStyle5;
            this.Chash.HeaderText = "Chash";
            this.Chash.Name = "Chash";
            this.Chash.ReadOnly = true;
            this.Chash.Width = 286;
            // 
            // btnTransAkt
            // 
            this.btnTransAkt.FlatAppearance.BorderSize = 0;
            this.btnTransAkt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnTransAkt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnTransAkt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransAkt.Image = ((System.Drawing.Image)(resources.GetObject("btnTransAkt.Image")));
            this.btnTransAkt.Location = new System.Drawing.Point(1059, 59);
            this.btnTransAkt.Name = "btnTransAkt";
            this.btnTransAkt.Size = new System.Drawing.Size(43, 43);
            this.btnTransAkt.TabIndex = 1;
            this.btnTransAkt.UseVisualStyleBackColor = true;
            this.btnTransAkt.Click += new System.EventHandler(this.btnTransAkt_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 359);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1248, 1);
            this.pictureBox2.TabIndex = 128;
            this.pictureBox2.TabStop = false;
            // 
            // txtBetrag
            // 
            this.txtBetrag.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtBetrag.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBetrag.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtBetrag.Location = new System.Drawing.Point(344, 312);
            this.txtBetrag.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.txtBetrag.MaxLength = 500;
            this.txtBetrag.Multiline = true;
            this.txtBetrag.Name = "txtBetrag";
            this.txtBetrag.Size = new System.Drawing.Size(609, 189);
            this.txtBetrag.TabIndex = 2;
            // 
            // btn1
            // 
            this.btn1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn1.BackgroundImage")));
            this.btn1.FlatAppearance.BorderSize = 0;
            this.btn1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Location = new System.Drawing.Point(963, 458);
            this.btn1.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(43, 43);
            this.btn1.TabIndex = 3;
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::Bolis.Properties.Resources.ganzklein;
            this.pictureBox8.Location = new System.Drawing.Point(344, 512);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(41, 31);
            this.pictureBox8.TabIndex = 133;
            this.pictureBox8.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.textBox2.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox2.Location = new System.Drawing.Point(391, 512);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(423, 33);
            this.textBox2.TabIndex = 130;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.checkBox1.Location = new System.Drawing.Point(344, 549);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(474, 23);
            this.checkBox1.TabIndex = 129;
            this.checkBox1.Text = "Ich stimme den Datenschutzbedingungen der io-market AG zu.";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(337, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 39);
            this.label2.TabIndex = 123;
            this.label2.Text = "Nachricht";
            // 
            // panelKontostand
            // 
            this.panelKontostand.Controls.Add(this.panelUeberweisungen);
            this.panelKontostand.Controls.Add(this.pictureBox5);
            this.panelKontostand.Controls.Add(this.label1);
            this.panelKontostand.Controls.Add(this.btnTestName);
            this.panelKontostand.Controls.Add(this.txtKontostand);
            this.panelKontostand.Location = new System.Drawing.Point(0, 306);
            this.panelKontostand.Name = "panelKontostand";
            this.panelKontostand.Size = new System.Drawing.Size(1260, 363);
            this.panelKontostand.TabIndex = 109;
            this.panelKontostand.Visible = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(530, 83);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(182, 39);
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
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
            // btnTestName
            // 
            this.btnTestName.FlatAppearance.BorderSize = 0;
            this.btnTestName.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnTestName.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnTestName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTestName.Image = ((System.Drawing.Image)(resources.GetObject("btnTestName.Image")));
            this.btnTestName.Location = new System.Drawing.Point(723, 130);
            this.btnTestName.Name = "btnTestName";
            this.btnTestName.Size = new System.Drawing.Size(43, 43);
            this.btnTestName.TabIndex = 1;
            this.btnTestName.UseVisualStyleBackColor = true;
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
            // btnueberweisen
            // 
            this.btnueberweisen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnueberweisen.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnueberweisen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnueberweisen.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnueberweisen.ForeColor = System.Drawing.Color.Lime;
            this.btnueberweisen.Location = new System.Drawing.Point(287, 167);
            this.btnueberweisen.Name = "btnueberweisen";
            this.btnueberweisen.Size = new System.Drawing.Size(332, 45);
            this.btnueberweisen.TabIndex = 122;
            this.btnueberweisen.Text = "DEIN NEUER BLOCK";
            this.btnueberweisen.UseVisualStyleBackColor = false;
            this.btnueberweisen.Click += new System.EventHandler(this.btnueberweisen_Click_1);
            // 
            // btnTransaktionen
            // 
            this.btnTransaktionen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnTransaktionen.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnTransaktionen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransaktionen.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransaktionen.ForeColor = System.Drawing.SystemColors.Window;
            this.btnTransaktionen.Location = new System.Drawing.Point(819, 167);
            this.btnTransaktionen.Name = "btnTransaktionen";
            this.btnTransaktionen.Size = new System.Drawing.Size(239, 45);
            this.btnTransaktionen.TabIndex = 123;
            this.btnTransaktionen.Text = "BLOCKCHAIN";
            this.btnTransaktionen.UseVisualStyleBackColor = false;
            this.btnTransaktionen.Click += new System.EventHandler(this.btnTransaktionen_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(179, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(366, 77);
            this.label3.TabIndex = 124;
            this.label3.Text = "IO-MARKET";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(635, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(419, 77);
            this.label4.TabIndex = 125;
            this.label4.Text = "BLOCKCHAIN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(538, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 39);
            this.label5.TabIndex = 126;
            this.label5.Text = "GOES";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Window;
            this.label10.Location = new System.Drawing.Point(12, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(417, 39);
            this.label10.TabIndex = 127;
            this.label10.Text = "Digitaltag Liechtenstein 2018";
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::Bolis.Properties.Resources.edexa_final_logo_white;
            this.pictureBox9.Location = new System.Drawing.Point(1101, 9);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(140, 39);
            this.pictureBox9.TabIndex = 128;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(136, 142);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(980, 1);
            this.pictureBox3.TabIndex = 107;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 665);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1248, 1);
            this.pictureBox1.TabIndex = 129;
            this.pictureBox1.TabStop = false;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1264, 682);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnTransaktionen);
            this.Controls.Add(this.btnueberweisen);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.panelKontostand);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Activated += new System.EventHandler(this.main_Activated);
            this.panelUeberweisungen.ResumeLayout(false);
            this.panelUeberweisungen.PerformLayout();
            this.panelTransaktion.ResumeLayout(false);
            this.panelTransaktion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.panelKontostand.ResumeLayout(false);
            this.panelKontostand.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCheck;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panelUeberweisungen;
        private System.Windows.Forms.Panel panelKontostand;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.TextBox txtBetrag;
        private System.Windows.Forms.FlowLayoutPanel panelTransaktion;
        private System.Windows.Forms.Button btnTransAkt;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTestName;
        public System.Windows.Forms.TextBox txtKontostand;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnueberweisen;
        private System.Windows.Forms.Button btnTransaktionen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Timestamp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nachricht;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phash;
        private System.Windows.Forms.DataGridViewTextBoxColumn Chash;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

