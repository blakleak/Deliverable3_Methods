/*
 * Name: Amanda Blakley
 * Date: 2/6/2020
 * Description: This C# console application code demonstrates
 * the use of a method after getting input from a user. 
 */

using System;

namespace Deliverable3_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display a message welcoming the user and then
            // prompt the user to enter their name
            Console.WriteLine("Welcome! ");
            Console.WriteLine();
            Console.WriteLine("___________________________");
            Console.WriteLine();
            Console.WriteLine("Please enter your name....");

            // Try-catch block handles possible errors 
            try
            {
                // Stores user input for the application 
                string input = Console.ReadLine();

                // This is void method 
                userName();
                void userName()
                {
                    // Display the user's name and a message
                    Console.WriteLine();
                    Console.WriteLine("Hello " + input + "!");
                    Console.WriteLine("___________________________");
                    Console.WriteLine();
                    Console.WriteLine("Press any key to exit the application and try again...");
                    Console.ReadKey(true);
                }
            }
            catch
            {
                // Display an error message for the user 
                Console.WriteLine("Please enter your name next time...");
                Console.WriteLine("Press any key to exit the application and try again...");
                Console.ReadKey(true);
            } // End of catch 
        }
    }
}
