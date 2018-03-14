// CONFIRMED from polinamusheva

using System;

namespace ConsoleApp7
{
    class MielsToKilometers
    {
        static void Main(string[] args)
        {
            // Here we read the amount of miles to be converted as a decimal data type from the console
            decimal miles = decimal.Parse(Console.ReadLine());
            // here we convert the miles to kilometers (by the formula) and assign the value to a new variable
            decimal kilometers = miles * (decimal)1.60934;
            // Finally we print the value of the kilometers with rouding to 2 numbers after the decimal point
            Console.WriteLine($"{kilometers:f2}");

        }
    }
}
