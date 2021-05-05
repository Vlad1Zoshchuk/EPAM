using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace epam_z2
{
    class EPAM_Z2
    {
        static void BinaryCode()
        {
            Console.Write("Число: ");
            int a = Int32.Parse(Console.ReadLine());

            string BinaryCode = Convert.ToString(a, 2);

            Console.WriteLine($"Двоичная система исчисления: {BinaryCode}");
            Console.WriteLine("-----------");
        }

        static void BinaryCode2()
        {
            Console.Write("Число: ");
            int N = Int32.Parse(Console.ReadLine());
            int i;
            int a = 0;

            int[] BinaryCode2 = new int[10];

            while (N >= 1)
            {
                i = N % 2;
                BinaryCode2[a] = i;
                a++;

                N = N / 2;
            }

            for (a = (BinaryCode2.Length - 1); a >= 0; a--)
            {
                Console.Write(BinaryCode2[a]);
            }
        }
        static void Main()
        {
            BinaryCode();
            BinaryCode2();
            Console.ReadKey();
        }
    }
}

