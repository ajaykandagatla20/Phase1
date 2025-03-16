using System;
namespace Practice
{
    class first
    {
        static void Main(String[] args)
        {

            Second s = new Second("blue", 4);
            string s1 = s.ToString();
            Console.WriteLine(s1);
        }
    }
    class Second
    {
        string color;
        int wheels;
        public Second(string Color, int Wheels)
        {
            this.color = Color;
            this.wheels = Wheels;
        }
        public void Splay()
        {
           Console.WriteLine("This is for practice");
        }

    }
}