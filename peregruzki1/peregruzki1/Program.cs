using System;
using System.Numerics;

namespace peregruzki1
{
    class Vector3
    {
        int x;
        int y;
        int z;
        public Vector3(int A, int B, int C)
        {
            x = A;
            y = B;
            z = C;
        }

        public int A
        {
            get
            {
                return x;
            }
        }
        public int B
        {
            get
            {
                return y;
            }
        }
        public int C
        {
            get
            {
                return z;
            }
        }
        public static Vector3 operator +(Vector3 a, Vector3 b)
        {
            return new Vector3(a.A + b.A, a.B + b.B, a.C + b.C);
        }
        public static Vector3 operator -(Vector3 a, Vector3 b)
        {
            return new Vector3(a.A - b.A, a.B - b.B, a.C - b.C);
        }
        public static Vector3 operator *(Vector3 a, Vector3 b)
        {
            return new Vector3(a.A * b.A, a.B * b.B, a.C * b.C);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;
            int z;
            int x1;
            int y1;
            int z1;
            Console.WriteLine("Введите координаты первого вектора: ");
            string textV1 = Console.ReadLine();
            string[] numbers = textV1.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            x = Convert.ToInt32(numbers[0]);
            y = Convert.ToInt32(numbers[1]);
            z = Convert.ToInt32(numbers[2]);

            Console.WriteLine("Введите координаты второго вектора: ");
            string textV2 = Console.ReadLine();
            string[] numbers1 = textV2.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            x1 = Convert.ToInt32(numbers1[0]);
            y1 = Convert.ToInt32(numbers1[1]);
            z1 = Convert.ToInt32(numbers1[2]);
            Vector3 a = new Vector3(x, y, z);
            Vector3 b = new Vector3(x1, y1, z1);
            Vector3 SumVectors = a + b;
            Vector3 DifVectors = a - b;
            Vector3 MulVectors = a * b;
            Console.WriteLine("Сумма двух векторов: " + SumVectors.A + ' ' + SumVectors.B + ' ' + SumVectors.C);
            Console.WriteLine("Разность двух векторов: " + DifVectors.A + ' ' + DifVectors.B + ' ' + DifVectors.C);
            Console.WriteLine("Перемножение двух векторов: " + MulVectors.A + ' ' + MulVectors.B + ' ' + MulVectors.C );
            Console.ReadKey();
        }
    }
}