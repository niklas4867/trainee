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
            this.button1 = new System.Windows.Forms.Button();
            this.btnKontostand = new System.Windows.Forms.Button();
            this.btnueberweisen = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelUeberweisungen = new System.Windows.Forms.Panel();
            this.txtBetrag = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtEmpfaenger = new System.Windows.Forms.TextBox();
            this.txtSender = new System.Windows.Forms.TextBox();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.panelKontostand = new System.Windows.Forms.Panel();
            this.btnTestName = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.panelTransaktion = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelUeberweisungen.SuspendLayout();
            this.panelKontostand.SuspendLayout();
            this.panelTransaktion.SuspendLayout();
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::Bolis.Properties.Resources.transaktionen;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(698, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 40);
            this.button1.TabIndex = 105;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnueberweisen_Click);
            // 
            // btnKontostand
            // 
            this.btnKontostand.BackColor = System.Drawing.Color.Transparent;
            this.btnKontostand.BackgroundImage = global::Bolis.Properties.Resources.kontostand;
            this.btnKontostand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnKontostand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKontostand.FlatAppearance.BorderSize = 0;
            this.btnKontostand.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnKontostand.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnKontostand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKontostand.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKontostand.ForeColor = System.Drawing.Color.White;
            this.btnKontostand.Location = new System.Drawing.Point(530, 165);
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
            this.btnueberweisen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnueberweisen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnueberweisen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnueberweisen.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnueberweisen.ForeColor = System.Drawing.Color.White;
            this.btnueberweisen.Location = new System.Drawing.Point(384, 166);
            this.btnueberweisen.Name = "btnueberweisen";
            this.btnueberweisen.Size = new System.Drawing.Size(140, 39);
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
            this.panelUeberweisungen.Controls.Add(this.panelTransaktion);
            this.panelUeberweisungen.Controls.Add(this.txtBetrag);
            this.panelUeberweisungen.Controls.Add(this.button4);
            this.panelUeberweisungen.Controls.Add(this.button3);
            this.panelUeberweisungen.Controls.Add(this.button2);
            this.panelUeberweisungen.Controls.Add(this.txtEmpfaenger);
            this.panelUeberweisungen.Controls.Add(this.txtSender);
            this.panelUeberweisungen.Controls.Add(this.btn2);
            this.panelUeberweisungen.Controls.Add(this.btn1);
            this.panelUeberweisungen.Location = new System.Drawing.Point(0, 211);
            this.panelUeberweisungen.Name = "panelUeberweisungen";
            this.panelUeberweisungen.Size = new System.Drawing.Size(1260, 470);
            this.panelUeberweisungen.TabIndex = 108;
            this.panelUeberweisungen.Visible = false;
            // 
            // txtBetrag
            // 
            this.txtBetrag.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtBetrag.Location = new System.Drawing.Point(783, 134);
            this.txtBetrag.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.txtBetrag.Name = "txtBetrag";
            this.txtBetrag.Size = new System.Drawing.Size(200, 53);
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
            this.button4.Location = new System.Drawing.Point(808, 83);
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
            this.button3.Location = new System.Drawing.Point(530, 83);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 40);
            this.button3.TabIndex = 116;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::Bolis.Properties.Resources.sender2;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(257, 83);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 40);
            this.button2.TabIndex = 117;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // txtEmpfaenger
            // 
            this.txtEmpfaenger.Location = new System.Drawing.Point(507, 134);
            this.txtEmpfaenger.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.txtEmpfaenger.Name = "txtEmpfaenger";
            this.txtEmpfaenger.Size = new System.Drawing.Size(196, 53);
            this.txtEmpfaenger.TabIndex = 111;
            this.txtEmpfaenger.TextChanged += new System.EventHandler(this.txtEmpfaenger_TextChanged);
            // 
            // txtSender
            // 
            this.txtSender.Location = new System.Drawing.Point(234, 134);
            this.txtSender.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.txtSender.Name = "txtSender";
            this.txtSender.Size = new System.Drawing.Size(196, 53);
            this.txtSender.TabIndex = 110;
            this.txtSender.TextChanged += new System.EventHandler(this.txtSender_TextChanged);
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
            this.btn2.Location = new System.Drawing.Point(1059, 134);
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
            this.btn1.Location = new System.Drawing.Point(1006, 134);
            this.btn1.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(43, 43);
            this.btn1.TabIndex = 114;
            this.btn1.UseVisualStyleBackColor = true;
            // 
            // panelKontostand
            // 
            this.panelKontostand.Controls.Add(this.btnTestName);
            this.panelKontostand.Controls.Add(this.txtName);
            this.panelKontostand.Location = new System.Drawing.Point(3, 211);
            this.panelKontostand.Name = "panelKontostand";
            this.panelKontostand.Size = new System.Drawing.Size(1260, 470);
            this.panelKontostand.TabIndex = 109;
            this.panelKontostand.Visible = false;
            // 
            // btnTestName
            // 
            this.btnTestName.Location = new System.Drawing.Point(667, 110);
            this.btnTestName.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.btnTestName.Name = "btnTestName";
            this.btnTestName.Size = new System.Drawing.Size(147, 43);
            this.btnTestName.TabIndex = 105;
            this.btnTestName.Text = "Überprüfen";
            this.btnTestName.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(446, 110);
            this.txtName.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(196, 53);
            this.txtName.TabIndex = 104;
            // 
            // panelTransaktion
            // 
            this.panelTransaktion.Controls.Add(this.label1);
            this.panelTransaktion.Location = new System.Drawing.Point(0, 3);
            this.panelTransaktion.Name = "panelTransaktion";
            this.panelTransaktion.Size = new System.Drawing.Size(1252, 467);
            this.panelTransaktion.TabIndex = 120;
            this.panelTransaktion.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Transaktionen";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(23F, 46F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panelUeberweisungen);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button1);
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
            this.panelKontostand.ResumeLayout(false);
            this.panelKontostand.PerformLayout();
            this.panelTransaktion.ResumeLayout(false);
            this.panelTransaktion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCheck;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnueberweisen;
        private System.Windows.Forms.Button btnKontostand;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panelUeberweisungen;
        private System.Windows.Forms.Panel panelKontostand;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtEmpfaenger;
        private System.Windows.Forms.TextBox txtSender;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.TextBox txtBetrag;
        private System.Windows.Forms.Button btnTestName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.FlowLayoutPanel panelTransaktion;
        private System.Windows.Forms.Label label1;
    }
}

