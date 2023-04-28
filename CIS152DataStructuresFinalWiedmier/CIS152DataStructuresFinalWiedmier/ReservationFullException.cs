using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/***************************************************************
* Name        : ReservationFullException
* Author      : Mandy Wiedmier
* Created      : 03/22/2023
***************************************************************/

namespace CIS152DataStructuresFinalWiedmier
{
    public class ReservationFullException : Exception
    {
        public override string Message
        {
            get
            {
                return "reservations are full.";
            }
        }
    }
}