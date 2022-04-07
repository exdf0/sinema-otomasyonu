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
    public partial class salonekle : Form
    {
        SqlConnection bag = new SqlConnection("Data Source=DESKTOP-RTSGMFH;Initial Catalog=SinemaOtomasyonu;Integrated Security=True");
        public salonekle()
        {
            InitializeComponent();
        }

        private void salonekle_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bag.Open();
            string salonekle = "insert into Salon_Bilgileri(SalonAdi) values (@salonadi)";
            SqlCommand komut = new SqlCommand(salonekle, bag);
            if (textBox1.Text=="")
            {
                MessageBox.Show("Lütfen Salon Adı Giriniz!","Uyarı!");
            }
            else
            {


                try
                {
                    komut.Parameters.AddWithValue("@salonadi", textBox1.Text);
                    komut.ExecuteNonQuery();
                    
                    MessageBox.Show("Salon Eklendi","Kayıt");
                    textBox1.Clear();
                }
                catch (Exception)
                {

                    MessageBox.Show("Aynı salon daha önce eklenmiş!","Uyarı!");
                }
            }
            bag.Close();
        }
    }
}
