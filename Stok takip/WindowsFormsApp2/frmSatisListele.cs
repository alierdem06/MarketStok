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
    public partial class frmSatisListele : Form
    {
        public frmSatisListele()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-7JAFR03\SQLEXPRESS;Initial Catalog=StokTakip;Integrated Security=True");
        DataSet daset = new DataSet();
        private void satışlistele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from satis", baglanti);
            adtr.Fill(daset, "satis");
            dataGridView1.DataSource = daset.Tables["satis"];
            
            baglanti.Close();

        }
        private void frmSatisListele_Load(object sender, EventArgs e)
        {
            satışlistele();
        }
    }
}

