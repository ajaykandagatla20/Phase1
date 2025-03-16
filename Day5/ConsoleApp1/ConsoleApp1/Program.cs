using System;
using System.Collections;
public class Class2
{
    public Class2()
    {

        Hashtable employee = new Hashtable(); //  initial capacity ,  load factor  , hashcode provider and comparer
        employee.Add("ID", "565656");

        employee.Add("Name", "Rohan");

        employee.Add("Company", "Wipro");
        employee.Add("Salary", "10LPA");
        foreach (object key in employee.Keys)
        {
            Console.WriteLine(hashtable[key]);

        }

        foreach (DictionaryEntry items in hashtable)
        {

            Console.WriteLine($"{items.Key} , {items.Value}");
        }

        var cities = new Hashtable()
        {
            { "UK" , "London , Manchester"},
            { "USA" , "Chicago, New Yord"},
            { "India" , "Mumbai , Delhi"}

        };



    }


}


