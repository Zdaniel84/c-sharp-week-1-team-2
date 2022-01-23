using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables Required!
            string userInputString = "";
            int userInputInt = 1;
            int fibonacciSmaller = 0;
            int fibonacciLarger = 1;
            int fibonacciCurrent = 0;

            //Following Variable added for choice to "play" again -- I think I need both of these
            string userPlayAgainChoice = "y";
            bool userPlayAgainChoiceBool = true;

            string fibSequence = "0, 1";
            
            //Adding a while loop to let the user "play" again
            while(userPlayAgainChoiceBool == true)
            {
                //Reset Variables -- Do I have to do this? Is there a better way? 
                fibonacciSmaller = 0;
                fibonacciLarger = 1;
                fibonacciCurrent = 1;

                //Changed Greeting and moved into Play again while loop
                Console.WriteLine("Greetings User! Provide me with an integer value, and I will show you the Fibonacci sequence up to your number!:");
                userInputString = Console.ReadLine();
                userInputInt = int.Parse(userInputString);
                fibSequence = "0, 1";

                //Special Case if ujser input is zero or less than zero
                if (userInputInt <= 0)
                {
                    Console.WriteLine(fibSequence);
                }
                //Special case if user input is one
                else if (userInputInt == 1)
                {
                    Console.WriteLine(fibSequence + ", 1");
                }

                //All other cases (integer input)
                else
                {
                    while (userInputInt >= fibonacciLarger + fibonacciSmaller)
                    {
                        fibonacciCurrent = fibonacciSmaller + fibonacciLarger;
                        fibonacciSmaller = fibonacciLarger;
                        fibonacciLarger = fibonacciCurrent;

                        fibSequence += ", " + fibonacciLarger;

                    }

                    Console.WriteLine(fibSequence);
                   


                }
                Console.WriteLine("Would you like to try another number? Enter y for yes or n for no");
                userPlayAgainChoice = Console.ReadLine();

                //Clear Screen to Make it Pretty
                Console.Clear();

                if(userPlayAgainChoice == "y")
                {
                    userPlayAgainChoice = "true";
                }
                else if(userPlayAgainChoice == "n")
                {
                    userPlayAgainChoice = "false";
                }

                userPlayAgainChoiceBool = bool.Parse(userPlayAgainChoice);

            }
        }
    }
}
