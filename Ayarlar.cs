using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yaho2
{
    public partial class Ayarlar : Form
    {
        public SoundPlayer sound = new SoundPlayer(Properties.Resources.kısıkwaka);

        public static bool location = true;
        public static Image resim = Properties.Resources.rengarenk;
        public void arkaplan() //arkaplan değiştirmek için
        {
            this.BackgroundImage = resim;

        }
        public Ayarlar()
        {
            InitializeComponent();
            arkaplan();
        }

        private void Ayarlar_Load(object sender, EventArgs e)   //müzik butonu değişimi
        {
            if (location == false)
            {



                soundPictureBox.Image = Properties.Resources.sound_off;

            }
        }

        private void button1_Click(object sender, EventArgs e) // butona basıldığında seçilen resmi tutuyoruz ve arkaplan fonksiyonuyla değiştiriyoruz
        {
            int value = trackBar1.Value;

            label1.Text = value.ToString();

            if (value >= 0 && value <= 25)
            {
                resim = Properties.Resources.rengarenk;
                arkaplan();
            }
            else if (value > 25 && value <= 50)
            {
                resim = Properties.Resources.mavigold;
                arkaplan();
            }
            else if (value > 50 && value <= 75)
            {
                resim = Properties.Resources.siyahgold;
                arkaplan();
            }
            else
            {
                resim = Properties.Resources.siyahbeyaz;
                arkaplan();
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            girisSayfasiForm.sarkısayac++;  //giriş sayfasına geçerken şarkıyı yeniden başlatmamak için
            girisSayfasiForm fr = new girisSayfasiForm();
            fr.Show();
            this.Close();
        }

        private void pictureBox6_Click(object sender, EventArgs e) //uygulama kapatma butonu
        {
            if ((MessageBox.Show("Kapatmak istediğinizden emin misin?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                Application.Exit();
            }
        }

        private void soundPictureBox_Click(object sender, EventArgs e) //şarkının çalması için
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
    }
}
