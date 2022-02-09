namespace KolekcijaPodaci
{
    partial class Form1
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
            this.btnUnos = new System.Windows.Forms.Button();
            this.btnObrada = new System.Windows.Forms.Button();
            this.btnIspis = new System.Windows.Forms.Button();
            this.cmbPodatak4 = new System.Windows.Forms.ComboBox();
            this.txtPodatak1 = new System.Windows.Forms.TextBox();
            this.txtPodatak2 = new System.Windows.Forms.TextBox();
            this.txtPodatak3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rtbIspis = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnUnos
            // 
            this.btnUnos.Location = new System.Drawing.Point(183, 20);
            this.btnUnos.Name = "btnUnos";
            this.btnUnos.Size = new System.Drawing.Size(187, 144);
            this.btnUnos.TabIndex = 0;
            this.btnUnos.Text = "Unos";
            this.btnUnos.UseVisualStyleBackColor = true;
            this.btnUnos.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnObrada
            // 
            this.btnObrada.Location = new System.Drawing.Point(407, 20);
            this.btnObrada.Name = "btnObrada";
            this.btnObrada.Size = new System.Drawing.Size(187, 144);
            this.btnObrada.TabIndex = 1;
            this.btnObrada.Text = "Obrada";
            this.btnObrada.UseVisualStyleBackColor = true;
            this.btnObrada.Click += new System.EventHandler(this.btnObrada_Click);
            // 
            // btnIspis
            // 
            this.btnIspis.Location = new System.Drawing.Point(637, 20);
            this.btnIspis.Name = "btnIspis";
            this.btnIspis.Size = new System.Drawing.Size(187, 144);
            this.btnIspis.TabIndex = 2;
            this.btnIspis.Text = "Ispis";
            this.btnIspis.UseVisualStyleBackColor = true;
            this.btnIspis.Click += new System.EventHandler(this.btnIspis_Click);
            // 
            // cmbPodatak4
            // 
            this.cmbPodatak4.FormattingEnabled = true;
            this.cmbPodatak4.Items.AddRange(new object[] {
            "M",
            "Ž"});
            this.cmbPodatak4.Location = new System.Drawing.Point(21, 143);
            this.cmbPodatak4.Name = "cmbPodatak4";
            this.cmbPodatak4.Size = new System.Drawing.Size(121, 21);
            this.cmbPodatak4.TabIndex = 3;
            // 
            // txtPodatak1
            // 
            this.txtPodatak1.Location = new System.Drawing.Point(21, 20);
            this.txtPodatak1.Name = "txtPodatak1";
            this.txtPodatak1.Size = new System.Drawing.Size(121, 20);
            this.txtPodatak1.TabIndex = 4;
            // 
            // txtPodatak2
            // 
            this.txtPodatak2.Location = new System.Drawing.Point(21, 64);
            this.txtPodatak2.Name = "txtPodatak2";
            this.txtPodatak2.Size = new System.Drawing.Size(121, 20);
            this.txtPodatak2.TabIndex = 5;
            // 
            // txtPodatak3
            // 
            this.txtPodatak3.Location = new System.Drawing.Point(21, 104);
            this.txtPodatak3.Name = "txtPodatak3";
            this.txtPodatak3.Size = new System.Drawing.Size(121, 20);
            this.txtPodatak3.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Podatak 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Podatak 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Podatak 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Podatak4";
            // 
            // rtbIspis
            // 
            this.rtbIspis.Location = new System.Drawing.Point(21, 195);
            this.rtbIspis.Name = "rtbIspis";
            this.rtbIspis.Size = new System.Drawing.Size(803, 243);
            this.rtbIspis.TabIndex = 12;
            this.rtbIspis.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 450);
            this.Controls.Add(this.rtbIspis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPodatak3);
            this.Controls.Add(this.txtPodatak2);
            this.Controls.Add(this.txtPodatak1);
            this.Controls.Add(this.cmbPodatak4);
            this.Controls.Add(this.btnIspis);
            this.Controls.Add(this.btnObrada);
            this.Controls.Add(this.btnUnos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUnos;
        private System.Windows.Forms.Button btnObrada;
        private System.Windows.Forms.Button btnIspis;
        private System.Windows.Forms.ComboBox cmbPodatak4;
        private System.Windows.Forms.TextBox txtPodatak1;
        private System.Windows.Forms.TextBox txtPodatak2;
        private System.Windows.Forms.TextBox txtPodatak3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtbIspis;
    }
}

