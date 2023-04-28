using System;

/***************************************************************
* Name        : InvalidDayException
* Author      : Mandy Wiedmier
* Created      : 03/22/2023
***************************************************************/

namespace CIS152DataStructuresFinalWiedmier
{
    public class InvalidDayException : Exception
    {
        public override string Message
        {
            get
            {
                return "Invalid Day";
            }
        }
    }
}