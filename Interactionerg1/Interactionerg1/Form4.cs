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
        public Form4()
        {
            InitializeComponent();
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
    }
}
