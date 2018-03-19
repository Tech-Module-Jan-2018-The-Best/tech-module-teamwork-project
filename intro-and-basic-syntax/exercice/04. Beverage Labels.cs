//Confirmed by yoanaangelova

using System;

namespace _04._Beverage_Labels
{
    class Program
    {
        static void Main(string[] args)
        {
			//Here we recieve the product's name
            var productName = Console.ReadLine(); // Old variable name was "name".
			
			//Here we recieve the product's volume
            int productVolume = int.Parse(Console.ReadLine()); // Old variable name was "volume".
			
			//Here we recieve the energy content of the product per 100ml
            int productEnergy = int.Parse(Console.ReadLine()); // Old variable name was "energy".
			
			//Here we recieve the sugar content of the product per 100ml
            int productSugar = int.Parse(Console.ReadLine()); // Old variable name was "sugar".

			//On the next two lines we calculate the energy and the sugar content of the product
            double neededEnergyProduct = (double)productEnergy * productVolume / 100; // Old variable name was "energy_need".
            double neededSugarProduct = (double)productSugar * productVolume / 100; // Olv variable name was "sugar_need".

			//Here we print the product's name and volume
            Console.WriteLine("{0}ml {1}:", productVolume, productName);
			
			//Here we print the energy and sugar content of the product
            Console.WriteLine("{0}kcal, {1}g sugars", neededEnergyProduct, neededSugarProduct);
        }
    }
}
