using System;
using System.Text;

namespace DebitCardNumber
{
    class DebitCardNumber
    {
        static void Main(string[] args)
        {   //Here we use a for-cycle to receive the input and later to print it
            for (int i = 0; i < 4; i++)
            {
                //Here we receive the input from the console and parse it to integer
                int currentNum = int.Parse(Console.ReadLine());
                //Here we print on the console the input in 4-digit debit card format
                Console.Write("{000:0000} ", currentNum);
            }
            Console.WriteLine();
        }
    }
}