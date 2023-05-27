using System.Data.SqlClient;
using System.Media;
using yaho2.Properties;

namespace yaho2
{
    public partial class girisSayfasiForm : Form
    {
        public SoundPlayer sound = new SoundPlayer(Properties.Resources.kýsýkwaka);

        public static bool location = true;
        public static string kullanýcý_adý;
        SqlConnection connection = new SqlConnection("Data Source=BERKAY\\SQL;Initial Catalog=worldcup2014;Integrated Security=True");
        SqlCommand command = new SqlCommand();
        SqlCommand command1 = new SqlCommand();
        SqlCommand command2 = new SqlCommand();
        public static int sarkýsayac = 0;

        private int yazýsüresi = 3000;


        public void arkaplan() //arkapalaný ayarlarda seçilen resim yapýyoruz

        {
            this.BackgroundImage = Ayarlar.resim;

        }

        public girisSayfasiForm()
        {

            InitializeComponent();
            arkaplan();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            int uzunluk;
            int deneme = 0;
            string kelime = isim.Text; //girilen kullanýcý adý uzunluk kontrolü için
            SqlDataReader oku;
            connection.Open();
            command.Connection = connection;
            command.CommandText = "select  skor_sayac from sayac "; //kaç kiþilik bir listemiz var diye sqlden bilgi çekiyoruz
            oku = command.ExecuteReader();
            oku.Read();
            uzunluk = Convert.ToInt32(oku[0]);
            connection.Close();
            bool buyukHarfVarMi = false;

            foreach (char harf in kelime) //büyük harf kontrolü
            {
                if (char.IsUpper(harf)) 

                {
                    buyukHarfVarMi = true;
                    break;
                }
            }
            for (int i = 1; i <= uzunluk; i++) //ayný isimden var mý kontrolü
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "select kullanýcý,skor_id from skorboard where skor_id=" + i;
                oku = command.ExecuteReader();
                oku.Read();
                if (isim.Text == oku[0].ToString()) { deneme = 1; connection.Close(); break; }
                connection.Close();
            }


            if (isim.Text == "")
            {
                MessageBox.Show("Takma isim kýsmý boþ býrakýlamaz.", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (kelime.Length > 12)
            {
                MessageBox.Show("Takma isim en fazla 12 karakterli olabilir.", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (kelime.Length < 3)
            {
                MessageBox.Show("Takma isim en az 3 karakterli olmalý.", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (deneme == 1)
            {

                MessageBox.Show("Bu isim alýnmýþ farklý bir tane deneyiniz.", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);



            }
            else if (buyukHarfVarMi == true)
            {
                MessageBox.Show("lütfen küçük harf bir tane deneyiniz.", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {


                zorluksecim zorlukform = new zorluksecim();
                DialogResult result = zorlukform.ShowDialog(); //zorluk formu ekranda durabilsin diye
                kullanýcý_adý = isim.Text;
                if (result == DialogResult.OK)
                {
                    progressBar1.Value = 0;
                    timer1.Start();
                }
                isim.Enabled = false;
                button1.Enabled = false;
            }








        }
        private void xButton_Click(object sender, EventArgs e) //oyunu kapatma butonu
        {

            if ((MessageBox.Show("Kapatmak istediðinizden emin misin?", "Uyarý", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                Application.Exit();
            }
        }
        private void pictureBox2_Click(object sender, EventArgs e) //þarký açma kapama için
        {
            if (location)
            {

                location = false;
                sound.Stop();
                soundPictureBox.Image = Properties.Resources.sound_off;
                oyunBirForm.location = false;
                Ayarlar.location = false;
            }
            else
            {
                location = true;
                sound.Play();
                soundPictureBox.Image = Properties.Resources.sound_on;
            }
        }

        public void timer1_Tick(object sender, EventArgs e) //zorluk modundan sonra progress bar çalýþmasý için ve diðer forma geçiþ
        {
            progressBar1.Visible = true;
            Loading_label.Visible = true;

            if (progressBar1.Value <= 99)
            {

                progressBar1.Value = progressBar1.Value + 1;
                Loading_label.Text = "Baþlatýlýyor...:  %" + progressBar1.Value;
            }
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                oyunBirForm form2 = new oyunBirForm();
                form2.Show();
                this.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e) //ayarlara geçiþ
        {
            Ayarlar fr = new Ayarlar();
            fr.Show();
            this.Close();
        }

        private void girisSayfasiForm_Load(object sender, EventArgs e)
        {
            // buradan 213. satýra kadar skor tablosu içine bilgi atmak için gereken kod en iyi 3 ü alýyor
            SqlDataReader oku, oku1, oku2;
            string adcýk;
            connection.Open();
            command.Connection = connection;
            command.CommandText = "select top 1 * from skorboard order by Skor desc";
            oku = command.ExecuteReader();
            oku.Read();
            listView1.Items[0].SubItems[1].Text = oku[0].ToString();
            listView1.Items[0].SubItems[2].Text = oku[1].ToString();
            command1.Connection = connection;
            adcýk = oku[0].ToString();
            command1.CommandText = "select top 7 * from skorboard where Skor <=" + oku[1] + "and kullanýcý !='" + oku[0] + "' order by Skor desc ";//AYNI PUAN GETÝRMEYÝ AYARLA
            oku.Close();
            connection.Close();

            connection.Open();
            oku1 = command1.ExecuteReader();
            oku1.Read();
            listView1.Items[1].SubItems[1].Text = oku1[0].ToString();
            listView1.Items[1].SubItems[2].Text = oku1[1].ToString();
            command2.Connection = connection;
            command2.CommandText = "select top 7 * from skorboard where Skor <= " + oku1[1] + "and kullanýcý !='" + oku1[0] + "'and kullanýcý !='" + adcýk + "' order by Skor desc ";
            oku1.Close();
            connection.Close();

            connection.Open();
            oku2 = command2.ExecuteReader();
            oku2.Read();
            listView1.Items[2].SubItems[1].Text = oku2[0].ToString();
            listView1.Items[2].SubItems[2].Text = oku2[1].ToString();

            oku2.Close();
            connection.Close();
            oyunBilgisiIkon.MouseEnter += new EventHandler(oyunBilgisiIkon_MouseEnter);
            oyunBilgisiIkon.MouseLeave += new EventHandler(oyunBilgisiIkon_MouseLeave);


            if (location == false) // þarký açma kapama
            {



                soundPictureBox.Image = Properties.Resources.sound_off;

            }
            else
            {

                soundPictureBox.Image = Properties.Resources.sound_on;
            }
            if (sarkýsayac == 0) //ayarlar veya form 4 ten ilk forma dönülünce þarký en baþtan baþlýyordu o yüzden sayaç eklendi en son ne kalýrsa o geliyor
                sound.PlayLooping();

        }
        private void oyunBilgisiIkon_MouseEnter(object sender, EventArgs e) //fare üzerine gelindiðinde nasýl oynanýr butonu içeriði
        {
            string uyarýMesajý = "Daha çok puan kazanmak için zorluðu arttýrabilirsiniz. \n Ancak bu size sunulan süreyi kýsaltacaðýný unutmayýn.\n" +
                "1.Oyunda doðru futbolcuyu bulmak için girdiðiniz futbolcularýn size verdiði bilgilerden yararlanýn. \n Kýrmýzý yanlýþ Yeþil doðru bilgi anlamýna gelmektedir. \n" +
                "2.Oyunda verilen sorulara, doðru düþündüðünüz futbolcuyu seçerek ilerleyin.";


            toolTip.Show(uyarýMesajý, oyunBilgisiIkon, oyunBilgisiIkon.Width, oyunBilgisiIkon.Height, 30000000);

        }

        private void oyunBilgisiIkon_MouseLeave(object sender, EventArgs e) //fare çekildiðinde boþluk gelicek
        {
            toolTip.SetToolTip(oyunBilgisiIkon, string.Empty);

        }

    }
}