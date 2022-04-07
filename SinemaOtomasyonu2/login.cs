using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SinemaOtomasyonu2
{
    public partial class login : Form
    {
        SqlConnection bag = new SqlConnection("Data Source=DESKTOP-RTSGMFH;Initial Catalog=SinemaOtomasyonu;Integrated Security=True");
        public login()
        {
            InitializeComponent();
           
        }

        private void login_Load(object sender, EventArgs e)
        {
            
        }
       
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var reply = MessageBox.Show("Çıkış yapmak istiyor musunuz?", "Çıkış talebinde bulundunuz", MessageBoxButtons.YesNo);
            DialogResult sonuc = reply;



            if (sonuc == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        bool isThere;
        private void button1_Click(object sender, EventArgs e)
        {

         
            string k_adi = textBox1.Text;
            string sifre = textBox2.Text;
            bag.Open();
            SqlCommand command = new SqlCommand("select * from admins",bag);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                if (k_adi==reader["k_adi"].ToString().TrimEnd() && sifre==reader["sifre"].ToString().TrimEnd())
                {
                    isThere = true;
                    break;
                }
                else
                {
                    isThere = false;
                }
            }

            bag.Close();

            if (isThere)
            {
                MessageBox.Show("Tekrardan hoşgeldin "+textBox1.Text+"!","Giriş Yapıldı");
                this.Hide();
               anasayfa test = new anasayfa();
                test.usernamefromlogin = textBox1.Text;
                
                test.Show();
            }
            else
            {
                MessageBox.Show("Girilen bilgilere ait bir kayıt bulunamadı!","Hata!");
            }
        }
    }
}
