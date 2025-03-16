using System;
namespace DependencyInversionPrincipleExample
{
    class Program
    {
        public static void Main()
        {
            IAutomobile am = new Car();
            AutomobileController AC = new AutomobileController(am);
            AC.DisplayWheels();
        }


        // High level
        public class AutomobileController
        {
            private IAutomobile _automobile;
            public AutomobileController(IAutomobile automobile)
            {
                _automobile = automobile;
            }
            public void DisplayWheels()
            {
                Console.WriteLine(_automobile.Wheels());
            }

        }


       
        public interface IAutomobile
        {
            string Wheels();
        }


        // Low level

        public class Bike : IAutomobile
        {
            public string Wheels()
            {
                return "2 wheels";
            }
        }

        public class Car : IAutomobile
        {
            public string Wheels()
            {
                return "4 wheels";
            }
        }





    }
}