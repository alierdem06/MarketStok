namespace WindowsFormsApp2
{
    partial class frmUrunEkle
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnYeniEkle = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboMarka = new System.Windows.Forms.ComboBox();
            this.comboKategori = new System.Windows.Forms.ComboBox();
            this.txtSatisFiyati = new System.Windows.Forms.TextBox();
            this.txtAlisFiyati = new System.Windows.Forms.TextBox();
            this.txtMiktari = new System.Windows.Forms.TextBox();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.txtBarkodNo = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblMiktari = new System.Windows.Forms.Label();
            this.btnVarOlanaEkle = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.SatisFiyatitxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Miktartxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.UrunAditxt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Markatxt = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.BarkodNotxt = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.Kategoritxt = new System.Windows.Forms.TextBox();
            this.AlisFiyatitxt = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnYeniEkle);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboMarka);
            this.groupBox1.Controls.Add(this.comboKategori);
            this.groupBox1.Controls.Add(this.txtSatisFiyati);
            this.groupBox1.Controls.Add(this.txtAlisFiyati);
            this.groupBox1.Controls.Add(this.txtMiktari);
            this.groupBox1.Controls.Add(this.txtUrunAdi);
            this.groupBox1.Controls.Add(this.txtBarkodNo);
            this.groupBox1.Location = new System.Drawing.Point(48, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 304);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni Ürün";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Satış Fiyatı";
            // 
            // btnYeniEkle
            // 
            this.btnYeniEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnYeniEkle.Location = new System.Drawing.Point(107, 257);
            this.btnYeniEkle.Name = "btnYeniEkle";
            this.btnYeniEkle.Size = new System.Drawing.Size(75, 23);
            this.btnYeniEkle.TabIndex = 2;
            this.btnYeniEkle.Text = "Ekle";
            this.btnYeniEkle.UseVisualStyleBackColor = false;
            this.btnYeniEkle.Click += new System.EventHandler(this.btnYeniEkle_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Alış Fiyatı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Miktar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ürün Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Marka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Kategori";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Barkod No";
            // 
            // comboMarka
            // 
            this.comboMarka.BackColor = System.Drawing.Color.Cyan;
            this.comboMarka.FormattingEnabled = true;
            this.comboMarka.Location = new System.Drawing.Point(73, 96);
            this.comboMarka.Name = "comboMarka";
            this.comboMarka.Size = new System.Drawing.Size(109, 21);
            this.comboMarka.TabIndex = 6;
            this.comboMarka.SelectedIndexChanged += new System.EventHandler(this.comboMarka_SelectedIndexChanged);
            // 
            // comboKategori
            // 
            this.comboKategori.BackColor = System.Drawing.Color.Cyan;
            this.comboKategori.FormattingEnabled = true;
            this.comboKategori.Location = new System.Drawing.Point(73, 63);
            this.comboKategori.Name = "comboKategori";
            this.comboKategori.Size = new System.Drawing.Size(109, 21);
            this.comboKategori.TabIndex = 5;
            this.comboKategori.SelectedIndexChanged += new System.EventHandler(this.comboKategori_SelectedIndexChanged);
            // 
            // txtSatisFiyati
            // 
            this.txtSatisFiyati.Location = new System.Drawing.Point(73, 225);
            this.txtSatisFiyati.Name = "txtSatisFiyati";
            this.txtSatisFiyati.Size = new System.Drawing.Size(109, 20);
            this.txtSatisFiyati.TabIndex = 4;
            // 
            // txtAlisFiyati
            // 
            this.txtAlisFiyati.Location = new System.Drawing.Point(73, 193);
            this.txtAlisFiyati.Name = "txtAlisFiyati";
            this.txtAlisFiyati.Size = new System.Drawing.Size(109, 20);
            this.txtAlisFiyati.TabIndex = 3;
            // 
            // txtMiktari
            // 
            this.txtMiktari.Location = new System.Drawing.Point(73, 161);
            this.txtMiktari.Name = "txtMiktari";
            this.txtMiktari.Size = new System.Drawing.Size(109, 20);
            this.txtMiktari.TabIndex = 2;
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(73, 129);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(109, 20);
            this.txtUrunAdi.TabIndex = 1;
            // 
            // txtBarkodNo
            // 
            this.txtBarkodNo.Location = new System.Drawing.Point(73, 31);
            this.txtBarkodNo.Name = "txtBarkodNo";
            this.txtBarkodNo.Size = new System.Drawing.Size(109, 20);
            this.txtBarkodNo.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblMiktari);
            this.groupBox2.Controls.Add(this.btnVarOlanaEkle);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.SatisFiyatitxt);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.Miktartxt);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.UrunAditxt);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.Markatxt);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.BarkodNotxt);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.Kategoritxt);
            this.groupBox2.Controls.Add(this.AlisFiyatitxt);
            this.groupBox2.Location = new System.Drawing.Point(311, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(214, 299);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Var Olan Ürün";
            // 
            // lblMiktari
            // 
            this.lblMiktari.AutoSize = true;
            this.lblMiktari.Location = new System.Drawing.Point(31, 260);
            this.lblMiktari.Name = "lblMiktari";
            this.lblMiktari.Size = new System.Drawing.Size(0, 13);
            this.lblMiktari.TabIndex = 21;
            // 
            // btnVarOlanaEkle
            // 
            this.btnVarOlanaEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnVarOlanaEkle.Location = new System.Drawing.Point(112, 250);
            this.btnVarOlanaEkle.Name = "btnVarOlanaEkle";
            this.btnVarOlanaEkle.Size = new System.Drawing.Size(75, 23);
            this.btnVarOlanaEkle.TabIndex = 3;
            this.btnVarOlanaEkle.Text = "Ekle";
            this.btnVarOlanaEkle.UseVisualStyleBackColor = false;
            this.btnVarOlanaEkle.Click += new System.EventHandler(this.btnVarOlanaEkle_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 218);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Satış Fiyatı";
            // 
            // SatisFiyatitxt
            // 
            this.SatisFiyatitxt.Location = new System.Drawing.Point(87, 217);
            this.SatisFiyatitxt.Name = "SatisFiyatitxt";
            this.SatisFiyatitxt.Size = new System.Drawing.Size(100, 20);
            this.SatisFiyatitxt.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 187);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Alış Fiyatı";
            // 
            // Miktartxt
            // 
            this.Miktartxt.Location = new System.Drawing.Point(87, 153);
            this.Miktartxt.Name = "Miktartxt";
            this.Miktartxt.Size = new System.Drawing.Size(100, 20);
            this.Miktartxt.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(36, 156);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Miktar";
            // 
            // UrunAditxt
            // 
            this.UrunAditxt.Location = new System.Drawing.Point(87, 121);
            this.UrunAditxt.Name = "UrunAditxt";
            this.UrunAditxt.Size = new System.Drawing.Size(100, 20);
            this.UrunAditxt.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 125);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Ürün Adı";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(35, 94);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "Marka";
            // 
            // Markatxt
            // 
            this.Markatxt.Location = new System.Drawing.Point(87, 89);
            this.Markatxt.Name = "Markatxt";
            this.Markatxt.Size = new System.Drawing.Size(100, 20);
            this.Markatxt.TabIndex = 4;
            this.Markatxt.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(26, 63);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 13);
            this.label13.TabIndex = 15;
            this.label13.Text = "Kategori";
            // 
            // BarkodNotxt
            // 
            this.BarkodNotxt.Location = new System.Drawing.Point(87, 25);
            this.BarkodNotxt.Name = "BarkodNotxt";
            this.BarkodNotxt.Size = new System.Drawing.Size(100, 20);
            this.BarkodNotxt.TabIndex = 2;
            this.BarkodNotxt.TextChanged += new System.EventHandler(this.BarkodNotxt_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(14, 32);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 13);
            this.label14.TabIndex = 14;
            this.label14.Text = "Barkod No";
            // 
            // Kategoritxt
            // 
            this.Kategoritxt.Location = new System.Drawing.Point(87, 57);
            this.Kategoritxt.Name = "Kategoritxt";
            this.Kategoritxt.Size = new System.Drawing.Size(100, 20);
            this.Kategoritxt.TabIndex = 3;
            // 
            // AlisFiyatitxt
            // 
            this.AlisFiyatitxt.Location = new System.Drawing.Point(87, 185);
            this.AlisFiyatitxt.Name = "AlisFiyatitxt";
            this.AlisFiyatitxt.Size = new System.Drawing.Size(100, 20);
            this.AlisFiyatitxt.TabIndex = 7;
            // 
            // frmUrunEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(568, 397);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmUrunEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Ekleme Sayfası";
            this.Load += new System.EventHandler(this.frmUrunEkle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSatisFiyati;
        private System.Windows.Forms.TextBox txtAlisFiyati;
        private System.Windows.Forms.TextBox txtMiktari;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.TextBox txtBarkodNo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox BarkodNotxt;
        private System.Windows.Forms.TextBox Kategoritxt;
        private System.Windows.Forms.TextBox Markatxt;
        private System.Windows.Forms.TextBox UrunAditxt;
        private System.Windows.Forms.TextBox Miktartxt;
        private System.Windows.Forms.TextBox AlisFiyatitxt;
        private System.Windows.Forms.TextBox SatisFiyatitxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboMarka;
        private System.Windows.Forms.ComboBox comboKategori;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnYeniEkle;
        private System.Windows.Forms.Button btnVarOlanaEkle;
        private System.Windows.Forms.Label lblMiktari;
    }
}