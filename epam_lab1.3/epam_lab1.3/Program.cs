using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace epam_lab1._3
{
    class Program
    {
        static void Main(string[] args)
        { 
            double factorial = 1;
            double sum = 0;
            int n = 0;
            Console.Write("Введите X: ");
            double x = Double.Parse(Console.ReadLine());
            Console.Write("Введите Eps: ");
            double eps = Double.Parse(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                factorial *= i + 1;
            }
            while ((Math.Pow(-1, n) / Math.Pow(factorial,2)) * Math.Pow( (x/2), 2 * (n + 1) )> eps)
            {
                sum+= Math.Pow(-1, n) / Math.Pow(factorial, 2) *Math.Pow((x / 2), 2 * (n + 1));
                n++;
            }
            Console.WriteLine($"Вывод: {sum}");
            Console.ReadLine();

        }
    }
}
