using System;

namespace CustomRandomList
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            RandomList randomList = new RandomList() { "first", "second", "third", "fourth" };
            Console.WriteLine(randomList.RandomString());
            Console.WriteLine(randomList.RandomString());
            Console.WriteLine(randomList.RandomString());
            Console.WriteLine(randomList.RandomString());
        }
    }
}
