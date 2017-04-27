using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
          
            int number = AskUser();
            
            //For loop to call all numbers in Fibonacci
            for (int index = 1; index <= number; index++)
            {
                Console.WriteLine(Fibonacci(index));
            }
        }

        /// <summary>
        /// Asks and convert users choice of number and then send it back to main method
        /// </summary>
        /// <returns>int for use in Fibonacci Method</returns>
        private static int AskUser()
        {
            //Variables for User Input
            String userInput;
            int userNumber;

            //Ask user for number than convert it from string to int
            Console.WriteLine("Please enter a number: ");
            userInput = Console.ReadLine();
            userNumber = Convert.ToInt32(userInput);

            return userNumber;
        }

        /// <summary>
        /// Method to preform the math and print out results
        /// </summary>
        /// <param name="a">base number</param>
        public static ulong Fibonacci(int number)
        {

            if (number == 1) { return 1; }
            if (number == 2) { return 1; }

            return Fibonacci(number - 1) + Fibonacci(number - 2);

        }

    
    }
}
