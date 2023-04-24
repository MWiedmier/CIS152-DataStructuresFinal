using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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