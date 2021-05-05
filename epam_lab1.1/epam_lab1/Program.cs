using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace epam_lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите k ");
            int k = int.Parse(Console.ReadLine());
            double s = 0;
            Console.WriteLine("Введите x ");
            int x = int.Parse(Console.ReadLine());
            for (int g = 1; g <= k; g++)
            {
                s += Math.Pow(-1, g) * (Math.Pow(x, 2 * g) / g * (g + 1) * (g + 2));
            }
            Console.WriteLine("вывод значения суммы = {0}", s.ToString());
            Console.ReadKey();



        }
    }
}
