using System;
using System.Linq;
using CIS152DataStructuresFinalWiedmier;
using Xunit;

namespace CIS152DataStructuresFinalWiedmierUnitTests
{
    public class PriorityQueueUnitTests
    {
        [Fact]
        public void TestCreatequeue()
        {
            // ARRANGE
            PriorityQueue myQueue = new PriorityQueue();
            bool actual;
            // ACT
            actual = myQueue.isEmpty();
            // ASSERT
            Assert.True(actual);
        }

        [Fact]
        public void TestIsEmptyTrue()
        {
            // ARRANGE
            PriorityQueue myQueue = new PriorityQueue();
            bool actual;
            // ACT
            actual = myQueue.isEmpty();
            // ASSERT
            Assert.True(actual);
        }

        [Fact]
        public void TestIsEmptyFalse()
        {
            // ARRANGE
            PriorityQueue myQueue = new PriorityQueue();
            Reservation reservationOne = new Reservation("John Doe", "Party", "monday", 1, 1234567890);
            Node reservationOneData = myQueue.newNode(reservationOne);
            bool actual;
            // ACT
            myQueue.enqueue(reservationOneData);
            actual = myQueue.isEmpty();
            // ASSERT
            Assert.False(actual);
        }

        [Fact]
        public void TestEnqueue()
        {
            // ARRANGE
            PriorityQueue myQueue = new PriorityQueue();
            Reservation reservationOne = new Reservation("John Doe", "Party", "monday", 1, 1234567890);
            Reservation reservationTwo = new Reservation("Jane Doe", "Party", "monday", 1, 1234567890);
            Node reservationOneData = myQueue.newNode(reservationOne);
            Node reservationTwoData = myQueue.newNode(reservationOne);
            Node actual, expected;
            expected = reservationOneData;
            // ACT
            myQueue.enqueue(reservationOneData);
            myQueue.enqueue(reservationOneData, reservationTwoData);
            actual = myQueue.peek();
            // ASSERT
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestDequeue()
        {
            // ARRANGE
            PriorityQueue myQueue = new PriorityQueue();
            Reservation reservationOne = new Reservation("John Doe", "Party", "monday", 1, 1234567890);
            Node reservationOneData = myQueue.newNode(reservationOne);
            Node actual, expected;
            expected = reservationOneData;
            myQueue.enqueue(reservationOneData);
            // ACT
            actual = myQueue.dequeue();
            // ASSERT
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestSizeZero()
        {
            // ARRANGE
            PriorityQueue myQueue = new PriorityQueue();
            int actual, expected;
            expected = 0;
            // ACT
            actual = myQueue.size();
            // ASSERT
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestSizeNonZero()
        {
            // ARRANGE
            PriorityQueue myQueue = new PriorityQueue();
            Reservation reservationOne = new Reservation("John Doe", "Party", "monday", 1, 1234567890);
            Reservation reservationTwo = new Reservation("Jane Doe", "Party", "monday", 1, 1234567890);
            Node reservationOneData = myQueue.newNode(reservationOne);
            Node reservationTwoData = myQueue.newNode(reservationOne);
            int actual, expected;
            expected = 2;
            // ACT
            myQueue.enqueue(reservationOneData);
            myQueue.enqueue(reservationOneData, reservationTwoData);
            actual = myQueue.size();
            // ASSERT
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestDequeueEmptyQueue()
        {
            // ARRANGE
            PriorityQueue myQueue = new PriorityQueue();
            // ACT
            // ASSERT
            Assert.Throws<queueEmptyException>(() => myQueue.dequeue());
        }

        [Fact]
        public void TestPeek()
        {
            // ARRANGE
            PriorityQueue myQueue = new PriorityQueue();
            Reservation reservationOne = new Reservation("John Doe", "Party", "monday", 1, 1234567890);
            Node reservationOneData = myQueue.newNode(reservationOne);
            Node actual, expected;
            expected = reservationOneData;
            // ACT
            myQueue.enqueue(reservationOneData);
            actual = myQueue.peek();
            // ASSERT
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestPeekEmptyQueue()
        {
            // ARRANGE
            PriorityQueue myQueue = new PriorityQueue();
            // ACT
            // ASSERT
            Assert.Throws<queueEmptyException>(() => myQueue.peek());
        }

        [Fact]
        public void TestPrintQueueEmptyQueue()
        {
            // ARRANGE
            PriorityQueue myQueue = new PriorityQueue();
            // ACT
            // ASSERT
            Assert.Throws<queueEmptyException>(() => myQueue.printQueue());
        }

        [Fact]
        public void TestPrintQueue()
        {
            // ARRANGE
            PriorityQueue myQueue = new PriorityQueue();
            Reservation reservationOne = new Reservation("John Doe", "Party", "monday", 1, 1234567890);
            Reservation reservationTwo = new Reservation("Jane Doe", "Vip", "monday", 1, 1234567890);
            Node reservationOneData = myQueue.newNode(reservationOne);
            Node reservationTwoData = myQueue.newNode(reservationTwo);
            String actual, expected;
            expected = "Reservation Name: Jane Doe, Reservation Day monday, Reservation Type Vip\nReservation Name: John Doe, Reservation Day monday, Reservation Type Party\n";
            // ACT
            myQueue.enqueue(reservationOneData);
            myQueue.enqueue(reservationOneData, reservationTwoData);
            actual = myQueue.printQueue();
            // ASSERT
            Assert.Equal(expected, actual);
        }
    }
}
