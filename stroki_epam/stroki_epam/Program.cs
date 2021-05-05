using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace stroki_epam
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 0, M = 0, i = 0, j = 0;
            string PathIn = "Inlet.txt";
            string PathOut = "Outlet.txt";
            string[,] array = new string[50, 50];
            string temp;
            string FileString;
            string[] FileMatrix;
            int[] lengthofStr = new int[50];

            using (var file = new StreamReader(PathIn))
            {
                while (!file.EndOfStream)
                {
                    FileString = file.ReadLine();
                    FileMatrix = FileString.Split(' ');
                    lengthofStr[i] = FileMatrix.Length;
                    for (j = 0; j < FileMatrix.Length; j++)
                    {
                        array[i, j] = FileMatrix[j];
                    }
                    i++;
                }
            }

            N = i;
            M = j;

            for (i = 0; i < N; i++)
            {
                if (lengthofStr[i] % 2 != 0)
                {
                    lengthofStr[i]--;
                   

                    for (j = 0; j < lengthofStr[i]; j += 2)
                    {
                        temp = array[i, j];
                        array[i, j] = array[i, j + 1];
                        array[i, j + 1] = temp;
                    }

                    lengthofStr[i]++;
                    continue;
                }
                for (j = 0; j < lengthofStr[i]; j+= 2)
                {
                    temp = array[i, j];
                    array[i, j] = array[i, j + 1];
                    array[i, j + 1] = temp;
                }
            }

            using (var file = new StreamWriter(Path.GetFullPath(PathOut), false))
            {
                
                for (i = 0; i < N; i++)
                {
                    for (j = 0; j < lengthofStr[i]; j++)
                    {
                        file.Write(array[i, j] + " ");
                    }
                    file.WriteLine();
                }
            }
            Console.WriteLine("Запись в файл произведена!");
            Console.ReadKey();
        }
    }
}