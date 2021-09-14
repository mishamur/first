using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
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

        private void button1_Click(object sender, EventArgs e)
        {
            double x = float.Parse(textBox1.Text);
            double y = float.Parse(textBox2.Text);
            double z = float.Parse(textBox3.Text);

            double a = Math.Pow((Math.Sin(x + y) / Math.Cos(x + y)), 2);
            double p = Math.Exp(y - z);
            double c = Math.Sqrt(Math.Cos(Math.Pow(x, 2)) + Math.Sin(Math.Pow(z, 2)));
            double u = a - p * c;
            textBox4.Text = Math.Round(u, 3).ToString("##.####");




        }
    }
}
