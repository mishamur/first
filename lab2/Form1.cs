using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class Form1 : Form
    {

        public string rbName  { get; set; }

        public Form1()
        {
            InitializeComponent();
            rbName = "radioButton1";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = Double.Parse(textBox1.Text);
            double y = Double.Parse(textBox2.Text);
            
            double fx = Math.Sinh(x);

            switch (rbName)
            {
                case "radioButton1": fx = Math.Sinh(x);
                    break;

                case "radioButton2": fx = Math.Pow(x, 2);
                    break;

                case "radioButton3": fx = Math.Exp(x);
                    break;

            }

            double result = 0;

            if(((x * y) > 0.5) && ( (x * y ) < 10))
            {
                result = Math.Round(Math.Exp(fx - Math.Abs(y)), 4);
                textBox4.Text = result.ToString();//"Сработало первое условие";
            }
            else if (((x * y) > 0.1) && ((x * y) < 0.5))
            {
                result = Math.Round(Math.Sqrt(fx + y), 4);
                textBox4.Text = result.ToString(); //"Сработало второе условие";
            }
            else
            {
                result = Math.Round(2 * Math.Pow(fx, 2), 4);
                textBox4.Text = result.ToString(); //"ни одно условие не сработало";
               // textBox4.Text = "ни одно условие не сработало";
            }

            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
            RadioButton radioButton = (RadioButton)sender;
            this.rbName = radioButton.Name;
            //textBox4.Text = this.rbName.ToString();

        }
    }
}
