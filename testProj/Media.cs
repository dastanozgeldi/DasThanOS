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
    public partial class Media : Form
    {
        public Media()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Open a Video/Audio File";
            open.Filter = "All Files|*.*";
            try
            {
                if (open.ShowDialog() == DialogResult.OK)
                {
                    axWindowsMediaPlayer1.URL = open.FileName;
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception) { } // Every other Exception kept here.
        }
    }
}
