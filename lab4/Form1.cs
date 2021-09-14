using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace lab4
{
    public partial class Form1 : Form
    {
        readonly int _Max = 10;
        int n { get; set; }
        int m { get; set; }

        public Form1()
        {
            InitializeComponent();
            this.n = 3;
            this.m = 3;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            

            List<char> list = new List<char>();
            

            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    if (!list.Contains(Char.Parse(dataGridView1[i, j].Value.ToString())))
                    {
                        list.Add(Char.Parse(dataGridView1[i, j].Value.ToString()));
                    }

                }
                Console.WriteLine();
            }

            textBoxAnswer.Text = list.Count.ToString();

        }

        private void buttonChangeSize_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();


            if (Char.IsDigit(Char.Parse(textBox1.Text.ToString())))
            {
                int number = int.Parse(Char.Parse(textBox1.Text.ToString()).ToString());
                if ((number < _Max) & (number > 0))
                {
                    n = number;
                }
            }


            if (Char.IsDigit(Char.Parse(textBox2.Text.ToString())))
            {
                int number = int.Parse(Char.Parse(textBox2.Text.ToString()).ToString());
                if ((number < _Max) & (number > 0))
                {
                    m = number;
                }
            }



            for (int i = 0; i < n; i++)
            {
                dataGridView1.Columns.Add("", $"i = {i + 1}");
                //dataGridView2.Columns.Add("", $"i = {i + 1}");

            }

            for (int i = 0; i < m; i++)
            {
                dataGridView1.Rows.Add();
                //dataGridView2.Rows.Add();

            }

        }
    }
}
