using System;

namespace SwitchExamples
{
    internal class Switchexample
    {
        public static void Main(string[] args)
        {
            bool order = true;
            int total=0;
            while(order) {
            Console.WriteLine("Select an item \n 1.Pizza: 200 \n 2.Burger:150 \n 3.Pasta:100 \n 4.Exit");
            int item = Convert.ToInt32(Console.ReadLine());

                switch (item)
                {
                    case 1:
                        Console.WriteLine("You selected Pizza");
                        total += 200;
                        break;
                    case 2:
                        Console.WriteLine("You selected Burger");
                        total += 150;
                        break;
                    case 3:
                        Console.WriteLine("You selected Pasta");
                        total += 100;
                        break;
                    case 4:
                        Console.WriteLine("You select to exit the menu");
                        order = false;
                        break;
                }
                Console.WriteLine("Total :" + total);
            }
        }
    }
}
