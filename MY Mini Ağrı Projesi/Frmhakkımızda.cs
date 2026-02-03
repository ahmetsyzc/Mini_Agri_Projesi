using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MY_Mini_Ağrı_Projesi
{
    public partial class Frmhakkımızda : Form
    {
        public Frmhakkımızda()
        {
            InitializeComponent();
        }

        private void Frmhakkımızda_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = @"Hakkımızda

Atlas Ağrı Projesi, Ağrı ilini ve ilçelerini tanıtmak, kültürel değerlerini, yöresel lezzetlerini, tarihi mirasını ve gezilecek yerlerini kullanıcı dostu bir arayüzle sunmak amacıyla hazırlanmış bir masaüstü uygulamasıdır.Bu proje, hem yazılım geliştirme becerilerini pekiştirmek hem de yerel değerleri dijital ortama taşımak hedefiyle oluşturulmuştur.

Uygulama içerisinde ilçeler, nüfus bilgileri, yemekler, tarihi yapılar ve turistik mekânlar gibi başlıklar altında Ağrı’ya dair temel ve öğretici bilgiler yer almaktadır. Kullanıcıların kolayca gezinebileceği sade bir tasarım anlayışı benimsenmiş, görsellik ile bilginin dengeli şekilde sunulmasına özen gösterilmiştir.

Atlas Ağrı Projesi, bir öğrenci projesi olmasına rağmen, hem eğitim amaçlı hem de tanıtım değeri taşıyan bir çalışma olarak tasarlanmıştır. Amacımız; teknolojiyi kullanarak kültürel mirası görünür kılmak, yerel değerlerin unutulmamasına katkı sağlamak ve yazılım alanındaki gelişim sürecimize anlamlı bir içerik kazandırmaktır.

Çünkü bazen küçük bir proje, büyük bir farkındalığın başlangıcıdır. 🌄";
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
