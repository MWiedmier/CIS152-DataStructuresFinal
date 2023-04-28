using System.Collections.Generic;
using System.Linq;

/***************************************************************
* Name        : InsertionSort
* Author      : Mandy Wiedmier
* Created      : 03/22/2023
***************************************************************/

namespace CIS152DataStructuresFinalWiedmier
{
    public class InsertionSort
    {
        /**************************************************************
        * Constructors
        ***************************************************************/
        /**************************************************************
        * Name: DecisionValidation
        * Description: Default no-arg constructor.
        * Input parameters: none
        ***************************************************************/
        public InsertionSort(){}

        /**************************************************************
        * Methods
        ***************************************************************/
        /**************************************************************
        * Name: sort
        * Description: Sorts the list using an insertion sort and returns the sorted list.
        * Input: List<Node> incomingList
        * Output: List<Node> sortedList
        ***************************************************************/
        public List<Node> sort(List<Node> incomingList)
        {
            List<Node> sortedList = incomingList;
            PriorityQueue model = new PriorityQueue();
            Node[] arrayToSort = incomingList.ToArray();
            int length = arrayToSort.Length;

            for (int i = 1; i < length; ++i)
            {
                int key = model.priorityNumber(arrayToSort[i].data.TypeOfReservation);
                Node currentNode = arrayToSort[i];
                int j = i - 1;
                while (j >= 0 && model.priorityNumber(arrayToSort[j].data.TypeOfReservation) < key)
                {
                    arrayToSort[j + 1] = arrayToSort[j];
                    j = j - 1;
                }
                arrayToSort[j + 1] = currentNode;
            }
            sortedList = arrayToSort.ToList();
            return sortedList;
        }
    }
}