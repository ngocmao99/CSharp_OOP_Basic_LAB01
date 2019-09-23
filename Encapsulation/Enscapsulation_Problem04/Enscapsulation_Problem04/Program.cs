using System;

namespace Enscapsulation_Problem04
{
    class Program
    {
        static void Main(string[] args)
        {
            Team team = new Team("GCD0819");
            Console.WriteLine("Enter the number of members:");
            int lines = int.Parse(Console.ReadLine());
            for (int i = 0; i < lines; i++)
            {
                Console.WriteLine("Input the personal information:");
                string[] cmdArgs = Console.ReadLine().Split();
                try
                {
                    Person person = new Person(cmdArgs[0], cmdArgs[1], int.Parse(cmdArgs[2]), decimal.Parse(cmdArgs[3]));
                    team.AddPlayer(person);
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
            }
            Console.WriteLine("The sizes of two team:");
            Console.WriteLine(team);
        }
    }
}
