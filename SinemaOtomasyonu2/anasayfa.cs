using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;

namespace SinemaOtomasyonu2
{
    public partial class anasayfa : Form
    {

        SqlConnection bag = new SqlConnection("Data Source=DESKTOP-RTSGMFH;Initial Catalog=SinemaOtomasyonu;Integrated Security=True");
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
    (
        int nLeftRect,
        int nTopRect,
        int nRightRect,
        int nBottomRect,
        int nWidthEllipse,
        int nHeightEllipse
    );
        public anasayfa()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = btnPanel.Height;
            pnlNav.Top = btnPanel.Top;
            pnlNav.Left = btnPanel.Left;
            btnPanel.BackColor = Color.FromArgb(46, 51, 73);

            lblPanelBaslik.Text = "Ana Sayfa";
            this.pnlFormYukleyici.Controls.Clear();
            anapage yonetimPage = new anapage() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            yonetimPage.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormYukleyici.Controls.Add(yonetimPage);
            yonetimPage.Show();
           
        }
        public string usernamefromlogin= " ";
        
        private void anasayfa_Load(object sender, EventArgs e)
        {
            label2.Text = usernamefromlogin;
        }

        private void btnPanel_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnPanel.Height;
            pnlNav.Top = btnPanel.Top;
            pnlNav.Left = btnPanel.Left;
            btnPanel.BackColor = Color.FromArgb(46, 51, 73);

            lblPanelBaslik.Text = "Yönetim Paneli";
            this.pnlFormYukleyici.Controls.Clear();
            anapage yonetimPage = new anapage() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            yonetimPage.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormYukleyici.Controls.Add(yonetimPage);
            yonetimPage.Show();



        }

      

        private void btnSalonlar_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnSatis.Height;
            pnlNav.Top = btnSatis.Top;
            pnlNav.Left = btnSatis.Left;
            btnSatis.BackColor = Color.FromArgb(46, 51, 73);
            lblPanelBaslik.Text = "Bilet Satış";
            this.pnlFormYukleyici.Controls.Clear();
            biletSatis biletsatis = new biletSatis() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            biletsatis.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormYukleyici.Controls.Add(biletsatis);
            biletsatis.Show();
        }

       

        private void btnFilmler_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnSalonEkle.Height;
            pnlNav.Top = btnSalonEkle.Top;
            pnlNav.Left = btnSalonEkle.Left;
            this.pnlFormYukleyici.Controls.Clear();
            btnSalonEkle.BackColor = Color.FromArgb(46, 51, 73);

            lblPanelBaslik.Text = "Salon Ekle";
            this.pnlFormYukleyici.Controls.Clear();
            salonekle salonekle = new salonekle() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            salonekle.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormYukleyici.Controls.Add(salonekle);
            salonekle.Show();
        }

        private void btnPanel_Leave(object sender, EventArgs e)
        {
            btnPanel.BackColor = Color.FromArgb(24, 30, 54);
        }

     

        private void btnFilmler_Leave(object sender, EventArgs e)
        {
            btnSalonEkle.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnSalonlar_Leave(object sender, EventArgs e)
        {
            btnSatis.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnAyarlar_Click(object sender, EventArgs e)
        {
      

          

        }

        private void btnSeansEkle_Leave(object sender, EventArgs e)
        {
            btnSeansEkle.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnFilmEkle_Leave(object sender, EventArgs e)
        {
            btnFilmEkle.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnSeansListe_Leave(object sender, EventArgs e)
        {
            btnSeansListe.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnAyarlar_Leave(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
      
        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            lblPanelBaslik.Text = "Yönetim Paneli";
            this.pnlFormYukleyici.Controls.Clear();
            anapage yonetimPage = new anapage() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            yonetimPage.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormYukleyici.Controls.Add(yonetimPage);
            yonetimPage.Show();
            pnlNav.Height = btnPanel.Height;
            pnlNav.Top = btnPanel.Top;
            pnlNav.Left = btnPanel.Left;
        }

        private void pnlFormYukleyici_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnFilmEkle_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnFilmEkle.Height;
            pnlNav.Top = btnFilmEkle.Top;
            pnlNav.Left = btnFilmEkle.Left;
            btnFilmEkle.BackColor = Color.FromArgb(46, 51, 73);
            lblPanelBaslik.Text = "Film Ekle";
            this.pnlFormYukleyici.Controls.Clear();
            Filmekle fimekle = new Filmekle() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            fimekle.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormYukleyici.Controls.Add(fimekle);
            fimekle.Show();
        }

        private void btnSeansEkle_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnSeansEkle.Height;
            pnlNav.Top = btnSeansEkle.Top;
            pnlNav.Left = btnSeansEkle.Left;
            btnSeansEkle.BackColor = Color.FromArgb(46, 51, 73);
            lblPanelBaslik.Text = "Seans Ekle";
            this.pnlFormYukleyici.Controls.Clear();
            Seansekle seansekle = new Seansekle() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            seansekle.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormYukleyici.Controls.Add(seansekle);
            seansekle.Show();
        }

        private void btnSeansListe_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnSeansListe.Height;
            pnlNav.Top = btnSeansListe.Top;
            pnlNav.Left = btnSeansListe.Left;
            btnSeansListe.BackColor = Color.FromArgb(46, 51, 73);
            lblPanelBaslik.Text = "Seans Listesi";
            this.pnlFormYukleyici.Controls.Clear();
            seansliste seansliste = new seansliste() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            seansliste.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormYukleyici.Controls.Add(seansliste);
            seansliste.Show();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnSeansListe.Height;
            pnlNav.Top = btnSatisListe.Top;
            pnlNav.Left = btnSatisListe.Left;
            btnSatisListe.BackColor = Color.FromArgb(46, 51, 73);
            lblPanelBaslik.Text = "Satış Listesi";
            this.pnlFormYukleyici.Controls.Clear();
            Satisliste satisliste = new Satisliste() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            satisliste.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormYukleyici.Controls.Add(satisliste);
            satisliste.Show();
        }

        private void biletSatis_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnSatis.Height;
            pnlNav.Top = btnSatis.Top;
            pnlNav.Left = btnSatis.Left;
            btnSatis.BackColor = Color.FromArgb(46, 51, 73);
            lblPanelBaslik.Text = "Bilet Satış";
            this.pnlFormYukleyici.Controls.Clear();
            biletSatis biletsatis = new biletSatis() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            biletsatis.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormYukleyici.Controls.Add(biletsatis);
            biletsatis.Show();
        }
    }
}
