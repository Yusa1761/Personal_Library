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
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AnimeListesi_form animeListesi_Form = new AnimeListesi_form();

            animeListesi_Form.Show();

            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TV_Shows tV_Shows = new TV_Shows();

            tV_Shows.Show();

            this.Hide();
        }
    }
}
