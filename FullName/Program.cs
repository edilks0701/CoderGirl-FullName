﻿using System;

namespace FullName
{
    public static class Program
    {
        public static void Main()
        {
         
            string firstName;
            Console.WriteLine("What is your first name?");
            firstName = Console.ReadLine();

            string lastName;
            Console.WriteLine("What is your last name?");
            lastName = Console.ReadLine();

            Console.WriteLine(FullName(firstName,lastName));
            
            Console.ReadLine();
        }

        public static string FullName(string firstName, string lastName)
        {
            
            string fullName = firstName + " " + lastName;

            return fullName; 
        }


        
    }
}
