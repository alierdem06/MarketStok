using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class frmUrunEkle : Form
    {
        public frmUrunEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-7JAFR03\SQLEXPRESS;Initial Catalog=StokTakip;Integrated Security=True");
        bool durum;
        private void barkodkontrol()
        {
            durum = true;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from urun", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (BarkodNotxt.Text==read["barkodno"].ToString() || txtBarkodNo.Text == "") 
                { 

                    durum = false;
                }
            }
            baglanti.Close();
        }
     
        private void kategorigetir()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from kategoribilgileri", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboKategori.Items.Add(read["kategori"].ToString());

            }
            baglanti.Close();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnYeniEkle_Click(object sender, EventArgs e)
        {
            barkodkontrol();
            if (durum==true)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into urun(barkodno,kategori,marka,urunadi,miktari,alisfiyati,satisfiyati,tarih) values(@barkodno,@kategori,@marka,@urunadi,@miktari,@alisfiyati,@satisfiyati,@tarih)", baglanti);
                komut.Parameters.AddWithValue("@barkodno", txtBarkodNo.Text);
                komut.Parameters.AddWithValue("@kategori", comboKategori.Text);
                komut.Parameters.AddWithValue("@marka", comboMarka.Text);
                komut.Parameters.AddWithValue("@urunadi", txtUrunAdi.Text);
                komut.Parameters.AddWithValue("@miktari", int.Parse(txtMiktari.Text));
                komut.Parameters.AddWithValue("@alisfiyati", double.Parse(txtAlisFiyati.Text));
                komut.Parameters.AddWithValue("@satisfiyati", double.Parse(txtSatisFiyati.Text));
                komut.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());

                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Ürün Eklendi");
            }
            else
            {
                MessageBox.Show("Böyle bir barkodno var","UYARI!");
            }
            
            comboMarka.Items.Clear();
            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
                if (item is ComboBox)
                {
                    item.Text = "";
                }

            }


        }

        private void frmUrunEkle_Load(object sender, EventArgs e)
        {
            kategorigetir();
        }

        private void comboKategori_SelectedIndexChanged(object sender, EventArgs e)
        {

            comboMarka.Items.Clear();
            comboMarka.Text = "";

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from markabilgileri where kategori='"+comboKategori.SelectedItem+"'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboMarka.Items.Add(read["marka"].ToString());

            }
            baglanti.Close();



        }

        private void BarkodNotxt_TextChanged(object sender, EventArgs e)
        {
            if (BarkodNotxt.Text=="")
            {
                lblMiktari.Text = "";
                foreach (Control item in groupBox2.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }

                }
            }



            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from urun where barkodno like '"+BarkodNotxt.Text+"'",baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {

                Kategoritxt.Text = read["kategori"].ToString();
                Markatxt.Text = read["marka"].ToString();
                UrunAditxt.Text = read["urunadi"].ToString();
                lblMiktari.Text = read["miktari"].ToString();
                AlisFiyatitxt.Text = read["alisfiyati"].ToString();
                SatisFiyatitxt.Text = read["satisfiyati"].ToString();
               

            }
            baglanti.Close();

        }

        private void btnVarOlanaEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update urun set miktari=miktari+'"+int.Parse(Miktartxt.Text)+"' where barkodno='"+BarkodNotxt.Text+"' ",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            foreach (Control item in groupBox2.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }

            }

            MessageBox.Show("Var Olan Ürüne Ekleme Yapıldı");

        }

        private void comboMarka_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
