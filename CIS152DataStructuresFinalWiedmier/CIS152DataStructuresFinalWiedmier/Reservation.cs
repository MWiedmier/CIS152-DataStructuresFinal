using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/***************************************************************
* Name        : Reservation
* Author      : Mandy Wiedmier
* Created      : 03/22/2023
***************************************************************/

namespace CIS152DataStructuresFinalWiedmier
{
    public class Reservation
    {
        /**************************************************************
        * Variables
        ***************************************************************/
        private string _reservationName;
        private string _typeOfReservation;
        private string _dayOfTheWeek;
        private int _numOfPeople;
        private long _phoneNumber;

        /**************************************************************
        * Getters and Setters
        ***************************************************************/
        public string ReservationName { get => _reservationName; set => _reservationName = value; }
        public string TypeOfReservation { get => _typeOfReservation; set => _typeOfReservation = value; }
        public string DayOfWeek { get => _dayOfTheWeek; set => _dayOfTheWeek = value; }
        public int NumOfPeople { get => _numOfPeople; set => _numOfPeople = value; }
        public long PhoneNumber { get => _phoneNumber; set => _phoneNumber = value; }

        /**************************************************************
        * Constructors
        ***************************************************************/
        /**************************************************************
        * Name: Reservation
        * Description: Default no-arg constructor
        * Input parameters: none
        ***************************************************************/
        public Reservation() { }

        /**************************************************************
        * Name: Reservation
        * Description: Constructoir that accepts 5 fields
        * Input parameters: string name, string rType, string wDay, int nPeople, long phoneNumber
        ***************************************************************/
        public Reservation(string name, string rType, string wDay, int nPeople, long phoneNumber)
        {
            ReservationName = name;
            TypeOfReservation = rType;
            DayOfWeek = wDay;
            NumOfPeople = nPeople;
            PhoneNumber = phoneNumber;
        }

        /**************************************************************
        * Methods
        ***************************************************************/
        /**************************************************************
        * Name: typeValidation
        * Description: Checks if reservation type is valid
        * Input: string reservationType
        * Output: bool
        ***************************************************************/
        public bool typeValidation(string reservationType)
        {
            if(reservationType.ToLower() == "vip"|| reservationType.ToLower() == "party"|| reservationType.ToLower() == "regular")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /**************************************************************
        * Name: dayValidation
        * Description: Checks if day is valid
        * Input: string reservationDay
        * Output: bool
        ***************************************************************/
        public bool dayValidation(string reservationDay)
        {
            if (reservationDay.ToLower() == "monday" || reservationDay.ToLower() == "tuesday" || reservationDay.ToLower() == "wednesday"|| reservationDay.ToLower() == "thursday"|| reservationDay.ToLower() == "friday"|| reservationDay.ToLower() == "saturday"|| reservationDay.ToLower() == "sunday")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /**************************************************************
        * Name: numberPeopleValidation
        * Description: Checks if number of people is valid and above 0
        * Input: string nPeople
        * Output: bool
        ***************************************************************/
        public bool numberPeopleValidation(int nPeople)
        {
            if(nPeople > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /**************************************************************
        * Name: phoneNumberValidation
        * Description: Checks if a phone number is valid and above between 1000000000 and 9999999999
        * Input: long pNumber
        * Output: bool
        ***************************************************************/
        public bool phoneNumberValidation(long pNumber)
        {
            int smallestPhoneNumber = 1000000000;
            long largestPhoneNumber = 9999999999;
            if (pNumber >= smallestPhoneNumber)
            {
                if (pNumber <= largestPhoneNumber)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
