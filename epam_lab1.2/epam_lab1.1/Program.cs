using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, eps;
            Console.WriteLine("Введите начальное значение а отрезка [a,b]:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите конечное значение b отрезка [a,b]:");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите точность eps:");
            eps = Convert.ToDouble(Console.ReadLine());

            double approximatione = fInitialapproximationе(a, b);
            double c = fFixedpoint(a, b);
            double x0;
            int k = 0;
            do
            {
                k++;
                x0 = approximatione;
                approximatione = x0 - ((f(x0) * (x0 - c)) / (f(x0) - f(c)));
            }
            while (Math.Abs(x0 - approximatione) > eps);// малость невязки
            Console.WriteLine($"Приближение равно {approximatione} в результате {k} итераций:");
            Console.ReadKey();

        }
        static double f(double x)
        {
            return Math.Sqrt(1 - 0.4 * Math.Pow(x, 2)) - Math.Asin(x); // уравнение
        }
        static double fDerivative(double x)
        {
            return -0.4*x/Math.Sqrt(1 - 0.4 * Math.Pow(x, 2))-1/Math.Sqrt(Math.Pow(-x,2)+1); // 1 производная
        }
        static double fSecondDerivative(double x)
        {
            return -0.16*Math.Pow(x,2)/Math.Pow(1-0.4*Math.Pow(x,2),3/2)-x/Math.Pow(Math.Pow(-x,2)+1,3/2)-0.4/ Math.Sqrt(1 - 0.4 * Math.Pow(x, 2)); // 2 производная
        }
        static double fInitialapproximationе(double a, double b)
        {
            return f(a) * fSecondDerivative(a) > 0 ? b : a;
        }

        static double fFixedpoint(double a, double b)
        {
            return f(a) * fSecondDerivative(a) > 0 ? a : b;
        }

    }
}
