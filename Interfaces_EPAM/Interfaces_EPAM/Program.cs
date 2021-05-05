using System;
using System.Collections.Generic;

namespace Interfaces_EPAM
{
    interface IConvertible
    {
        string ConvertToCSharp(string str);
        string ConvertToVB(string str);
    }

    interface ICodeChecker
    {
        bool CheckCodeSyntax(string strToCheck, string usedLanguage);
    }


    class ProgramConverter : IConvertible
    {
        public string ConvertToCSharp(string str)
        {
            return $"Converted to {str} code";
        }

        public string ConvertToVB(string str)
        {
            return $"Converted to {str} code";
        }
    }

    class ProgramHelper : ProgramConverter, ICodeChecker
    {
        public bool CheckCodeSyntax(string strToCheck, string usedLanguage)
        {
            if (strToCheck == usedLanguage)
                return true;

            return false;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            List<ProgramConverter> array = new List<ProgramConverter>(3);

            for (int i = 0; i < 3; i++)
            {
                array.Add(new ProgramHelper());
            }
            Console.ReadLine();
            /*string usedLanguage = "CSharp";


            /*for(int i = 0; i < 6; i++)
            {
                if (array[i] is ICodeChecker)
                {
                    if (array[i].CheckCodeSyntax("CSharp", usedLanguage))
                    {
                        Console.WriteLine(array[i].ConvertToCSharp("CSharp"));
                        continue;
                    }

                    Console.WriteLine(array[i].ConvertToVB("VB"));
                    continue;
                }

                Console.WriteLine(array[i].ConvertToCSharp("CSharp"));
                Console.WriteLine(array[i].ConvertToVB("VB"));
            }*/
        }
    }
}
