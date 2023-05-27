using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yaho2
{
    public partial class acilis : Form
    {
        public acilis()
        {
            InitializeComponent();
        }
        bool control = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (control == false)
            {
                this.Opacity += 0.009;
            }
            if (this.Opacity == 1.0)
            {
                control = true;
            }
            if (control == true)
            {
                this.Opacity -= 0.009;
            }
            if (this.Opacity == 0)
            {
                girisSayfasiForm form1 = new girisSayfasiForm();
                this.Hide();
                form1.Show();
                timer1.Enabled = false;
            }
        }
    }
}
