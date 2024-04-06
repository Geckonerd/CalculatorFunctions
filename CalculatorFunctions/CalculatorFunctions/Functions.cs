using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorFunctions
{
    /************************************************************************************
     * Class: Functions
     * Desciption: A base class of formulas, providing  
     * necessary functions for both the Volume and Area classes
     ************************************************************************************/
    internal class Functions : MathClass
    {
        public Functions() { }

        // These four functions are here to gather needed
        // information, as they are common between both classses
        public int getHeight()
        {
            Console.WriteLine("Please enter Height: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        public int getWidth()
        {
            Console.WriteLine("Please enter Width: ");
            return Convert.ToInt32(Console.ReadLine());
        }
        public int getRadius()
        {
            Console.WriteLine("Please enter Radius: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        public int getLength()
        {
            Console.WriteLine("Please enter Length: ");
            return Convert.ToInt32(Console.ReadLine());
        }
        public override void functionChoice() {}
    }

    /************************************************************************************
     * Class: Area
     * Desciption: An extension of the Functions class, Area contains formulas
     * that calculate the area of 2-Dimensional objects with the provided measurements
     ************************************************************************************/
    internal class Area : Functions
    {
        public Area() {}

        // These four functions calculate the area of the respective shapes
        private void Circle() 
        {
            int radius = getRadius();
            Console.WriteLine("The area of this circle is " + (Math.PI * radius * radius));
        }

        private void Square() 
        {
            int length = getLength();
            Console.WriteLine("The area of this square is " + (length * length));
        }

        private void Triangle() 
        {
            int length = getLength();
            int height = getHeight();
            Console.WriteLine("The area of this triangle is " + ((length * height) / 2));
        }

        private void Rectangle() 
        {
            int length = getLength();
            int height = getHeight();
            Console.WriteLine("The area of this rectangle is " + (length * height));
        }
        public override void functionChoice()
        {
            Console.Clear();
            Console.WriteLine("1. Circle");
            Console.WriteLine("2. Square");
            Console.WriteLine("3. Triangle");
            Console.WriteLine("4. Rectangle");

            int input = Convert.ToInt32(Console.ReadLine());

            switch (input)
            {
                case 1:
                    Circle();
                    break;
                case 2:
                    Square();
                    break;
                case 3:
                    Triangle();
                    break;
                case 4:
                    Rectangle();
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

    /************************************************************************************
     * Class: Volume
     * Desciption: An extension of the Functions class, Volume contains formulas
     * that calculate the volume of 3-Dimensional objects with the provided measurements
     ************************************************************************************/
    internal class Volume : Functions
    {
        public Volume() {}

        // These four functions calculate the volume of the respective shapes
        private void Sphere() 
        {
            int radius = getRadius();
            Console.WriteLine("The volume of this sphere is " + ((4/3) * Math.PI * Math.Pow(radius,3)));
        }

        private void Cube() 
        {
            int length = getLength();
            Console.WriteLine("The volume of this cube is " + Math.Pow(length, 3));
        }

        private void Pyramid() 
        {
            int length = getLength();
            int width = getWidth();
            int height = getHeight();
            Console.WriteLine("The volume of this pyramid is " + ((length * width * height) / 3));
        }

        private void Cylinder() 
        {
            int radius = getRadius();
            int height = getHeight();
            Console.WriteLine("The volume of this pyramid is " + (Math.PI * radius * radius * height));
        }
        public override void functionChoice()
        {
            Console.Clear();
            Console.WriteLine("1. Sphere");
            Console.WriteLine("2. Cube");
            Console.WriteLine("3. Pyramid");
            Console.WriteLine("4. Cylinder");

            int input = Convert.ToInt32(Console.ReadLine());

            switch (input)
            {
                case 1:
                    Sphere();
                    break;
                case 2:
                    Cube();
                    break;
                case 3:
                    Pyramid();
                    break;
                case 4:
                    Cylinder();
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
