using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace MY_Mini_Ağrı_Projesi
{
    public partial class Frmtarihce : Form
    {
        public Frmtarihce()
        {
            InitializeComponent();
        }
        SoundPlayer player = new SoundPlayer(Properties.Resources.Klasik_Muzik_Schubert_Ave_Maria_Opera);
        private void Frmtarihce_Load(object sender, EventArgs e)
        {
            webBrowser1.Dock = DockStyle.Fill;          // (1) Tam ekran
            webBrowser1.ScriptErrorsSuppressed = true;  // (2) Script hatalarını sustur
            webBrowser1.ScrollBarsEnabled = true;       // (3) Scroll aktif
            player.Play();
            axWindowsMediaPlayer1.settings.volume = 100;
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            webBrowser1.Document.Body.Style = "zoom:100%";
        }

        private void doğubeyazıtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://tr.wikipedia.org/wiki/Do%C4%9Fubayaz%C4%B1t");
        }

        private void merkezToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://tr.wikipedia.org/wiki/A%C4%9Fr%C4%B1");
        }

        private void patnosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://tr.wikipedia.org/wiki/Patnos");
        }

        private void diyadinToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://tr.wikipedia.org/wiki/Diyadin");
        }

        private void eleşkirtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://tr.wikipedia.org/wiki/Ele%C5%9Fkirt");
        }

        private void taşlıçayToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://tr.wikipedia.org/wiki/Ta%C5%9Fl%C4%B1%C3%A7ay");
        }

        private void tutakToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://tr.wikipedia.org/wiki/Tutak");
        }

        private void hamurToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://tr.wikipedia.org/wiki/Hamur,_A%C4%9Fr%C4%B1");
        }

        private void Frmtarihce_FormClosed(object sender, FormClosedEventArgs e)
        {
            player.Stop();
        }
    }
}
