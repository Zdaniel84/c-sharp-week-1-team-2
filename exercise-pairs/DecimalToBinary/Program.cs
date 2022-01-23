using System;

namespace DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, Dave! \nPlease enter a series of base-10 integers (separated by spaces):");
            string userInput = "";
            // string[] decimalInputArray = userInput.Split(" ");
            string userPlayAgainChoice = "";
            bool userPlayAgainChoiceBool = true;

            //13 % 2 = 1
            //(13 / 2 = 6)
            //6 % 2 = 0
            //(6 / 2 = 3)
            //3 % 2 = 1
            //(3 / 2 = 1)
            //1 % 2 = 1

            //    1101
            
            int convertedValuePlaceholder = 0; //declare temp variables
            int integerDivisionResults = 1;
            int moduloResult = 0;
            string returnToUser = "";
            int convertedValue = 0;
            bool continueVariable = true;
            
            while (continueVariable == true)
            {
                Console.WriteLine("Hello, Dave! \nPlease enter a series of base-10 integers (separated by spaces):");
                userInput = Console.ReadLine();
                string[] decimalInputArray = userInput.Split(" ");
              //  userPlayAgainChoice = "y";
                //userPlayAgainChoiceBool;


                for (int i = 0; i < decimalInputArray.Length; i++)
                {
                    //Reset Variables
                    integerDivisionResults = 1;
                    returnToUser = "";



                    convertedValue = int.Parse(decimalInputArray[i]); // convert to integer array
                                                                      //converted value to binary

                    {//modulo math
                        convertedValuePlaceholder = convertedValue;
                        while (integerDivisionResults != 0)

                        {
                            moduloResult = convertedValue % 2;

                            if (moduloResult == 1)
                            {
                                returnToUser = "1" + returnToUser;
                            }
                            else if (moduloResult == 0)
                            {
                                returnToUser = "0" + returnToUser;
                            }
                            integerDivisionResults = convertedValue / 2;
                            //convertedValuePlaceholder = convertedValue;
                            convertedValue = convertedValue / 2;



                        }
                        Console.WriteLine(convertedValuePlaceholder + " in binary is: " + returnToUser);
                        //  Console.WriteLine(returnToUser);
                        //   returnToUser = "";
                        //toss result to string

                        //integer division



                    }


                }

                //Copied the play again code from Fibonacci
                //-----------------------------------------
                Console.WriteLine("Would you like to try another number? Enter y for yes or n for no");
                userPlayAgainChoice = Console.ReadLine();

                //Clear Screen to Make it Pretty
                Console.Clear();

                if (userPlayAgainChoice == "y")
                {
                    userPlayAgainChoice = "true";
                }
                else if (userPlayAgainChoice == "n")
                {
                    userPlayAgainChoice = "false";
                    Console.WriteLine("Have a Nice Day!\r\nPress Return to Exit");
                    Console.ReadLine();
                }

                continueVariable = bool.Parse(userPlayAgainChoice);
            }




            //start for loop
            //parse to ints
            //binary conversion
        }

    }
}
