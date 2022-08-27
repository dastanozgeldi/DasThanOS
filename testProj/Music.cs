using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace testProj
{
    public partial class Music : Form
    {
        SoundPlayer player = null;
        string filename = string.Empty;
        public Music()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog()
            {
                Filter = "WAV (.wav)|*.wav",
                Multiselect = false,
                ValidateNames = true
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filename = textBox1.Text = ofd.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            player.Play();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            player.Stop();
        }
    }
}
