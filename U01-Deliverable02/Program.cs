using System;

namespace U01_Deliverable02
{
    class Program
    {
        static void Main(string[] args)
        {

            string input;                       //user inputted text
            string message = "";                 //holds the encoded string
            int checksum = 0;                   //holds total unicode value of string
            int i = 0;                          //counter for while loop
            int decVal;                         //hold the dec val of the char

            Console.Write("What is your message?  ");
            input = Console.ReadLine();

            int inputLength = input.Length;     //gets length of string

            input = input.ToUpper();            //converts to upper case

            while (i < inputLength)
            {
                decVal = input[i];                  //convets from char value in input string into decimal because decVal is integer
                checksum += decVal;                 //adds to total of checksum
                message += (decVal - 64) + "-";     //appends to end of message string with code values of A=1, B=2, etc... buy subtracting from ASCII value
                i++;
            }
         
            Console.WriteLine("Your encoded message is " + message);
            Console.WriteLine("Your checksum is " + checksum);


        }
    }
}
