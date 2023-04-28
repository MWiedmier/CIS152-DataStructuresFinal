using System.Collections.Generic;

/***************************************************************
* Name        : DaysOfWeek
* Author      : Mandy Wiedmier
* Created      : 03/22/2023
***************************************************************/

namespace CIS152DataStructuresFinalWiedmier
{
    public class DaysOfWeek
    {
        /**************************************************************
        * Variables
        ***************************************************************/
        //Max Values for Lists
        public const int WEEK_MAX = 70;
        public const int DAY_MAX = 10;
        //List Setup
        private List<Node> mondayReservations;
        private List<Node> tuesdayReservations;
        private List<Node> wednesdayReservations;
        private List<Node> thursdayReservations;
        private List<Node> fridayReservations;
        private List<Node> saturdayReservations;
        private List<Node> sundayReservations;
        private List<Node> allReservations;

        /**************************************************************
        * Constructors
        ***************************************************************/
        /**************************************************************
        * Name: DaysOfWeek
        * Description: Default no-arg constructor. Sets all the Lists.
        * Input parameters: none
        ***************************************************************/
        public DaysOfWeek()
        {
            mondayReservations = new List<Node>();
            tuesdayReservations = new List<Node>();
            wednesdayReservations = new List<Node>();
            thursdayReservations = new List<Node>();
            fridayReservations = new List<Node>();
            saturdayReservations = new List<Node>();
            sundayReservations = new List<Node>();
            allReservations = new List<Node>();
        }

        /**************************************************************
        * Methods
        ***************************************************************/
        /**************************************************************
        * Name: insert
        * Description: Inserts a node to a list based on the day of the week
        * Input: Node reservation
        * Output: 
        ***************************************************************/
        public void insert(Node reservation)
        {
            //Add to specific day lists and All list
            if(reservation.data.DayOfWeek.ToLower() == "monday")//Checks if day matches and if that list is full
            {
                if(mondayReservations.Count < DAY_MAX)
                {
                    mondayReservations.Add(reservation);
                    allReservations.Add(reservation);
                }
                else
                {
                    throw new ReservationFullException();
                }
            }
            else if (reservation.data.DayOfWeek.ToLower() == "tuesday")//Checks if day matches and if that list is full
            {
                if (mondayReservations.Count < DAY_MAX)
                {
                    tuesdayReservations.Add(reservation);
                    allReservations.Add(reservation);
                }
                else
                {
                    throw new ReservationFullException();
                }
            }
            else if (reservation.data.DayOfWeek.ToLower() == "wednesday")//Checks if day matches and if that list is full
            {
                if (mondayReservations.Count < DAY_MAX)
                {
                    wednesdayReservations.Add(reservation);
                    allReservations.Add(reservation);
                }
                else
                {
                    throw new ReservationFullException();
                }
            }
            else if (reservation.data.DayOfWeek.ToLower() == "thursday")//Checks if day matches and if that list is full
            {
                if (mondayReservations.Count < DAY_MAX)
                {
                    thursdayReservations.Add(reservation);
                    allReservations.Add(reservation);
                }
                else
                {
                    throw new ReservationFullException();
                }
            }
            else if (reservation.data.DayOfWeek.ToLower() == "friday")//Checks if day matches and if that list is full
            {
                if (mondayReservations.Count < DAY_MAX)
                {
                    fridayReservations.Add(reservation);
                    allReservations.Add(reservation);
                }
                else
                {
                    throw new ReservationFullException();
                }
            }
            else if (reservation.data.DayOfWeek.ToLower() == "saturday")//Checks if day matches and if that list is full
            {
                if (mondayReservations.Count < DAY_MAX)
                {
                    saturdayReservations.Add(reservation);
                    allReservations.Add(reservation);
                }
                else
                {
                    throw new ReservationFullException();
                }
            }
            else if (reservation.data.DayOfWeek.ToLower() == "sunday")//Checks if day matches and if that list is full
            {
                if (mondayReservations.Count < DAY_MAX)
                {
                    sundayReservations.Add(reservation);
                    allReservations.Add(reservation);
                }
                else
                {
                    throw new ReservationFullException();
                }
            }
            else
            {
                throw new InvalidDayException();
            }
        }

        /**************************************************************
        * Name: returnList
        * Description: Inserts a node to a list based on the day of the week
        * Input: string key
        * Output: List<Node> weekList
        ***************************************************************/
        public List<Node> returnList(string key)
        {
            List<Node> weekList = new List<Node>();
            if (key.ToLower() == "monday")
            {
                weekList = mondayReservations;
            }
            else if (key.ToLower() == "tuesday")
            {
                weekList = tuesdayReservations;
            }
            else if (key.ToLower() == "wednesday")
            {
                weekList = wednesdayReservations;
            }
            else if (key.ToLower() == "thursday")
            {
                weekList = thursdayReservations;
            }
            else if (key.ToLower() == "friday")
            {
                weekList = fridayReservations;
            }
            else if (key.ToLower() == "saturday")
            {
                weekList = saturdayReservations;
            }
            else if (key.ToLower() == "sunday")
            {
                weekList = sundayReservations;
            }
            else if (key.ToLower() == "all")
            {
                weekList = allReservations;
            }
            else
            {
                throw new InvalidDayException();
            }
            return weekList;
        }

        /**************************************************************
        * Name: listSearchValidation
        * Description: Checks if input is valid
        * Input: string listKey
        * Output: bool
        ***************************************************************/
        public bool listSearchValidation(string listKey)
        {
            if (listKey.ToLower() == "all" || listKey.ToLower() == "monday" || listKey.ToLower() == "tuesday" || listKey.ToLower() == "wednesday" || listKey.ToLower() == "thursday" || listKey.ToLower() == "friday" || listKey.ToLower() == "saturday" || listKey.ToLower() == "sunday")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /**************************************************************
        * Name: printList
        * Description: Creates a string based on the nodes of the list inserted
        * Input: List<Node> dataList
        * Output: string listString
        ***************************************************************/
        public string printList(List<Node> dataList)
        {
            string listString = "";
            foreach(Node data in dataList)
            {
                listString = listString + "Reservation Name: " + data.data.ReservationName + ", Reservation Day: " + data.data.DayOfWeek + ", Reservation Type: " + data.data.TypeOfReservation + ", Number of People: " + data.data.NumOfPeople + ", Phone Number: " + data.data.PhoneNumber + "\n";
            }
            return listString;
        }
    }
}
