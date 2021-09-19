using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace lab7
{
    public partial class Form1 : Form
    {
        public string oper { get; set; }

        public Form1()
        {
            InitializeComponent();
            oper = "radioButtonSum";
        }


        public static string f10_8(int num)
        {
            if (num < 0)
                return "-" + Convert.ToString(Math.Abs(num), 8);
            return Convert.ToString(num, 8);



        }

        public static int f8_10(string num)
        {
            int number;
            bool test = int.TryParse(num, out number);
            if(test == false)
            {
                throw new FormatException();
            }
            
            int result = 0;
            int b = 1;
            
            byte c = 0;
            if (num[0] == '-')
                c = 1;
            for(int i = num.Length - 1; i >= c; i--)
            {
               // result = num[i];
                result = result + b * (num[i] - '0');
                b *= 8;
                
            }
            if (c == 1)
                result = -result;

            return result;

            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int x;
            int y;
            string userResult;
            userResult = textBoxResult.Text;
            try
            {
                x = f8_10(textBoxX.Text.ToString());
                y = f8_10(textBoxY.Text.ToString());
                
            }
            catch (FormatException ex)
            {
                MessageBox.Show( " неверный формат");
                textBoxX.Text = "";
                textBoxY.Text = "";
                return;
            }
            
            
            string result = "";
            try
            {
                try
                {
                    try
                    {
                        switch (oper)
                        {
                            case "radioButtonSum":
                                result = f10_8(x + y);
                                break;

                            case "radioButtonSub":
                                result = f10_8(x - y);
                                break;

                            case "radioButtonMult":
                                result = f10_8(x * y);
                                break;
                            case "radioButtonDiv":
                                result = f10_8(x / y);

                                break;
                            case "radioButtonMod":
                                result = f10_8(x % y);
                                break;
                        }


                        if(userResult == result)
                        {
                            textBoxResult.BackColor = Color.LightGreen;
                            
                            
                            MessageBox.Show("Вы правы!");
                            
                        }
                        else
                        {
                            textBoxResult.BackColor = Color.IndianRed;
                            MessageBox.Show("Неверно!");
                        }

                        textBoxResult.Text = result;

                        
                    }
                    catch (OverflowException)
                    {

                        MessageBox.Show("переполнение при выполнении операци");

                    }

                }
                catch (DivideByZeroException)
                {
                    MessageBox.Show("нельзя делить на ноль");

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBoxX_KeyUp(object sender, KeyEventArgs e)
        {

            
        }

        private void textBoxX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((int)e.KeyChar == 08 || e.KeyChar == '-')
            {
                return;
            }

            if ((e.KeyChar < '0' | e.KeyChar >= '8')) 
            {
                MessageBox.Show("Возможно цифры лишь от 0 до 7");
                if(e.KeyChar != '-' | e.KeyChar != '+')
                {
                    
                    e.Handled = true;
                }
                
            }
        }

        private void radioButtonSum_CheckedChanged(object sender, EventArgs e)
        {
            this.oper = "radioButtonSum";
        }

        private void radioButtonSub_CheckedChanged(object sender, EventArgs e)
        {
            this.oper = "radioButtonSub";

        }

        private void radioButtonMult_CheckedChanged(object sender, EventArgs e)
        {
            this.oper = "radioButtonMult";

        }

        private void radioButtonDiv_CheckedChanged(object sender, EventArgs e)
        {
            this.oper = "radioButtonDiv";

        }

        private void radioButtonMod_CheckedChanged(object sender, EventArgs e)
        {
            this.oper = "radioButtonMod";

        }
    }
}
