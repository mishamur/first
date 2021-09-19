using System;
using System.Text.RegularExpressions;

namespace first
{
    class Program
    {
        
        //ДАНА строка из чисел, между ними как минимум один или более пробелов,
        //вывести отрицательные числа
        static void Main(string[] args)
        {
            string pattern = @"\s+";
            Regex regex = new Regex(pattern);

            string stroke = Console.ReadLine();

            string[] arrSroke = regex.Split(stroke);

            foreach(string value in arrSroke)
            {
                if (value[0] == '-')
                {
                    Console.WriteLine(value);
                }
            }
        }
    }
}
