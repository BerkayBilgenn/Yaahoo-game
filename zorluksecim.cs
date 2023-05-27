using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace yaho2
{
    public partial class zorluksecim : Form
    {
        public static int zorluk;


        public zorluksecim()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            oyunIkiForm fr = new oyunIkiForm();

            if (radioButton1.Checked)       //seçilen zorluk moduna göre soru süresi
            {

                zorluk = 21;

            }
            else if (radioButton2.Checked)
            {

                zorluk = 16;

            }
            else
            {
                zorluk = 11;

            }

            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
