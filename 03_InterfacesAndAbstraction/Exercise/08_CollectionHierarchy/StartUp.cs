using System;
using System.Collections.Generic;

namespace _08_CollectionHierarchy
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            AddCollection addCollection = new AddCollection();
            AddRemoveCollection addRemoveCollection = new AddRemoveCollection();
            MyList myList = new MyList();

            string[] itemsToAdd = Console.ReadLine().Split();

            foreach (string item in itemsToAdd)
            {
                Console.Write(addCollection.AddString(item) + " ");
            }
            Console.WriteLine();

            foreach (string item in itemsToAdd)
            {
                Console.Write(addRemoveCollection.AddString(item) + " ");
            }
            Console.WriteLine();

            foreach (string item in itemsToAdd)
            {
                Console.Write(myList.AddString(item) + " ");
            }
            Console.WriteLine();

            int numberToRemove = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberToRemove; i++)
            {
                Console.Write(addRemoveCollection.Remove() + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < numberToRemove; i++)
            {
                Console.Write(myList.Remove() + " ");
            }
            Console.WriteLine();
        }
    }
}
