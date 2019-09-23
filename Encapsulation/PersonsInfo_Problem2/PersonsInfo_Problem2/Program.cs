using System;
using System.Collections.Generic;

namespace PersonsInfo_Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the number of person:");
            int lines = int.Parse(Console.ReadLine());
            List<Person> persons = new List<Person>();
            for (int i = 0; i < lines; i++)
            {
                Console.WriteLine("Input personal information:");
                string[] cmdArgs = Console.ReadLine().Split();
                Person person = new Person(cmdArgs[0], cmdArgs[1], int.Parse(cmdArgs[2]), decimal.Parse(cmdArgs[3]));
                persons.Add(person);
            }
            Console.WriteLine("Enter the percentage:");
            decimal bonus = decimal.Parse(Console.ReadLine());
            Console.WriteLine("The salary of each person:");
            persons.ForEach(person => person.IncreaseSalary(bonus));
            persons.ForEach(person => Console.WriteLine(person.ToString()));
        }
    }
}
