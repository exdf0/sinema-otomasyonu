
namespace SinemaOtomasyonu2
{
    partial class anasayfa
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSatisListe = new System.Windows.Forms.Button();
            this.btnSeansListe = new System.Windows.Forms.Button();
            this.btnSeansEkle = new System.Windows.Forms.Button();
            this.btnFilmEkle = new System.Windows.Forms.Button();
            this.btnSatis = new System.Windows.Forms.Button();
            this.btnSalonEkle = new System.Windows.Forms.Button();
            this.btnPanel = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.lblPanelBaslik = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.pnlFormYukleyici = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAnasayfa = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlFormYukleyici.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.btnSatisListe);
            this.panel1.Controls.Add(this.btnSeansListe);
            this.panel1.Controls.Add(this.btnSeansEkle);
            this.panel1.Controls.Add(this.btnFilmEkle);
            this.panel1.Controls.Add(this.btnSatis);
            this.panel1.Controls.Add(this.btnSalonEkle);
            this.panel1.Controls.Add(this.btnPanel);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 710);
            this.panel1.TabIndex = 0;
            // 
            // btnSatisListe
            // 
            this.btnSatisListe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSatisListe.FlatAppearance.BorderSize = 0;
            this.btnSatisListe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSatisListe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSatisListe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnSatisListe.Image = global::SinemaOtomasyonu2.Properties.Resources.icons8_group_of_companies_48;
            this.btnSatisListe.Location = new System.Drawing.Point(0, 597);
            this.btnSatisListe.Margin = new System.Windows.Forms.Padding(4);
            this.btnSatisListe.Name = "btnSatisListe";
            this.btnSatisListe.Size = new System.Drawing.Size(248, 64);
            this.btnSatisListe.TabIndex = 10;
            this.btnSatisListe.Text = "Sinema || Satış Listele";
            this.btnSatisListe.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSatisListe.UseVisualStyleBackColor = true;
            this.btnSatisListe.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSeansListe
            // 
            this.btnSeansListe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSeansListe.FlatAppearance.BorderSize = 0;
            this.btnSeansListe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeansListe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSeansListe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnSeansListe.Image = global::SinemaOtomasyonu2.Properties.Resources.icons8_group_of_companies_48;
            this.btnSeansListe.Location = new System.Drawing.Point(0, 527);
            this.btnSeansListe.Margin = new System.Windows.Forms.Padding(4);
            this.btnSeansListe.Name = "btnSeansListe";
            this.btnSeansListe.Size = new System.Drawing.Size(248, 70);
            this.btnSeansListe.TabIndex = 9;
            this.btnSeansListe.Text = "Sinema || Seans Listele";
            this.btnSeansListe.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSeansListe.UseVisualStyleBackColor = true;
            this.btnSeansListe.Click += new System.EventHandler(this.btnSeansListe_Click);
            this.btnSeansListe.Leave += new System.EventHandler(this.btnSeansListe_Leave);
            // 
            // btnSeansEkle
            // 
            this.btnSeansEkle.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSeansEkle.FlatAppearance.BorderSize = 0;
            this.btnSeansEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeansEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSeansEkle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnSeansEkle.Image = global::SinemaOtomasyonu2.Properties.Resources.icons8_group_of_companies_48;
            this.btnSeansEkle.Location = new System.Drawing.Point(0, 457);
            this.btnSeansEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnSeansEkle.Name = "btnSeansEkle";
            this.btnSeansEkle.Size = new System.Drawing.Size(248, 70);
            this.btnSeansEkle.TabIndex = 8;
            this.btnSeansEkle.Text = "Sinema || Seans Ekle";
            this.btnSeansEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSeansEkle.UseVisualStyleBackColor = true;
            this.btnSeansEkle.Click += new System.EventHandler(this.btnSeansEkle_Click);
            this.btnSeansEkle.Leave += new System.EventHandler(this.btnSeansEkle_Leave);
            // 
            // btnFilmEkle
            // 
            this.btnFilmEkle.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFilmEkle.FlatAppearance.BorderSize = 0;
            this.btnFilmEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilmEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFilmEkle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnFilmEkle.Image = global::SinemaOtomasyonu2.Properties.Resources.icons8_mockup_48;
            this.btnFilmEkle.Location = new System.Drawing.Point(0, 387);
            this.btnFilmEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnFilmEkle.Name = "btnFilmEkle";
            this.btnFilmEkle.Size = new System.Drawing.Size(248, 70);
            this.btnFilmEkle.TabIndex = 7;
            this.btnFilmEkle.Text = "Sinema || Film Ekle";
            this.btnFilmEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnFilmEkle.UseVisualStyleBackColor = true;
            this.btnFilmEkle.Click += new System.EventHandler(this.btnFilmEkle_Click);
            this.btnFilmEkle.Leave += new System.EventHandler(this.btnFilmEkle_Leave);
            // 
            // btnSatis
            // 
            this.btnSatis.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSatis.FlatAppearance.BorderSize = 0;
            this.btnSatis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSatis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSatis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnSatis.Image = global::SinemaOtomasyonu2.Properties.Resources.icons8_group_of_companies_48;
            this.btnSatis.Location = new System.Drawing.Point(0, 317);
            this.btnSatis.Margin = new System.Windows.Forms.Padding(4);
            this.btnSatis.Name = "btnSatis";
            this.btnSatis.Size = new System.Drawing.Size(248, 70);
            this.btnSatis.TabIndex = 5;
            this.btnSatis.Text = "Sinema || Bilet Satış";
            this.btnSatis.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSatis.UseVisualStyleBackColor = true;
            this.btnSatis.Click += new System.EventHandler(this.biletSatis_Click);
            this.btnSatis.Leave += new System.EventHandler(this.btnSalonlar_Leave);
            // 
            // btnSalonEkle
            // 
            this.btnSalonEkle.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSalonEkle.FlatAppearance.BorderSize = 0;
            this.btnSalonEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalonEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSalonEkle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnSalonEkle.Image = global::SinemaOtomasyonu2.Properties.Resources.icons8_mockup_48;
            this.btnSalonEkle.Location = new System.Drawing.Point(0, 247);
            this.btnSalonEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalonEkle.Name = "btnSalonEkle";
            this.btnSalonEkle.Size = new System.Drawing.Size(248, 70);
            this.btnSalonEkle.TabIndex = 4;
            this.btnSalonEkle.Text = "Sinema || Salon Ekle";
            this.btnSalonEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSalonEkle.UseVisualStyleBackColor = true;
            this.btnSalonEkle.Click += new System.EventHandler(this.btnFilmler_Click);
            this.btnSalonEkle.Leave += new System.EventHandler(this.btnFilmler_Leave);
            // 
            // btnPanel
            // 
            this.btnPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPanel.FlatAppearance.BorderSize = 0;
            this.btnPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnPanel.Image = global::SinemaOtomasyonu2.Properties.Resources.icons8_project_48;
            this.btnPanel.Location = new System.Drawing.Point(0, 177);
            this.btnPanel.Margin = new System.Windows.Forms.Padding(4);
            this.btnPanel.Name = "btnPanel";
            this.btnPanel.Size = new System.Drawing.Size(248, 70);
            this.btnPanel.TabIndex = 2;
            this.btnPanel.Text = "Gösterge Paneli";
            this.btnPanel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnPanel.UseVisualStyleBackColor = true;
            this.btnPanel.Click += new System.EventHandler(this.btnPanel_Click);
            this.btnPanel.Leave += new System.EventHandler(this.btnPanel_Leave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(248, 177);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.label2.Location = new System.Drawing.Point(96, 144);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "{k_adi}";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(43, 108);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Yetkili Personel";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SinemaOtomasyonu2.Properties.Resources.icons8_business_network_48;
            this.pictureBox1.Location = new System.Drawing.Point(80, 27);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.pnlNav.Location = new System.Drawing.Point(0, 238);
            this.pnlNav.Margin = new System.Windows.Forms.Padding(4);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(4, 123);
            this.pnlNav.TabIndex = 1;
            // 
            // lblPanelBaslik
            // 
            this.lblPanelBaslik.AutoSize = true;
            this.lblPanelBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPanelBaslik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lblPanelBaslik.Location = new System.Drawing.Point(256, 11);
            this.lblPanelBaslik.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPanelBaslik.Name = "lblPanelBaslik";
            this.lblPanelBaslik.Size = new System.Drawing.Size(264, 39);
            this.lblPanelBaslik.TabIndex = 2;
            this.lblPanelBaslik.Text = "Yönetim Paneli";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.textBox1.Location = new System.Drawing.Point(586, 18);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(389, 32);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Ara...";
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(983, 19);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 31);
            this.button1.TabIndex = 4;
            this.button1.Text = "Ara";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.label15.Location = new System.Drawing.Point(505, 596);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(502, 23);
            this.label15.TabIndex = 9;
            this.label15.Text = "ExDF(Hakan Arslan) Sinema Otomasyonu v1.0  Copyright © 2021";
            // 
            // pnlFormYukleyici
            // 
            this.pnlFormYukleyici.Controls.Add(this.label15);
            this.pnlFormYukleyici.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFormYukleyici.Location = new System.Drawing.Point(248, 82);
            this.pnlFormYukleyici.Name = "pnlFormYukleyici";
            this.pnlFormYukleyici.Size = new System.Drawing.Size(1020, 628);
            this.pnlFormYukleyici.TabIndex = 10;
            this.pnlFormYukleyici.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlFormYukleyici_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel3.Controls.Add(this.btnAnasayfa);
            this.panel3.Location = new System.Drawing.Point(1056, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(212, 100);
            this.panel3.TabIndex = 10;
            // 
            // btnAnasayfa
            // 
            this.btnAnasayfa.FlatAppearance.BorderSize = 0;
            this.btnAnasayfa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnasayfa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAnasayfa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnAnasayfa.Image = global::SinemaOtomasyonu2.Properties.Resources.icons8_group_of_companies_48;
            this.btnAnasayfa.Location = new System.Drawing.Point(-14, 0);
            this.btnAnasayfa.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnasayfa.Name = "btnAnasayfa";
            this.btnAnasayfa.Size = new System.Drawing.Size(248, 81);
            this.btnAnasayfa.TabIndex = 7;
            this.btnAnasayfa.Text = "Anasayfa";
            this.btnAnasayfa.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAnasayfa.UseVisualStyleBackColor = true;
            this.btnAnasayfa.Click += new System.EventHandler(this.btnAnasayfa_Click);
            // 
            // anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1268, 710);
            this.Controls.Add(this.pnlFormYukleyici);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblPanelBaslik);
            this.Controls.Add(this.pnlNav);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "anasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.anasayfa_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlFormYukleyici.ResumeLayout(false);
            this.pnlFormYukleyici.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSatis;
        private System.Windows.Forms.Button btnSalonEkle;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Label lblPanelBaslik;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel pnlFormYukleyici;
        private System.Windows.Forms.Button btnAnasayfa;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnFilmEkle;
        private System.Windows.Forms.Button btnSeansEkle;
        private System.Windows.Forms.Button btnSeansListe;
        private System.Windows.Forms.Button btnSatisListe;
    }
}

