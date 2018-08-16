using System;

namespace CG_6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // ask for the users first and last names
            // set the user input to a string value
            Console.WriteLine("Please enter your first name");
            string firstname = Console.ReadLine();
            Console.WriteLine("Please enter your last name");
            string lastname = Console.ReadLine();

            //set the string builder to add the two above string into one to output the users full name
           System.Text.StringBuilder mynewstring = new System.Text.StringBuilder(" " + firstname + " " + lastname);

            Console.WriteLine("Hello," + " " + mynewstring);

            Console.ReadLine();
                  
        }
    }
}
