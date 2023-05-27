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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace yaho2
{
    public partial class oyunIkiForm : Form
    {
        private const string V = "C:\\Users\\user\\OneDrive\\Belgeler\\GitHub\\yahoooooo\\yaho2\\asset\\futbolcular";
        public SoundPlayer sound = new SoundPlayer(Properties.Resources.kısıkwaka);
        public static int puan2;
        public static bool location = true;
        oyunBirForm oyunform1 = new oyunBirForm();
        public string Form3ye_Gidecek_Veri = "";
        int süre;
        public static int skor_sayac;
        int skor1, skor2;
        int soru_sayisi = 0;
        public static int oyunIkipuan;
        SqlConnection connection = new SqlConnection("Data Source=BERKAY\\SQL;Initial Catalog=worldcup2014;Integrated Security=True");
        SqlCommand command = new SqlCommand();
        SqlCommand command1 = new SqlCommand();
        SqlCommand command2 = new SqlCommand();
        Random rand = new Random();
        int soruno;
        string[] sorular = { "Hangi futbolcu daha çok gole sahiptir?","Hangi futbolcu daha çok asiste sahiptir?","Hangi futbolcunun gördüğü kart daha fazladır?",
            "Hangi futbolcu daha çok skor katkısı yapmıştır?" };
        int oyuncu1, oyuncu2;
        string oyuncu1ad, oyuncu2ad;
        string[] fotoAdlari = new string[737];
        public string fotodizini;
        public static object[] dizi = new object[6];
        public void arkaplan()
        {
            this.BackgroundImage = Ayarlar.resim;


        }
        public oyunIkiForm()
        {

            InitializeComponent();
            for (int i = 0; i < 737; i++)
            {
                fotoAdlari[i] = (i).ToString();
            }
            arkaplan();
        }

        private void xButton_Click(object sender, EventArgs e) //oyunu kapatmak için
        {
            if ((MessageBox.Show("Kapatmak istediğinizden emin misin?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                Application.Exit();
            }
        }
        void soru_degisim() //her soru geldiğinde olucaklar
        {

            SqlDataReader oku;
            this.progressBar1.Value = zorluksecim.zorluk; //zorluk seçimine göre gelicek saniye
            oyuncu1 = rand.Next(1, 737);
            oyuncu2 = rand.Next(1, 737);
            fotodizini = V;
            while (oyuncu1 == oyuncu2)
            {
                oyuncu2 = rand.Next(1, 737);    //karşılaştırma yapılacak oyunlar aynı geldiyse değiştirme yapılması için
            }
            int index = oyuncu1;
            int index2 = oyuncu2;
            string fotoAdi = fotoAdlari[index] + ".png";    //fotoadları gereksiz aslında ama yaptık bi kere programın seçtiği ilk kişinin idsini yazıyorki dosyadan adını bulabilsin
            string fotoYolu = Path.Combine(fotodizini, fotoAdi);
            oyunIkiForm_futbolcu1Pic.Image = Image.FromFile(fotoYolu);
            fotoAdi = fotoAdlari[index2] + ".png";
            fotoYolu = Path.Combine(fotodizini, fotoAdi);
            oyunIkiForm_futbolcu2Pic.Image = Image.FromFile(fotoYolu);
            timer1.Start(); //zorluk moduna göre gelen zaman başlıyor
            soruno = rand.Next(0, 4); //gelen random sayıya göre soru seçiliyor ve soruya bağlı olarak iki oyuncudan gerekli bilgiler çekiliyor ve karşılaştırılıyor




            if (soruno == 0)
            {
                oyunIkiForm_soru.Text = sorular[0];
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT Futbolcular.F_Ad, Futbolcular.F_ID, goller.Gol_Atan_F_ID, ( SELECT COUNT(*) FROM goller AS G  WHERE G.Gol_Atan_F_ID = Futbolcular.F_ID ) AS Gol_Sayisi FROM Futbolcular LEFT JOIN goller ON Futbolcular.F_ID = goller.Gol_Atan_F_ID WHERE futbolcular.F_ID = " + oyuncu1 + " GROUP BY Futbolcular.F_Ad, Futbolcular.F_ID, goller.Gol_Atan_F_ID";
                oku = command.ExecuteReader();
                oku.Read();
                skor1 = Convert.ToInt16(oku[3]);
                oyunIkiForm_buttonF1.Text = oku[0].ToString();
                oku.Close();
                command.CommandText = "SELECT Futbolcular.F_Ad, Futbolcular.F_ID, goller.Gol_Atan_F_ID, ( SELECT COUNT(*) FROM goller AS G  WHERE G.Gol_Atan_F_ID = Futbolcular.F_ID ) AS Gol_Sayisi FROM Futbolcular LEFT JOIN goller ON Futbolcular.F_ID = goller.Gol_Atan_F_ID WHERE futbolcular.F_ID = " + oyuncu2 + " GROUP BY Futbolcular.F_Ad, Futbolcular.F_ID, goller.Gol_Atan_F_ID";
                oku = command.ExecuteReader();
                oku.Read();
                skor2 = Convert.ToInt16(oku[3]);
                oyunIkiForm_buttonF2.Text = oku[0].ToString();
                oku.Close();
                connection.Close();
                soru_sayisi++;
            }
            else if (soruno == 1)
            {
                oyunIkiForm_soru.Text = sorular[1];
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT Futbolcular.F_Ad, Futbolcular.F_ID, goller.Asist_Yapan_F_ID, ( SELECT COUNT(*) FROM goller AS G  WHERE G.Asist_Yapan_F_ID = Futbolcular.F_ID ) AS Gol_Sayisi FROM Futbolcular LEFT JOIN goller ON Futbolcular.F_ID = goller.Gol_Atan_F_ID WHERE futbolcular.F_ID = " + oyuncu1 + " GROUP BY Futbolcular.F_Ad, Futbolcular.F_ID, goller.Asist_Yapan_F_ID";
                oku = command.ExecuteReader();
                oku.Read();
                skor1 = Convert.ToInt16(oku[3]);
                oyunIkiForm_buttonF1.Text = oku[0].ToString();
                oku.Close();
                command.CommandText = "SELECT Futbolcular.F_Ad, Futbolcular.F_ID, goller.Asist_Yapan_F_ID, ( SELECT COUNT(*) FROM goller AS G  WHERE G.Asist_Yapan_F_ID = Futbolcular.F_ID ) AS Gol_Sayisi FROM Futbolcular LEFT JOIN goller ON Futbolcular.F_ID = goller.Gol_Atan_F_ID WHERE futbolcular.F_ID = " + oyuncu2 + " GROUP BY Futbolcular.F_Ad, Futbolcular.F_ID, goller.Asist_Yapan_F_ID";
                oku = command.ExecuteReader();
                oku.Read();
                skor2 = Convert.ToInt16(oku[3]);
                oyunIkiForm_buttonF2.Text = oku[0].ToString();
                oku.Close();
                connection.Close();
                soru_sayisi++;
            }
            else if (soruno == 2)
            {
                oyunIkiForm_soru.Text = sorular[2];
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT Futbolcular.F_Ad, Futbolcular.F_ID, kartlar.F_ID, (SELECT COUNT(*) FROM kartlar AS G  WHERE G.F_ID = Futbolcular.F_ID ) AS kart_Sayisi FROM Futbolcular LEFT JOIN kartlar ON Futbolcular.F_ID = kartlar.F_ID  where Futbolcular.F_ID = " + oyuncu1 + " GROUP BY Futbolcular.F_Ad, Futbolcular.F_ID, kartlar.F_ID";
                oku = command.ExecuteReader();
                oku.Read();
                skor1 = Convert.ToInt16(oku[3]);
                oyunIkiForm_buttonF1.Text = oku[0].ToString();
                oku.Close();
                command.CommandText = "SELECT Futbolcular.F_Ad, Futbolcular.F_ID, kartlar.F_ID, (SELECT COUNT(*) FROM kartlar AS G  WHERE G.F_ID = Futbolcular.F_ID ) AS kart_Sayisi FROM Futbolcular LEFT JOIN kartlar ON Futbolcular.F_ID = kartlar.F_ID  where Futbolcular.F_ID = " + oyuncu2 + " GROUP BY Futbolcular.F_Ad, Futbolcular.F_ID, kartlar.F_ID";
                oku = command.ExecuteReader();
                oku.Read();
                skor2 = Convert.ToInt16(oku[3]);
                oyunIkiForm_buttonF2.Text = oku[0].ToString();
                oku.Close();
                connection.Close();
                soru_sayisi++;
            }
            else if (soruno == 3)
            {
                oyunIkiForm_soru.Text = sorular[3];
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT Futbolcular.F_Ad, Futbolcular.F_ID, goller.Gol_Atan_F_ID, ( SELECT COUNT(*) FROM goller AS G  WHERE G.Gol_Atan_F_ID = Futbolcular.F_ID ) AS Gol_Sayisi FROM Futbolcular LEFT JOIN goller ON Futbolcular.F_ID = goller.Gol_Atan_F_ID WHERE futbolcular.F_ID = " + oyuncu1 + " GROUP BY Futbolcular.F_Ad, Futbolcular.F_ID, goller.Gol_Atan_F_ID";
                oku = command.ExecuteReader();
                oku.Read();
                skor1 = Convert.ToInt16(oku[3]);
                oyunIkiForm_buttonF1.Text = oku[0].ToString();
                oku.Close();
                command.CommandText = "SELECT Futbolcular.F_Ad, Futbolcular.F_ID, goller.Asist_Yapan_F_ID, ( SELECT COUNT(*) FROM goller AS G  WHERE G.Asist_Yapan_F_ID = Futbolcular.F_ID ) AS Gol_Sayisi FROM Futbolcular LEFT JOIN goller ON Futbolcular.F_ID = goller.Gol_Atan_F_ID WHERE futbolcular.F_ID = " + oyuncu1 + " GROUP BY Futbolcular.F_Ad, Futbolcular.F_ID, goller.Asist_Yapan_F_ID";
                oku = command.ExecuteReader();
                oku.Read();
                skor1 = Convert.ToInt16(oku[3]) + skor1;
                oku.Close();
                command.CommandText = "SELECT Futbolcular.F_Ad, Futbolcular.F_ID, goller.Gol_Atan_F_ID, ( SELECT COUNT(*) FROM goller AS G  WHERE G.Gol_Atan_F_ID = Futbolcular.F_ID ) AS Gol_Sayisi FROM Futbolcular LEFT JOIN goller ON Futbolcular.F_ID = goller.Gol_Atan_F_ID WHERE futbolcular.F_ID = " + oyuncu2 + " GROUP BY Futbolcular.F_Ad, Futbolcular.F_ID, goller.Gol_Atan_F_ID";
                oku = command.ExecuteReader();
                oku.Read();
                skor2 = Convert.ToInt16(oku[3]);
                oyunIkiForm_buttonF2.Text = oku[0].ToString();
                oku.Close();
                command.CommandText = "SELECT Futbolcular.F_Ad, Futbolcular.F_ID, goller.Asist_Yapan_F_ID, ( SELECT COUNT(*) FROM goller AS G  WHERE G.Asist_Yapan_F_ID = Futbolcular.F_ID ) AS Gol_Sayisi FROM Futbolcular LEFT JOIN goller ON Futbolcular.F_ID = goller.Gol_Atan_F_ID WHERE futbolcular.F_ID = " + oyuncu2 + " GROUP BY Futbolcular.F_Ad, Futbolcular.F_ID, goller.Asist_Yapan_F_ID";
                oku = command.ExecuteReader();
                oku.Read();
                skor2 += Convert.ToInt16(oku[3]);
                oku.Close();
                connection.Close();
                soru_sayisi++;
            }
        }
        private void oyunIkiForm_Load(object sender, EventArgs e)

        {
            oyun2Puan.Text = oyunIkipuan.ToString();
            if (location == false)  //şarkı açma kapama
            {


                sonucForm.location = false;
                soundPictureBox.Image = Properties.Resources.sound_off;

            }
            else
            {

                soundPictureBox.Image = Properties.Resources.sound_on;
            }

            soru_degisim();
        }

        private void oyunIkiForm_buttonF1_Click(object sender, EventArgs e)
        {
            if (skor1 > skor2) //skor1 sorunun sol taraftaki oyuncuya göre cevabi skor 2 ise sağ taraftaki eğer soldaki oyuncu sağdakinden büyükse ve soldaki butona basarsak
            {
                oyunIkipuan += 500;
                oyun2Puan.Text = oyunIkipuan.ToString();
                switch (soru_sayisi)
                {
                    case 1: oyunIkiForm_buttonS1.BackColor = Color.FromArgb(255, 0, 192, 0); break;
                    case 2: oyunIkiForm_buttonS2.BackColor = Color.FromArgb(255, 0, 192, 0); break;
                    case 3: oyunIkiForm_buttonS3.BackColor = Color.FromArgb(255, 0, 192, 0); break;
                    case 4: oyunIkiForm_buttonS4.BackColor = Color.FromArgb(255, 0, 192, 0); break;
                    case 5: oyunIkiForm_buttonS5.BackColor = Color.FromArgb(255, 0, 192, 0); break;
                    case 6: oyunIkiForm_buttonS6.BackColor = Color.FromArgb(255, 0, 192, 0); break;
                    case 7: oyunIkiForm_buttonS7.BackColor = Color.FromArgb(255, 0, 192, 0); break;
                    case 8: oyunIkiForm_buttonS8.BackColor = Color.FromArgb(255, 0, 192, 0); break;
                    case 9: oyunIkiForm_buttonS9.BackColor = Color.FromArgb(255, 0, 192, 0); break;
                    case 10: oyunIkiForm_buttonS10.BackColor = Color.FromArgb(255, 0, 192, 0); break;
                }
            }
            else
            {
                switch (soru_sayisi)
                {
                    case 1: oyunIkiForm_buttonS1.BackColor = Color.FromArgb(255, 215, 0, 0); break;
                    case 2: oyunIkiForm_buttonS2.BackColor = Color.FromArgb(255, 215, 0, 0); break;
                    case 3: oyunIkiForm_buttonS3.BackColor = Color.FromArgb(255, 215, 0, 0); break;
                    case 4: oyunIkiForm_buttonS4.BackColor = Color.FromArgb(255, 215, 0, 0); break;
                    case 5: oyunIkiForm_buttonS5.BackColor = Color.FromArgb(255, 215, 0, 0); break;
                    case 6: oyunIkiForm_buttonS6.BackColor = Color.FromArgb(255, 215, 0, 0); break;
                    case 7: oyunIkiForm_buttonS7.BackColor = Color.FromArgb(255, 215, 0, 0); break;
                    case 8: oyunIkiForm_buttonS8.BackColor = Color.FromArgb(255, 215, 0, 0); break;
                    case 9: oyunIkiForm_buttonS9.BackColor = Color.FromArgb(255, 215, 0, 0); break;
                    case 10: oyunIkiForm_buttonS10.BackColor = Color.FromArgb(255, 215, 0, 0); break;
                }
            }
            if (soru_sayisi == 10) //sorular bittiğinde daha fazla basılamaması için

            {
                oyunIkiForm_buttonF1.Enabled = false;
                oyunIkiForm_buttonF2.Enabled = false;
                oyunIkiForm_buttonBerabere.Enabled = false;
                oyun2_ilerle_button.Visible = true;
            }
            soru_degisim();
        }
        private void button1_Click(object sender, EventArgs e) //skor1 sorunun sol taraftaki oyuncuya göre cevabi skor 2 ise sağ taraftaki eğer soldaki oyuncuyla eşitse ve berabere butonuna basarsak
        {
            if (skor1 == skor2)
            {
                oyunIkipuan += 500;
                oyun2Puan.Text = oyunIkipuan.ToString();
                switch (soru_sayisi)
                {
                    case 1: oyunIkiForm_buttonS1.BackColor = Color.FromArgb(255, 0, 192, 0); break;
                    case 2: oyunIkiForm_buttonS2.BackColor = Color.FromArgb(255, 0, 192, 0); break;
                    case 3: oyunIkiForm_buttonS3.BackColor = Color.FromArgb(255, 0, 192, 0); break;
                    case 4: oyunIkiForm_buttonS4.BackColor = Color.FromArgb(255, 0, 192, 0); break;
                    case 5: oyunIkiForm_buttonS5.BackColor = Color.FromArgb(255, 0, 192, 0); break;
                    case 6: oyunIkiForm_buttonS6.BackColor = Color.FromArgb(255, 0, 192, 0); break;
                    case 7: oyunIkiForm_buttonS7.BackColor = Color.FromArgb(255, 0, 192, 0); break;
                    case 8: oyunIkiForm_buttonS8.BackColor = Color.FromArgb(255, 0, 192, 0); break;
                    case 9: oyunIkiForm_buttonS9.BackColor = Color.FromArgb(255, 0, 192, 0); break;
                    case 10: oyunIkiForm_buttonS10.BackColor = Color.FromArgb(255, 0, 192, 0); break;
                }
            }
            else
            {
                switch (soru_sayisi)
                {
                    case 1: oyunIkiForm_buttonS1.BackColor = Color.FromArgb(255, 215, 0, 0); break;
                    case 2: oyunIkiForm_buttonS2.BackColor = Color.FromArgb(255, 215, 0, 0); break;
                    case 3: oyunIkiForm_buttonS3.BackColor = Color.FromArgb(255, 215, 0, 0); break;
                    case 4: oyunIkiForm_buttonS4.BackColor = Color.FromArgb(255, 215, 0, 0); break;
                    case 5: oyunIkiForm_buttonS5.BackColor = Color.FromArgb(255, 215, 0, 0); break;
                    case 6: oyunIkiForm_buttonS6.BackColor = Color.FromArgb(255, 215, 0, 0); break;
                    case 7: oyunIkiForm_buttonS7.BackColor = Color.FromArgb(255, 215, 0, 0); break;
                    case 8: oyunIkiForm_buttonS8.BackColor = Color.FromArgb(255, 215, 0, 0); break;
                    case 9: oyunIkiForm_buttonS9.BackColor = Color.FromArgb(255, 215, 0, 0); break;
                    case 10: oyunIkiForm_buttonS10.BackColor = Color.FromArgb(255, 215, 0, 0); break;
                }
            }

            if (soru_sayisi == 10)  //sorular bittiğinde daha fazla basılmaması için
            {
                oyunIkiForm_buttonF1.Enabled = false;
                oyunIkiForm_buttonF2.Enabled = false;
                oyunIkiForm_buttonBerabere.Enabled = false;
                oyun2_ilerle_button.Visible = true;
            }
            soru_degisim();

        }

        private void oyunIkiForm_buttonF2_Click(object sender, EventArgs e) //skor1 sorunun sol taraftaki oyuncuya göre cevabi skor 2 ise sağ taraftaki eğer soldaki oyuncu sağdakinden küçükşe ve sağdaki butona basarsak
        {
            if (skor1 < skor2)
            {
                oyunIkipuan += 500;
                oyun2Puan.Text = oyunIkipuan.ToString();
                switch (soru_sayisi)
                {
                    case 1: oyunIkiForm_buttonS1.BackColor = Color.FromArgb(255, 0, 192, 0); break;
                    case 2: oyunIkiForm_buttonS2.BackColor = Color.FromArgb(255, 0, 192, 0); break;
                    case 3: oyunIkiForm_buttonS3.BackColor = Color.FromArgb(255, 0, 192, 0); break;
                    case 4: oyunIkiForm_buttonS4.BackColor = Color.FromArgb(255, 0, 192, 0); break;
                    case 5: oyunIkiForm_buttonS5.BackColor = Color.FromArgb(255, 0, 192, 0); break;
                    case 6: oyunIkiForm_buttonS6.BackColor = Color.FromArgb(255, 0, 192, 0); break;
                    case 7: oyunIkiForm_buttonS7.BackColor = Color.FromArgb(255, 0, 192, 0); break;
                    case 8: oyunIkiForm_buttonS8.BackColor = Color.FromArgb(255, 0, 192, 0); break;
                    case 9: oyunIkiForm_buttonS9.BackColor = Color.FromArgb(255, 0, 192, 0); break;
                    case 10: oyunIkiForm_buttonS10.BackColor = Color.FromArgb(255, 0, 192, 0); break;
                }
            }
            else
            {
                switch (soru_sayisi)
                {
                    case 1: oyunIkiForm_buttonS1.BackColor = Color.FromArgb(255, 215, 0, 0); break;
                    case 2: oyunIkiForm_buttonS2.BackColor = Color.FromArgb(255, 215, 0, 0); break;
                    case 3: oyunIkiForm_buttonS3.BackColor = Color.FromArgb(255, 215, 0, 0); break;
                    case 4: oyunIkiForm_buttonS4.BackColor = Color.FromArgb(255, 215, 0, 0); break;
                    case 5: oyunIkiForm_buttonS5.BackColor = Color.FromArgb(255, 215, 0, 0); break;
                    case 6: oyunIkiForm_buttonS6.BackColor = Color.FromArgb(255, 215, 0, 0); break;
                    case 7: oyunIkiForm_buttonS7.BackColor = Color.FromArgb(255, 215, 0, 0); break;
                    case 8: oyunIkiForm_buttonS8.BackColor = Color.FromArgb(255, 215, 0, 0); break;
                    case 9: oyunIkiForm_buttonS9.BackColor = Color.FromArgb(255, 215, 0, 0); break;
                    case 10: oyunIkiForm_buttonS10.BackColor = Color.FromArgb(255, 215, 0, 0); break;
                }
            }

            if (soru_sayisi == 10) //sorular bittiğinde daha fazla basılamaması için
            {
                oyunIkiForm_buttonF1.Enabled = false;
                oyunIkiForm_buttonF2.Enabled = false;
                oyunIkiForm_buttonBerabere.Enabled = false;
                oyun2_ilerle_button.Visible = true;
            }
            soru_degisim();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlDataReader oku, oku1, oku2;

            connection.Open();
            command.Connection = connection;
            command.CommandText = "select skor_sayac from sayac"; //sqlden son oyuncunun id bilgisini alıyorum
            oku = command.ExecuteReader();
            oku.Read();
            skor_sayac = Convert.ToInt32(oku[0]);
            skor_sayac++;
            connection.Close();

            puan2 = oyunIkiForm.oyunIkipuan;

            if (zorluksecim.zorluk == 21)       //zorluk seçimine göre gelen ekstra puan
            {
                oyunIkiForm.oyunIkipuan += 1000;

            }
            if (zorluksecim.zorluk == 16)
            {
                oyunIkiForm.oyunIkipuan += 2000;
            }
            if (zorluksecim.zorluk == 11)
            {
                oyunIkiForm.oyunIkipuan += 3000;
            }

            connection.Open();
            command.Connection = connection;
            command.CommandText = " UPDATE sayac SET skor_sayac =" + skor_sayac; //sql deki sayacc bilgisini güncelliyor
            command.ExecuteNonQuery(); //sadece komut okutmak istediğinde bu kod gerekiyor read yerine
            connection.Close();

            connection.Open();
            command.Connection = connection; //kullanıcının adı ver puanı sql tablosuna kayıt ediliyor
            command.CommandText = "INSERT INTO skorboard (kullanıcı, Skor,skor_id)VALUES ('" + girisSayfasiForm.kullanıcı_adı + "'," + oyunIkiForm.oyunIkipuan + "," + skor_sayac + ");";
            command.ExecuteNonQuery(); //sadece komut okutmak istediğinde bu kod gerekiyor read yerine
            connection.Close();




            sonucForm form4 = new sonucForm(); //diğer forma geçiliyor
            form4.Show();
            this.Close();
        }

        private void oyun2_ilerle_button_Visible_Changed(object sender, EventArgs e)
        {
            oyunIkiForm_soru.Text = "SONUÇ EKRANINA GEÇMEK İÇİN İLERLE";

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Visible = true;
            if (soru_sayisi == 11)
            {
                timer1.Stop();

                oyunIkiForm_buttonF1.Enabled = false;
                oyunIkiForm_buttonF2.Enabled = false;
                oyunIkiForm_buttonBerabere.Enabled = false;
                oyun2_ilerle_button.Visible = true;
                label1.Visible = false;
                label2.Visible = false;
                oyunIkiForm_futbolcu1Pic.Visible = false;
                oyunIkiForm_futbolcu2Pic.Visible = false;

            }



            if (progressBar1.Value >= 1)
            {

                progressBar1.Value = progressBar1.Value - 1;
                label2.Text = progressBar1.Value.ToString();
            }
            if (progressBar1.Value == 0) //süre bittiğinde olucaklar bunlar
            {
                switch (soru_sayisi)
                {
                    case 1: oyunIkiForm_buttonS1.BackColor = Color.FromArgb(255, 215, 0, 0); break;
                    case 2: oyunIkiForm_buttonS2.BackColor = Color.FromArgb(255, 215, 0, 0); break;
                    case 3: oyunIkiForm_buttonS3.BackColor = Color.FromArgb(255, 215, 0, 0); break;
                    case 4: oyunIkiForm_buttonS4.BackColor = Color.FromArgb(255, 215, 0, 0); break;
                    case 5: oyunIkiForm_buttonS5.BackColor = Color.FromArgb(255, 215, 0, 0); break;
                    case 6: oyunIkiForm_buttonS6.BackColor = Color.FromArgb(255, 215, 0, 0); break;
                    case 7: oyunIkiForm_buttonS7.BackColor = Color.FromArgb(255, 215, 0, 0); break;
                    case 8: oyunIkiForm_buttonS8.BackColor = Color.FromArgb(255, 215, 0, 0); break;
                    case 9: oyunIkiForm_buttonS9.BackColor = Color.FromArgb(255, 215, 0, 0); break;
                    case 10: oyunIkiForm_buttonS10.BackColor = Color.FromArgb(255, 215, 0, 0); break;
                }
                soru_degisim();
            }
        }

        private void soundPictureBox_Click(object sender, EventArgs e)  //ses açma kapama için
        {
            if (location)
            {

                location = false;
                sound.Stop();
                soundPictureBox.Image = Properties.Resources.sound_off;
                oyunBirForm.location = false;
            }
            else
            {
                location = true;
                sound.Play();
                soundPictureBox.Image = Properties.Resources.sound_on;
                sonucForm.location = true;
            }
        }
    }
}
