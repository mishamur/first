using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBoxInput_KeyUp(object sender, KeyEventArgs e)
        {
            textBox2.Text = "";
            //парсинг числа в строке
            string inputStr = textBoxInput.Text.ToString();

            string number = "";
            bool flag = false;

            for(int i = 0; i < inputStr.Length; i++) 
            {
                if(flag == false)
                {

                    if (inputStr[i] == '+' | inputStr[i] == '-')
                    {
                        flag = true;
                        number = inputStr[i].ToString();
                    }

                }
                else
                {
                    
                    
                    
                    if (char.IsDigit(inputStr[i]))
                    {
                        number += inputStr[i];
                        textBox2.Text += number + Environment.NewLine;
                    }
                    else if (inputStr[i] == '+' | inputStr[i] == '-')
                    {
                        
                        number = inputStr[i].ToString();
                    }
                    else
                    {
                        number = "";
                        flag = false;
                    }
                }

            }
        }
    }
}
