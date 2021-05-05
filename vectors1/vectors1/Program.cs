﻿using System;
using System.IO;

namespace vectors1
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 0, i = 0, j = 0;
            string PathIn = "Inlet.txt";
            string PathOut = "Outlet.txt";
            int[] Vector = new int[50];
            string FileString;
            string[] FileMatrix;
            int result = 0;

            using (var file = new StreamReader(PathIn))
            {
                while (!file.EndOfStream)
                {
                    FileString = file.ReadLine();
                    FileMatrix = FileString.Split(' ');
                    for (j = 0; j < FileMatrix.Length; j++)
                    {
                        Vector[j] = int.Parse(FileMatrix[j]);
                    }
                    i++;
                }
            }

            N = j;

            for (i = 1; i < N - 1; i++)
            {
                if (Vector[i - 1] > Vector[i] && Vector[i] < Vector[i + 1])
                {
                    result += Vector[i];
                }
            }
            using (var file = new StreamWriter(Path.GetFullPath(PathOut), false))
                file.Write($"Result: {result}");
            Console.WriteLine("Запись в файл произведена!");
            Console.ReadKey();
        }
    }
}
