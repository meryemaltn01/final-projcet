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

namespace QUIZZPROJE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        SqlConnection baglantı = new SqlConnection("Data Source=MERYY\\SQLEXPRES;Initial " +
            "Catalog=\"quizz veri tabanı\";Integrated Security=True;Persist Security Info=True;Replication=true;");

        private void buttn_giriş_Click(object sender, EventArgs e)
        {
            Form form = new Form2();
            form.Show();
            string kullaniciadi = textBox1.Text;// kullanıcı adı alanının textbox adı
            string şifre = textBox2.Text;
            if (string.IsNullOrEmpty(kullaniciadi) || string.IsNullOrEmpty(şifre))
            {

                MessageBox.Show("lütfen parolanızı girin");
                return;

            }
            // burada kullanıcı adı ve şifre doğrulaması yapabilirsiniz
            MessageBox.Show("giriş başarlı :" + şifre);


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //kullanıcdan alınan şifre
            string şifre = textBox2.Text;
            // şifre uzunluk
            if (şifre.Length > 6)
            {
                MessageBox.Show("şifre en az 6 karekteri olmalıdır.", "hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btn_baglantıAc_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            MessageBox.Show("veri tabanı ile c# arasındaki bağlantıyı kurduk ve bu bağlantıtı açtık");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglantı.Close();
            MessageBox.Show("veri tabanı ile c# arasındaki bağlantıyı kurduk ve bu bağlantıtı kapatık");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(baglantı.State .ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
