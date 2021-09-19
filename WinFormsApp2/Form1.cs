using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            double x = Double.Parse( textBox1.Text);
            double y = Double.Parse( textBox2.Text);
            double z = Double.Parse( textBox3.Text);

            double a = Math.Sqrt(10 * (Math.Pow(x, (1.0/3.0)) + Math.Pow(x, y + 2)));
            
            double b = Math.Asin(z) * Math.Asin(z) - Math.Abs(x - y);
            
            
            double r = a * b;
            r = Math.Round(r, 5);
            textBox4.Text = r.ToString();

            int k = Math.Abs((int)((r * 10) % 10));
            textBoxK.Text = k.ToString();
        }
    }
}
