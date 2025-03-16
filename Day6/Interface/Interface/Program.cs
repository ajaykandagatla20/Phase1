using System;
/*
class Person

{

   public string name
    {
        get { return name; }
        set
        {
         name = value;
        }
    }


    private int age;
    public Person(string name, int age) // Constructor

    {
        this.name = name;
        

        this.age = age;

    }
    public int Age
    {
        get { return age; }

        set { age = value; }

    }

}
 */
class first
{
    public static void Main(string[] args)
    {
        /*
                Person person = new Person("John", 30); // Creates a new Person object using the constructor

                Console.WriteLine(person.name); // Accesses the name using the getter

                person.name = "Ajay"; // Modifies the age using the setter
                Console.WriteLine(person.name);
        


        int? nullableInt = 15;

        if (nullableInt.HasValue)
        {
            Console.WriteLine("The value is " + nullableInt.Value);
        }
        else
        {
            Console.WriteLine("The value is null");
        }

        */

        string name = "Ajay Kumar Kandagatla";

        Console.WriteLine(name.Substring(3,5));
        Console.WriteLine(name.ToUpper());
        Console.WriteLine(name.Length);
        name += "Ajay";

        Console.WriteLine(name);
    }
}