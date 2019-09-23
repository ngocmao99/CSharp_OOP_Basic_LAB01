using Polymorphism_Problem02.Models;
using System;

namespace Polymorphism_Problem02
{
    class Program
    {
        static void Main(string[] args)
        {
            Animals cat = new Cat("Pesho", "Whiskas");
            Animals dog = new Dog("Gosho", "Meat");

            Console.WriteLine(cat.ExplainMyself());
            Console.WriteLine(dog.ExplainMyself());
        }
    }
}
