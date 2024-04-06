using System;

/******************************************************************************************
 * Program: CalculatorFunctions
 * Description: The program puts the user in a while loop that will ask the
 * user to choose a function to perform between 4 categories. While running, it
 * will keep track of how many calculations have been performed throughout the program
 ******************************************************************************************/

namespace CalculatorFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            // setup the program by making the class objects
            BasicMath basic = new BasicMath();
            AdvancedMath advanced = new AdvancedMath();
            Area area = new Area();
            Volume volume = new Volume();
            Console.WriteLine("Welcome to the Calculator App!");

            int input = 0;

            do
            {
                // Display the list of commands to the user and accept input
                Console.WriteLine("");
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1: Basic Mathematical Equations");
                Console.WriteLine("2: Advanced Functions");
                Console.WriteLine("3: Compute Area");
                Console.WriteLine("4: Compute Volume");
                Console.WriteLine("0: Exit");

                input = Convert.ToInt32(Console.ReadLine());
                
                // Switch statements will call the appropriate function.
                switch(input)
                {
                    case 1:
                        basic.functionChoice();
                        break;
                    case 2:
                        advanced.functionChoice();
                        break;
                    case 3:
                        area.functionChoice();
                        break;
                    case 4:
                        volume.functionChoice();
                        break;
                    default:
                        break;
                }

            } while (input != 0); // Loop will repeat while the user hasn't entered 0

            // At the end of the program, the console will display how many 
            // calculations have been performed based on which class performed it
            Console.WriteLine("You performed this many Calculations:");
            Console.WriteLine("Number of Basic Calculations: " + basic.getCalculations());
            Console.WriteLine("Number of Advanced Calculations: " + advanced.getCalculations());
            Console.WriteLine("Number of Area Calculations: " + area.getCalculations());
            Console.WriteLine("Number of Volume Calculations: " + volume.getCalculations());
        }
    }
}