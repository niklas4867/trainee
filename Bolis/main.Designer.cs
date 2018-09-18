namespace Bloackchain_V1
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
            this.label2 = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.txtBetrag = new System.Windows.Forms.TextBox();
            this.txtSender = new System.Windows.Forms.TextBox();
            this.txtEmpfaenger = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTestName = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sender";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Empfänger";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Betrag";
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(96, 172);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 23);
            this.btn1.TabIndex = 4;
            this.btn1.Text = "Bestätigen";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // txtBetrag
            // 
            this.txtBetrag.Location = new System.Drawing.Point(86, 114);
            this.txtBetrag.Name = "txtBetrag";
            this.txtBetrag.Size = new System.Drawing.Size(100, 20);
            this.txtBetrag.TabIndex = 3;
            // 
            // txtSender
            // 
            this.txtSender.Location = new System.Drawing.Point(12, 61);
            this.txtSender.Name = "txtSender";
            this.txtSender.Size = new System.Drawing.Size(100, 20);
            this.txtSender.TabIndex = 1;
            // 
            // txtEmpfaenger
            // 
            this.txtEmpfaenger.Location = new System.Drawing.Point(175, 61);
            this.txtEmpfaenger.Name = "txtEmpfaenger";
            this.txtEmpfaenger.Size = new System.Drawing.Size(100, 20);
            this.txtEmpfaenger.TabIndex = 2;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(63, 325);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(145, 23);
            this.btnCheck.TabIndex = 100;
            this.btnCheck.Text = "Überprüfe Integrität";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(86, 243);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 101;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 102;
            this.label4.Text = "Kontostand von ...";
            // 
            // btnTestName
            // 
            this.btnTestName.Location = new System.Drawing.Point(96, 269);
            this.btnTestName.Name = "btnTestName";
            this.btnTestName.Size = new System.Drawing.Size(75, 23);
            this.btnTestName.TabIndex = 103;
            this.btnTestName.Text = "Überprüfen";
            this.btnTestName.UseVisualStyleBackColor = true;
            this.btnTestName.Click += new System.EventHandler(this.btnTestName_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 360);
            this.Controls.Add(this.btnTestName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.txtEmpfaenger);
            this.Controls.Add(this.txtSender);
            this.Controls.Add(this.txtBetrag);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "main";
            this.Text = "Bolis";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.TextBox txtBetrag;
        private System.Windows.Forms.TextBox txtSender;
        private System.Windows.Forms.TextBox txtEmpfaenger;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTestName;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

