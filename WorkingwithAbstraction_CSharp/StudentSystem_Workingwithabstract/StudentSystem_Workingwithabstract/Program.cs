using System;

namespace StudentSystem_Workingwithabstract
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentSystem studentSystem = new StudentSystem();
            Console.WriteLine("Welcome Student System");
            Console.WriteLine("Menu Options");
            Console.WriteLine("Create");
            Console.WriteLine("Show");
            Console.WriteLine("Exit");
            Console.WriteLine("To implement one of the function, please enter the named of funtionc.");
            string input = Console.ReadLine();
            while (input != "Exit")
            {
                studentSystem.ParseCommand(input);
                input = Console.ReadLine();
            }
        }
    }
}
