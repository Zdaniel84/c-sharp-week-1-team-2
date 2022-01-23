using System;

namespace DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {            
            string userInput = "";            
            string userPlayAgainChoice = "";
            //bool userPlayAgainChoiceBool = true;

            //13 % 2 = 1
            //(13 / 2 = 6)
            //6 % 2 = 0
            //(6 / 2 = 3)
            //3 % 2 = 1
            //(3 / 2 = 1)
            //1 % 2 = 1
            //1101
                        
            //int moduloResult = 0;  -- Moved into loop/works fine.           
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
                    //integerDivisionResults = 1;
                    string returnToUser = "";

                    //-------------------------------------------------------------------------
                    // Trying to fix invalid form/input/anything that doesn't follow the rules.
                    // Also problem with 0 not returning result for 0.
                    // TryParse test works! Now need to figure out how to apply TryParse to each element in array...
                    //-------------------------------------------------------------------------
                    //int convertedValue;
                    //if (int.TryParse(decimalInputArray[0], out convertedValue))
                    //{
                    //    Console.WriteLine("It worked!" + convertedValue);
                    //    Console.ReadLine();
                    //}
                    //else
                    //{
                    //    Console.WriteLine("It didn't work!"); ??
                    //    Console.ReadLine();
                    //}
                    int convertedValue = int.Parse(decimalInputArray[i]); // convert to integer array
                                                                      //converted value to binary


                    {//modulo math
                        int convertedValuePlaceholder = convertedValue;

                        while (convertedValue != 0)

                        {
                            int moduloResult = convertedValue % 2;

                            if (moduloResult == 1)
                            {
                                returnToUser = "1" + returnToUser;
                            }
                            else if (moduloResult == 0)
                            {
                                returnToUser = "0" + returnToUser;
                            }
                            //integerDivisionResults = convertedValue / 2;
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
                bool validInput = false;

                while (!validInput)
                {




                    //Zac and Jason working on various user input options.


                    if (userPlayAgainChoice == "y" || userPlayAgainChoice == "yes" || userPlayAgainChoice == "Y" || userPlayAgainChoice == "Yes")
                                                          
                    {
                        userPlayAgainChoice = "true";
                        validInput = true;
                        Console.Clear();
                    }
                    else if (userPlayAgainChoice == "n" || userPlayAgainChoice == "no" || userPlayAgainChoice == "N" || userPlayAgainChoice == "No")
                    {

                        userPlayAgainChoice = "false";
                        validInput = true;
                        Console.Clear();
                        Console.WriteLine("Have a Nice Day!\r\nPress Return to Exit");
                        Console.ReadLine();
                    }
                    else //Anything else that's entered.
                    {
                        //Console.WriteLine("You suck at following directions!"); //DON'T FORGET TO CHANGE MESSAGE!
                        //Console.ReadLine();
                        validInput = false;
                        Console.Clear();
                        Console.WriteLine("Invalid input, please enter y or n to continue: ");
                        userPlayAgainChoice = Console.ReadLine();
                        
                    }
                }
                continueVariable = bool.Parse(userPlayAgainChoice);
            }




            //start for loop
            //parse to ints
            //binary conversion
        }

    }
}
