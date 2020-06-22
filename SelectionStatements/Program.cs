using System;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initialize an integer to represent a favorite number and assign a value with a number of your choosing or you can assign a random number to this variable:
            var r = new Random();

            //This assigns a new random number inside of favNumber variable
            var favNumber = r.Next(1, 1000);

            Console.WriteLine($"Try to correctly guess the random number:");

            var userInput = int.Parse(Console.ReadLine());

            //if (userInput == favNumber)
            //{
            //    Console.WriteLine($"Success!");
            //}
            //else
            //{
            //    Console.WriteLine($"Wrong!");
            //}

            if (userInput < favNumber)
            {
                Console.WriteLine($"Too low.");
            }
            
            else if(userInput > favNumber)
            {
                Console.WriteLine($"Too high!");
            }
            
            else 
            {
                Console.WriteLine($"Nevermind");
            }
        }
        
    }
}
