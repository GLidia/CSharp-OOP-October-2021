using System;

namespace _01_SquareRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                int number = int.Parse(Console.ReadLine());
                if (number < 0)
                {
                    throw new ArgumentOutOfRangeException("number", "number should not be negative");
                }
                double squareRoot = Math.Sqrt(number);
                Console.WriteLine(squareRoot);
            }
            catch(FormatException)
            {
                Console.WriteLine("Invalid number");
            }
            catch(ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}
