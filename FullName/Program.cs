using System;

namespace FullName
{
    public static class Program
    {
        public static void Main()
        {
            // TODO: Ask the user for their first name and then their last name.
            FullName_ReturnValue();

            // TODO: Call a method called FullName that returns their full name.

            // TODO: Output their full name.

            Console.ReadLine();
        }

        private static void FullName_ReturnValue()
        {
            string Main_FirstName;
            Console.WriteLine("What is your first name?");
            Main_FirstName = Console.ReadLine();

            string Main_LastName;
            Console.WriteLine("What is your last name?");
            Main_LastName = Console.ReadLine();

            string Main_FullName;
            Console.WriteLine(Main_FirstName + " " + Main_LastName);
            Main_FullName = Console.ReadLine();
            

        }


        // TODO: Create a method call FullName that takes the firstName and lastName as parameters.
    }
}
