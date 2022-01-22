using System;

namespace DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Dave! \nPlease enter a series of base-10 integers (separated by spaces):");
            string userInput = Console.ReadLine();
            string[] decimalInputArray = userInput.Split(" ");

            //13 % 2 = 1
            //(13 / 2 = 6)
            //6 % 2 = 0
            //(6 / 2 = 3)
            //3 % 2 = 1
            //(3 / 2 = 1)
            //1 % 2 = 1

            //    1101
        }

    }
}
