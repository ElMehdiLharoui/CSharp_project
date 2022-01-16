using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace image
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void shoo_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                pictureBox2.Load(openFileDialog1.FileName);
            }
        }

        private void thebg_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                pictureBox2.BackColor = colorDialog1.Color;
        }

        private void cleaaar_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = null;
        }

        private void clooose_Click(object sender, EventArgs e)
        {
            MessageBox.Show("see you next time a batal ");
            this.Close();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            else
                pictureBox2.SizeMode = PictureBoxSizeMode.Normal;
        }
        
    }
}
