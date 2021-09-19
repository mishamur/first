using System;

namespace MyLib
{
    public class MyMath
    {
        public static double SinxSin(double x)
        {
           return Math.Sin(x) * Math.Sin(x);
        }

        public static double Tang(double x)
        {
            return Math.Sin(x) / Math.Cos(x);
        }

        public static double CosH(double x)
        {
            return (Math.Exp(x) - Math.Exp(-x)) / 2;
        }




    }
}
