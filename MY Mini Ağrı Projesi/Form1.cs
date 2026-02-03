using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace MY_Mini_Ağrı_Projesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frmilceler ilceler = new Frmilceler();
            ilceler.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frmyemekler yemekler = new Frmyemekler();
            yemekler.Show();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            Frmtarihce tarihce = new Frmtarihce();
            tarihce.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Uygulama Kapatıldı İyi Günler");
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                // 2. Butonlar için Ultra Saydam Efekt
                if (c is Button)
                {
                    Button btn = (Button)c;

                    // Çok düşük opaklık (40), sadece hafif bir cam parlaması verir
                    btn.BackColor = Color.Transparent; //FromArgb(0, 255, 255, 255);
                    btn.ForeColor = Color.White; // Yazılar beyaz kalsın

                    // Tasarımdaki o ince çizgiler için:
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 1;
                    btn.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255); // Kenarlıklar yarı saydam beyaz

                    // Mouse ile üzerine gelince belirginleşsin
                    btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(80, 255, 255, 255);
                }

                // 3. Labelları (Başlık ve Saat) Beyaz Yap
                else if (c is Label)
                {
                    c.BackColor = Color.Transparent;
                    c.ForeColor = Color.Black;

                    // Yazı tipini biraz kalınlaştırmak okunurluğu artırır
                    c.Font = new Font(c.Font.FontFamily, c.Font.Size, FontStyle.Bold);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
            label3.Text = DateTime.Now.ToString("dddd", new CultureInfo("tr-TR"));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Frmnufuslar frm = new Frmnufuslar();
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Frmgezilecekyerler frm = new Frmgezilecekyerler();
            frm.Show();
        }

        private void tamekranToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.WindowState = FormWindowState.Normal;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.FormBorderStyle = FormBorderStyle.Sizable;
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Frmhakkımızda frm = new Frmhakkımızda();
            frm.Show();
        }

        private void hakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmhakkımızda frm = new Frmhakkımızda();
            frm.Show();
        }

        private void yenileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void koyuModToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.geceagridagi;
            this.BackgroundImageLayout = ImageLayout.Stretch;

            this.BackColor = Color.FromArgb(20, 20, 30); // Gece mavisi/siyah tonu

            foreach (Control c in this.Controls)
            {
                if (c is Button)
                {
                    Button btn = (Button)c;
                    btn.BackColor = Color.FromArgb(0, 30, 30, 50); // Yarı saydam koyu mavi
                    btn.ForeColor = Color.White;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 1;
                    btn.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255); //LightSteelBlue; // Geceye uygun kenarlık
                }
                else if (c is Label)
                {
                    c.BackColor = Color.Transparent;
                    c.ForeColor = Color.Snow;
                }
            }
        }

        private void saydamModToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.sabahagridagi;
            this.BackgroundImageLayout = ImageLayout.Stretch;

            this.ForeColor = Color.FromArgb(45, 45, 45);

            foreach (Control c in this.Controls)
            {
                // 2. Butonlar için Ultra Saydam Efekt
                if (c is Button)
                {
                    Button btn = (Button)c;

                    // Çok düşük opaklık (40), sadece hafif bir cam parlaması verir
                    btn.BackColor = Color.FromArgb(0, 255, 255, 255);
                    btn.ForeColor = Color.White; // Yazılar beyaz kalsın

                    // Tasarımdaki o ince çizgiler için:
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 1;
                    btn.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255); // Kenarlıklar yarı saydam beyaz

                    // Mouse ile üzerine gelince belirginleşsin
                    btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(80, 255, 255, 255);
                }

                // 3. Labelları (Başlık ve Saat) Beyaz Yap
                else if (c is Label)
                {
                    c.BackColor = Color.Transparent;
                    c.ForeColor = Color.Black;

                    // Yazı tipini biraz kalınlaştırmak okunurluğu artırır
                    c.Font = new Font(c.Font.FontFamily, c.Font.Size, FontStyle.Bold);
                }
            }
        }
    }
}
