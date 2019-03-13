using System;

namespace FullName
{
    public static class Program
    {
        public static void Main()
        {
            // TODO: Ask the user for their first name and then their last name.
            string firstName;
            Console.WriteLine("What is your first name?");
            firstName = Console.ReadLine();

            string lastName;
            Console.WriteLine("What is your last name?");
            lastName = Console.ReadLine();

            FullName(firstName,lastName);

              Console.ReadLine();
        }

        public static void FullName(2)
        {
            //string firstname;
            //Console.WriteLine("What is your first name?");
            //firstname = Console.ReadLine();

            //string lastName;
            //Console.WriteLine("What is your last name?");
            //lastName = Console.ReadLine();
            Console.WriteLine(firstName + " " + lastName);
            
            

        }


        
    }
}
