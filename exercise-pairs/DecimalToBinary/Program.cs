using System;

namespace DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {   //Code works great, comments could use some work
            string userInput = "";            
            string userPlayAgainChoice = "";            
            
                        
            //int moduloResult = 0;  -- Moved into loop/works fine.           
            bool continueVariable = true;
            
            while (continueVariable == true)
            {
                Console.WriteLine("Hello, Dave! \nPlease enter a series of base-10 integers (separated by spaces):");
                userInput = Console.ReadLine();
                string[] decimalInputArray = userInput.Split(" ");
             


                for (int i = 0; i < decimalInputArray.Length; i++)
                {
                    
                    string returnToUser = "";
                    
                    int convertedValue = int.Parse(decimalInputArray[i]); 

                    
                        int convertedValuePlaceholder = convertedValue; //modulo math
                        if (convertedValue == 0)
                        {
                            returnToUser = "0";
                        }
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
                            
                            convertedValue = convertedValue / 2;



                        }
                        Console.WriteLine(convertedValuePlaceholder + " in binary is: " + returnToUser);                      



                    


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
                        
                        validInput = false;
                        Console.Clear();
                        Console.WriteLine("Invalid input, please enter y or n to continue: ");
                        userPlayAgainChoice = Console.ReadLine();
                        
                    }
                }
                continueVariable = bool.Parse(userPlayAgainChoice);
            }




            
        }

    }
}
