﻿using System;

interface I1
{
    void InterfaceMethod();
}
interface I2
{
    void InterfaceMethod();
}

public class Program : I1, I2
{
    public void InterfaceMethod()
    {
        Console.WriteLine("I1 interface method");
    }

    public static void Main(string[] args)
    {
        Program p = new Program(); 

        ((I1)p).InterfaceMethod();
        ((I2)p).InterfaceMethod();
    }
   
}