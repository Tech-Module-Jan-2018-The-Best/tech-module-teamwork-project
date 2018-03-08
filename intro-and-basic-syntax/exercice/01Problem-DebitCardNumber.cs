using System;
using System.Text;

namespace DebitCardNumber
{
    class DebitCardNumber
    {
        static void Main(string[] args)
        {
            var result = new StringBuilder();

            for (int i = 0; i < 4; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());

                Console.Write("{000:0000} ", currentNum);
            }
            Console.WriteLine();
        }
    }
}