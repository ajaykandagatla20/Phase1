using System;

namespace EvenOdd
{
    public static class checking
    {
        public static void run()
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number >= 2 && number <= 20)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine($"The number {number} is Even.");
                }
                else
                {
                    Console.WriteLine($"The number {number} is Odd.");
                }

            }
            else
            {
                Console.WriteLine($"{number} is grater than 20");
            }
        }
        }
}
