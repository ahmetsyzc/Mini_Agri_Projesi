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
    public partial class Frmgezilecekyerler : Form
    {
        public Frmgezilecekyerler()
        {
            InitializeComponent();
        }
        SqlConnection cnt = new SqlConnection("Data Source=DESKTOP-4QHAJ0K\\SQLEXPRESS;Initial Catalog=agriveriler;Integrated Security=True");
        private void showdatas(string name, string pname)
        {
            cnt.Open();
            SqlCommand cmd = new SqlCommand("Select * from gezilecekyerler where yeradi=@ad", cnt);
            cmd.Parameters.AddWithValue("@ad", name);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                richTextBox1.Text = dr["tarihi"].ToString();
            }
            cnt.Close();

            pictureBox1.Image = (Image)Properties.Resources.ResourceManager.GetObject(pname);

            //Resimler sisteme gömülmeden önce bu yollarla klasörden alınıyordu
            //yol 1
            //pictureBox1.Image = Image.FromFile(@"C:\Users\User\Desktop\Mini Ağrı Projesi Resimler\"+pname+ ".png");
            //yol 2
            //string yol = Path.Combine(
            //@"C:\Users\User\Desktop\Mini Ağrı Projesi Resimler",
            //pname + ".png"
            //);
            //if (File.Exists(yol))
            //{
            //    pictureBox1.Image = Image.FromFile(yol);
            //}
            //else
            //{
            //    MessageBox.Show("Resim bulunamadı:\n" + yol);
            //}
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            showdatas(radioButton1.Text, "agridagi");
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            showdatas(radioButton2.Text, "meteorcukuru");
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            showdatas(radioButton3.Text, "nuhungemisi");
        }
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            showdatas(radioButton4.Text, "balıkgolu");
        }
        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            showdatas(radioButton5.Text, "diyadinkaplicalari");
        }
        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            showdatas(radioButton6.Text, "ishakpasasarayi");
        }
        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            showdatas(radioButton7.Text, "tendüreklavakintilari");
        }
    }
}
