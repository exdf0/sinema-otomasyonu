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
    public partial class biletSatis : Form
    {
        SqlConnection bag = new SqlConnection("Data Source=DESKTOP-RTSGMFH;Initial Catalog=SinemaOtomasyonu;Integrated Security=True");
        public biletSatis()
        {
            InitializeComponent();
        }
        int sayac = 0;

        private void FilmveSalonGetir(ComboBox combo,string sql1,string sql2)
        {
            bag.Open();
            SqlCommand komut = new SqlCommand(sql1,bag);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                combo.Items.Add(read[sql2].ToString());

            }
            bag.Close();
        }
        private void combo_dolu_koltuklar()
        {
            comboBox9.Items.Clear();
            comboBox9.Text = "";
            foreach (Control item in groupBox3.Controls)
            {
                if (item is Button)
                {
                    if (item.BackColor==Color.Red)
                    {
                        comboBox9.Items.Add(item.Text);
                    }
                }
            }
        }

        private void vt_dolu_koltuklar()
        {
            bag.Open();
            SqlCommand komut = new SqlCommand("select * from satis_bilgileri where filmadi='"+comboBox1.Text+"' and salonadi= '"+comboBox2.Text+"'and tarih = '"+comboBox3.SelectedItem+"'and saat='"+comboBox4.SelectedItem+"'",bag);
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                foreach (Control item in groupBox3.Controls)
                {
                    if (item is Button)
                    {
                        if (reader["koltukno"].ToString()==item.Text)
                        {
                            item.BackColor = Color.Red;

                        }
                    }
                }
            }
            bag.Close();
        }
        private void yenidenRenklendir()
        {
            foreach (Control item in groupBox3.Controls)
            {
                if (item is Button)
                {
                    item.BackColor = Color.White;
                }
            }
        }
        private void FilmAfisiGoster()
        {
            bag.Open();
            SqlCommand komut = new SqlCommand("select * from film_bilgiler where filmadi='"+comboBox1.SelectedItem+"'", bag);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                pictureBox1.ImageLocation = read["resim"].ToString();
            }
            bag.Close();
        }
        private void biletSatis_Load(object sender, EventArgs e)
        {
            Bos_Koltuklar();
            FilmveSalonGetir(comboBox1,"select*from film_bilgiler","filmadi");
            FilmveSalonGetir(comboBox2, "select*from salon_bilgileri", "salonadi");
        }

        private void Bos_Koltuklar()
        {
            sayac = 1;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Button btn = new Button();
                    btn.Size = new Size(30, 30);
                    btn.BackColor = Color.White;
                    btn.Location = new Point(j * 30 + 20, i * 30 + 30);
                    btn.Name = sayac.ToString();
                    btn.Text = sayac.ToString();
                    if (j == 4)
                    {
                        continue;
                    }
                    sayac++;
                    this.groupBox3.Controls.Add(btn);
                    btn.Click += Btn_Click;
                }
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.BackColor==Color.White)
            {
                textBox1.Text = b.Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bag.Open();
            string filmekle = "insert into Satis_Bilgileri(KoltukNo,SalonAdi,FilmAdi,Tarih,Saat,Ad,Soyad,Ucret,SatisTarihi) values (@koltukno,@salonadi,@filmadi,@filmtarihi,@saat,@ad,@soyad,@ucret,@satistarihi)";
            SqlCommand komut = new SqlCommand(filmekle, bag);


            if (textBox1.Text != "")
            {
                try
                {
                    komut.Parameters.AddWithValue("@filmadi", comboBox1.Text);
                    komut.Parameters.AddWithValue("@salonadi", comboBox2.Text);
                    komut.Parameters.AddWithValue("@filmtarihi", comboBox3.Text);
                    komut.Parameters.AddWithValue("@saat", comboBox4.Text);
                    komut.Parameters.AddWithValue("@koltukno", textBox1.Text);
                    komut.Parameters.AddWithValue("@ad", textBox2.Text);
                    komut.Parameters.AddWithValue("@soyad", textBox3.Text);
                    komut.Parameters.AddWithValue("@ucret", comboBox8.Text);
                    komut.Parameters.AddWithValue("@satistarihi", DateTime.Now.ToString());
                    komut.ExecuteNonQuery();
                    foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text = "";
                

                    MessageBox.Show("Bilet Kesildi", "Kayıt");

                bag.Close();
                yenidenRenklendir();
                vt_dolu_koltuklar();
                combo_dolu_koltuklar();
            }
                catch (Exception)
                {

                    MessageBox.Show("hata", "hata");
                }
            }
            else
            {
                MessageBox.Show("Koltuk seçimi yapmadınız!!!", "Uyarı!");
            }
            bag.Close();
        }
        

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox4.Items.Clear();
            comboBox3.Items.Clear();
            comboBox4.Text = "";
            comboBox3.Text = "";
            foreach (Control item in groupBox3.Controls) if (item is TextBox) item.Text = "";
            FilmAfisiGoster();
            yenidenRenklendir();
            combo_dolu_koltuklar();
        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void Film_Tarihi_getir()
        {
            
            bag.Open();
            SqlCommand komut = new SqlCommand("select * from  seans_bilgileri where filmadi='"+comboBox1.SelectedItem+"' and salonadi='"+comboBox2.SelectedItem+"'",bag);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (DateTime.Parse(read["tarih"].ToString())>=DateTime.Parse(DateTime.Now.ToShortDateString()))
                {
                    if (!comboBox3.Items.Contains(read["tarih"].ToString()))
                    {
                        comboBox3.Items.Add(read["tarih"].ToString());
                    }
                   
                }
             
            }
            bag.Close();
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Film_Tarihi_getir();
        }
        private void Film_Seansi_Getir() {
            comboBox4.Text = "";
            comboBox4.Items.Clear();

            bag.Open();
            SqlCommand komut = new SqlCommand("select * from  seans_bilgileri where filmadi='" + comboBox1.SelectedItem + "' and salonadi='" + comboBox2.SelectedItem + "'and tarih='"+comboBox3.SelectedItem+"'", bag);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (DateTime.Parse(read["tarih"].ToString()) == DateTime.Parse(DateTime.Now.ToShortDateString()))
                {

                    if (DateTime.Parse(read["seans"].ToString())>DateTime.Parse(DateTime.Now.ToShortTimeString()))
                    {
                        comboBox4.Items.Add(read["seans"].ToString());

                    }

                }
               else  if (DateTime.Parse(read["tarih"].ToString()) > DateTime.Parse(DateTime.Now.ToShortDateString()))
                {
                    
                        comboBox4.Items.Add(read["seans"].ToString());
                    

                }

            }
            bag.Close();

        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            Film_Seansi_Getir();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            yenidenRenklendir();
            vt_dolu_koltuklar();
            combo_dolu_koltuklar();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            bag.Open();
            if (comboBox9.Text!="")
            {
                try
                {
                    SqlCommand verisil = new SqlCommand("delete from Satis_Bilgileri where filmadi='" + comboBox1.Text + "'and salonadi='" + comboBox2.Text + "'and tarih='" + comboBox3.SelectedItem + "'and saat='" + comboBox4.Text + "'and koltukno='" + comboBox9.Text + "'",bag);
                    verisil.ExecuteNonQuery();
                    bag.Close();
                    yenidenRenklendir();
                    vt_dolu_koltuklar();
                    combo_dolu_koltuklar();
                    
                }
                catch (Exception hata)
                {
                    MessageBox.Show("Hata oluştu!"+hata.Message, "Uyarı");
                    
                }
            }
            else
            {
                MessageBox.Show("Koltuk seçimi yapmadınız!", "Uyarı!");
            }
            
            bag.Close();
        }
    }
}
