/***************************************************************
* Name        : DecisionValidation
* Author      : Mandy Wiedmier
* Created      : 04/27/2023
***************************************************************/

namespace CIS152DataStructuresFinalWiedmier
{
    public class DecisionValidation
    {
        /**************************************************************
        * Constructors
        ***************************************************************/
        /**************************************************************
        * Name: DecisionValidation
        * Description: Default no-arg constructor.
        * Input parameters: none
        ***************************************************************/
        public DecisionValidation(){}

        /**************************************************************
        * Name: inputValidation
        * Description: Determines if user input is valid
        * Input: string data
        * Output: bool
        ***************************************************************/
        public bool inputValidation(string data)
        {
            bool isValid = false;
            if (data.ToLower() == "yes")
            {
                isValid = true;
            }
            else if (data.ToLower() == "no")
            {
                isValid = true;
            }
            else
            {
                isValid = false;
            }
            return isValid;
        }
    }
}
