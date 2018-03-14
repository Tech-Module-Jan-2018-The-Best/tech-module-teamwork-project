using System;

namespace Problem_02._Rectangle_Area
{
    class Program02RectangleArea
    {
        static void Main(string[] args)
        {
			// Create a variable "width" from double data type.
			// Parsing the input to double and save it to width.
            double widthOfRectangle = double.Parse(Console.ReadLine()); //variable name changed from "width" to "widthOfRectangle"

            // Create a variable "height" from double data type.
            // Parsing the input to double and save it to height.
            double heightOfRectangle = double.Parse(Console.ReadLine()); //variable name changed from "height" to "heightOfRectangle"

            // Create a variable "area" from double data type, which will save the result.
            double area = widthOfRectangle * heightOfRectangle;

			// Print the area to the console.
            Console.WriteLine($"{area:f2}");
        }
    }
}
