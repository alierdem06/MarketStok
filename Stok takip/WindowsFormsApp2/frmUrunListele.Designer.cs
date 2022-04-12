namespace WindowsFormsApp2
{
    partial class frmUrunListele
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblMiktari = new System.Windows.Forms.Label();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.SatisFiyatitxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Miktaritxt = new System.Windows.Forms.TextBox();
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
            this.btnSil = new System.Windows.Forms.Button();
            this.txtBarkodNoAra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboKategori = new System.Windows.Forms.ComboBox();
            this.comboMarka = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMarkaGuncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(200, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(503, 258);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // lblMiktari
            // 
            this.lblMiktari.AutoSize = true;
            this.lblMiktari.Location = new System.Drawing.Point(25, 318);
            this.lblMiktari.Name = "lblMiktari";
            this.lblMiktari.Size = new System.Drawing.Size(0, 13);
            this.lblMiktari.TabIndex = 37;
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.BackColor = System.Drawing.Color.Lime;
            this.btnGüncelle.Location = new System.Drawing.Point(106, 308);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(75, 30);
            this.btnGüncelle.TabIndex = 23;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = false;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 276);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "Satış Fiyatı";
            // 
            // SatisFiyatitxt
            // 
            this.SatisFiyatitxt.Location = new System.Drawing.Point(81, 275);
            this.SatisFiyatitxt.Name = "SatisFiyatitxt";
            this.SatisFiyatitxt.Size = new System.Drawing.Size(100, 20);
            this.SatisFiyatitxt.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 245);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "Alış Fiyatı";
            // 
            // Miktaritxt
            // 
            this.Miktaritxt.Location = new System.Drawing.Point(81, 211);
            this.Miktaritxt.Name = "Miktaritxt";
            this.Miktaritxt.Size = new System.Drawing.Size(100, 20);
            this.Miktaritxt.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 214);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "Miktar";
            // 
            // UrunAditxt
            // 
            this.UrunAditxt.Location = new System.Drawing.Point(81, 179);
            this.UrunAditxt.Name = "UrunAditxt";
            this.UrunAditxt.Size = new System.Drawing.Size(100, 20);
            this.UrunAditxt.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 183);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 33;
            this.label11.Text = "Ürün Adı";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(29, 152);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 13);
            this.label12.TabIndex = 32;
            this.label12.Text = "Marka";
            // 
            // Markatxt
            // 
            this.Markatxt.Location = new System.Drawing.Point(81, 147);
            this.Markatxt.Name = "Markatxt";
            this.Markatxt.ReadOnly = true;
            this.Markatxt.Size = new System.Drawing.Size(100, 20);
            this.Markatxt.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 121);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 13);
            this.label13.TabIndex = 31;
            this.label13.Text = "Kategori";
            // 
            // BarkodNotxt
            // 
            this.BarkodNotxt.Location = new System.Drawing.Point(81, 83);
            this.BarkodNotxt.Name = "BarkodNotxt";
            this.BarkodNotxt.Size = new System.Drawing.Size(100, 20);
            this.BarkodNotxt.TabIndex = 22;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 90);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 13);
            this.label14.TabIndex = 30;
            this.label14.Text = "Barkod No";
            // 
            // Kategoritxt
            // 
            this.Kategoritxt.Location = new System.Drawing.Point(81, 115);
            this.Kategoritxt.Name = "Kategoritxt";
            this.Kategoritxt.ReadOnly = true;
            this.Kategoritxt.Size = new System.Drawing.Size(100, 20);
            this.Kategoritxt.TabIndex = 24;
            // 
            // AlisFiyatitxt
            // 
            this.AlisFiyatitxt.Location = new System.Drawing.Point(81, 243);
            this.AlisFiyatitxt.Name = "AlisFiyatitxt";
            this.AlisFiyatitxt.Size = new System.Drawing.Size(100, 20);
            this.AlisFiyatitxt.TabIndex = 28;
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Lime;
            this.btnSil.Location = new System.Drawing.Point(709, 77);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(64, 24);
            this.btnSil.TabIndex = 38;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // txtBarkodNoAra
            // 
            this.txtBarkodNoAra.BackColor = System.Drawing.Color.White;
            this.txtBarkodNoAra.Location = new System.Drawing.Point(408, 41);
            this.txtBarkodNoAra.Name = "txtBarkodNoAra";
            this.txtBarkodNoAra.Size = new System.Drawing.Size(100, 20);
            this.txtBarkodNoAra.TabIndex = 39;
            this.txtBarkodNoAra.TextChanged += new System.EventHandler(this.txtBarkodNoAra_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(302, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "BarkodNo ile arama";
            // 
            // comboKategori
            // 
            this.comboKategori.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboKategori.FormattingEnabled = true;
            this.comboKategori.Location = new System.Drawing.Point(329, 354);
            this.comboKategori.Name = "comboKategori";
            this.comboKategori.Size = new System.Drawing.Size(121, 21);
            this.comboKategori.TabIndex = 41;
            this.comboKategori.SelectedIndexChanged += new System.EventHandler(this.comboKategori_SelectedIndexChanged);
            // 
            // comboMarka
            // 
            this.comboMarka.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboMarka.FormattingEnabled = true;
            this.comboMarka.Location = new System.Drawing.Point(329, 388);
            this.comboMarka.Name = "comboMarka";
            this.comboMarka.Size = new System.Drawing.Size(121, 21);
            this.comboMarka.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(277, 357);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Kategori";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(286, 391);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "Marka";
            // 
            // btnMarkaGuncelle
            // 
            this.btnMarkaGuncelle.BackColor = System.Drawing.Color.Lime;
            this.btnMarkaGuncelle.Location = new System.Drawing.Point(469, 357);
            this.btnMarkaGuncelle.Name = "btnMarkaGuncelle";
            this.btnMarkaGuncelle.Size = new System.Drawing.Size(94, 48);
            this.btnMarkaGuncelle.TabIndex = 45;
            this.btnMarkaGuncelle.Text = "Marka Güncelle";
            this.btnMarkaGuncelle.UseVisualStyleBackColor = false;
            this.btnMarkaGuncelle.Click += new System.EventHandler(this.btnMarkaGuncelle_Click);
            // 
            // frmUrunListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMarkaGuncelle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboMarka);
            this.Controls.Add(this.comboKategori);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBarkodNoAra);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.lblMiktari);
            this.Controls.Add(this.btnGüncelle);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.SatisFiyatitxt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Miktaritxt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.UrunAditxt);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Markatxt);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.BarkodNotxt);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.Kategoritxt);
            this.Controls.Add(this.AlisFiyatitxt);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmUrunListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Listeleme Sayfası";
            this.Load += new System.EventHandler(this.frmUrunListele_Load);
            this.DoubleClick += new System.EventHandler(this.frmUrunListele_DoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblMiktari;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox SatisFiyatitxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Miktaritxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox UrunAditxt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Markatxt;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox BarkodNotxt;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox Kategoritxt;
        private System.Windows.Forms.TextBox AlisFiyatitxt;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.TextBox txtBarkodNoAra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboKategori;
        private System.Windows.Forms.ComboBox comboMarka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMarkaGuncelle;
    }
}