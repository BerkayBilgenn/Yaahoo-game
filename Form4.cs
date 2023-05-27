using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yaho2
{
    public partial class sonucForm : Form
    {
        public SoundPlayer sound = new SoundPlayer(Properties.Resources.kısıkwaka);
        public static bool location = true;
        SqlConnection connection = new SqlConnection("Data Source=BERKAY\\SQL;Initial Catalog=worldcup2014;Integrated Security=True");
        SqlCommand command = new SqlCommand();
        SqlCommand command1 = new SqlCommand();
        int ikincioyunpuanıhesap = (oyunIkiForm.puan2 - oyunBirForm.puan) / 500;
        string[] sonoynanan = new string[2];
        int bitis, baslangıc, index = 0;
        string zorlukmodu;
        public void arkaplan()
        {
            this.BackgroundImage = Ayarlar.resim;


        }


        public sonucForm()
        {
            InitializeComponent();
            arkaplan();
            timer1.Start();
            progressBar1.Value = 0;
            SqlDataReader oku;
            connection.Open();
            command.Connection = connection;
            command.CommandText = "select * from skorboard order by skor_id desc";  //kayıt edilen son oyuncunun idsini alıyoruz
            oku = command.ExecuteReader();
            oku.Read();
            bitis = Convert.ToInt32(oku[2]);
            oku.Close();
            connection.Close();
            int j = 0;
            baslangıc = bitis - 10; //skor boarda son 10 oyuncu olucağı için son oyuncudan 10 çıkartıyoruz
            for (int i = bitis; i > baslangıc; i--) //son 10 oyuncuyu listviewın içine ekliyoruz
            {
                connection.Open();
                command.CommandText = "select * from skorboard where skor_id =" + i;
                oku = command.ExecuteReader();
                oku.Read();
                listView1.Items[j].SubItems[0].Text = Convert.ToString(j + 1);
                listView1.Items[index].SubItems[1].Text = oku[0].ToString();
                listView1.Items[index].SubItems[2].Text = oku[1].ToString();
                index++;
                j++;
                oku.Close();
                connection.Close();
            }
        }

        private void xButton_Click(object sender, EventArgs e)  //kapatma butonu
        {
            if ((MessageBox.Show("Kapatmak istediğinizden emin misin?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                Application.Exit();
            }
        }
        private void sonucForm_Load(object sender, EventArgs e) //zorluk modu ekranında seçilen zorluğa göre skor tablosunda görünen labelların atamaları yapılıyor
        {
            if (zorluksecim.zorluk == 21)
            {
                zorlukmodu = "Kolay";
                label8.Text = "1000";
            }

            if (zorluksecim.zorluk == 16)
            {
                zorlukmodu = "Orta";
                label8.Text = "2000";
            }

            if (zorluksecim.zorluk == 11)
            {
                zorlukmodu = "Zor";
                label8.Text = "3000";
            }


            label10.Text = zorlukmodu;

            if (location == false)      //şarkı açma kapama
            {
                girisSayfasiForm.location = false;
                soundPictureBox.Image = Properties.Resources.sound_off;
            }
            else
            {
                soundPictureBox.Image = Properties.Resources.sound_on;
            }

            if (oyunBirForm.puan >= 1000) //bu gelen puan ipucu kullanımına göre yapılıyor
            {
                kalandenemepuan.Text = (oyunBirForm.deneme + 1).ToString() + " X 1000";
            }
            else kalandenemepuan.Text = oyunBirForm.deneme.ToString() + " X 1000"; ;

            ipucupuanı.Text = oyunBirForm.ipucukullanımı;
            ikincioyunpuan.Text = ikincioyunpuanıhesap.ToString() + " X 500";

            ikincioyunskor.Text = (ikincioyunpuanıhesap * 500).ToString();
            if (oyunBirForm.ipucukullanımı == "evet")
            {
                ipucuskor.Text = 0.ToString();
                birincioyunskor.Text = (oyunBirForm.puan).ToString();
            }
            else
            {
                ipucuskor.Text = 500.ToString();
                birincioyunskor.Text = (oyunBirForm.puan - 500).ToString();

            }

            sonskor.Text = oyunIkiForm.oyunIkipuan.ToString();

        }

        private void button1_Click(object sender, EventArgs e)  //tekrar oynamak için yapılan buton
        {
            girisSayfasiForm fr = new girisSayfasiForm();
            oyunBirForm.deneme = 10;
            oyunBirForm.puan = 10500;
            girisSayfasiForm.sarkısayac++;      //şarkı yeniden başlamasının önüne geçmek için

            fr.Show();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)        //skorboard ve sonuç ekranının zamanla tek tek gelmesi için
        {
            if (progressBar1.Value <= 5)
            {

                progressBar1.Value = progressBar1.Value + 5;
                kalandenemepuan.Visible = true;

            }
            else if (progressBar1.Value <= 10)
            {
                progressBar1.Value = progressBar1.Value + 5;
                ipucupuanı.Visible = true;
            }
            else if (progressBar1.Value <= 15)
            {
                progressBar1.Value = progressBar1.Value + 5;
                ikincioyunpuan.Visible = true;
            }
            else if (progressBar1.Value <= 20)
            {
                progressBar1.Value = progressBar1.Value + 5;
                label10.Visible = true;
            }
            else if (progressBar1.Value <= 25)
            {
                progressBar1.Value = progressBar1.Value + 5;
                birincioyunskor.Visible = true;
            }
            else if (progressBar1.Value <= 30)
            {
                progressBar1.Value = progressBar1.Value + 5;
                ikincioyunskor.Visible = true;
            }

            else if (progressBar1.Value <= 35)
            {
                progressBar1.Value = progressBar1.Value + 5;
                ipucuskor.Visible = true;
            }
            else if (progressBar1.Value <= 40)
            {
                progressBar1.Value = progressBar1.Value + 5;
                label8.Visible = true;
                label18.Visible = true;
                label19.Visible = true;
            }
            else if (progressBar1.Value <= 45)
            {
                progressBar1.Value = progressBar1.Value + 5;
                sonskor.Visible = true;

            }
            else if (progressBar1.Value <= 50)
            {
                progressBar1.Value = progressBar1.Value + 5;
                label6.Visible = true;

            }
            else if (progressBar1.Value <= 55)
            {
                progressBar1.Value = progressBar1.Value + 5;
                listView1.Visible = true;

            }
            else if (progressBar1.Value <= 60)
            {
                progressBar1.Value = progressBar1.Value + 5;
                button1.Visible = true;

            }



            else
            {
                timer1.Stop();
                label6.Visible = true;

            }
        }

        private void soundPictureBox_Click(object sender, EventArgs e)      //şarkı aç kapa yapmak için
        {
            if (location)
            {

                location = false;
                sound.Stop();
                soundPictureBox.Image = Properties.Resources.sound_off;
                girisSayfasiForm.location = false;
            }
            else
            {
                location = true;
                sound.Play();
                soundPictureBox.Image = Properties.Resources.sound_on;
                girisSayfasiForm.location = true;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
