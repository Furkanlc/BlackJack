using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuratYücedağBlackJack21Oyunu3.deneme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rastgele = new Random();
        int sayac = 0;
        int oyuncupuan = 0;
        int bilgisayarpuan = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            sayac++;
            if (sayac == 1)
            {

                int a1, a2, toplam;
                a1 = rastgele.Next(1, 11);
                a2 = rastgele.Next(1, 11);
                toplam = a1 + a2;

                label1.Text = a1.ToString();
                label2.Text = a2.ToString();
                label10.Text = toplam.ToString();
            }
            if (sayac == 2)
            {
                int a3, toplam;
                a3 = rastgele.Next(1, 11);
                label3.Text = a3.ToString();
                toplam = Convert.ToInt32(label1.Text) + Convert.ToInt32(label2.Text) + a3;
                label10.Text = toplam.ToString();
            }
            if (sayac == 3)
            {
                int a4, toplam;
                a4 = rastgele.Next(1, 11);
                label4.Text = a4.ToString();

                toplam = Convert.ToInt32(label1.Text) + Convert.ToInt32(label2.Text) + Convert.ToInt32(label3.Text) + a4;
                label10.Text = toplam.ToString();
            }
            //label1 pixturebox1 resimleri
            if (label1.Text == "1")
            {
                pictureBox1.ImageLocation = "C:\\Users\\Mostar\\Desktop\\iskambil\\1.jpg";
            }
            if (label1.Text == "2")
            {
                pictureBox1.ImageLocation = "C:\\Users\\Mostar\\Desktop\\iskambil\\2.png";
            }
            if (label1.Text == "3")
            {
                pictureBox1.ImageLocation = "C:\\Users\\Mostar\\Desktop\\iskambil\\3.png";
            }
            if (label1.Text == "4")
            {
                pictureBox1.ImageLocation = "C:\\Users\\Mostar\\Desktop\\iskambil\\4.png";
            }
            if (label1.Text == "5")
            {
                pictureBox1.ImageLocation = "C:\\Users\\Mostar\\Desktop\\iskambil\\5.png";
            }
            if (label1.Text == "6")
            {
                pictureBox1.ImageLocation = "C:\\Users\\Mostar\\Desktop\\iskambil\\6.png";
            }
            if (label1.Text == "7")
            {
                pictureBox1.ImageLocation = "C:\\Users\\Mostar\\Desktop\\iskambil\\7.png";
            }
            if (label1.Text == "8")
            {
                pictureBox1.ImageLocation = "C:\\Users\\Mostar\\Desktop\\iskambil\\8.png";
            }
            if (label1.Text == "9")
            {
                pictureBox1.ImageLocation = "C:\\Users\\Mostar\\Desktop\\iskambil\\9.png";
            }
            if (label1.Text == "10")
            {
                pictureBox1.ImageLocation = "C:\\Users\\Mostar\\Desktop\\iskambil\\10.png";
            }
            //labe2 piturebox2 resim degişiyor 

            if (label2.Text == "1")
            {
                pictureBox2.ImageLocation = "C:\\Users\\Mostar\\Desktop\\iskambil\\1.jpg";
            }
            if (label2.Text == "2")
            {
                pictureBox2.ImageLocation = "C:\\Users\\Mostar\\Desktop\\iskambil\\2.png";
            }
            if (label2.Text == "3")
            {
                pictureBox2.ImageLocation = "C:\\Users\\Mostar\\Desktop\\iskambil\\3.png";
            }
            if (label2.Text == "4")
            {
                pictureBox2.ImageLocation = "C:\\Users\\Mostar\\Desktop\\iskambil\\4.png";
            }
            if (label2.Text == "5")
            {
                pictureBox2.ImageLocation = "C:\\Users\\Mostar\\Desktop\\iskambil\\5.png";
            }
            if (label2.Text == "6")
            {
                pictureBox2.ImageLocation = "C:\\Users\\Mostar\\Desktop\\iskambil\\6.png";
            }
            if (label2.Text == "7")
            {
                pictureBox2.ImageLocation = "C:\\Users\\Mostar\\Desktop\\iskambil\\7.png";
            }
            if (label2.Text == "8")
            {
                pictureBox2.ImageLocation = "C:\\Users\\Mostar\\Desktop\\iskambil\\8.png";
            }
            if (label2.Text == "9")
            {
                pictureBox2.ImageLocation = "C:\\Users\\Mostar\\Desktop\\iskambil\\9.png";
            }
            if (label2.Text == "10")
            {
                pictureBox2.ImageLocation = "C:\\Users\\Mostar\\Desktop\\iskambil\\J.png";
            }
            //label3 picturebox3 resimleri geliyor
            if (label3.Text == "1")
            {
                pictureBox3.ImageLocation = "C:\\Users\\Mostar\\Desktop\\iskambil\\1.jpg";
            }
            if (label3.Text == "2")
            {
                pictureBox3.ImageLocation = "C:\\Users\\Mostar\\Desktop\\iskambil\\2.png";
            }
            if (label3.Text == "3")
            {
                pictureBox3.ImageLocation = "C:\\Users\\Mostar\\Desktop\\iskambil\\3.png";
            }
            if (label3.Text == "4")
            {
                pictureBox3.ImageLocation = "C:\\Users\\Mostar\\Desktop\\iskambil\\4.png";
            }
            if (label3.Text == "5")
            {
                pictureBox3.ImageLocation = "C:\\Users\\Mostar\\Desktop\\iskambil\\5.png";
            }
            if (label3.Text == "6")
            {
                pictureBox3.ImageLocation = "C:\\Users\\Mostar\\Desktop\\iskambil\\6.png";
            }
            if (label3.Text == "7")
            {
                pictureBox3.ImageLocation = "C:\\Users\\Mostar\\Desktop\\iskambil\\7.png";
            }
            if (label3.Text == "8")
            {
                pictureBox3.ImageLocation = "C:\\Users\\Mostar\\Desktop\\iskambil\\8.png";
            }
            if (label3.Text == "9")
            {
                pictureBox3.ImageLocation = "C:\\Users\\Mostar\\Desktop\\iskambil\\9.png";
            }
            if (label3.Text == "10")
            {
                pictureBox3.ImageLocation = "C:\\Users\\Mostar\\Desktop\\iskambil\\O.png";
            }
            // label4 picturebox4 resimleri geliyor
            if (label4.Text == "1")
            {
                pictureBox4.ImageLocation = "C:\\Users\\Mostar\\Desktop\\iskambil\\1.jpg";
            }
            if (label4.Text == "2")
            {
                pictureBox4.ImageLocation = "C:\\Users\\Mostar\\Desktop\\iskambil\\2.png";
            }
            if (label4.Text == "3")
            {
                pictureBox4.ImageLocation = "C:\\Users\\Mostar\\Desktop\\iskambil\\3.png";
            }
            if (label4.Text == "4")
            {
                pictureBox4.ImageLocation = "C:\\Users\\Mostar\\Desktop\\iskambil\\4.png";
            }
            if (label4.Text == "5")
            {
                pictureBox4.ImageLocation = "C:\\Users\\Mostar\\Desktop\\iskambil\\5.png";
            }
            if (label4.Text == "6")
            {
                pictureBox4.ImageLocation = "C:\\Users\\Mostar\\Desktop\\iskambil\\6.png";
            }
            if (label4.Text == "7")
            {
                pictureBox4.ImageLocation = "C:\\Users\\Mostar\\Desktop\\iskambil\\7.png";
            }
            if (label4.Text == "8")
            {
                pictureBox4.ImageLocation = "C:\\Users\\Mostar\\Desktop\\iskambil\\8.png";
            }
            if (label4.Text == "9")
            {
                pictureBox4.ImageLocation = "C:\\Users\\Mostar\\Desktop\\iskambil\\9.png";
            }
            if (label4.Text == "10")
            {
                pictureBox4.ImageLocation = "C:\\Users\\Mostar\\Desktop\\iskambil\\K.png";
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            int b1, b2, toplam;
            b1 = rastgele.Next(1, 11);
            b2 = rastgele.Next(1, 11);
            toplam = b1 + b2;

            label5.Text = b1.ToString();
            label6.Text = b2.ToString();
            label11.Text = toplam.ToString();

            if (toplam < 16)
            {
                int b3;
                b3 = rastgele.Next(1, 11);
                label7.Text = b3.ToString();

                toplam = toplam + b3;
                label11.Text = toplam.ToString();
            }
            if (toplam < 16)
            {
                int b4;
                b4 = rastgele.Next(1, 11);
                label8.Text = b4.ToString();
                toplam = toplam + b4;
                label11.Text = toplam.ToString();
            }
            //label 5 picturebox5 resimleri
            if (label5.Text == "1")
            {
                pictureBox5.ImageLocation = "C:\\Users\\Mostar\\Desktop\\iskambil\\1.jpg";
            }
            if (label5.Text == "2")
            {
                pictureBox5.ImageLocation = "C:\\Users\\Mostar\\Desktop\\iskambil\\2.png";
            }
            if (label5.Text == "3")
            {
                pictureBox5.ImageLocation = "C:\\Users\\Mostar\\Desktop\\iskambil\\3.png";
            }
            if (label5.Text == "4")
            {
                pictureBox5.ImageLocation = "C:\\Users\\Mostar\\Desktop\\iskambil\\4.png";
            }
            if (label5.Text == "5")
            {
                pictureBox5.ImageLocation = "C:\\Users\\Mostar\\Desktop\\iskambil\\5.png";
            }
            if (label5.Text == "6")
            {
                pictureBox5.ImageLocation = "C:\\Users\\Mostar\\Desktop\\iskambil\\6.png";
            }
            if (label5.Text == "7")
            {
                pictureBox5.ImageLocation = "C:\\Users\\Mostar\\Desktop\\iskambil\\7.png";
            }
            if (label5.Text == "8")
            {
                pictureBox5.ImageLocation = "C:\\Users\\Mostar\\Desktop\\iskambil\\8.png";
            }
            if (label5.Text == "9")
            {
                pictureBox5.ImageLocation = "C:\\Users\\Mostar\\Desktop\\iskambil\\9.png";
            }
            if (label5.Text == "10")
            {
                pictureBox5.ImageLocation = "C:\\Users\\Mostar\\Desktop\\iskambil\\K.png";
            }
            //label6 picturebox6 resimleri
            if (label6.Text == "1")
            {
                pictureBox6.ImageLocation = "C:\\Users\\Mostar\\Desktop\\iskambil\\1.jpg";
            }
            if (label6.Text == "2")
            {
                pictureBox6.ImageLocation = "C:\\Users\\Mostar\\Desktop\\iskambil\\2.png";
            }
            if (label6.Text == "3")
            {
                pictureBox6.ImageLocation = "C:\\Users\\Mostar\\Desktop\\iskambil\\3.png";
            }
            if (label6.Text == "4")
            {
                pictureBox6.ImageLocation = "C:\\Users\\Mostar\\Desktop\\iskambil\\4.png";
            }
            if (label6.Text == "5")
            {
                pictureBox6.ImageLocation = "C:\\Users\\Mostar\\Desktop\\iskambil\\5.png";
            }
            if (label6.Text == "6")
            {
                pictureBox6.ImageLocation = "C:\\Users\\Mostar\\Desktop\\iskambil\\6.png";
            }
            if (label6.Text == "7")
            {
                pictureBox6.ImageLocation = "C:\\Users\\Mostar\\Desktop\\iskambil\\7.png";
            }
            if (label6.Text == "8")
            {
                pictureBox6.ImageLocation = "C:\\Users\\Mostar\\Desktop\\iskambil\\8.png";
            }
            if (label6.Text == "9")
            {
                pictureBox6.ImageLocation = "C:\\Users\\Mostar\\Desktop\\iskambil\\9.png";
            }
            if (label6.Text == "10")
            {
                pictureBox6.ImageLocation = "C:\\Users\\Mostar\\Desktop\\iskambil\\K.png";
            }
            //label7 picturebox6 resimleri
            if (label7.Text == "1")
            {
                pictureBox7.ImageLocation = "C:\\Users\\Mostar\\Desktop\\iskambil\\1.jpg";
            }
            if (label7.Text == "2")
            {
                pictureBox7.ImageLocation = "C:\\Users\\Mostar\\Desktop\\iskambil\\2.png";
            }
            if (label7.Text == "3")
            {
                pictureBox7.ImageLocation = "C:\\Users\\Mostar\\Desktop\\iskambil\\3.png";
            }
            if (label7.Text == "4")
            {
                pictureBox7.ImageLocation = "C:\\Users\\Mostar\\Desktop\\iskambil\\4.png";
            }
            if (label7.Text == "5")
            {
                pictureBox7.ImageLocation = "C:\\Users\\Mostar\\Desktop\\iskambil\\5.png";
            }
            if (label7.Text == "6")
            {
                pictureBox7.ImageLocation = "C:\\Users\\Mostar\\Desktop\\iskambil\\6.png";
            }
            if (label7.Text == "7")
            {
                pictureBox7.ImageLocation = "C:\\Users\\Mostar\\Desktop\\iskambil\\7.png";
            }
            if (label7.Text == "8")
            {
                pictureBox7.ImageLocation = "C:\\Users\\Mostar\\Desktop\\iskambil\\8.png";
            }
            if (label7.Text == "9")
            {
                pictureBox7.ImageLocation = "C:\\Users\\Mostar\\Desktop\\iskambil\\9.png";
            }
            if (label7.Text == "10")
            {
                pictureBox7.ImageLocation = "C:\\Users\\Mostar\\Desktop\\iskambil\\K.png";
            }
            //label8 picturebox8 resimleri
            if (label8.Text == "1")
            {
                pictureBox8.ImageLocation = "C:\\Users\\Mostar\\Desktop\\iskambil\\1.jpg";
            }
            if (label8.Text == "2")
            {
                pictureBox8.ImageLocation = "C:\\Users\\Mostar\\Desktop\\iskambil\\2.png";
            }
            if (label8.Text == "3")
            {
                pictureBox8.ImageLocation = "C:\\Users\\Mostar\\Desktop\\iskambil\\3.png";
            }
            if (label8.Text == "4")
            {
                pictureBox8.ImageLocation = "C:\\Users\\Mostar\\Desktop\\iskambil\\4.png";
            }
            if (label8.Text == "5")
            {
                pictureBox8.ImageLocation = "C:\\Users\\Mostar\\Desktop\\iskambil\\5.png";
            }
            if (label8.Text == "6")
            {
                pictureBox8.ImageLocation = "C:\\Users\\Mostar\\Desktop\\iskambil\\6.png";
            }
            if (label8.Text == "7")
            {
                pictureBox8.ImageLocation = "C:\\Users\\Mostar\\Desktop\\iskambil\\7.png";
            }
            if (label8.Text == "8")
            {
                pictureBox8.ImageLocation = "C:\\Users\\Mostar\\Desktop\\iskambil\\8.png";
            }
            if (label8.Text == "9")
            {
                pictureBox8.ImageLocation = "C:\\Users\\Mostar\\Desktop\\iskambil\\9.png";
            }
            if (label8.Text == "10")
            {
                pictureBox8.ImageLocation = "C:\\Users\\Mostar\\Desktop\\iskambil\\K.png";
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            button4.Enabled = true;
            button3.Enabled = false;

            int oyuncutoplam, bilgisayartoplam;
            oyuncutoplam = Convert.ToInt32(label10.Text);
            bilgisayartoplam = Convert.ToInt32(label11.Text);

            if (oyuncutoplam > bilgisayartoplam && oyuncutoplam < 21)
            {
                oyuncupuan = oyuncupuan + 10;
                label20.Text = oyuncupuan.ToString();
            }
            if (bilgisayartoplam > oyuncutoplam && bilgisayartoplam <= 21)
            {
                bilgisayarpuan = bilgisayarpuan + 10;
                label21.Text = bilgisayarpuan.ToString();
            }
            if (bilgisayartoplam > 21 && oyuncutoplam > 21)
            {
                MessageBox.Show("Değerler Büyük Beraberlik");
            }
            if (bilgisayartoplam == oyuncutoplam && bilgisayartoplam <= 21 && oyuncutoplam <= 21)
            {
                bilgisayarpuan = bilgisayarpuan + 10;
                oyuncupuan = oyuncupuan + 10;
            }
            if (oyuncupuan == 50)
            {
                MessageBox.Show("Tebrikler Kazandınız");
            }
            if (bilgisayarpuan == 50)
            {
                MessageBox.Show("Maalesef Kaybettiniz");
            }
            if (bilgisayartoplam <= 21 && oyuncutoplam > 21)
            {
                bilgisayarpuan = bilgisayarpuan + 10;
                label21.Text = bilgisayarpuan.ToString();
            }
            if (oyuncutoplam <= 21 && bilgisayartoplam > 21)
            {
                oyuncutoplam = oyuncutoplam + 10;
                label20.Text = oyuncutoplam.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sayac = 0;
            label1.Text = "0";
            label2.Text = "0";
            label3.Text = "0";
            label4.Text = "0";
            label5.Text = "0";
            label6.Text = "0";
            label7.Text = "0";
            label8.Text = "0";
            label11.Text = "0";
            label10.Text = "0";
            button4.Enabled = false;
            button3.Enabled = true;
            pictureBox1.ImageLocation = "C:\\Users\\Mostar\\Desktop\\iskambil\\ters.jpg";
            pictureBox2.ImageLocation = "C:\\Users\\Mostar\\Desktop\\iskambil\\ters.jpg";
            pictureBox3.ImageLocation = "C:\\Users\\Mostar\\Desktop\\iskambil\\ters.jpg";
            pictureBox4.ImageLocation = "C:\\Users\\Mostar\\Desktop\\iskambil\\ters.jpg";
            pictureBox5.ImageLocation = "C:\\Users\\Mostar\\Desktop\\iskambil\\ters.jpg";
            pictureBox6.ImageLocation = "C:\\Users\\Mostar\\Desktop\\iskambil\\ters.jpg";
            pictureBox7.ImageLocation = "C:\\Users\\Mostar\\Desktop\\iskambil\\ters.jpg";
            pictureBox8.ImageLocation = "C:\\Users\\Mostar\\Desktop\\iskambil\\ters.jpg";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "C:\\Users\\Mostar\\Desktop\\Bahadır Sağlam - Kır Papatyası.mp3";
            axWindowsMediaPlayer1.Visible = false;
        }
    }
}
