using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyLib;
namespace lab5
{
    public partial class Form1 : Form
    {
        public Action<double> tang = (double x) =>
        {
            MyMath.Tang(x);
        };

        public Action<double> sinxSin = (double x) =>
        {
            MyMath.SinxSin(x);
        };

        public Action<double> CosH = (double x) =>
        {
            MyMath.CosH(x);
        };

        void calc(Action<double> act, double x)
        {
            act(x);
        }

        

        public Form1()
        {
            InitializeComponent();

        }
    }
}
