using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interactionerg1
{
    public partial class Form3 : Form
    {
        public static int lbfb = 0;
        public static int lbfs = 0;
        public static int lbs = 0;
        public static int lbfk = 0;
        public static int lbfy = 0;
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
            progressBar1.Value = trackBar2.Value;
            label34.Text = trackBar2.Value.ToString() + "0% ΓΕΜΑΤΗ";
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
            label31.Text = trackBar1.Value.ToString() + " ΒΑΘΜΟΙ ΚΕΛΣΙΟΥ";
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

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            label8.Text = trackBar3.Value.ToString() + " ΒΑΘΜΟΙ ΚΕΛΣΙΟΥ";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (productvalue8 < 100)
            {
                productvalue8 = productvalue8 + 1;
                labelproduct8.Text = productvalue8.ToString();
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

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonfd_Click(object sender, EventArgs e)
        {
            if (lbfs == 0)
            {
                buttonfs.Text = "ΑΝΟΙΧΤΟ";
                lbfs = 1;
                lbfsa.Text = "Το φώς είναι ανοιχτό";
            }
            else
            {
                buttonfs.Text = "ΚΛΕΙΣΤΟ";
                lbfs = 0;
                lbfsa.Text = "Το φώς είναι κλειστό";
            }
        }

        private void buttonfk_Click(object sender, EventArgs e)
        {
            if (lbfk == 0)
            {
                buttonfk.Text = "ΑΝΟΙΧΤΟ";
                lbfk = 1;
                lbfka.Text = "Το φώς είναι ανοιχτό";
            }
            else
            {
                buttonfk.Text = "ΚΛΕΙΣΤΟ";
                lbfk = 0;
                lbfka.Text = "Το φώς είναι κλειστό";
            }
        }

        private void buttonfb_Click(object sender, EventArgs e)
        {
            if (lbfb == 0)
            {
                buttonfb.Text = "ΑΝΟΙΧΤΟ";
                lbfb = 1;
                lbfba.Text = "Το φώς είναι ανοιχτό";
            }
            else
            {
                buttonfb.Text = "ΚΛΕΙΣΤΟ";
                lbfb = 0;
                lbfba.Text = "Το φώς είναι κλειστό";
            }
        }

        private void buttonfy_Click(object sender, EventArgs e)
        {
            if (lbfy == 0)
            {
                buttonfy.Text = "ΑΝΟΙΧΤΟ";
                lbfy = 1;
                lbfya.Text = "Το φώς είναι ανοιχτό";
            }
            else
            {
                buttonfy.Text = "ΚΛΕΙΣΤΟ";
                lbfy = 0;
                lbfya.Text = "Το φώς είναι κλειστό";
            }
        }

        private void buttons_Click(object sender, EventArgs e)
        {
            if (lbs == 0)
            {
                buttons.Text = "ΕΝΕΡΓΟΠΟΙΗΜΕΝΟΣ";
                lbs = 1;
                lbsa.Text = "Ο συναγερμός είναι ενεργοποιημένος";
            }
            else
            {
                buttons.Text = "ΑΠΕΝΕΡΓΟΠΟΙΗΜΕΝΟΣ";
                lbs = 0;
                lbsa.Text = "Ο συναγερμός είναι απενεργοποιημένος";
            }
        }
    }
}
