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
    public partial class Lotto : Form
    {
        public Lotto()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int n;
            n = new Random().Next(10, 100);
            textBox1.Text = n.ToString();
            n = new Random().Next(20, 100);
            textBox2.Text = n.ToString();
            n = new Random().Next(30, 100);
            textBox3.Text = n.ToString();
            n = new Random().Next(40, 100);
            textBox4.Text = n.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            // Check if the user won.
            if (textBox1.Text == textBox2.Text && textBox2.Text == textBox3.Text && textBox3.Text == textBox4.Text)
            {
                MessageBox.Show("You've won in this round!");
            }
        }
    }
}
