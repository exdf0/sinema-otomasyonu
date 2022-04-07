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
    public partial class Seansekle : Form
    {
        SqlConnection bag = new SqlConnection("Data Source=DESKTOP-RTSGMFH;Initial Catalog=SinemaOtomasyonu;Integrated Security=True");
        public Seansekle()
        {
            InitializeComponent();
        }
        string seans = "";
        private void FilmveSalonGoster(ComboBox combo,string sql,string sql2)
        {
            bag.Open();
            SqlCommand komut = new SqlCommand(sql, bag);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read()==true)
            {
                combo.Items.Add(read[sql2].ToString()); 
            }
            bag.Close();
        }
        private void RadioButtonSeçiliyse()
        {
            if (radioButton1.Checked == true) seans = radioButton1.Text;  // if / else kullanarak hangi buton işaretliyse seansa o radyo butonunun değerini atadık
            else if (radioButton2.Checked == true) seans = radioButton2.Text;
            else if (radioButton3.Checked == true) seans = radioButton3.Text;
            else if (radioButton4.Checked == true) seans = radioButton4.Text;
            else if (radioButton5.Checked == true) seans = radioButton5.Text;
            else if (radioButton6.Checked == true) seans = radioButton6.Text;
            else if (radioButton7.Checked == true) seans = radioButton7.Text;
            else if (radioButton8.Checked == true) seans = radioButton8.Text;
            else if (radioButton9.Checked == true) seans = radioButton9.Text;
            else if (radioButton10.Checked == true) seans = radioButton10.Text;
            else if (radioButton11.Checked == true) seans = radioButton11.Text;
            else if (radioButton12.Checked == true) seans = radioButton12.Text;
        }
        private void Seansekle_Load(object sender, EventArgs e)
        {
            FilmveSalonGoster(comboBox1, "select * from film_bilgiler","filmadi"); // combobox1'e film isinlerini getirdik
            FilmveSalonGoster(comboBox2, "select * from salon_bilgileri", "salonadi"); // combobox2 ye salon isimlerini getirdik
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            RadioButtonSeçiliyse();
            if (seans!="")
            {
                bag.Open();


                string seansekle = "insert into Seans_Bilgileri(FilmAdi,SalonAdi,Tarih,Seans) values (@filmadi,@salonadi,@tarih,@seans)";
                SqlCommand komut = new SqlCommand(seansekle, bag);
                komut.Parameters.AddWithValue("@filmadi", comboBox1.Text);
                komut.Parameters.AddWithValue("@salonadi", comboBox2.Text);
                komut.Parameters.AddWithValue("@tarih", dateTimePicker1.Text);
                komut.Parameters.AddWithValue("@seans", seans);
                komut.ExecuteNonQuery();
                MessageBox.Show("Seans ekleme işlemi başarılı", "Kayıt");

                bag.Close();

            }
            else if (seans=="")
            {
                MessageBox.Show("Seans seçimi yapmadınız!!!", "Uyarı!");
            }
            comboBox1.Text = "";
            comboBox2.Text = "";
            dateTimePicker1.Text = DateTime.Now.ToShortDateString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            foreach (Control item3 in groupBox1.Controls)
            {
                item3.Enabled = true;
            }
            DateTime bugün = DateTime.Parse(DateTime.Now.ToShortDateString());
            DateTime yeni = DateTime.Parse(dateTimePicker1.Text);
            if (yeni==bugün)
            {
                foreach (Control item in groupBox1.Controls)
                {
                    if (DateTime.Parse(DateTime.Now.ToShortTimeString()) > DateTime.Parse(item.Text)) // radyo butonlar şuanki saatten küçükse pasif ediliyor
                    {
                        item.Enabled = false;
                    }
                }
                Tarihi_karsilastir();
            }
            else if (yeni>bugün)
            {
                Tarihi_karsilastir();
            }
            else if (yeni<bugün)
            {
                MessageBox.Show("Geriye dönük işlem yapılamaz!!!","Uyarı!");
                dateTimePicker1.Text = DateTime.Now.ToShortDateString();
            }
        }

        private void Tarihi_karsilastir()
        {
            bag.Open();
            SqlCommand komut = new SqlCommand("select * from seans_bilgileri where salonadi='" + comboBox2.Text + "'and tarih='" + dateTimePicker1.Text + "'", bag);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read() == true)
            {
                foreach (Control item2 in groupBox1.Controls)
                {
                    if (read["seans"].ToString() == item2.Text)
                    {
                        item2.Enabled = false;
                    }
                }
            }
            bag.Close();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
