using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace epam_z1
{
    class EPAM_Z1
    {
           
        static void Main(string[] args)
        {                
            double Pow(double a, int pow)
            {   
                double result = 1;
                for (int i = 0; i < pow; i++) result *= a;
                return result;
            }
            double SqrtN(double n, double A, double eps = 0.0001)
            {
                var x0 = A / n;
                var x1 = (1 / n) * ((n - 1) * x0 + A / Pow(x0, (int)n - 1));
           
                while (Math.Abs(x1 - x0) > eps)
                {
                    x0 = x1;
                    x1 = (1 / n) * ((n - 1) * x0 + A / Pow(x0, (int)n - 1));
                }
           
                return x1;
            }
            {
                Console.WriteLine(SqrtN(3, 4));
                Console.ReadKey();
            }
        }  
    }      
}          
