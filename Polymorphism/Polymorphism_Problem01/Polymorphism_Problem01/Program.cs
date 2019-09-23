using System;
using System.Collections.Generic;

namespace Polymorphism_Problem01
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOperation mathOperations = new MathOperation();
            Console.WriteLine(mathOperations.Add(2, 3));
            Console.WriteLine(mathOperations.Add(2.2, 3.3, 5.5));
            Console.WriteLine(mathOperations.Add(2.2m, 3.3m, 4.4m));
        }
    }
}
