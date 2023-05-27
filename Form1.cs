using System.Data.SqlClient;
using System.Media;
using yaho2.Properties;

namespace yaho2
{
    public partial class girisSayfasiForm : Form
    {
        public SoundPlayer sound = new SoundPlayer(Properties.Resources.k�s�kwaka);

        public static bool location = true;
        public static string kullan�c�_ad�;
        SqlConnection connection = new SqlConnection("Data Source=BERKAY\\SQL;Initial Catalog=worldcup2014;Integrated Security=True");
        SqlCommand command = new SqlCommand();
        SqlCommand command1 = new SqlCommand();
        SqlCommand command2 = new SqlCommand();
        public static int sark�sayac = 0;

        private int yaz�s�resi = 3000;


        public void arkaplan() //arkapalan� ayarlarda se�ilen resim yap�yoruz

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
            string kelime = isim.Text; //girilen kullan�c� ad� uzunluk kontrol� i�in
            SqlDataReader oku;
            connection.Open();
            command.Connection = connection;
            command.CommandText = "select  skor_sayac from sayac "; //ka� ki�ilik bir listemiz var diye sqlden bilgi �ekiyoruz
            oku = command.ExecuteReader();
            oku.Read();
            uzunluk = Convert.ToInt32(oku[0]);
            connection.Close();
            bool buyukHarfVarMi = false;

            foreach (char harf in kelime) //b�y�k harf kontrol�
            {
                if (char.IsUpper(harf)) 

                {
                    buyukHarfVarMi = true;
                    break;
                }
            }
            for (int i = 1; i <= uzunluk; i++) //ayn� isimden var m� kontrol�
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "select kullan�c�,skor_id from skorboard where skor_id=" + i;
                oku = command.ExecuteReader();
                oku.Read();
                if (isim.Text == oku[0].ToString()) { deneme = 1; connection.Close(); break; }
                connection.Close();
            }


            if (isim.Text == "")
            {
                MessageBox.Show("Takma isim k�sm� bo� b�rak�lamaz.", "Uyar�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (kelime.Length > 12)
            {
                MessageBox.Show("Takma isim en fazla 12 karakterli olabilir.", "Uyar�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (kelime.Length < 3)
            {
                MessageBox.Show("Takma isim en az 3 karakterli olmal�.", "Uyar�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (deneme == 1)
            {

                MessageBox.Show("Bu isim al�nm�� farkl� bir tane deneyiniz.", "Uyar�", MessageBoxButtons.OK, MessageBoxIcon.Warning);



            }
            else if (buyukHarfVarMi == true)
            {
                MessageBox.Show("l�tfen k���k harf bir tane deneyiniz.", "Uyar�", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {


                zorluksecim zorlukform = new zorluksecim();
                DialogResult result = zorlukform.ShowDialog(); //zorluk formu ekranda durabilsin diye
                kullan�c�_ad� = isim.Text;
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

            if ((MessageBox.Show("Kapatmak istedi�inizden emin misin?", "Uyar�", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                Application.Exit();
            }
        }
        private void pictureBox2_Click(object sender, EventArgs e) //�ark� a�ma kapama i�in
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

        public void timer1_Tick(object sender, EventArgs e) //zorluk modundan sonra progress bar �al��mas� i�in ve di�er forma ge�i�
        {
            progressBar1.Visible = true;
            Loading_label.Visible = true;

            if (progressBar1.Value <= 99)
            {

                progressBar1.Value = progressBar1.Value + 1;
                Loading_label.Text = "Ba�lat�l�yor...:  %" + progressBar1.Value;
            }
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                oyunBirForm form2 = new oyunBirForm();
                form2.Show();
                this.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e) //ayarlara ge�i�
        {
            Ayarlar fr = new Ayarlar();
            fr.Show();
            this.Close();
        }

        private void girisSayfasiForm_Load(object sender, EventArgs e)
        {
            // buradan 213. sat�ra kadar skor tablosu i�ine bilgi atmak i�in gereken kod en iyi 3 � al�yor
            SqlDataReader oku, oku1, oku2;
            string adc�k;
            connection.Open();
            command.Connection = connection;
            command.CommandText = "select top 1 * from skorboard order by Skor desc";
            oku = command.ExecuteReader();
            oku.Read();
            listView1.Items[0].SubItems[1].Text = oku[0].ToString();
            listView1.Items[0].SubItems[2].Text = oku[1].ToString();
            command1.Connection = connection;
            adc�k = oku[0].ToString();
            command1.CommandText = "select top 7 * from skorboard where Skor <=" + oku[1] + "and kullan�c� !='" + oku[0] + "' order by Skor desc ";//AYNI PUAN GET�RMEY� AYARLA
            oku.Close();
            connection.Close();

            connection.Open();
            oku1 = command1.ExecuteReader();
            oku1.Read();
            listView1.Items[1].SubItems[1].Text = oku1[0].ToString();
            listView1.Items[1].SubItems[2].Text = oku1[1].ToString();
            command2.Connection = connection;
            command2.CommandText = "select top 7 * from skorboard where Skor <= " + oku1[1] + "and kullan�c� !='" + oku1[0] + "'and kullan�c� !='" + adc�k + "' order by Skor desc ";
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


            if (location == false) // �ark� a�ma kapama
            {



                soundPictureBox.Image = Properties.Resources.sound_off;

            }
            else
            {

                soundPictureBox.Image = Properties.Resources.sound_on;
            }
            if (sark�sayac == 0) //ayarlar veya form 4 ten ilk forma d�n�l�nce �ark� en ba�tan ba�l�yordu o y�zden saya� eklendi en son ne kal�rsa o geliyor
                sound.PlayLooping();

        }
        private void oyunBilgisiIkon_MouseEnter(object sender, EventArgs e) //fare �zerine gelindi�inde nas�l oynan�r butonu i�eri�i
        {
            string uyar�Mesaj� = "Daha �ok puan kazanmak i�in zorlu�u artt�rabilirsiniz. \n Ancak bu size sunulan s�reyi k�saltaca��n� unutmay�n.\n" +
                "1.Oyunda do�ru futbolcuyu bulmak i�in girdi�iniz futbolcular�n size verdi�i bilgilerden yararlan�n. \n K�rm�z� yanl�� Ye�il do�ru bilgi anlam�na gelmektedir. \n" +
                "2.Oyunda verilen sorulara, do�ru d���nd���n�z futbolcuyu se�erek ilerleyin.";


            toolTip.Show(uyar�Mesaj�, oyunBilgisiIkon, oyunBilgisiIkon.Width, oyunBilgisiIkon.Height, 30000000);

        }

        private void oyunBilgisiIkon_MouseLeave(object sender, EventArgs e) //fare �ekildi�inde bo�luk gelicek
        {
            toolTip.SetToolTip(oyunBilgisiIkon, string.Empty);

        }

    }
}