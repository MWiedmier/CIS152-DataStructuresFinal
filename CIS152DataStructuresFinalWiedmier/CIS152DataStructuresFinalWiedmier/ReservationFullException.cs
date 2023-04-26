using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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