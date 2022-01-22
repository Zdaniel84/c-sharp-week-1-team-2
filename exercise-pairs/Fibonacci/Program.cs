using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Greetings User! Please enter an integer value:");
            
            string userInputString = Console.ReadLine();
            int userInputInt = int.Parse(userInputString);
            int fibonacciSmaller = 0;
            int fibonacciLarger = 1;
            int fibonacciCurrent = 0;
           
            string fibSequence = "0, 1";

            //Special Case <+0
            if(userInputInt <= 0)
            {
                Console.WriteLine(fibSequence);
            }
            else if (userInputInt == 1)
            {
                Console.WriteLine(fibSequence + ", 1");
            }
            else
            {
                while(userInputInt >= fibonacciLarger + fibonacciSmaller)
                {
                    fibonacciCurrent = fibonacciSmaller + fibonacciLarger;
                    fibonacciSmaller = fibonacciLarger;
                    fibonacciLarger = fibonacciCurrent;

                    fibSequence += ", " + fibonacciLarger;

                }

                Console.WriteLine(fibSequence);

            }
            //Adjust String for next Fibonacci number
            //Loop to add numbers to string until the Fibonacci > UserInput

            //Print the string 

            //Startover


            //Create a 10 number long version of the Fibbonacci Sequence
        }
    }
}
