using System;

namespace ConsoleApp7
{
    class MielsToKilometers
    {
        static void Main(string[] args)
        {
            decimal miles = decimal.Parse(Console.ReadLine());

            decimal kilometers = miles * (decimal)1.60934;

            Console.WriteLine($"{kilometers:f2}");

        }
    }
}
