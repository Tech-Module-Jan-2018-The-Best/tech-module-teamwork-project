using System;

namespace _04._Beverage_Labels
{
    class Program
    {
        static void Main(string[] args)
        {
			//Here we recieve the product's name
            var name = Console.ReadLine();
			//Here we recieve the product's volume
            int volume = int.Parse(Console.ReadLine());
			//Here we recieve the energy content of the product per 100ml
            int energy = int.Parse(Console.ReadLine());
			//Here we recieve the sugar content of the product per 100ml
            int sugar = int.Parse(Console.ReadLine());

			//On the next two lines we calculate the energy and the sugar content of the product
            double energy_need = (double)energy * volume / 100;			
            double sugar_need = (double)sugar * volume / 100;

			//Here we print the product's name and volume
            Console.WriteLine("{0}ml {1}:", volume, name);
			//Here we print the energy and sugar content of the product
            Console.WriteLine("{0}kcal, {1}g sugars", energy_need, sugar_need);
        }
    }
}
