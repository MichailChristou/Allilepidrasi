using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interactionerg1
{
    public partial class Form3 : Form
    {
        int panelWidth;
        bool Hidden;
        public Form3()
        {
            InitializeComponent();
            panelWidth = panelSlide.Width;
            Hidden= false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Hidden) 
            {
                panelSlide.Width = panelSlide.Width + 5;
                if (panelSlide.Width >= panelWidth) 
                {
                    timer1.Stop();
                    Hidden= false;
                    this.Refresh();
                }
            }
            else
            {
                panelSlide.Width = panelSlide.Width - 5;
                if (panelSlide.Width <=0) 
                {
                    timer1.Stop();
                    Hidden = true; 
                    this.Refresh();
                }
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (radioButton14.Checked)
            {
                Form5 form5 = new Form5();
                form5.ShowDialog();
            }
        }
    }
}
