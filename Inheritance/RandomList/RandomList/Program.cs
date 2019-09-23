using System;

namespace RandomList
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomList randomList = new RandomList();

            randomList.Add("test 1");
            randomList.Add("test 2");
            randomList.Add("test 3");
            Console.WriteLine("Total Items: ");
            foreach (string s in randomList)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine($"Item Removed: {randomList.RandomString()}");
            Console.WriteLine("Item Remains: ");
            foreach (string s in randomList)
            {
                Console.WriteLine(s);
            }
        }
    }
}
