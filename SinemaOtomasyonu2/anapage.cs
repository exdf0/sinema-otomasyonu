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
    public partial class anapage : Form
    {
        SqlConnection bag = new SqlConnection("Data Source=DESKTOP-RTSGMFH;Initial Catalog=SinemaOtomasyonu;Integrated Security=True");
        public anapage()
        {
            InitializeComponent();
        }
        int filmSayisi = -1;
        int salonSayisi = -1;
        int seansSayisi = -1;
        int satisSayisi = -1;
        private void YonetimPaneli_Load(object sender, EventArgs e)
        {
           
            bag.Open();
            SqlCommand komut = new SqlCommand("select count(*) from film_bilgiler",bag);
            SqlCommand komut2 = new SqlCommand("select count(*) from salon_bilgileri", bag);
            SqlCommand komut3 = new SqlCommand("select count(*) from seans_bilgileri", bag);
            SqlCommand komut4 = new SqlCommand("select count(*) from satis_bilgileri", bag);
            filmSayisi = Convert.ToInt32(komut.ExecuteScalar());
            salonSayisi = Convert.ToInt32(komut2.ExecuteScalar());
            seansSayisi = Convert.ToInt32(komut3.ExecuteScalar());
            satisSayisi = Convert.ToInt32(komut4.ExecuteScalar());
            label4.Text = filmSayisi.ToString();
            label10.Text = salonSayisi.ToString();
            label13.Text = seansSayisi.ToString();
            label1.Text = satisSayisi.ToString();
            bag.Close();
            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
