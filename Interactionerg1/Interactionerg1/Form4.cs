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
    public partial class Form4 : Form
    {
        public static int productvalue1 = 0;
        public static int productvalue2 = 0;
        public static int productvalue3 = 0;
        public static int productvalue4 = 0;
        public static int productvalue5 = 0;
        public static int productvalue6 = 0;
        public static int productvalue7 = 0;
        public static int productvalue8 = 0;
        public static int productvalue9 = 0;
        public static int productvalue10 = 0;
        public static int productvalue11 = 0;
        public static int productvaluetotal = 0;
        int panelWidth;
        bool Hidden;
        public Form4()
        {
            InitializeComponent();
            panelWidth = panelSlide.Width;
            Hidden = false;
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            pictureBoxlocation.Location = new Point(pictureBoxlocation.Location.X, pictureBoxlocation.Location.Y - 5);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            pictureBoxlocation.Location = new Point(pictureBoxlocation.Location.X, pictureBoxlocation.Location.Y + 5);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            pictureBoxlocation.Location = new Point(pictureBoxlocation.Location.X - 5, pictureBoxlocation.Location.Y);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            pictureBoxlocation.Location = new Point(pictureBoxlocation.Location.X + 5, pictureBoxlocation.Location.Y);
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
                    Hidden = false;
                    this.Refresh();
                }
            }
            else
            {
                panelSlide.Width = panelSlide.Width - 5;
                if (panelSlide.Width <= 0)
                {
                    timer1.Stop();
                    Hidden = true;
                    this.Refresh();
                }
            }
        }

        private void productbutton1minus_Click(object sender, EventArgs e)
        {
            if (productvalue1 > 0)
            {
                productvalue1 = productvalue1 - 1;
                labelproduct1.Text = productvalue1.ToString();
            }
        }

        private void productbutton1plus_Click(object sender, EventArgs e)
        {
            if (productvalue1 < 100)
            {
                productvalue1 = productvalue1 + 1;
                labelproduct1.Text = productvalue1.ToString();
            }
        }

        private void productbutton2minus_Click(object sender, EventArgs e)
        {
            if (productvalue2 > 0)
            {
                productvalue2 = productvalue2 - 1;
                labelproduct2.Text = productvalue2.ToString();
            }
        }

        private void productbutton2plus_Click(object sender, EventArgs e)
        {
            if (productvalue2 < 100)
            {
                productvalue2 = productvalue2 + 1;
                labelproduct2.Text = productvalue2.ToString();
            }
        }

        private void productbutton3minus_Click(object sender, EventArgs e)
        {
            if (productvalue3 > 0)
            {
                productvalue3 = productvalue3 - 1;
                labelproduct3.Text = productvalue3.ToString();
            }
        }

        private void productbutton3plus_Click(object sender, EventArgs e)
        {
            if (productvalue3 < 100)
            {
                productvalue3 = productvalue3 + 1;
                labelproduct3.Text = productvalue3.ToString();
            }
        }

        private void productbutton4minus_Click(object sender, EventArgs e)
        {
            if (productvalue4 > 0)
            {
                productvalue4 = productvalue4 - 1;
                labelproduct4.Text = productvalue4.ToString();
            }
        }

        private void productbutton4plus_Click(object sender, EventArgs e)
        {
            if (productvalue4 < 100)
            {
                productvalue4 = productvalue4 + 1;
                labelproduct4.Text = productvalue4.ToString();
            }
        }

        private void productbutton5minus_Click(object sender, EventArgs e)
        {
            if (productvalue5 > 0)
            {
                productvalue5 = productvalue5 - 1;
                labelproduct5.Text = productvalue5.ToString();
            }
        }

        private void productbutton5plus_Click(object sender, EventArgs e)
        {
            if (productvalue5 < 100)
            {
                productvalue5 = productvalue5 + 1;
                labelproduct5.Text = productvalue5.ToString();
            }
        }

        private void productbutton6minus_Click(object sender, EventArgs e)
        {
            if (productvalue6 > 0)
            {
                productvalue6 = productvalue6 - 1;
                labelproduct6.Text = productvalue6.ToString();
            }
        }

        private void productbutton6plus_Click(object sender, EventArgs e)
        {
            if (productvalue6 < 100)
            {
                productvalue6 = productvalue6 + 1;
                labelproduct6.Text = productvalue6.ToString();
            }
        }

        private void productbutton7minus_Click(object sender, EventArgs e)
        {
            if (productvalue7 > 0)
            {
                productvalue7 = productvalue7 - 1;
                labelproduct7.Text = productvalue7.ToString();
            }
        }

        private void productbutton7plus_Click(object sender, EventArgs e)
        {
            if (productvalue7 < 100)
            {
                productvalue7 = productvalue7 + 1;
                labelproduct7.Text = productvalue7.ToString();
            }
        }

        private void productbutton8minus_Click(object sender, EventArgs e)
        {
            if (productvalue8 > 0)
            {
                productvalue8 = productvalue8 - 1;
                labelproduct8.Text = productvalue8.ToString();
            }
        }

        private void productbutton8plus_Click(object sender, EventArgs e)
        {
            if (productvalue8 < 100)
            {
                productvalue8 = productvalue8 + 1;
                labelproduct8.Text = productvalue8.ToString();
            }
        }

        private void productbutton9minus_Click(object sender, EventArgs e)
        {
            if (productvalue9 > 0)
            {
                productvalue9 = productvalue9 - 1;
                labelproduct9.Text = productvalue9.ToString();
            }
        }

        private void productbutton9plus_Click(object sender, EventArgs e)
        {
            if (productvalue9 < 100)
            {
                productvalue9 = productvalue9 + 1;
                labelproduct9.Text = productvalue9.ToString();
            }
        }

        private void productbutton10minus_Click(object sender, EventArgs e)
        {
            if (productvalue10 > 0)
            {
                productvalue10 = productvalue10 - 1;
                labelproduct10.Text = productvalue10.ToString();
            }
        }

        private void productbutton10plus_Click(object sender, EventArgs e)
        {
            if (productvalue10 < 100)
            {
                productvalue10 = productvalue10 + 1;
                labelproduct10.Text = productvalue10.ToString();
            }
        }

        private void productbutton11minus_Click(object sender, EventArgs e)
        {
            if (productvalue11 > 0)
            {
                productvalue11 = productvalue11 - 1;
                labelproduct11.Text = productvalue11.ToString();
            }
        }

        private void productbutton11plus_Click(object sender, EventArgs e)
        {
            if (productvalue11 < 100)
            {
                productvalue11 = productvalue11 + 1;
                labelproduct11.Text = productvalue11.ToString();
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            productvaluetotal = productvalue1 * 4 + productvalue2 * 4 + productvalue3 * 3 + productvalue4 * 3 + productvalue5 * 10 + productvalue6 * 25 + productvalue7 * 10 + productvalue8 * 5 + productvalue9 * 6 + productvalue10 * 10 + productvalue11 * 13;

            if (radioButton13.Checked)
            {
                MessageBox.Show("Το ποσό πληρωμής είναι " + productvaluetotal);
            }

            if (radioButton14.Checked)
            {
                MessageBox.Show("Το ποσό πληρωμής είναι " + productvaluetotal);
                Form5 form5 = new Form5();
                form5.ShowDialog();
            }
        }
    }
}
