using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Add(2, 3);
            Add(new int[] { 5, 6, 5 });

        }


        public static void Add(int a,int b)
        {
            Console.WriteLine("result : "+(a+b));
        }


        public static int Add(int[] numbers)
        {
            int result = 0;
            foreach(int n in numbers)
            {
                result = numbers[n];
            }
            return result;
        }

    }
}
