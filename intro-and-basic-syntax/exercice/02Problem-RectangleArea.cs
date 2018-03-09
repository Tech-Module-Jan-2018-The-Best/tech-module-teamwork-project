using System;

namespace Problem_02._Rectangle_Area
{
    class Program02RectangleArea
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double area = width * height;

            Console.WriteLine($"{area:f2}");
        }
    }
}
