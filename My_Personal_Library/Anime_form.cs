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
    public partial class AnimeListesi_form : Form
    {
        public AnimeListesi_form()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://gogoanime.lu/category/overlord-iv");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://gogoanime.lu/category/one-piece");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://gogoanime.lu/category/one-piece-dub");
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://gogoanime.lu//search.html?keyword=DUNGEON%20NI%20DEAI%20WO%20MOTOMERU%20NO%20WA%20MACHIGATTEIRU");
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://gogoanime.lu//search.html?keyword=boku%20no%20hero");
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://gogoanime.lu//search.html?keyword=mushoku");
        }

        private void linkLabel4_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://gogoanime.lu//search.html?keyword=tensei%20shitara");
        }

        private void AnimeListesi_form_Load(object sender, EventArgs e)
        {

        }

        
    }
}
