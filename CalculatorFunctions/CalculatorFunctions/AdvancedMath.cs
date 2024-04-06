using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace CalculatorFunctions
{
    /************************************************************************************
     * Class: AdvancedMath
     * Desciption: An extension of MathClass, AdvancedMath provides calculations
     * for 3 mathematical concepts that are more complex than those in BasicMath
     ************************************************************************************/
    internal class AdvancedMath : MathClass
    {
        public AdvancedMath() { }

        // After asking the user for a number, it will determine
        // whether or not the given number is a prime number
        private void advancedPrime() 
        {
            Console.WriteLine("What number would you like to check?");
            int prime = Convert.ToInt32(Console.ReadLine());

            // If the number is 2, it is a prime number
            if (prime == 2)
            {
                Console.WriteLine("It is a prime number.");
                return;
            }

            // If the number is less than 2 or is
            // divisible by 2 it is not a prime number
            if (prime < 2 || prime % 2 == 0) 
            {
                Console.WriteLine("It is not a prime number.");
            }

            for (int i = 3; i <= Math.Sqrt(prime); i+=2)
            {
                if (prime % i == 0)
                {
                    Console.WriteLine("It is not a prime number.");
                    return;
                }
            }

            Console.WriteLine("It is a prime number.");
        }

        // Using recursion, the program will calculate the total result
        // based on the product of all numbers from the starting point to 1
        private int advancedFactorial(int n) 
        {
            if (n == 1)
            {
                return 1;
            }
            return n * advancedFactorial(n - 1);
        }

        // Using recursion, the program will calculate the total result
        // based on the sum of its two previous results, all the way to 0 and 1
        private int advancedFibonacci(int n) 
        { 
            if ((n == 0) || (n == 1)) 
            {
                return n;
            }

            return advancedFibonacci(n - 1) + advancedFibonacci(n - 2);
        }

        // Another type of division, modular division instead
        // returns the remainder that comes from the calculation
        private void advancedModular() 
        {
            Console.WriteLine("Enter your first number: ");
            int first = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your second number: ");
            int second = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The remainder of your two numbers are " + first % second);
        }

        public override void functionChoice()
        {
            Console.Clear();
            Console.WriteLine("1. Determine Prime Number");
            Console.WriteLine("2. Factorial Multiplication");
            Console.WriteLine("3. Fibonacci Sequence");
            Console.WriteLine("4. Modular Division");

            int input = Convert.ToInt32(Console.ReadLine());

            // This is needed for functions that require a loop
            int loops = 0;

            switch (input)
            {

                case 1:
                    advancedPrime();
                    break;
                case 2:
                    // Because recursion is needed, the program needed the starting point
                    // before going into the loop, as well as print the result here.
                    Console.WriteLine("How high would you like the sequence to go?");
                    loops = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Your final result is " + advancedFactorial(loops));
                    break;
                case 3:
                    // Because recursion is needed, the program needed the starting point
                    // before going into the loop, as well as print the result here.
                    Console.WriteLine("How high would you like the sequence to go?");
                    loops = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Your final result is " + advancedFibonacci(loops));
                    break;
                case 4:
                    advancedModular();
                    break;
                // numCalculations-- serves to keep the number accurate
                // if the user doesn't pick any of the four options
                default:
                    numCalculations--;
                    break;
            }
            numCalculations++;
        }
    }
}
