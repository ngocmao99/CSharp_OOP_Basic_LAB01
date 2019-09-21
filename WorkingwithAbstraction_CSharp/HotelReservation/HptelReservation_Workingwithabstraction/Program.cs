using System;

namespace HotelReservation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the value following the formart (Price Per Day) (number of days) (season) (discount type):");
            string[] inputTokens = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            
            decimal pricePerDay = decimal.Parse(inputTokens[0]);
            int daysCount = int.Parse(inputTokens[1]);
            SeasonsPrice season = Enum.Parse<SeasonsPrice>(inputTokens[2]);
            Discount discount = Discount.None;

            if (inputTokens.Length == 4)
            {
                discount = Enum.Parse<Discount>(inputTokens[3]);
            }

            PriceCalculator priceCalculator = new PriceCalculator(pricePerDay, daysCount, season, discount);
            Console.WriteLine("The total price of the holiday is:");
            priceCalculator.Calculate(Console.WriteLine);
        }
    }
}
