﻿using System;
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
    public partial class Form2 : Form
    {
        private const int V = 1;

        public Form2()
        {
            InitializeComponent();
        }
        private void menuButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void LoginPage_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {

                if (textBox1.Text == "d100")
                {
                    Form3 form3 = new Form3();
                    form3.ShowDialog();
                    this.Close();
                }
                else if (textBox1.Text == "t100")
                {
                    Form4 form4 = new Form4();
                    form4.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Λάθος username ή password");
                }

            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

       
    }
}
