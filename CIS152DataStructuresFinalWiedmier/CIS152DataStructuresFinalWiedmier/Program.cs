using System;
using System.Collections.Generic;

/**************************************************************
* Name : Final Project- Reservation Tracking
* Author: Mandy Wiedmier
* Created : 03/22/2023
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
        static void Main(string[] args)
        {
            /**************************************************************
            * Variables
            ***************************************************************/
            //Main Path User Input Validation
            bool isValidViewOrInsert = false; //Insert or view reservations?
            bool isValidInsertData = false; //Insert reservation?
            bool isValidViewData = false; //View Reservations?
            //Continue User Main Path Input Validation
            bool isValidInsertContinue = false; //Continue Inserting More Reservations?
            bool isValidViewContinue = false; //Continue Viewing more reservations?
            bool isValidViewOrInsertContinue = false; //Continue Insering or Viewing more reservations?
            //Program Continuation Flags
            bool continueProgram = true; //Flag to continue Loop
            bool insertMoreReservations = true; //Flag to Continue Loop
            bool viewMoreReservations = true; //Flag to Continue Loop
            //User Input Checks
            bool isNameValid = false; //Name Validation Check
            bool isRTypeValid = false;//Type Validation Check
            bool isDayValid = false;//Day Validation Check
            bool isNumberPeopleValid = false;//Number Validation Check
            bool isPhoneNumberValid = false;//Phone Number Check
            bool isValidWeekday = false;//List Search Check
            //User Input
            string userInput = "";//Main Decision Path Input
            string reservationNameInput = "";
            string reservationTypeInput = "";
            string reservationDayInput = "";
            int reservationNumberOfPeopleInput = 0;
            long reservationPhoneNumberInput = 0;
            //Base Class Calls
            PriorityQueue reservationQueue = new PriorityQueue();
            List<Node> reservationList = new List<Node>();
            InsertionSort sortList = new InsertionSort();
            DecisionValidation decision = new DecisionValidation();
            Reservation reservationInputValidation = new Reservation();
            DaysOfWeek daysOfWeekInputValidation = new DaysOfWeek();
            Node head = new Node();

            //Premade Reservations
            //Reservation reservationOne = new Reservation("Cole", "Party", "monday", 4, 1234567890);
            //Reservation reservationTwo = new Reservation("Olivia", "vip", "monday", 4, 1234567890);
            //Reservation reservationThree = new Reservation("DJ", "Regular", "monday", 4, 1234567890);
            //Reservation reservationFour = new Reservation("Isaac", "Party", "monday", 4, 1234567890);
            //Reservation reservationFive = new Reservation("Nathan", "Party", "monday", 4, 1234567890);
            //Reservation reservationSix = new Reservation("Grace", "vip", "monday", 4, 1234567890);
            //Reservation reservationSeven = new Reservation("Felix", "Regular", "Tuesday", 4, 1234567890);
            //Reservation reservationEight = new Reservation("Umar", "Party", "Tuesday", 4, 1234567890);
            //Reservation reservationNine = new Reservation("Nick", "Party", "Tuesday", 4, 1234567890);
            //head = reservationQueue.newNode(reservationOne);
            //Data to Nodes
            //Node reservationTwoData = reservationQueue.newNode(reservationTwo);
            //Node reservationThreeData = reservationQueue.newNode(reservationThree);
            //Node reservationFourData = reservationQueue.newNode(reservationFour);
            //Node reservationFiveData = reservationQueue.newNode(reservationFive);
            //Node reservationSixData = reservationQueue.newNode(reservationSix);
            //Node reservationSevenData = reservationQueue.newNode(reservationSeven);
            //Node reservationEightData = reservationQueue.newNode(reservationEight);
            //Node reservationNineData = reservationQueue.newNode(reservationNine);
            //Reservations to Queue
            //reservationQueue.enqueue(head);
            //reservationQueue.enqueue(head, reservationTwoData);
            //reservationQueue.enqueue(head, reservationThreeData);
            //reservationQueue.enqueue(head, reservationFourData);
            //reservationQueue.enqueue(head, reservationFiveData);
            //reservationQueue.enqueue(head, reservationSixData);
            //reservationQueue.enqueue(head, reservationSevenData);
            //reservationQueue.enqueue(head, reservationEightData);
            //reservationQueue.enqueue(head, reservationNineData);

            /**************************************************************
            * Program Start
            ***************************************************************/
            Console.WriteLine("Do you want to insert or view the reservations?");
            while (isValidViewOrInsert == false)//Determines validity of first question
            {
                Console.WriteLine("Please enter Yes or No");
                userInput = Console.ReadLine();
                if (!string.IsNullOrEmpty(userInput))//Null Check
                {
                    isValidViewOrInsert = decision.inputValidation(userInput);
                }
                else
                {
                    Console.WriteLine("Input must not be blank.");
                }                
            }
            if(userInput.ToLower() == "yes")//Branch where it goes to reservation input and list requests
            {
                while(continueProgram == true)//Marked true on first run
                {
                    isValidViewOrInsertContinue = false;
                    Console.WriteLine("Do you want to insert new reservations?");
                    while (isValidInsertData == false)//Determines validity of new reservation question
                    {
                        Console.WriteLine("Please enter Yes or No");
                        userInput = Console.ReadLine();
                        if (!string.IsNullOrEmpty(userInput))//Null Check
                        {
                            isValidInsertData = decision.inputValidation(userInput);
                        }
                        else
                        {
                            Console.WriteLine("Input must not be blank.");
                        }
                    }
                    if (userInput == "yes")//Branch where you insert data
                    {
                        while (insertMoreReservations == true)//Set to true on first run
                        {
                            //All of these flags set to false to ensure data can be inserted in multiple loops
                            isValidInsertContinue = false;
                            isNameValid = false;
                            isRTypeValid = false;
                            isDayValid = false;
                            isNumberPeopleValid = false;
                            isPhoneNumberValid = false;

                            Console.WriteLine("Please enter a name for the reservation.");
                            while (isNameValid == false)//Name Validation
                            {
                                reservationNameInput = Console.ReadLine();
                                if (!string.IsNullOrEmpty(reservationNameInput))//Empty Value Check
                                {
                                    isNameValid = true;
                                }
                                else
                                {
                                    Console.WriteLine("Name must not be blank.");
                                }
                            }
                            Console.WriteLine("Please enter a type of reservation.");
                            while (isRTypeValid == false)//Type Validation
                            {
                                Console.WriteLine("(VIP, Party, or Regular)");
                                reservationTypeInput = Console.ReadLine();
                                if (!string.IsNullOrEmpty(reservationTypeInput))//Empty Value Check
                                {
                                    isRTypeValid = reservationInputValidation.typeValidation(reservationTypeInput);
                                }
                                else
                                {
                                    Console.WriteLine("Reservation type must not be blank.");
                                }
                            }
                            Console.WriteLine("Please enter the day preferred.");
                            while (isDayValid == false)//Day Validation
                            {
                                Console.WriteLine("(Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, or Sunday)");
                                reservationDayInput = Console.ReadLine();
                                if (!string.IsNullOrEmpty(reservationDayInput))//Empty Value Check
                                {
                                    isDayValid = reservationInputValidation.dayValidation(reservationDayInput);
                                }
                                else
                                {
                                    Console.WriteLine("Preferred day must not be blank.");
                                }
                            }
                            Console.WriteLine("Please enter the number of people attending (must be greater than 0).");
                            while (isNumberPeopleValid == false)//Number of people
                            {
                                Console.WriteLine("(must be greater than 0)");
                                try//Value Must be an Interger check and not null
                                {
                                    reservationNumberOfPeopleInput = Convert.ToInt32(Console.ReadLine());
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine(e.Message + " Input must be a number.");
                                }
                                isNumberPeopleValid = reservationInputValidation.numberPeopleValidation(reservationNumberOfPeopleInput);
                            }
                            Console.WriteLine("Please enter a phone number (digits only between 1000000000 and 9999999999).");
                            while (isPhoneNumberValid == false)//Phone Number
                            {
                                Console.WriteLine("(digits only between 1000000000 and 9999999999)");
                                try//Value must be a long and not null check
                                {                                 
                                    reservationPhoneNumberInput = Convert.ToInt64(Console.ReadLine());
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine(e.Message + " Input must be a number.");
                                }
                                isPhoneNumberValid = reservationInputValidation.phoneNumberValidation(reservationPhoneNumberInput);
                            }
                            //Inserting Data into the Priority Queue
                            if (reservationQueue.size() == 0 && isNameValid == true && isRTypeValid == true && isDayValid == true && isNumberPeopleValid == true && isPhoneNumberValid == true)
                            {
                                Reservation inputReservationData = new Reservation(reservationNameInput, reservationTypeInput, reservationDayInput, reservationNumberOfPeopleInput, reservationPhoneNumberInput);
                                head = reservationQueue.newNode(inputReservationData);
                                reservationQueue.enqueue(head);
                            }
                            else
                            {
                                Reservation inputReservationData = new Reservation(reservationNameInput, reservationTypeInput, reservationDayInput, reservationNumberOfPeopleInput, reservationPhoneNumberInput);
                                Node incomingNode = reservationQueue.newNode(inputReservationData);
                                reservationQueue.enqueue(head, incomingNode);
                            }
                            //Continue Inserting Values Question
                            Console.WriteLine("Insert more reservations?");
                            while (isValidInsertContinue == false)//Determines validity of first question
                            {
                                Console.WriteLine("Please enter Yes or No");
                                userInput = Console.ReadLine();
                                if (!string.IsNullOrEmpty(userInput))//Null Check
                                {
                                    isValidInsertContinue = decision.inputValidation(userInput);
                                }
                                else
                                {
                                    Console.WriteLine("Input must not be blank.");
                                }
                            }
                            if (userInput == "no")
                            {
                                insertMoreReservations = false;
                            }
                        }
                    }
                    //Place where you view reservations
                    Console.WriteLine("Do you want to view a reservation list?");
                    while (isValidViewData == false)//Determines validity of viewing a reservation question
                    {
                        Console.WriteLine("Please enter Yes or No");
                        userInput = Console.ReadLine();
                        if (!string.IsNullOrEmpty(userInput))//Null Check
                        {
                            isValidViewData = decision.inputValidation(userInput);
                        }
                        else
                        {
                            Console.WriteLine("Input must not be blank.");
                        }
                    }
                    if (userInput == "yes")//Branch where you view data
                    {
                        reservationQueue.weekdayListInsert(reservationQueue.PQueue);

                        while (viewMoreReservations == true)//Set to true first
                        {
                            //All of these flags set to false to ensure data can be inserted in multiple loops
                            isValidViewContinue = false;
                            isValidWeekday = false;

                            while(isValidWeekday == false)//Check for valid search key
                            {
                                Console.WriteLine("(All, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, or Sunday)");
                                reservationDayInput = Console.ReadLine();
                                if (!string.IsNullOrEmpty(reservationDayInput))//Null Check
                                {
                                    isValidWeekday = daysOfWeekInputValidation.listSearchValidation(reservationDayInput);
                                }
                                else
                                {
                                    Console.WriteLine("Input must not be blank.");
                                }
                            }
                            //List Calls
                            reservationList = reservationQueue.getReservationList(reservationDayInput);
                            reservationList = sortList.sort(reservationList);
                            Console.WriteLine(reservationDayInput + " reservations: " + "\n" + daysOfWeekInputValidation.printList(reservationList));

                            Console.WriteLine("View more reservations?");
                            while (isValidViewContinue == false)//Determines validity of viewling more reservation question
                            {
                                Console.WriteLine("Please enter Yes or No");
                                userInput = Console.ReadLine();
                                if (!string.IsNullOrEmpty(userInput))//Null Check
                                {
                                    isValidViewContinue = decision.inputValidation(userInput);
                                }
                                else
                                {
                                    Console.WriteLine("Input must not be blank.");
                                }
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
                        if (!string.IsNullOrEmpty(userInput))//Null Check
                        {
                            isValidViewOrInsertContinue = decision.inputValidation(userInput);
                        }
                        else
                        {
                            Console.WriteLine("Input must not be blank.");
                        }                        
                    }
                    if (userInput == "no")
                    {
                        continueProgram = false;
                    }
                }
            }
            Console.WriteLine("Thank you for your input. Have a nice day.");
            /**************************************************************
            * Program End
            ***************************************************************/
        }
    }
}
