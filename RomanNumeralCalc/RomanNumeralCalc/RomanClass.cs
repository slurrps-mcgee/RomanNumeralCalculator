using System;
using System.Collections.Generic;
using System.Text;

namespace RomanClassTest
{
    //Author: Kenneth Lamb
    //Purpose:  This class contains the definiton of a RomanClassTest. It contains one private data members and 
    // 9 public methods. The data members are: strRomanNumeral which holds the string of roman numeral characters.
    // A summary of the methods appears below:
    // 
    // Assumptions: Data supplied will be a valid roman numeral.
    //          
    // Exception Handling: None
    //
    // Summary of Methods:
    //  Public static bool IsValidRomanNum(string strNum) used to test the string to make sure it is a valid roman numeral
    //  public static RomanClass operator +(RomanClass leftOP, RomanClass rtOP) used to add two roman numerals together
    //  public static RomanClass operator -(RomanClass rtOp, RomanClass leftOp) used to subtract two roman numerals together
    //  public static bool operator > (RomanClass leftOp, RomanClass rtOp) used to see if the leftOp is greater than the rtOp
    //  public static bool operator <(RomanClass leftOp, RomanClass rtOp) used to see if the leftOp is less than the rtOp
    //  public int ConvertToDecimal() //to convert the string to decimal format
    //  public string SetString(int intNumber) to convert the decimal to roman numeral string format and set the string of the class
    //  public int SingleValueCharacters(char romanCharacter) used to see which characters in the string hold which value in the roman numeral system
    //  public override string ToString() overrides the ToString method


    class RomanClass
    {
        //PDM------------------------
        private string strRomanNumeral = "";//Holds the Roman Numeral to come into the class

        //Default Constructor-------------------------------------------------------
        //Pre: Object has been instantiated
        //Post: Class has been initialized to strRomanNumeral ""
        //Purpose: initialized a class object
        public RomanClass()
        {
            strRomanNumeral = "";
        }

        //Non Default Constructor------------------------------------------------
        //Pre: strRomanNumeral contains the roman number in string
        //Post: PDM of class have been set to incoming parameters
        //Purpose: initialized a class object with values strRomanNumeral
        public RomanClass(string romanNumber)
        {
            strRomanNumeral = romanNumber;
        }

        //Addition Override
        //RomanClass operator + ------------------------------------------------------
        //Pre:Object has been instantiated
        //Post: overrides the addition letting the two string add together
        //Purpose: returns the class initiated in the method set to the sum of the two strings
        public static RomanClass operator +(RomanClass leftOP, RomanClass rtOP)
        {
            RomanClass rtn = new RomanClass();//set an instance of the Roman Class for the return value

            int intNum1 = leftOP.ConvertToDecimal();//Converts the second button to decimal
            int intNum2 = rtOP.ConvertToDecimal();//Converts first number to decimal
            

            int intTotal = intNum1 + intNum2; //Adds the two numbers together
            //Checks to make sure the number is not over 3999
            if(intTotal > 3999)
            {
                intTotal = 0;
            }


            rtn.SetString(intTotal);//Sets the PDM of the return value.

            return rtn;//Returns the value
        }//End RomanClass operator +

        //Subtraction override
        //RomanClass operator - ------------------------------------------------
        //Pre:Object has been instantiated
        //Post: overrides the subtraction letting the two string subtract from one another
        //Purpose: returns the class initiated in the method set to the subtraction of the two strings
        public static RomanClass operator -(RomanClass leftOp, RomanClass rtOp)
        {
            RomanClass rtn = new RomanClass();//set an instance of the Roman Class for the return value

            int intNumR = rtOp.ConvertToDecimal();//Converts first number to decimal
            int intNumL = leftOp.ConvertToDecimal();//Converts the second button to decimal
            int intTotal = 0;
            if (leftOp > rtOp)
            {
                intTotal = intNumL - intNumR; //subtracts the left from the right
            }
            else if(leftOp < rtOp)
            {
                intTotal = intNumR - intNumL; //subtracts the right from the left
            }
                       
            rtn.SetString(intTotal);//Sets the PDM of the return value.

            return rtn;//Returns the value
        }//End RomanClass operator -

        //Override the greater than operator
        //Bool operator >---------------------------------------------------
        //Pre:Object has been instantiated
        //Post: overrides the greater than sign to test if one class is greater than the other
        //Purpose: returns true or false depending if the left class is greater than the right class
        public static bool operator > (RomanClass leftOp, RomanClass rtOp)
        {
            //Set the integers to the strings of the classes
            int intNumR = rtOp.ConvertToDecimal();
            int intNumL = leftOp.ConvertToDecimal();
            //check if the left is greater than the right
            if(intNumL > intNumR)
            {
                return true;
            }
            else
            {
                return false;
            }

        }//End Bool Operator >

        //Override the less than operator
        //Bool Operator <---------------------------------------------
        //Pre:Object has been instantiated
        //Post: overrides the less than sign to test if one class is less than the other
        //Purpose: returns true or false depending if the left class is less than the right class
        public static bool operator <(RomanClass leftOp, RomanClass rtOp)
        {
            //Set the integers from the classes Strings
            int intNumR = rtOp.ConvertToDecimal();
            int intNumL = leftOp.ConvertToDecimal();
            //Check if the left is less than the right
            if (intNumL < intNumR)
            {
                return true;
            }
            else
            {
                return false;
            }

        }//End Bool Operator <


        //Check to see whether the character is a roman numeral letter
        //IsValidRomanNum-----------------------------------------------------
        //Pre:Object has been instantiated
        //Post: returns true or false depending on whether the string is a roman numeral or not
        //Purpose: to test each character in the string to see if they are valid roman characters
        public bool IsValidRomanNum(string strNum)
        {
            //Set the bool isValid to false
            bool isValid = false;

            if (strNum == "LLL" || strNum == "DDD")
            {
                isValid = false;
            }
            else
            {
                foreach (char charLetter in strNum.ToUpper().Trim())
                {

                    //Here we will run each letter through this switch to make sure it is of the list of available
                    //letters in the roman numeral set.
                    switch (charLetter)
                    {
                        case 'M':
                            {
                                isValid = true;
                                break;
                            }

                        case 'D':
                            {
                                isValid = true;
                                break;
                            }

                        case 'C':
                            {
                                isValid = true;
                                break;
                            }

                        case 'L':
                            {
                                isValid = true;
                                break;
                            }

                        case 'X':
                            {
                                isValid = true;
                                break;
                            }

                        case 'V':
                            {
                                isValid = true;
                                break;
                            }

                        case 'I':
                            {
                                isValid = true;
                                break;
                            }
                        default:
                            {
                                isValid = false;
                                break;
                            }
                    }//End switch

                }
            }



            //return the boolean
            return isValid;


        }//End IsValidRomanNum

        //Converts the string strRomanNumeral to an integer
        //ConvertToDecimal------------------------------------------------------
        //Pre:Object has been instantiated
        //Post: returns the integer that comes from the string strRomanNumeral
        //Purpose: to convert each character to their decimal values then add them together returning the integer
        public int ConvertToDecimal()
        {

            int result = 0; //This will hold the result

            //We will throw each character in the romanNumeral string into the switch statement
            //SingleValueCharacters to convert each character in the string
            foreach (char romanCharacter in strRomanNumeral.ToUpper().Trim()) //Make sure to .ToUpper the incomming string
            {
                if (IsValidRomanNum(strRomanNumeral) == false)//Check to see if the characters are a valid Roman Numeral.
                {
                    Console.WriteLine("This is not a valid a valid roman character! Please enter a valid Roman Numeral.");
                }
                else
                {
                    result += SingleValueCharacters(romanCharacter);//Convert each character to decimal then add it to the result variable
                }

            }

            //If the string contains any of the two combinations below simply remove 2 from the result.
            //This will take care of 4's and 9's
            if (strRomanNumeral.Contains("IV") || strRomanNumeral.Contains("IX"))
            {
                result -= 2;
            }
            //If the string contains any of the two combinations below simply remove 20 from the result.
            //This will take care of 40's and 90's
            if (strRomanNumeral.Contains("XL") || strRomanNumeral.Contains("XC"))
            {
                result -= 20;
            }
            //If the string contains any of the two combinations below simply remove 200 from the result.
            //This will take care of 400's and 900's
            if (strRomanNumeral.Contains("CD") || strRomanNumeral.Contains("CM"))
            {
                result -= 200;
            }

            //Chack to make sure the result is not over 3999 or under 0
            if (result > 3999)
            {
                Console.WriteLine("Error number is too high cannot be above 3999");
            }
            else if (result < 0)
            {
                Console.WriteLine("Error number cannot be below 0");
            }

            //Return result
            return result;

        }//End ConverToDecimal

        //Converts the integer to a string then sets that string as the PDM
        //SetString--------------------------------------------------------
        //Pre:Object has been instantiated
        //Post: returns the string that results in converting the integer into a roman numeral and sets it to the PDM
        //Purpose: convert the integer into a roman numeral string then return the string
        public string SetString(int intNumber)
        {

            string strRomanNumber = ""; //Holds the string to be returned
            int remainder; //Holds the remainder of the calculation to see how many times it goes into the number
            int intExitNumber = 0; //This is the exit number for that loop

            //Do error checking here
            //the number is below zero produce the following error message
            if (intNumber < 0)
            {
                Console.WriteLine("Number cannot be negative");
            }
            else if (intNumber > 3999) //if over 3999 error too high a number
            {
                Console.WriteLine("Number cannot be above 3999");
            }
            else if (intNumber == 0)//If 0 output a string of ""
            {
                strRomanNumber = "";
            }


            do //Do while loop to convert the decimal values into roman numeral strings.
            {
                //1000----------------------check for 1000's
                if (intNumber >= 1000)
                {
                    //depending on the remainder is how many of the characters are entered into the string!
                    remainder = intNumber / 1000;
                    if (remainder == 1)
                    {
                        strRomanNumber = strRomanNumber + "M";
                    }
                    else if (remainder == 2)
                    {
                        strRomanNumber = strRomanNumber + "MM";
                    }
                    else if (remainder == 3)
                    {
                        strRomanNumber = strRomanNumber + "MMM";
                    }

                    intNumber = intNumber % 1000;
                }//Works
                //900--------------------------check for 900's
                else if (intNumber >= 900 && intNumber < 1000)
                {
                    strRomanNumber = strRomanNumber + "CM";
                    intNumber = intNumber % 900;
                }
                //500--------------------check for 500's
                else if (intNumber >= 500 && intNumber < 900)
                {
                    strRomanNumber = strRomanNumber + "D";
                    intNumber = intNumber % 500;
                }
                //100---------------------check for 100's
                else if (intNumber >= 100)
                {
                    //depending on the remainder is how many of the characters are entered into the string!
                    remainder = intNumber / 100;
                    if (remainder == 1)
                    {
                        strRomanNumber = strRomanNumber + "C";
                    }
                    else if (remainder == 2)
                    {
                        strRomanNumber = strRomanNumber + "CC";
                    }
                    else if (remainder == 3)
                    {
                        strRomanNumber = strRomanNumber + "CCC";
                    }
                    else if (remainder == 4)
                    {
                        strRomanNumber = strRomanNumber + "CD";
                    }

                    intNumber = intNumber % 100;
                }
                //90----------------------check for 90's
                else if (intNumber >= 90 && intNumber < 100)
                {
                    strRomanNumber = strRomanNumber + "XC";
                    intNumber = intNumber % 90;
                }
                //50--------------------------check for 50's
                else if (intNumber >= 50)
                {
                    strRomanNumber = strRomanNumber + "L";
                    intNumber = intNumber % 50;
                }
                //10-----------------------check for 10's
                else if (intNumber >= 10)
                {
                    //depending on the remainder is how many of the characters are entered into the string!
                    remainder = intNumber / 10;
                    if (remainder == 1)
                    {
                        strRomanNumber = strRomanNumber + "X";
                    }
                    else if (remainder == 2)
                    {
                        strRomanNumber = strRomanNumber + "XX";
                    }
                    else if (remainder == 3)
                    {
                        strRomanNumber = strRomanNumber + "XXX";
                    }
                    else if (remainder == 4)
                    {
                        strRomanNumber = strRomanNumber + "XL";
                    }

                    intNumber = intNumber % 10;
                }
                //9-----------------------------check for 9's
                else if (intNumber >= 9 && intNumber < 10)
                {
                    strRomanNumber = strRomanNumber + "IX";
                    intNumber = intNumber % 9;
                }
                //5-------------------------------check for five's
                else if (intNumber >= 5)
                {
                    strRomanNumber = strRomanNumber + "V";
                    intNumber = intNumber % 5;
                }
                //1---------------------------Check for one's
                else if (intNumber >= 1)
                {
                    //depending on the remainder is how many of the characters are entered into the string!
                    remainder = intNumber / 1;
                    if (remainder == 1)
                    {
                        strRomanNumber = strRomanNumber + "I";
                    }
                    else if (remainder == 2)
                    {
                        strRomanNumber = strRomanNumber + "II";
                    }
                    else if (remainder == 3)
                    {
                        strRomanNumber = strRomanNumber + "III";
                    }
                    else if (remainder == 4)
                    {
                        strRomanNumber = strRomanNumber + "IV";
                    }
                    intNumber = intNumber % 1;
                }


            } while (intExitNumber < intNumber);

            //Set the string to be placed in the PDM
            strRomanNumeral = strRomanNumber;

            return strRomanNumber;

        }//End Set String class

        //Here we will use a switch statement for all of the single character roman numerals to set the value 
        //according to which character they are
        //SingleValueCharacter-----------------------------------------------------------------------------------
        //Pre:Object has been instantiated
        //Post: returns the integer that comes from the character that is brought into the method
        //Purpose: checks all the characters brought in and sees what value they are and returns that value
        private int SingleValueCharacters(char romanCharacter)
        {


            //We will use this string to return values for each character in the string to the convert decimal method
            switch (romanCharacter)
            {
                case 'M':
                    {
                        return 1000;
                    }

                case 'D':
                    {
                        return 500;
                    }

                case 'C':
                    {
                        return 100;
                    }

                case 'L':
                    {
                        return 50;
                    }

                case 'X':
                    {
                        return 10;
                    }

                case 'V':
                    {
                        return 5;
                    }

                default:
                    {
                        return 1;
                    }


            }//End switch
        }//End SingleValueCharacters class


        //ToString override--------------------------------------------------------------------------------------
        //Pre:Object has been instantiated
        //Post: A string representing the contents of the PDM's has been returned
        //Purpose: returns a string delineating the contents of the class PDM's
        public override string ToString()
        {
            return strRomanNumeral;
        }
    }
}
