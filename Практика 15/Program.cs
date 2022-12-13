using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Задача__1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            {
                Console.Write("Введите строку: ");
                string str = Console.ReadLine();
                int i = 0;
                int j = 1;
                var index = new List<int>();
                foreach (Match m in Regex.Matches(str, @"red?"))
                {
                    index.Add(j);
                    i++;
                    j++;
                }
                Console.WriteLine("Количество слов в тексте: {0}", index.Count);
            }
        }
    }
}