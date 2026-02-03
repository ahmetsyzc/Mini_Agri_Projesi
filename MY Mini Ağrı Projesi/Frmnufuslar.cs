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

namespace MY_Mini_Ağrı_Projesi
{
    public partial class Frmnufuslar : Form
    {
        public Frmnufuslar()
        {
            InitializeComponent();
        }
        SqlConnection cnt = new SqlConnection("Data Source=DESKTOP-4QHAJ0K\\SQLEXPRESS;Initial Catalog=agriveriler;Integrated Security=True");
        private void showdatas(string data)
        {
            cnt.Open();
            SqlCommand cmd = new SqlCommand(data, cnt);
            SqlDataReader read = cmd.ExecuteReader();

            while (read.Read())
            {
                ListViewItem add = new ListViewItem();
                add.Text = read["yeradi"].ToString();
                add.SubItems.Add(read["nüfusu"].ToString());
                listView1.Items.Add(add);
            }
            cnt.Close();
        }
        private void Frmnufuslar_Load(object sender, EventArgs e)
        {
            showdatas("Select * From nufusbilgileri");

            progressBar1.Maximum = 499801;

            chart1.Series.Clear();
            chart1.Series.Add("Nüfus");
            chart1.Series["Nüfus"].Points.AddXY("Merkez", 150602);
            chart1.Series["Nüfus"].Points.AddXY("Doğubayazıt", 114769);
            chart1.Series["Nüfus"].Points.AddXY("Patnos", 109224);
            chart1.Series["Nüfus"].Points.AddXY("Diyadin", 36416);
            chart1.Series["Nüfus"].Points.AddXY("Eleşkirt", 28901);
            chart1.Series["Nüfus"].Points.AddXY("Tutak", 26776);
            chart1.Series["Nüfus"].Points.AddXY("Taşlıçay", 18152);
            chart1.Series["Nüfus"].Points.AddXY("Hamur", 14961);

            chart1.ChartAreas[0].AxisX.Title = "İlçeler";
            chart1.ChartAreas[0].AxisY.Title = "Nüfus";
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            double yuzde;
            if (treeView1.SelectedNode.Text == "Ağrı")
            {
                pictureBox1.Image = Properties.Resources.agriharitasi;
                progressBar1.Value = 499801;
            }
            else if (treeView1.SelectedNode.Text == "Merkez")
            {
                progressBar1.Value = 150602;
                pictureBox1.Image = Properties.Resources.agrimerkez_genel;
            }
            else if (treeView1.SelectedNode.Text == "Doğubeyazıt")
            {
                pictureBox1.Image = Properties.Resources.dogubeyazit_genel;
                progressBar1.Value = 114769;
            }
            else if (treeView1.SelectedNode.Text == "Patnos")
            {
                pictureBox1.Image = Properties.Resources.ptns_genel;
                progressBar1.Value = 109224;
            }
            else if (treeView1.SelectedNode.Text == "Diyadin")
            {
                pictureBox1.Image = Properties.Resources.diyadin_genel;
                progressBar1.Value = 36416;
            }
            else if (treeView1.SelectedNode.Text == "Eleşkirt")
            {
                pictureBox1.Image = Properties.Resources.elşkrt_genel;
                progressBar1.Value = 28901;
            }
            else if (treeView1.SelectedNode.Text == "Tutak")
            {
                pictureBox1.Image = Properties.Resources.ttk_genel;
                progressBar1.Value = 26776;
            }
            else if (treeView1.SelectedNode.Text == "Taşlıçay")
            {
                pictureBox1.Image = Properties.Resources.tşlçy_genel;
                progressBar1.Value = 18152;
            }
            else if (treeView1.SelectedNode.Text == "Hamur")
            {
                pictureBox1.Image = Properties.Resources.hmr_genel;
                progressBar1.Value = 14961;
            }
            yuzde = ((double)progressBar1.Value / progressBar1.Maximum) * 100;
            label1.Text = "%" + yuzde.ToString("N3");
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
                return;

            int satir = listView1.SelectedItems[0].Index;

            switch (satir)
            {
                case 0: // Toplam Nüfus
                    pictureBox1.Image = Properties.Resources.agriharitasi;
                    progressBar1.Value = 499801;
                    break;

                case 1: // Merkez
                    pictureBox1.Image = Properties.Resources.agrimerkez_genel;
                    progressBar1.Value = 150602;
                    break;

                case 2: // Doğubeyazıt
                    pictureBox1.Image = Properties.Resources.dogubeyazit_genel;
                    progressBar1.Value = 114769;
                    break;

                case 3: // Patnos
                    pictureBox1.Image = Properties.Resources.dogubeyazit_genel;
                    progressBar1.Value = 109224;
                    break;

                case 4: // Diyadin
                    pictureBox1.Image = Properties.Resources.diyadin_genel;
                    progressBar1.Value = 36416;
                    break;

                case 5: // Eleşkirt
                    pictureBox1.Image = Properties.Resources.elşkrt_genel;
                    progressBar1.Value = 28901;
                    break;

                case 6: // Tutak
                    pictureBox1.Image = Properties.Resources.ttk_genel;
                    progressBar1.Value = 26776;
                    break;

                case 7: // Taşlıçay
                    pictureBox1.Image = Properties.Resources.tşlçy_genel;
                    progressBar1.Value = 18152;
                    break;

                case 8: // Hamur
                    pictureBox1.Image = Properties.Resources.hmr_genel;
                    progressBar1.Value = 14961;
                    break;
            }

            double yuzde = ((double)progressBar1.Value / progressBar1.Maximum) * 100;
            label1.Text = "%" + yuzde.ToString("N3");
        }
    }
}
