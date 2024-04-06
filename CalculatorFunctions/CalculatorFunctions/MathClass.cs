using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorFunctions
{
    /************************************************************************************
     * Class: MathClass
     * Desciption: An abstract class, MathClass provides   
     * the abstract function functionChoice, as the classes that   
     * inherit from MathClass have different forms on how it will run.
     ************************************************************************************/
    abstract class MathClass
    {
        public MathClass() { numCalculations = 0; }

        // Provides the abstract function for the child classes to override
        public abstract void functionChoice();

        // Gets the calculations that have been done based on the class that called it
        public int getCalculations() { return numCalculations; }

        // Each class tracks its own number of calculations done
        protected int numCalculations;
    }
}
