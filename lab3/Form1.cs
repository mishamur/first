using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //double a = Double.Parse(textBoxA.Text);
            //double b = Double.Parse(textBoxB.Text);
            //int n = Int32.Parse(textBoxN.Text);
            double a = 0.1;
            double b = 1.0;
            int n = 80;

            double h = (b - a) / 10;
            textBoxH.Text = h.ToString();

            //шаг
            for(double x = a; x <= b; x += h)
            {
                x = Math.Round(x, 3);
                double sx = 0.0;
                double yx = 0.0;
                //сам ряд
                for (int i = 0; i <= n; i++)
                {
                    

                    
                    double temp = 1.0;
                    //факториал и степень
                    for(long j = 1; j <= (2 * i + 1); j++)
                    {
                        double now = temp * x / j;

                        temp = now;
                    }
                    
                    sx += temp;
                    
                    

                }
                yx = (Math.Exp(x) - Math.Exp(-x)) / 2;

                textBoxResult.Text += $"x: {x} sx: {Math.Round(sx, 8)}" + Environment.NewLine;
                textBoxResult.Text += $"x: {x} yx: {Math.Round(yx, 8)}" + Environment.NewLine;
                textBoxResult.Text += $"------------------------------" + Environment.NewLine;

            }



        }


    }
}
