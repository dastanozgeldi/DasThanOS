using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testProj
{
    public partial class OS : Form
    {
        public OS()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Calculator calc = new Calculator();
            calc.Show();
        }

        private void buttonSendFeedback_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks for the feedback! We will try to imrpove geometrically.");
            richTextBox1.Clear();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Lotto lotto = new Lotto();
            lotto.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Media media = new Media();
            media.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Dio dio = new Dio();
            dio.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Calendar calendar = new Calendar();
            calendar.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Music music = new Music();
            music.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.github.com/Dositan");
        }
    }
}
