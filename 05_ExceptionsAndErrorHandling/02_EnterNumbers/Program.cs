using System;
using System.Collections.Generic;

namespace _02_EnterNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 100;
            List<int> numbers = new List<int>();

            while (numbers.Count < 10)
            {
                try
                {
                    int number = ReadNumber(a, b);
                    numbers.Add(number);
                    a = number;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input");
                    numbers.Clear();
                    a = 1;
                }
                catch(ArgumentOutOfRangeException aore)
                {
                    Console.WriteLine(aore.Message);
                    numbers.Clear();
                    a = 1;
                }
            }

            Console.WriteLine(string.Join(", ", numbers));
        }

        static int ReadNumber(int start, int end)
        {
            int n;
            n = int.Parse(Console.ReadLine());

            if (n <= start || n >= end)
            {
                throw new ArgumentOutOfRangeException("number should be in the appropriate range");
            }

            return n;
        }
    }
}
