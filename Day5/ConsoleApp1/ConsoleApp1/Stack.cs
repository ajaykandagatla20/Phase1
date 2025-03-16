using System;
namespace Practice
{
    class first
    {
        static void Main(String[] args)
        {
            
            Second s = new Second("blue", 4);
            Console.WriteLine(s.ToString());
        }
    }
    class Second
    {
        string color;
        int wheels;
        public Second(string Color,int Wheels)
        {
            this.color = Color;
            this.wheels = Wheels;
        }
        public override string ToString()
        {
            return "This is for practice";
        }
    }
}