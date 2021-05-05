using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace matrica_epam
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPath = "Inlet.txt";
            string outputPath = "Outlet.txt";


            string[] inputString;

            using (var inputFile = new StreamReader(inputPath))
            {
                inputString = inputFile.ReadLine().Split(' ');
            }


            int N = Convert.ToInt32(inputString[0]);
            int G = Convert.ToInt32(inputString[1]);
            int incG = Convert.ToInt32(inputString[2]);


            int[,] mainMatrix = new int[N, N];

            for (int i = 0; i < N; i++)                          // заполняем половину матрицы
            {                                                   // 1 1 1 1
                mainMatrix[0, i] = G;                           // 1 1 1 0
                                                                // 1 1 0 0
                for (int j = 0, iTmp = i; j < i; j++, iTmp--)    // 1 0 0 0
                {
                    mainMatrix[iTmp, j] = G;
                }

                G += incG;
            }

            for (int i = 1; i < N; i++)                                // заполняем оставшиеся ячейки
            {
                mainMatrix[i, N - 1] = G;

                for (int j = N - 1, iTmp = i; j > i - 1; j--, iTmp++)
                {
                    mainMatrix[iTmp, j] = G;
                }

                G += incG;
            }


            using (var outputFile = new StreamWriter(outputPath))
            {
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        outputFile.Write(mainMatrix[i, j]);
                        outputFile.Write(' ');
                    }
                    outputFile.WriteLine();
                }
            }
        }
    }
}
