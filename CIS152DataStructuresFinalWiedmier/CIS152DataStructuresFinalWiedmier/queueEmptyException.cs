using System;

/***************************************************************
* Name        : QueueEmptyException
* Author      : Mandy Wiedmier
* Created      : 03/22/2023
***************************************************************/

namespace CIS152DataStructuresFinalWiedmier
{
    public class QueueEmptyException : Exception
    {
        public override string Message
        {
            get
            {
                return "Queue is Empty";
            }
        }
    }
}
