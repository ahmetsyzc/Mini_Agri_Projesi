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
using System.IO;

namespace MY_Mini_Ağrı_Projesi
{
    public partial class Frmilceler : Form
    {
        public Frmilceler()
        {
            InitializeComponent();
        }
        SqlConnection cnt = new SqlConnection("Data Source=DESKTOP-4QHAJ0K\\SQLEXPRESS;Initial Catalog=agriveriler;Integrated Security=True");
        private void showdatas(string info, DataGridView dgv)
        {
            SqlDataAdapter da = new SqlDataAdapter(info, cnt);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dgv.DataSource = ds.Tables[0];
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgv.AllowUserToAddRows = false;
        }

        private void Frmilceler_Load(object sender, EventArgs e)
        {
            showdatas("Select *from merkezkoyler", dataGridView1);
            richTextBox1.Text = Properties.Resources.merkeztarihi;
            label1.Text = "Toplam Köy: " + dataGridView1.Rows.Count.ToString();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            showdatas("Select *from merkezkoyler", dataGridView1);
            richTextBox1.Text = Properties.Resources.merkeztarihi;
            //richTextBox1.Text = File.ReadAllText(@"C:\Users\User\Desktop\Mini Ağrı Projesi Resimler\agritarihi.txt"); Önceden kullanılan yol
            label1.Text = "Toplam Köy: " + dataGridView1.Rows.Count.ToString();

            showdatas("Select *from dogubeyazitkoyler",dataGridView2);
            richTextBox2.Text = Properties.Resources.dogubeyazittarihi;
            label2.Text = "Toplam Köy: " + dataGridView2.Rows.Count.ToString();

            showdatas("Select *from patnoskoyler", dataGridView3);
            richTextBox3.Text = Properties.Resources.patnostarihi;
            label3.Text = "Toplam Köy: " + dataGridView3.Rows.Count.ToString();

            showdatas("Select *from diyadinkoyler", dataGridView4);
            richTextBox4.Text = Properties.Resources.diyadintarihi;
            label4.Text = "Toplam Köy: " + dataGridView4.Rows.Count.ToString();

            showdatas("Select *from eleskirtkoyler", dataGridView5);
            richTextBox5.Text = Properties.Resources.eleskirttarihi;
            label5.Text = "Toplam Köy: " + dataGridView5.Rows.Count.ToString();

            showdatas("Select *from taslicaykoyler", dataGridView6);
            richTextBox6.Text = Properties.Resources.taslicaytarihi;
            label6.Text = "Toplam Köy: " + dataGridView6.Rows.Count.ToString();

            showdatas("Select *from tutakkoyler", dataGridView7);
            richTextBox7.Text = Properties.Resources.tutaktarihi;
            label7.Text = "Toplam Köy: " + dataGridView7.Rows.Count.ToString();

            showdatas("Select *from hamurkoyler", dataGridView8);
            richTextBox8.Text = Properties.Resources.hamurtarihi;
            label8.Text = "Toplam Köy: " + dataGridView8.Rows.Count.ToString();
        }
    }
}
