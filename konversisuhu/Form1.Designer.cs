namespace konversisuhu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txNilai = new System.Windows.Forms.TextBox();
            this.cbDari = new System.Windows.Forms.ComboBox();
            this.cbKe = new System.Windows.Forms.ComboBox();
            this.btHasil = new System.Windows.Forms.Button();
            this.btBersih = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txHasil = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 82);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(290, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Konversi Suhu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(36, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Masukkan Nilai :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dari";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(261, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ke";
            // 
            // txNilai
            // 
            this.txNilai.Location = new System.Drawing.Point(180, 109);
            this.txNilai.Name = "txNilai";
            this.txNilai.Size = new System.Drawing.Size(151, 20);
            this.txNilai.TabIndex = 4;
            // 
            // cbDari
            // 
            this.cbDari.FormattingEnabled = true;
            this.cbDari.Items.AddRange(new object[] {
            "Celcius",
            "Fahrenheit",
            "Reamur"});
            this.cbDari.Location = new System.Drawing.Point(88, 190);
            this.cbDari.Name = "cbDari";
            this.cbDari.Size = new System.Drawing.Size(121, 21);
            this.cbDari.TabIndex = 5;
            // 
            // cbKe
            // 
            this.cbKe.FormattingEnabled = true;
            this.cbKe.Items.AddRange(new object[] {
            "Celcius",
            "Fahrenheit",
            "Reamur"});
            this.cbKe.Location = new System.Drawing.Point(296, 190);
            this.cbKe.Name = "cbKe";
            this.cbKe.Size = new System.Drawing.Size(121, 21);
            this.cbKe.TabIndex = 6;
            // 
            // btHasil
            // 
            this.btHasil.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btHasil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHasil.Location = new System.Drawing.Point(88, 281);
            this.btHasil.Name = "btHasil";
            this.btHasil.Size = new System.Drawing.Size(74, 31);
            this.btHasil.TabIndex = 7;
            this.btHasil.Text = "Hasil";
            this.btHasil.UseVisualStyleBackColor = false;
            this.btHasil.Click += new System.EventHandler(this.btHasil_Click);
            // 
            // btBersih
            // 
            this.btBersih.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btBersih.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBersih.Location = new System.Drawing.Point(296, 280);
            this.btBersih.Name = "btBersih";
            this.btBersih.Size = new System.Drawing.Size(74, 32);
            this.btBersih.TabIndex = 8;
            this.btBersih.Text = "Bersih";
            this.btBersih.UseVisualStyleBackColor = false;
            this.btBersih.Click += new System.EventHandler(this.btBersih_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 374);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Hasil =";
            // 
            // txHasil
            // 
            this.txHasil.Location = new System.Drawing.Point(109, 373);
            this.txHasil.Name = "txHasil";
            this.txHasil.Size = new System.Drawing.Size(131, 20);
            this.txHasil.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txHasil);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btBersih);
            this.Controls.Add(this.btHasil);
            this.Controls.Add(this.cbKe);
            this.Controls.Add(this.cbDari);
            this.Controls.Add(this.txNilai);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txNilai;
        private System.Windows.Forms.ComboBox cbDari;
        private System.Windows.Forms.ComboBox cbKe;
        private System.Windows.Forms.Button btHasil;
        private System.Windows.Forms.Button btBersih;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txHasil;
    }
}

