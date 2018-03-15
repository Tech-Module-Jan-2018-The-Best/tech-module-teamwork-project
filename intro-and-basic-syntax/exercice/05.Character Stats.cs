// CONFIRMED from HristomirAsenov
using System;

namespace _05.Character_Stats
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOfCharacter = Console.ReadLine();
            // Here We read four input lines from the console  and convert it to Integer data type by the "Parse" Method
            int currentHealth = int.Parse(Console.ReadLine());
            int maxHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());

            int numberOfHealthDashes = currentHealth;

            // Here We create a new string by repeating the char '|', as many times as the value of numberOfHealthDashes
            string healthDashes = new string('|', numberOfHealthDashes);

            int numberOfHealthDots = maxHealth - currentHealth;
            string healthDots = new string('.', numberOfHealthDots);

            int numberOfEnergyDashes = currentEnergy;
            string energyDashes = new string('|', numberOfEnergyDashes);

            int numberOfEnergyDots = maxEnergy - currentEnergy;
            string energyDots = new string('.', numberOfEnergyDots);

            // Here We print the output to the console by using String Interpolation
            Console.WriteLine($"Name: {nameOfCharacter}");
            Console.WriteLine($"Health: |{healthDashes}{healthDots}|");
            Console.WriteLine($"Energy: |{energyDashes}{energyDots}|");
        }
    }
}
