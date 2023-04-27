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
            bool isValidViewOrInsert = false; //Insert or view reservations?
            bool isValidInsertData = false; //Insert reservation?
            bool isValidViewData = false; //View Reservations?

            bool isValidInsertContinue = false; //Continue Inserting More Reservations?
            bool isValidViewContinue = false; //Continue Viewing more reservations?
            bool isValidViewOrInsertContinue = false; //Continue Insering or Viewing more reservations?

            bool continueProgram = true; //Flag to continue Loop
            bool insertMoreReservations = true; //Flag to Continue Loop
            bool viewMoreReservations = true; //Flag to Continue Loop

            bool isNameValid = false;
            bool isRTypeValid = false;
            bool isDayValid = false;
            bool isNumberPeopleValid = false;
            bool isPhoneNumberValid = false;
            bool isValidWeekday = false;


            string userInput = "";
            string reservationNameInput = "";
            string reservationTypeInput = "";
            string reservationDayInput = "";
            int reservationNumberOfPeopleInput = 0;
            int reservationPhoneNumberInput = 0;

            PriorityQueue reservationQueue = new PriorityQueue();
            List<Node> reservationList = new List<Node>();
            InsertionSort sortList = new InsertionSort();
            Reservation reservationInputValidation = new Reservation();
            DaysOfWeek daysOfWeekInputValidation = new DaysOfWeek();
            Node head = new Node();



            Reservation reservationOne = new Reservation("Lian", "Party", "monday", 4, 1234567890);
            Reservation reservationTwo = new Reservation("Peony", "vip", "monday", 4, 1234567890);
            Reservation reservationThree = new Reservation("Jade", "Regular", "monday", 4, 1234567890);
            Reservation reservationFour = new Reservation("Guy", "Party", "monday", 4, 1234567890);
            head = reservationQueue.newNode(reservationOne);
            Node reservationTwoData = reservationQueue.newNode(reservationTwo);
            Node reservationThreeData = reservationQueue.newNode(reservationThree);
            Node reservationFourData = reservationQueue.newNode(reservationFour);
            reservationQueue.enqueue(head);
            reservationQueue.enqueue(head, reservationTwoData);
            reservationQueue.enqueue(head, reservationThreeData);
            reservationQueue.enqueue(head, reservationFourData);



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
                    //Place where you insert data
                    if (userInput == "yes")//Branch where you insert data
                    {
                        while (insertMoreReservations == true)//Set to true
                        {
                            isValidInsertContinue = false;
                            isNameValid = false;
                            isRTypeValid = false;
                            isDayValid = false;
                            isNumberPeopleValid = false;
                            isPhoneNumberValid = false;
        
                            //Console.WriteLine("Please enter a name for the reservation.");
                            //while (isNameValid == false)//Name Validation
                            //{ 
                            //    reservationNameInput = Console.ReadLine();
                            //    if (!string.IsNullOrEmpty(reservationNameInput))
                            //    {
                            //        isNameValid = true;
                            //    }
                            //    else
                            //    {
                            //        Console.WriteLine("Name must not be blank.");
                            //    }
                                
                            //}
                            //Console.WriteLine("Please enter a type of reservation.");
                            //while (isRTypeValid == false)//Type Validation
                            //{
                            //    Console.WriteLine("(VIP, Party, or Regular)");
                            //    reservationTypeInput = Console.ReadLine();
                            //    if (!string.IsNullOrEmpty(reservationTypeInput))
                            //    {
                            //        isRTypeValid = reservationInputValidation.typeValidation(reservationTypeInput);
                            //    }
                            //    else
                            //    {
                            //        Console.WriteLine("Reservation type must not be blank.");
                            //    }
                            //}
                            //Console.WriteLine("Please enter the day preferred.");
                            //while (isDayValid == false)//Day Validation
                            //{
                            //    Console.WriteLine("(Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, or Sunday)");
                            //    reservationDayInput = Console.ReadLine();
                            //    if (!string.IsNullOrEmpty(reservationDayInput))
                            //    {
                            //        isDayValid = reservationInputValidation.dayValidation(reservationDayInput);
                            //    }
                            //    else
                            //    {
                            //        Console.WriteLine("Preferred day must not be blank.");
                            //    }
                            //}
                            //Console.WriteLine("Please enter the number of people attending (must be greater than 0).");
                            //while (isNumberPeopleValid == false)//Number of people
                            //{
                            //    Console.WriteLine("(must be greater than 0).");
                            //    try
                            //    {
                            //        reservationNumberOfPeopleInput = Convert.ToInt32(Console.ReadLine());
                            //    }
                            //    catch(Exception e)
                            //    {
                            //        Console.WriteLine(e.Message + " Input must be a number.");
                            //    }
                            //    isNumberPeopleValid = reservationInputValidation.numberPeopleValidation(reservationNumberOfPeopleInput);
                            //}
                            //while (isPhoneNumberValid == false)//Phone Number
                            //{
                            //    Console.WriteLine("Please enter a phone number (digits only between 1000000000 and 9999999999).");
                            //    try
                            //    {
                            //        reservationPhoneNumberInput = Convert.ToInt32(Console.ReadLine());
                            //    }
                            //    catch (Exception e)
                            //    {
                            //        Console.WriteLine(e.Message + " Input must be a number.");
                            //    }
                            //    isPhoneNumberValid = reservationInputValidation.phoneNumberValidation(reservationPhoneNumberInput);
                            //}
                            
                            //if (reservationQueue.size() == 0 && isNameValid == true && isRTypeValid == true && isDayValid == true && isNumberPeopleValid == true && isPhoneNumberValid == true)
                            //{                                
                            //    Reservation inputReservationData = new Reservation(reservationNameInput, reservationTypeInput, reservationDayInput, reservationNumberOfPeopleInput, reservationPhoneNumberInput);
                            //    head = reservationQueue.newNode(inputReservationData);
                            //    reservationQueue.enqueue(head);
                            //}
                            //else
                            //{ 
                            //    Reservation inputReservationData = new Reservation(reservationNameInput, reservationTypeInput, reservationDayInput, reservationNumberOfPeopleInput, reservationPhoneNumberInput);
                            //    Node incomingNode = reservationQueue.newNode(inputReservationData);
                            //    reservationQueue.enqueue(head, incomingNode);
                            //}

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
                    Console.WriteLine("Queue: " + reservationQueue.printQueue());
                    //Place where you view reservations
                    Console.WriteLine("Do you want to view a reservation list?");
                    while (isValidViewData == false)//Determines validity of viewing a reservation question
                    {
                        Console.WriteLine("Please enter Yes or No");
                        userInput = Console.ReadLine();
                        isValidViewData = inputValidation(userInput);
                    }
                    if (userInput == "yes")//Branch where you view data
                    {
                        reservationQueue.weekdayListInsert(reservationQueue.PQueue);

                        while (viewMoreReservations == true)//Set to true first
                        {
                            isValidViewContinue = false;
                            isValidWeekday = false;

                            while(isValidWeekday == false)
                            {
                                Console.WriteLine("(All, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, or Sunday)");
                                reservationDayInput = Console.ReadLine();
                                if (!string.IsNullOrEmpty(reservationDayInput))
                                {
                                    isValidWeekday = daysOfWeekInputValidation.listSearchValidation(reservationDayInput);
                                }
                                else
                                {
                                    Console.WriteLine("Input must not be blank.");
                                }
                            }
                            reservationList = reservationQueue.getReservationList(reservationDayInput);
                            reservationList = sortList.sort(reservationList);
                            Console.WriteLine(reservationDayInput + " reservations: " + "\n" + daysOfWeekInputValidation.printList(reservationList));

                            Console.WriteLine("View more reservations?");
                            while (isValidViewContinue == false)//Determines validity of viewling more reservation question
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
