using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace epam_lab2._3
{
    abstract class Figure
    {
        public abstract string Area();
        public abstract string Perimeter();
        public abstract string ShapeName();

        public void ShowInfo()
        {
            Console.WriteLine(
                $"Название фигуры: {ShapeName()}\n" +
                $"Площадь: {Area()}\n" +
                $"Периметр: {Perimeter()}"
                );
            Console.WriteLine();
        }
    }

    class Star : Figure
    {
        double sideA;
        public Star(double starSideA)
        {
            SideA = starSideA;
        }
        public double SideA
        {
            get { return sideA; }
            set { sideA = value < 0 ? -value : value; }
        }
        public override string Area()
        {
            double PerA = (Math.Pow(sideA, 2) * Math.Sqrt(3)) / 2; // формула нахождения площади равностороннего треугольника 
            return ((PerA * 6) + (3 * Math.Sqrt(3) * Math.Pow(sideA, 2))/2).ToString(); // формула нахождения площади правильной шестиугольной звезды
            //(3 * Math.Sqrt(3) * Math.Pow(sideA, 2))/2) формула нахождения площади шестиугольника
        }

        public override string Perimeter()
        {
            return (sideA*12).ToString(); // формула нахождения периметра правильной шестиугольной звезды
        }
        public override string ShapeName()
        {
            return "Правильная шестиконечная звезда";
        }
    }
    class Program
    {
        static void Main()
        {
            Figure figure1 = new Star(6);
            figure1.ShowInfo();
            Console.ReadKey();
        }
    }
}