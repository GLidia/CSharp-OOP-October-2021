using System;

namespace _05_ConvertToDouble
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                string inputAsString = Console.ReadLine();
                double a = Convert.ToDouble(inputAsString);
                Console.WriteLine(a);
            }
            catch (FormatException sfe)
            {
                Console.WriteLine(sfe);
                throw;
            }
            catch (OverflowException oe)
            {
                Console.WriteLine(oe);
                throw;
            }      
        }
    }
}
