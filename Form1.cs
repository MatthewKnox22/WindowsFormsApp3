using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public static class global
        {
            public static double cost = 0;
            public static double coke = 20;
            public static double fanta = 20;
            public static double sprite = 20;
            public static double gingerale = 20;
            public static double mtndew = 20;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (global.coke == 0)
            {
                textBox1.Text = "sold out";
            }
            else
            {
                global.coke = global.coke - 1;
                textBox1.Text = global.coke.ToString();
                global.cost = global.cost + 1.50;
                textBox6.Text = global.cost.ToString("c");
            }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (global.fanta == 0)
            {
                textBox2.Text = "sold out";
            }
            else
            {
                global.fanta = global.fanta - 1;
                textBox2.Text = global.coke.ToString();
                global.cost = global.cost + 1.50;
                textBox6.Text = global.cost.ToString("c");
            }
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (global.sprite == 0)
            {
                textBox3.Text = "sold out";
            }
            else
            {
                global.sprite = global.sprite - 1;
                textBox3.Text = global.coke.ToString();
                global.cost = global.cost + 1.50;
                textBox6.Text = global.cost.ToString("c");
            }
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (global.gingerale == 0)
            {
                textBox4.Text = "sold out";
            }
            else
            {
                global.gingerale = global.gingerale - 1;
                textBox4.Text = global.gingerale.ToString();
                global.cost = global.cost + 1.50;
                textBox6.Text = global.cost.ToString("c");
            }
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (global.mtndew == 0)
            {
                textBox5.Text = "sold out";
            }
            else
            {
                global.mtndew = global.mtndew - 1;
                textBox5.Text = global.mtndew.ToString();
                global.cost = global.cost + 1.50;
                textBox6.Text = global.cost.ToString("c");
            }
        }
    }
}
