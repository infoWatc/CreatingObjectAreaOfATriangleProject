/* **************************************************
 * Example of creating an object and doing some work
 ***************************************************/
using System;

namespace creatingObjectAreaOfATriangle
{
    class Triangle
    {
        //Declare class integer for work
        public decimal baseTriangle, height, half;

        //Class Method Triangle assigning type
        public Triangle(decimal b, decimal h)
        {
            baseTriangle = b;
            height = h;           
        }

        //Class Method to process work
        public decimal Area()
        {
            // Declare value for Decimal type integer half of 0.5
            half = 0.5m; 

            // integer variable length * base;
            return  (half * height * baseTriangle);
        }
    }
    // Class Program for Main
    class Program
    {
        static void Main(string[] args)
        {
            // Console Write
            Console.Write("Step 1; Please enter breadth of the triangle: ");

            // Console Read Line convert to integer
            int readLine1 = int.Parse(Console.ReadLine());

            Console.Write("Step 2; Please enter the height of the triangle: ");

            // Console Read Line convert to integer
            int readLine2 = int.Parse(Console.ReadLine());

            // create object with the variables values to do work
            Triangle tri1 = new Triangle(readLine1, readLine2);              

            // Declare int area to hold data from class method Triangle.Area
            decimal area = tri1.Area();
           
            // Print Line text + variable area
            Console.WriteLine($"The area of the" +
                $" Triangle is {area}");
        }
    }
}
