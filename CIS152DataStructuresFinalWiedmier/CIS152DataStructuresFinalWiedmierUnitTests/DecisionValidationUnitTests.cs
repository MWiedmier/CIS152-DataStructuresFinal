using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CIS152DataStructuresFinalWiedmier;
using Xunit;

/***************************************************************
* Name        : Priority Queue
* Author      : Mandy Wiedmier
* Created     : 02/22/2023
* Edited      : 03/22/2023
***************************************************************/

namespace CIS152DataStructuresFinalWiedmierUnitTests
{
    public class DecisionValidationUnitTests
    {
        [Fact]
        public void ValidInputValidation()
        {
 
            // ARRANGE
            DecisionValidation decision = new DecisionValidation();
            string validSearch = "Yes";
            bool actual;
            // ACT
            actual = decision.inputValidation(validSearch);
            // ASSERT
            Assert.True(actual);
        }

        [Fact]
        public void InvalidInputValidation()
        {
            // ARRANGE
            DecisionValidation decision = new DecisionValidation();
            string invalidSearch = "Invalid";
            bool actual;
            // ACT
            actual = decision.inputValidation(invalidSearch);
            // ASSERT
            Assert.False(actual);
        }
    }
}
