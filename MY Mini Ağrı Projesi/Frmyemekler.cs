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
    public partial class Frmyemekler : Form
    {
        public Frmyemekler()
        {
            InitializeComponent();
        }
        SqlConnection cnt = new SqlConnection("Data Source=DESKTOP-4QHAJ0K\\SQLEXPRESS;Initial Catalog=agriveriler;Integrated Security=True");
        private void Frmyemekler_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_MouseClick(object sender, MouseEventArgs e)
        {
            comboBox1.Items.Clear();
            cnt.Open();
            SqlCommand cmd = new SqlCommand("Select * from yemekler ", cnt);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["yemekadlari"].ToString());
            }
            cnt.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            cnt.Open();
            SqlCommand cmd = new SqlCommand("Select * from yemekler where yemekadlari=@ad", cnt);
            cmd.Parameters.AddWithValue("@ad", comboBox1.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                richTextBox1.Text = dr["yemektarifleri"].ToString();
                label4.Text = dr["mekan"].ToString();
                //pictureBox1.ImageLocation = dr["resimyolu"].ToString(); //resimler sisteme gömülmeden önce bu şekilde alınıyordu
            }
            cnt.Close();

            string secim = comboBox1.Text.ToLower().Replace(" ","");
            pictureBox1.Image = (Image)Properties.Resources.ResourceManager.GetObject(secim);
        }
    }
}
