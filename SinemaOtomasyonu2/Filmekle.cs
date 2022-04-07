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
    public partial class Filmekle : Form
    {
        SqlConnection bag = new SqlConnection("Data Source=DESKTOP-RTSGMFH;Initial Catalog=SinemaOtomasyonu;Integrated Security=True");
        public Filmekle()
        {
            InitializeComponent();
        }

        private void Filmekle_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bag.Open();
            string filmekle = "insert into Film_Bilgiler(FilmAdi,Yonetmen,FilmTuru,FilmSuresi,tarih,YapimYili,Resim) values (@filmadi,@yonetmen,@filmturu,@filmsuresi,@tarih,@yapimyili,@resim)";
            SqlCommand komut = new SqlCommand(filmekle, bag);


            try
            {
                komut.Parameters.AddWithValue("@filmadi", textBox1.Text);
                komut.Parameters.AddWithValue("@yonetmen", textBox2.Text);
                komut.Parameters.AddWithValue("@filmturu", comboBox1.Text);
                komut.Parameters.AddWithValue("@filmsuresi", textBox4.Text);
                komut.Parameters.AddWithValue("@yapimyili", textBox5.Text);
                komut.Parameters.AddWithValue("@tarih", dateTimePicker1.Text);
                komut.Parameters.AddWithValue("@resim", pictureBox2.ImageLocation);
                komut.ExecuteNonQuery();

                MessageBox.Show("Film Eklendi", "Kayıt");
            }
            catch (Exception)
            {
                MessageBox.Show("Bu Film zaten kayıtlarda bulunuyor!", "Uyarı!");

            }
               
               
                   
                
            
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            {
                comboBox1.Text = "";
            }
            bag.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox2.ImageLocation = openFileDialog1.FileName;
        }
    }
}
