using CIS152DataStructuresFinalWiedmier;
using Xunit;

/***************************************************************
* Name        : ReservationsUnitTests
* Author      : Mandy Wiedmier
* Created      : 04/24/2023
***************************************************************/

namespace CIS152DataStructuresFinalWiedmierUnitTests
{
    public class ReservationsUnitTests
    {
        [Fact]
        public void ValidTypeTest()
        {
            // ARRANGE
            Reservation myReservation = new Reservation();
            string validString = "VIP";
            bool actual;
            // ACT
            actual = myReservation.typeValidation(validString);
            // ASSERT
            Assert.True(actual);
        }

        [Fact]
        public void InvalidTypeTest()
        {
            // ARRANGE
            Reservation myReservation = new Reservation();
            string invalidString = "notAType";
            bool actual;
            // ACT
            actual = myReservation.typeValidation(invalidString);
            // ASSERT
            Assert.False(actual);
        }

        [Fact]
        public void ValidDayTest()
        {
            // ARRANGE
            Reservation myReservation = new Reservation();
            string validString = "Monday";
            bool actual;
            // ACT
            actual = myReservation.dayValidation(validString);
            // ASSERT
            Assert.True(actual);
        }

        [Fact]
        public void InvalidDayTest()
        {
            // ARRANGE
            Reservation myReservation = new Reservation();
            string invalidString = "notADay";
            bool actual;
            // ACT
            actual = myReservation.dayValidation(invalidString);
            // ASSERT
            Assert.False(actual);
        }

        [Fact]
        public void ValidNumberOfPeopleTest()
        {
            // ARRANGE
            Reservation myReservation = new Reservation();
            int validInt = 4;
            bool actual;
            // ACT
            actual = myReservation.numberPeopleValidation(validInt);
            // ASSERT
            Assert.True(actual);
        }

        [Fact]
        public void InvalidNumberOfPeopleTest()
        {
            // ARRANGE
            Reservation myReservation = new Reservation();
            int invalidInt = 0;
            bool actual;
            // ACT
            actual = myReservation.numberPeopleValidation(invalidInt);
            // ASSERT
            Assert.False(actual);
        }

        [Fact]
        public void ValidPhoneNumberTest()
        {
            // ARRANGE
            Reservation myReservation = new Reservation();
            long validInt = 1234567890;
            bool actual;
            // ACT
            actual = myReservation.phoneNumberValidation(validInt);
            // ASSERT
            Assert.True(actual);
        }

        [Fact]
        public void InvalidPhoneNumberLowTest()
        {
            // ARRANGE
            Reservation myReservation = new Reservation();
            long invalidNumber = 123;
            bool actual;
            // ACT
            actual = myReservation.phoneNumberValidation(invalidNumber);
            // ASSERT
            Assert.False(actual);
        }

        [Fact]
        public void InvalidPhoneNumberHighTest()
        {
            // ARRANGE
            Reservation myReservation = new Reservation();
            long invalidNumber = 10000000000;
            bool actual;
            // ACT
            actual = myReservation.phoneNumberValidation(invalidNumber);
            // ASSERT
            Assert.False(actual);
        }
    }
}
