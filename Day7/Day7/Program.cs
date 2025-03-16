using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Day7;

namespace Day7
{


    class Program
    {
        static void Main(string[] args)
        {
            string word = "Ajay Kumar Kandagatla";
            int wordcount = word.GetWordCount();
            Console.WriteLine("Total words in the given string is : "+wordcount);
        }
    }
}
