using System;

namespace StackofStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            StackOfStrings stack = new StackOfStrings();
            Console.WriteLine($"Is stack empty: {stack.IsEmpty()}");
            stack.Push("1");
            stack.Push("2");
            stack.Push("3");
            stack.Push("4");
            Console.WriteLine($"Peek: {stack.Peek()}");
            stack.Push("5");
            Console.WriteLine($"Pop: {stack.Pop()}");
            stack.Push("6");
        }
    }
}
