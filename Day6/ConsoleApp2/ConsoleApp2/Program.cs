using System;
namespace ExceptionExample
{

    public class ExceptionPractive : Exception
    {
        public override string Message
        {
            get { return "Yor are not eligible to vote idiot!"; }
        }
    }


    class program
    {

        public static void Main(string[] args)
        {
            
            try
            {
                Console.WriteLine("Enter your name :");
                string Name = Console.ReadLine();
                Console.WriteLine("Enter your age :");
                int Age = Convert.ToInt32(Console.ReadLine());
                
                if(Age<18)
                {
                    throw new NotEligibleToVoteException();
                   
                }
            }
            catch(NotEligibleToVoteException nv)
            {
                Console.WriteLine(nv.Message);
            }
            catch(FormatException fe)
            {
                Console.WriteLine(fe.Message);
            }
















        }



























    }
}