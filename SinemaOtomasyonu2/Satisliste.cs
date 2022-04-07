using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SinemaOtomasyonu2
{
    
    public partial class Satisliste : Form
    {
        SqlConnection bag = new SqlConnection("Data Source=DESKTOP-RTSGMFH;Initial Catalog=SinemaOtomasyonu;Integrated Security=True");
        DataTable tablo = new DataTable();

        public Satisliste()
        {
            InitializeComponent();
        }
        private void SatisListesi(string sql)
        {
            bag.Open();
            SqlDataAdapter adtr = new SqlDataAdapter(sql, bag);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            bag.Close();

        }
        private void Satisliste_Load(object sender, EventArgs e)
        {
            tablo.Clear();

            SatisListesi("select * from satis_bilgileri");
            
        }

        private void ToplamUcretHesapla()
        {
            int ucrettoplami = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                ucrettoplami += Convert.ToInt32(dataGridView1.Rows[i].Cells["ucret"].Value);
            }
            label1.Text = " Toplam Satış " + ucrettoplami + "TL";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tablo.Clear();
            SatisListesi("select * from satis_bilgileri");
            ToplamUcretHesapla();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            tablo.Clear();
            SatisListesi("select * from satis_bilgileri where SatisTarihi like '"+dateTimePicker1.Text +"'");
            ToplamUcretHesapla();
        }
    }
}
