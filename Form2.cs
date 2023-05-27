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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms.VisualStyles;
using System.Security.Cryptography.X509Certificates;
using System.Media;
using System.Runtime.Intrinsics.X86;

namespace yaho2
{
    public partial class oyunBirForm : Form
    {
        public SoundPlayer sound = new SoundPlayer(Properties.Resources.kısıkwaka);
        string fotodizinii = "C:\\Users\\user\\OneDrive\\Belgeler\\GitHub\\yahoooooo\\yaho2\\asset\\futbolcular";
        string[] bilgiler = new string[6];
        string[] karsilastirma = new string[6];
        string[] ipucu = new string[] { "false", "true", "true", "true", "true", "true" };
        public static bool location = true;
        int hint;
        int hintkapa = 0;
        public static string ipucukullanımı = "Hayır";

        Random rand = new Random();
        int sayi, sayac = 0;
        public static int deneme = 10;
        public static int puan = 10500;
        SqlConnection connection = new SqlConnection("Data Source=BERKAY\\SQL;Initial Catalog=worldcup2014;Integrated Security=True");
        SqlCommand command = new SqlCommand();
        SqlCommand command1 = new SqlCommand();
        public void arkaplan()  //ayarlar formundan gelen bilgiyle arkaplan değişimi
        {
            this.BackgroundImage = Ayarlar.resim;


        }
        public oyunBirForm()
        {
            InitializeComponent();
            oyun_skor.Text = puan.ToString();   //puan gösterimi
            hak.Text = deneme.ToString();   //deneme hakkı gösterimi
            arkaplan();

        }

        private void oyunBirForm_Load(object sender, EventArgs e)
        {
            if (location == false)  //şarkı açma kapama
            {


                oyunIkiForm.location = false;
                soundPictureBox.Image = Properties.Resources.sound_off;

            }
            else
            {

                soundPictureBox.Image = Properties.Resources.sound_on;
            }

            SqlDataReader oku;
            sayi = rand.Next(1, 737);   //oyunun arka planda bulmamızı istediği kişinin id si random seçiliyor

            connection.Open();

            command1.Connection = connection;
            command1.CommandText = "SELECT F_Ad, Forma_No, F_Mevki, Kulup_Takim, takimlar.Takim_Adi, F_Yas FROM futbolcular inner join takimlar on futbolcular.Takim_ID = takimlar.Takim_ID WHERE F_ID =" + sayi;

            oku = command1.ExecuteReader();
            oku.Read();
            for (int i = 0; i < bilgiler.Length; i++) //random seçilen kişinin bilgilerini  sqlden tek tek alıp bilgiler dizine atılıyor
            {
                bilgiler[i] = oku[i].ToString();
            }
            oyun1Puan.Text = bilgiler[0];   // oyun kimi seçtiğini görmek için kontrol amaçlı
            oku.Close();

            command.Connection = connection;
            command.CommandText = "SELECT F_Ad FROM futbolcular";
            oku = command.ExecuteReader();
            while (oku.Read())  //comboboxın içine elimizdeki oyunların bilgilerini giriyoruz
            {
                comboBox1.Items.Add(oku[0].ToString());
            }
            oku.Close();

            connection.Close();
        }

        private void xButton_Click(object sender, EventArgs e) //kapatma butonu
        {
            if ((MessageBox.Show("Kapatmak istediğinizden emin misin?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlDataReader oku;
            string ad = comboBox1.Text; ;
            int uyarı = 0;


            for (int i = 1; i < 737; i++)
            {
                connection.Open();
                command1.Connection = connection;
                command1.CommandText = "SELECT F_Ad, Forma_No, F_Mevki, Kulup_Takim, takimlar.Takim_Adi, F_Yas FROM futbolcular inner join takimlar on futbolcular.Takim_ID = takimlar.Takim_ID WHERE F_ID=" + i;
                oku = command1.ExecuteReader();
                oku.Read();
                if (ad == oku[0].ToString())    //kullanıcın comboxa girdiği metin elimizdeki futbolcu adlarıyla örtüşme durumu kontrolü
                {
                    uyarı = 1;
                    i = 738;

                }
                oku.Close();
                connection.Close();
            }
            if (uyarı != 1) //üstteki durumun olmadığı
            {
                MessageBox.Show("Listeden doğru ismi seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (uyarı == 1) //sorun yok devam durumu
            {

                connection.Open();
                command1.Connection = connection;
                command1.CommandText = "SELECT F_Ad, Forma_No, F_Mevki, Kulup_Takim, takimlar.Takim_Adi, F_Yas FROM futbolcular inner join takimlar on futbolcular.Takim_ID = takimlar.Takim_ID WHERE F_Ad='" + ad + "'";
                oku = command1.ExecuteReader();
                oku.Read();

                for (int i = 0; i < karsilastirma.Length; i++)  //kullanıcının seçtiği futbolcunun bilgilerini karşılaştırmaya kaydediyoruz
                {
                    karsilastirma[i] = oku[i].ToString();
                }
                oku.Close();

                connection.Close();
                listView1.Items[sayac].Text = karsilastirma[0];         //karşılaştırmadan alınan yani kullanıcının seçtiği bilgiyi listview giriyoruz
                if (listView1.Items[sayac].Text == karsilastirma[0])    //kullanıcının seçtiği bilgiler aranan bilgilerle örtüşüyorsa yeşil örtüşmüyorsa kırmızı
                {
                    listView1.Items[sayac].BackColor = Color.FromArgb(255, 0, 192, 0);
                }
                else
                {
                    listView1.Items[sayac].BackColor = Color.FromArgb(255, 215, 0, 0);
                }
                for (int i = sayac; i <= sayac; i++)    //burada ise diğer kalanların renkleri ayarlarnıyor
                {
                    for (int j = 0; j < 6; j++)
                    {
                        listView1.Items[i].SubItems[j].Text = karsilastirma[j];
                        if (bilgiler[j] == karsilastirma[j])
                        {
                            listView1.Items[i].SubItems[j].BackColor = Color.FromArgb(255, 0, 192, 0);
                            ipucu[j] = "false"; //ipucu verilirken doğru olanların bilgisini vermemesi için hepsini true başlatıp kullanıcının doğru bulduğu sutünları aradan çıkartıyoruz ki ipucu bulanmayan bilgilerden verilebilsin
                            if (ipucu[1] == "false" && ipucu[2] == "false" && ipucu[3] == "false" && ipucu[4] == "false" && ipucu[5] == "false") hintkapa++;
                            if (hintkapa == 1) checkBox1.Visible = false;
                        }
                        else
                        {
                            listView1.Items[i].SubItems[j].BackColor = Color.FromArgb(255, 215, 0, 0);
                        }

                    }
                    if (bilgiler[0] != karsilastirma[0]) //eğer ynalış bir tahminde bulunduysa kullanıcı puanı düşer
                    {
                        puan -= 1000;
                        oyun_skor.Text = puan.ToString();
                    }
                    else //kullanıcı doğru kişiyi bulursa olucaklar //oyunu kaybetmeyle aynı
                    {
                        connection.Open();
                        command1.Connection = connection;
                        command1.CommandText = "select F_ID FROM futbolcular WHERE F_Ad ='" + bilgiler[0] + "'";
                        oku = command1.ExecuteReader();
                        oku.Read();
                        int index = sayi; //oyunun arka planda bulmamızı istediği kişinin idsi indexin içine atılıyor fotoğraf adlarını idleri yaptım ki aşağıdaki kod ile kolayca bulabilelim
                        string fotoAdi = index + ".png";
                        string fotoYolu = Path.Combine(fotodizinii, fotoAdi); //doğru kişinin fotoğrafını getirmek için yapılan kod ilki konum ikincisi ad olarak
                        pictureBox1.Image = Image.FromFile(fotoYolu);
                        oku.Close();
                        connection.Close();
                        comboBox1.Visible = false;
                        pictureBox1.Visible = true;
                        button1.Visible = false;
                        button1.Enabled = false;
                        label2.Text = bilgiler[0];
                        label2.Visible = true;
                        oyun1_ilerle_button.Visible = true;

                    }
                }
                sayac++; //listview'de satırları inmek için
                deneme--;
                hak.Text = deneme.ToString();
                if (sayac == 10) //kullanıcı bütün haklarını bitirdiğinde olucaklar//oyunu kazanmayla aynı
                {

                    connection.Open();
                    command1.Connection = connection;
                    command1.CommandText = "select F_ID FROM futbolcular WHERE F_Ad ='" + bilgiler[0] + "'";
                    oku = command1.ExecuteReader();
                    oku.Read();
                    int index = sayi; //oyunun arka planda bulmamızı istediği kişinin idsi indexin içine atılıyor fotoğraf adlarını idleri yaptım ki aşağıdaki kod ile kolayca bulabilelim
                    string fotoAdi = index + ".png";
                    string fotoYolu = Path.Combine(fotodizinii, fotoAdi); //doğru kişinin fotoğrafını getirmek için yapılan kod ilki konum ikincisi ad olarak
                    pictureBox1.Image = Image.FromFile(fotoYolu);
                    oku.Close();
                    connection.Close();
                    pictureBox1.Visible = true;
                    comboBox1.Visible = false;
                    button1.Enabled = false;
                    button1.Visible = false;
                    label2.Text = bilgiler[0];
                    label2.Visible = true;
                    oyun1_ilerle_button.Visible = true;
                    checkBox1.Visible = false;
                }
            }






        }

        private void ilerle_button_Click(object sender, EventArgs e) // diğer forma yani form 3 e geçmek için kullandığımız buton
        {
            oyunIkiForm form3 = new oyunIkiForm();
            oyunIkiForm.oyunIkipuan = puan;
            form3.Show();
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) //ipucu butonu kullanımı
        {
            ipucukullanımı = "Evet";
            checkBox1.Visible = false;
            puan -= 500;
            oyun_skor.Text = puan.ToString();
            do
            {
                hint = rand.Next(1, 6);
            } while (ipucu[hint] == "false"); //hala bulunmayan bilgiler hakkında ipucu verilmesi için bu kod
            if (hint == 1)
            {
                label4.Visible = true;
                label3.Visible = true;
                label3.Text = "Aradığınız futbolcunun forma numarası = ";
                label4.Text = bilgiler[1];

            }
            else if (hint == 2)
            {
                label4.Visible = true;
                label3.Visible = true;
                label3.Text = "Aradığınız futbolcunun mevkisi = ";
                label4.Text = bilgiler[2];
            }
            else if (hint == 3)
            {
                label4.Visible = true;
                label3.Visible = true;
                label3.Text = "Aradığınız futbolcunun Kulüp takımı = ";
                label4.Text = bilgiler[3];
            }
            else if (hint == 4)
            {
                label4.Visible = true;
                label3.Visible = true;
                label3.Text = "Aradığınız futbolcunun milli takımı = ";
                label4.Text = bilgiler[4];
            }
            else if (hint == 5)
            {
                label4.Visible = true;
                label3.Visible = true;
                label3.Text = "Aradığınız futbolcunun yaşı = ";
                label4.Text = bilgiler[5];
            }



        }

        private void soundPictureBox_Click(object sender, EventArgs e) //şarkı açma kapama
        {
            if (location)
            {

                location = false;
                sound.Stop();
                soundPictureBox.Image = Properties.Resources.sound_off;
                oyunIkiForm.location = false;
            }
            else
            {
                location = true;
                sound.Play();
                soundPictureBox.Image = Properties.Resources.sound_on;
                oyunIkiForm.location = true;

            }
        }
    }
}
