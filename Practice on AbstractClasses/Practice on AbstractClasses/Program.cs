using System;

public abstract class Customer
{
    public void print()
    {

    }
    public abstract void display();

   // public abstract void display();
}

public class Program : Customer
{
    public override void display()
    {
        Console.WriteLine("Hello");
    }
    public static void Main(string[] args)
    {

    }
}