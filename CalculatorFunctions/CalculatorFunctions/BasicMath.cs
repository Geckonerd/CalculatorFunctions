using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorFunctions
{
    /************************************************************************************
     * Class: BasicMath
     * Desciption: An extension of MathClass, BasicMath provides
     * calculations for basic concepts, like addition and multiplication
     ************************************************************************************/
    internal class BasicMath : MathClass
    {
        public BasicMath() { }

        // These 4 functions ask the user how many numbers they want to calculate
        // With that number, they will run a for loop to calculate those numbers together
        private void basicAddition(int loops) 
        {
            int sum = 0;
            for (int i = 1; i <= loops; i++)
            {
                Console.WriteLine("Enter a number greater than 1: ");
                sum += Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Your total is " + sum);
        }

        private void basicSubtraction(int loops) 
        {
            // Since subtraction is taking away from a starting number,
            // this function needs to have a starting number
            Console.WriteLine("Enter your starting number: ");
            int difference = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < loops; i++)
            {
                Console.WriteLine("Enter a number greater than 1: ");
                difference -= Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Your total is " + difference);
        }

        private void basicMultiply(int loops) 
        {
            // Since multiplication can't start with 0 (as it'll always end in 0),
            // this function needs to have a starting number
            Console.WriteLine("Enter your starting number: ");
            int product = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < loops; i++)
            {
                Console.WriteLine("Enter a number greater than 1: ");
                product *= Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Your total is " + product);
        }

        private void basicDivide(int loops) 
        {
            // Since division is taking away from a starting number,
            // this function needs to have a starting number
            Console.WriteLine("Enter your starting number: ");
            int quotient = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < loops; i++)
            {
                Console.WriteLine("Enter a number greater than 1: ");
                quotient /= Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Your total is " + quotient);
        }

        public override void functionChoice()
        {
            Console.Clear();
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");

            int input = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many numbers would you like to calculate? ");
            Console.WriteLine("Enter a number greater than 1. ");
            int loops = Convert.ToInt32(Console.ReadLine());

            switch(input)
            {
                case 1:
                    basicAddition(loops);
                    break;
                case 2:
                    basicSubtraction(loops);
                    break;
                case 3:
                    basicMultiply(loops);
                    break;
                case 4:
                    basicDivide(loops);
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