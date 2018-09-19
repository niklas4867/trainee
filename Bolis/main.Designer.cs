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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.txtBetrag = new System.Windows.Forms.TextBox();
            this.txtSender = new System.Windows.Forms.TextBox();
            this.txtEmpfaenger = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTestName = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("BigNoodleTitling", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(310, 282);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sender";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(562, 279);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 35);
            this.label3.TabIndex = 2;
            this.label3.Text = "Empfänger";
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(1022, 322);
            this.btn1.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(134, 43);
            this.btn1.TabIndex = 4;
            this.btn1.Text = "Bestätigen";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // txtBetrag
            // 
            this.txtBetrag.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtBetrag.Location = new System.Drawing.Point(799, 322);
            this.txtBetrag.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.txtBetrag.Name = "txtBetrag";
            this.txtBetrag.Size = new System.Drawing.Size(200, 43);
            this.txtBetrag.TabIndex = 3;
            this.txtBetrag.TextChanged += new System.EventHandler(this.txtBetrag_TextChanged);
            // 
            // txtSender
            // 
            this.txtSender.Location = new System.Drawing.Point(250, 322);
            this.txtSender.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.txtSender.Name = "txtSender";
            this.txtSender.Size = new System.Drawing.Size(196, 43);
            this.txtSender.TabIndex = 1;
            // 
            // txtEmpfaenger
            // 
            this.txtEmpfaenger.Location = new System.Drawing.Point(524, 322);
            this.txtEmpfaenger.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.txtEmpfaenger.Name = "txtEmpfaenger";
            this.txtEmpfaenger.Size = new System.Drawing.Size(196, 43);
            this.txtEmpfaenger.TabIndex = 2;
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
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(524, 492);
            this.txtName.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(196, 43);
            this.txtName.TabIndex = 101;
            this.txtName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(525, 449);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 35);
            this.label4.TabIndex = 102;
            this.label4.Text = "Kontostand von ...";
            // 
            // btnTestName
            // 
            this.btnTestName.Location = new System.Drawing.Point(744, 492);
            this.btnTestName.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.btnTestName.Name = "btnTestName";
            this.btnTestName.Size = new System.Drawing.Size(147, 43);
            this.btnTestName.TabIndex = 103;
            this.btnTestName.Text = "Überprüfen";
            this.btnTestName.UseVisualStyleBackColor = true;
            this.btnTestName.Click += new System.EventHandler(this.btnTestName_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Bolis.Properties.Resources.asdasdasd;
            this.pictureBox1.Location = new System.Drawing.Point(477, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(291, 132);
            this.pictureBox1.TabIndex = 104;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("BigNoodleTitling", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(861, 279);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Betrag";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnTestName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.txtEmpfaenger);
            this.Controls.Add(this.txtSender);
            this.Controls.Add(this.txtBetrag);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("BigNoodleTitling", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bolis";
            this.Load += new System.EventHandler(this.main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.TextBox txtBetrag;
        private System.Windows.Forms.TextBox txtSender;
        private System.Windows.Forms.TextBox txtEmpfaenger;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTestName;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}

