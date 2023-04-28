using System;
using CIS152DataStructuresFinalWiedmier;
using Xunit;

/***************************************************************
* Name        : DayOfWeekUnitTests
* Author      : Mandy Wiedmier
* Created      : 04/24/2023
***************************************************************/

namespace CIS152DataStructuresFinalWiedmierUnitTests
{
    public class DayOfWeekUnitTests
    {
        [Fact]
        public void ValidInsertAndPrintListTest()
        {
            // ARRANGE
            DaysOfWeek dow = new DaysOfWeek();
            PriorityQueue myQueue = new PriorityQueue();
            Reservation reservationOne = new Reservation("John Doe", "Party", "monday", 1, 1234567890);
            Node reservationOneData = myQueue.newNode(reservationOne);
            String actual, expected;
            expected = "Reservation Name: John Doe, Reservation Day: monday, Reservation Type: Party, Number of People: 1, Phone Number: 1234567890\n";
            // ACT
            dow.insert(reservationOneData);
            actual = dow.printList(dow.returnList(reservationOneData.data.DayOfWeek));
            // ASSERT
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void InsertReservationFullTest()
        {
            // ARRANGE
            DaysOfWeek dow = new DaysOfWeek();
            PriorityQueue myQueue = new PriorityQueue();
            Reservation reservationOne = new Reservation("John Doe", "Party", "monday", 1, 1234567890);
            Node reservationOneData = myQueue.newNode(reservationOne);
            // ACT
            dow.insert(reservationOneData);
            dow.insert(reservationOneData);
            dow.insert(reservationOneData);
            dow.insert(reservationOneData);
            dow.insert(reservationOneData);
            dow.insert(reservationOneData);
            dow.insert(reservationOneData);
            dow.insert(reservationOneData);
            dow.insert(reservationOneData);
            dow.insert(reservationOneData);
            // ASSERT
            Assert.Throws<ReservationFullException>(() => dow.insert(reservationOneData));
        }

        [Fact]
        public void InvalidInsertDayTest()
        {
            // ARRANGE
            DaysOfWeek dow = new DaysOfWeek();
            PriorityQueue myQueue = new PriorityQueue();
            Reservation reservationOne = new Reservation("John Doe", "Party", "notADay", 1, 1234567890);
            Node reservationOneData = myQueue.newNode(reservationOne);
            // ACT
            // ASSERT
            Assert.Throws<InvalidDayException>(() => dow.insert(reservationOneData));
        }

        [Fact]
        public void ValidReturnListTest()
        {
            // ARRANGE
            DaysOfWeek dow = new DaysOfWeek();
            PriorityQueue myQueue = new PriorityQueue();
            Reservation reservationOne = new Reservation("Jane Doe", "VIP", "Tuesday", 1, 1234567890);
            Node reservationOneData = myQueue.newNode(reservationOne);
            String actual, expected;
            expected = "Reservation Name: Jane Doe, Reservation Day: Tuesday, Reservation Type: VIP, Number of People: 1, Phone Number: 1234567890\n";
            // ACT
            dow.insert(reservationOneData);
            actual = dow.printList(dow.returnList(reservationOneData.data.DayOfWeek));
            // ASSERT
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void InalidReturnListTest()
        {
            // ARRANGE
            DaysOfWeek dow = new DaysOfWeek();
            string invalidDay = "Not A Day";   
            // ACT
            // ASSERT
            Assert.Throws<InvalidDayException>(() => dow.returnList(invalidDay));
        }

        [Fact]
        public void ValidListSearchTest()
        {
            // ARRANGE
            DaysOfWeek dow = new DaysOfWeek();
            string validSearch = "Monday";
            bool actual;
            // ACT
            actual = dow.listSearchValidation(validSearch);
            // ASSERT
            Assert.True(actual);
        }

        [Fact]
        public void InvalidListSearchTest()
        {
            // ARRANGE
            DaysOfWeek dow = new DaysOfWeek();
            string invalidSearch = "Invalid";
            bool actual;
            // ACT
            actual = dow.listSearchValidation(invalidSearch);
            // ASSERT
            Assert.False(actual);
        }
    }
}
