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
            
            int convertedValuePlaceholder = 0; //declare temp variables
            int integerDivisionResults = 1;
            int moduloResult = 0;
            string returnToUser = "";
           
            for (int i = 0; i < decimalInputArray.Length; i++) 
            {
                
                int convertedValue = int.Parse(decimalInputArray[i]); // convert to integer array
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
                    Console.WriteLine(returnToUser);
                    returnToUser = "";
                    //toss result to string

                    //integer division



                }
                

            }






            //start for loop
            //parse to ints
            //binary conversion
        }

    }
}
