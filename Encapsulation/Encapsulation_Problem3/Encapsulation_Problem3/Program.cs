using System;
using System.Collections.Generic;

namespace Encapsulation_Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of person: ");
            var lines = int.Parse(Console.ReadLine());
            var persons = new List<Person>();
            for (int i = 0; i < lines; i++)
            {
                Console.WriteLine("Input the personal information: ");
                var cmdArgs = Console.ReadLine().Split();
                try
                {
                    var person = new Person(cmdArgs[0], cmdArgs[1], int.Parse(cmdArgs[2]), decimal.Parse(cmdArgs[3]));
                    persons.Add(person);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            Console.WriteLine("Enter the bonus: ");
            var bonus = decimal.Parse(Console.ReadLine());
            persons.ForEach(person => person.IncreaseSalary(bonus));
            persons.ForEach(person => Console.WriteLine(person.ToString()));
        }
    }
}
