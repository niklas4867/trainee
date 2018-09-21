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
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnTransaktionen = new System.Windows.Forms.Button();
            this.btnKontostand = new System.Windows.Forms.Button();
            this.btnueberweisen = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelUeberweisungen = new System.Windows.Forms.Panel();
            this.panelTransaktion = new System.Windows.Forms.FlowLayoutPanel();
            this.txtBetrag = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtEmpfaenger = new System.Windows.Forms.TextBox();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.panelKontostand = new System.Windows.Forms.Panel();
            this.btnTestName = new System.Windows.Forms.Button();
            this.txtTransaktionen = new System.Windows.Forms.RichTextBox();
            this.btnTransAkt = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelUeberweisungen.SuspendLayout();
            this.panelTransaktion.SuspendLayout();
            this.panelKontostand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
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
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
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
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.TabIndex = 106;
            this.pictureBox2.TabStop = false;
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
            this.btnKontostand.UseVisualStyleBackColor = false;
            this.btnKontostand.Click += new System.EventHandler(this.btnKontostand_Click);
            // 
            // btnueberweisen
            // 
            this.btnueberweisen.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
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
            this.btnueberweisen.Location = new System.Drawing.Point(380, 166);
            this.btnueberweisen.Name = "btnueberweisen";
            this.btnueberweisen.Size = new System.Drawing.Size(150, 40);
            this.btnueberweisen.TabIndex = 105;
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
            // panelUeberweisungen
            // 
            this.panelUeberweisungen.Controls.Add(this.txtBetrag);
            this.panelUeberweisungen.Controls.Add(this.button4);
            this.panelUeberweisungen.Controls.Add(this.button3);
            this.panelUeberweisungen.Controls.Add(this.txtEmpfaenger);
            this.panelUeberweisungen.Controls.Add(this.btn2);
            this.panelUeberweisungen.Controls.Add(this.btn1);
            this.panelUeberweisungen.Location = new System.Drawing.Point(0, 199);
            this.panelUeberweisungen.Name = "panelUeberweisungen";
            this.panelUeberweisungen.Size = new System.Drawing.Size(1260, 470);
            this.panelUeberweisungen.TabIndex = 108;
            this.panelUeberweisungen.Visible = false;
            // 
            // panelTransaktion
            // 
            this.panelTransaktion.Controls.Add(this.pictureBox4);
            this.panelTransaktion.Controls.Add(this.txtTransaktionen);
            this.panelTransaktion.Controls.Add(this.btnTransAkt);
            this.panelTransaktion.Location = new System.Drawing.Point(0, 234);
            this.panelTransaktion.Name = "panelTransaktion";
            this.panelTransaktion.Size = new System.Drawing.Size(1252, 432);
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
            this.txtBetrag.TabIndex = 119;
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
            this.button3.UseVisualStyleBackColor = false;
            // 
            // txtEmpfaenger
            // 
            this.txtEmpfaenger.Location = new System.Drawing.Point(357, 134);
            this.txtEmpfaenger.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.txtEmpfaenger.Name = "txtEmpfaenger";
            this.txtEmpfaenger.Size = new System.Drawing.Size(196, 44);
            this.txtEmpfaenger.TabIndex = 111;
            this.txtEmpfaenger.TextChanged += new System.EventHandler(this.txtEmpfaenger_TextChanged);
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
            this.btn2.TabIndex = 113;
            this.btn2.UseVisualStyleBackColor = true;
            // 
            // btn1
            // 
            this.btn1.BackgroundImage = global::Bolis.Properties.Resources.checkmark1;
            this.btn1.FlatAppearance.BorderSize = 0;
            this.btn1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Location = new System.Drawing.Point(880, 134);
            this.btn1.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(43, 43);
            this.btn1.TabIndex = 114;
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // panelKontostand
            // 
            this.panelKontostand.Controls.Add(this.btnTestName);
            this.panelKontostand.Location = new System.Drawing.Point(0, 199);
            this.panelKontostand.Name = "panelKontostand";
            this.panelKontostand.Size = new System.Drawing.Size(1260, 470);
            this.panelKontostand.TabIndex = 109;
            this.panelKontostand.Visible = false;
            // 
            // btnTestName
            // 
            this.btnTestName.Location = new System.Drawing.Point(533, 107);
            this.btnTestName.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.btnTestName.Name = "btnTestName";
            this.btnTestName.Size = new System.Drawing.Size(147, 43);
            this.btnTestName.TabIndex = 105;
            this.btnTestName.Text = "Überprüfen";
            this.btnTestName.UseVisualStyleBackColor = true;
            this.btnTestName.Click += new System.EventHandler(this.btnTestName_Click);
            // 
            // txtTransaktionen
            // 
            this.txtTransaktionen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtTransaktionen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTransaktionen.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtTransaktionen.Location = new System.Drawing.Point(390, 3);
            this.txtTransaktionen.Name = "txtTransaktionen";
            this.txtTransaktionen.Size = new System.Drawing.Size(459, 404);
            this.txtTransaktionen.TabIndex = 1;
            this.txtTransaktionen.TabStop = false;
            this.txtTransaktionen.Text = "";
            // 
            // btnTransAkt
            // 
            this.btnTransAkt.Location = new System.Drawing.Point(855, 3);
            this.btnTransAkt.Name = "btnTransAkt";
            this.btnTransAkt.Size = new System.Drawing.Size(163, 71);
            this.btnTransAkt.TabIndex = 2;
            this.btnTransAkt.Text = "button1";
            this.btnTransAkt.UseVisualStyleBackColor = true;
            this.btnTransAkt.Click += new System.EventHandler(this.btnTransAkt_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(3, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(381, 50);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panelTransaktion);
            this.Controls.Add(this.panelUeberweisungen);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnTransaktionen);
            this.Controls.Add(this.btnKontostand);
            this.Controls.Add(this.btnueberweisen);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.panelKontostand);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bolis";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelUeberweisungen.ResumeLayout(false);
            this.panelUeberweisungen.PerformLayout();
            this.panelTransaktion.ResumeLayout(false);
            this.panelKontostand.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCheck;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnueberweisen;
        private System.Windows.Forms.Button btnKontostand;
        private System.Windows.Forms.Button btnTransaktionen;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panelUeberweisungen;
        private System.Windows.Forms.Panel panelKontostand;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtEmpfaenger;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.TextBox txtBetrag;
        private System.Windows.Forms.Button btnTestName;
        private System.Windows.Forms.FlowLayoutPanel panelTransaktion;
        private System.Windows.Forms.RichTextBox txtTransaktionen;
        private System.Windows.Forms.Button btnTransAkt;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

