using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Animeler
{
    public partial class Login_form : Form
    {
        public Login_form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Options options = new Options();


            string kullanıcı_adi, sifre;

            // kullanıcı_adi.ToLower() = txt_KulAD.Text;  Bu şekilde yazılmıyor buna dikkat et @@@@@

            kullanıcı_adi = txt_ID.Text.ToLower();
            sifre = txt_Password.Text;

            if (kullanıcı_adi == "yusa" && sifre == "1761")
            {


                options.Show();

                this.Hide();

            }

            else { MessageBox.Show("Invalid User ID or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }


        }
    }
}
