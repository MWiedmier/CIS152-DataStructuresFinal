using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**************************************************************
* Name : Final Project- Reservation Tracking
* Author: Mandy Wiedmier
* Created : 04/24/2023
* Course: CIS 152 - Data Structure
* Version: 1.0
* OS: Windows 11
* IDE: Visual Studio 2019
* Copyright : This is my own original work 
* based onspecifications issued by our instructor
* Description : An app that helps view and input reservations using Priority Queues and Lists.
*            Input: Yes or No user input and Reservation input.
*            Ouput: Lists of reservations.
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or
* unmodified. I have not given other fellow student(s) access
* to my program.
***************************************************************/

namespace CIS152DataStructuresFinalWiedmier
{
    class Program
    {
        /**************************************************************
        * Name: inputValidation
        * Description: Determines if user input is valid
        * Input: string data
        * Output: bool
        ***************************************************************/
        public static bool inputValidation(string data)
        {
            bool isValid = false;
            if (data.ToLower() == "yes")
            {
                isValid = true;
            }
            else if (data.ToLower() == "no")
            {
                isValid = true;
            }
            else
            {
                isValid = false;
            }
            return isValid;
        }
        public static bool continueProgram (string data)
        {
            bool isValid = false;
            if (data.ToLower() == "yes")
            {
                isValid = true;
            }
            else if (data.ToLower() == "no")
            {
                isValid = false;
            }
            else
            {
                isValid = false;
            }
            return isValid;
        }

        /**************************************************************
        * Name: Main
        * Description: The main method of the program
        * Input: 
        * Output:
        ***************************************************************/
        static void Main(string[] args)
        {
            bool isValidViewOrInsert = false;
            bool isValidInsertData = false;
            bool isValidViewData = false;
            bool isValidInsertContinue = false;
            bool isValidViewContinue = false;
            bool isValidViewOrInsertContinue = false;
            bool continueProgram = true;
            bool insertMoreReservations = true;
            bool viewMoreReservations = true;

            string userInput = "";

            Console.WriteLine("Do you want to insert or view the reservations?");
            while (isValidViewOrInsert == false)//Determines validity of first question
            {
                Console.WriteLine("Please enter Yes or No");
                userInput = Console.ReadLine();
                isValidViewOrInsert = inputValidation(userInput);
            }
            if(userInput.ToLower() == "yes")//Branch where it goes to reservation input and list requests
            {
                while(continueProgram == true)
                {
                    isValidViewOrInsertContinue = false;
                    Console.WriteLine("Do you want to insert new reservations?");
                    while (isValidInsertData == false)//Determines validity of first question
                    {
                        Console.WriteLine("Please enter Yes or No");
                        userInput = Console.ReadLine();
                        isValidInsertData = inputValidation(userInput);
                    }
                    if (userInput == "yes")//Branch where you insert data
                    {
                        while (insertMoreReservations == true)//Set to true
                        {
                            isValidInsertContinue = false;
                            Console.WriteLine("Place where you insert reservations.");
                            // name
                            // type of reservation
                            // day of week
                            // number of people
                            // phone number
                            Console.WriteLine("Insert more reservations?");
                            while (isValidInsertContinue == false)//Determines validity of first question
                            {
                                Console.WriteLine("Please enter Yes or No");
                                userInput = Console.ReadLine();
                                isValidInsertContinue = inputValidation(userInput);
                            }
                            if (userInput == "no")
                            {
                                insertMoreReservations = false;
                            }
                        }
                    }
                    //Place where you view reservations
                    Console.WriteLine("Do you want to view a reservation list?");
                    while (isValidViewData == false)//Determines validity of first question
                    {
                        Console.WriteLine("Please enter Yes or No");
                        userInput = Console.ReadLine();
                        isValidViewData = inputValidation(userInput);
                    }
                    if (userInput == "yes")//Branch where you insert data
                    {
                        while (viewMoreReservations == true)//Set to true first
                        {
                            Console.WriteLine("Place where you view reservation lists.");
                            isValidViewContinue = false;
                            // if statements and validation of days
                            Console.WriteLine("View more reservations?");
                            while (isValidViewContinue == false)//Determines validity of first question
                            {
                                Console.WriteLine("Please enter Yes or No");
                                userInput = Console.ReadLine();
                                isValidViewContinue = inputValidation(userInput);
                            }
                            if (userInput == "no")
                            {
                                viewMoreReservations = false;
                            }
                        }
                    }
                    Console.WriteLine("Would you like to view or insert more reservations?");
                    while (isValidViewOrInsertContinue == false)//Determines validity of first question
                    {
                        Console.WriteLine("Please enter Yes or No");
                        userInput = Console.ReadLine();
                        isValidViewOrInsertContinue = inputValidation(userInput);
                    }
                    if (userInput == "no")
                    {
                        continueProgram = false;
                    }
                }
            }
            Console.WriteLine("Thank you for your input. Have a nice day.");
        }
    }
}
