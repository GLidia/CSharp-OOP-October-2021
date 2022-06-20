using System;

namespace _06_ValidPerson
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Person person = new Person("", "LastName", 21);
            }
            catch(ArgumentNullException ane)
            {
                Console.WriteLine(ane.Message);
            }
        }
    }
}
