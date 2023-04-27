using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CIS152DataStructuresFinalWiedmier;
using Xunit;

namespace CIS152DataStructuresFinalWiedmierUnitTests
{
    public class InsertionSortUnitTests
    { 
        [Fact]
        public void ValidInsertAndPrintListTest()
        {
            // ARRANGE
            InsertionSort sorted = new InsertionSort();
            DaysOfWeek dow = new DaysOfWeek();
            PriorityQueue myQueue = new PriorityQueue();
            Reservation reservationOne = new Reservation("John Doe", "Regular", "monday", 1, 1234567890);
            Reservation reservationTwo = new Reservation("Jane Doe", "Party", "monday", 1, 1234567890);
            Reservation reservationThree = new Reservation("Jimmy Doe", "Vip", "monday", 1, 1234567890);
            Node reservationOneData = myQueue.newNode(reservationOne);
            Node reservationTwoData = myQueue.newNode(reservationTwo);
            Node reservationThreeData = myQueue.newNode(reservationThree);
            String actual, expected;
            expected = "Reservation Name: Jimmy Doe, Reservation Day: monday, Reservation Type: Vip, Number of People: 1, Phone Number: 1234567890\nReservation Name: Jane Doe, Reservation Day: monday, Reservation Type: Party, Number of People: 1, Phone Number: 1234567890\nReservation Name: John Doe, Reservation Day: monday, Reservation Type: Regular, Number of People: 1, Phone Number: 1234567890\n";
            // ACT
            dow.insert(reservationOneData);
            dow.insert(reservationTwoData);
            dow.insert(reservationThreeData);

            actual = dow.printList(sorted.sort(dow.returnList(reservationOneData.data.DayOfWeek)));
            // ASSERT
            Assert.Equal(expected, actual);
        }


    }
}
