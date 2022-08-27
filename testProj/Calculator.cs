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
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text), b = Convert.ToDouble(textBox2.Text);
            textBox3.Text = (a + b).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text), b = Convert.ToDouble(textBox2.Text);
            textBox3.Text = (a - b).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text), b = Convert.ToDouble(textBox2.Text);
            textBox3.Text = (a * b).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text), b = Convert.ToDouble(textBox2.Text);
            textBox3.Text = (a / b).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox3.Text;
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double r, l, s, d;
            if (string.IsNullOrEmpty(textBox4.Text) && string.IsNullOrEmpty(textBox5.Text) && string.IsNullOrEmpty(textBox6.Text) && string.IsNullOrEmpty(textBox7.Text))
            {
                MessageBox.Show("All fields are empty, please fill at least one.");
                return;
            }

            if (textBox4.Text != null && string.IsNullOrEmpty(textBox5.Text) && string.IsNullOrEmpty(textBox6.Text) && string.IsNullOrEmpty(textBox7.Text))
            {
                r = Convert.ToDouble(textBox4.Text);
                l = 2 * Math.PI * r;
                s = Math.PI * r * r;
                d = 2 * r;
                textBox5.Text = l.ToString();
                textBox6.Text = s.ToString();
                textBox7.Text = d.ToString();
            }
            else if (string.IsNullOrEmpty(textBox4.Text) && textBox5.Text != null && string.IsNullOrEmpty(textBox6.Text) && string.IsNullOrEmpty(textBox7.Text))
            {
                l = Convert.ToDouble(textBox5.Text);
                r = l / 2 * Math.PI;
                s = Math.PI * r * r;
                d = 2 * r;
                textBox4.Text = r.ToString();
                textBox6.Text = s.ToString();
                textBox7.Text = d.ToString();
            }
            else if (string.IsNullOrEmpty(textBox4.Text) && string.IsNullOrEmpty(textBox5.Text) && textBox6.Text != null && string.IsNullOrEmpty(textBox7.Text))
            {
                s = Convert.ToDouble(textBox6.Text);
                r = Math.Sqrt(s / Math.PI);
                l = 2 * Math.PI * r;
                d = 2 * r;
                textBox4.Text = r.ToString();
                textBox5.Text = l.ToString();
                textBox7.Text = d.ToString();
            }
            else if (string.IsNullOrEmpty(textBox4.Text) && string.IsNullOrEmpty(textBox5.Text) && string.IsNullOrEmpty(textBox6.Text) && textBox7.Text != null)
            {
                d = Convert.ToDouble(textBox7.Text);
                r = d / 2;
                l = 2 * Math.PI * r;
                s = Math.PI * r * r;
                textBox4.Text = r.ToString();
                textBox5.Text = l.ToString();
                textBox6.Text = s.ToString();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text), b = Convert.ToDouble(textBox2.Text);
            textBox3.Text = (a / 100 * b).ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text), starting = a,  b = Convert.ToInt32(textBox2.Text);
            while (b > 1)
            {
                a *= starting;
                b--;
            }
            textBox3.Text = a.ToString();
        }
    }
}
