using System;
using System.Linq;

namespace PointinRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputParts = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Rectangle rectangle = new Rectangle(inputParts[0], inputParts[1], inputParts[2], inputParts[3]);

            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine("Input the coordinates:");
                inputParts = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                Point point = new Point(inputParts[0], inputParts[1]);
                rectangle.Contains(point);
            }
        }
    }
}
