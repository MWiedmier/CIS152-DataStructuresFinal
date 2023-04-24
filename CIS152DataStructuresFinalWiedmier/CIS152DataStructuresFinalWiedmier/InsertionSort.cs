using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CIS152DataStructuresFinalWiedmier
{
    public class InsertionSort
    {
        public InsertionSort()
        {

        }
        public InsertionSort(List<Node> incomingArray)
        {
            PriorityQueue model = new PriorityQueue();
            Node[] arrayToSort = incomingArray.ToArray();
            int length = arrayToSort.Length;

            for (int i = 1; i < length; ++i)
            {
                
                
                int key = model.priorityNumber(arrayToSort[i].data.TypeOfReservation);
                Node currentNode = arrayToSort[i];
                int j = i - 1;

                // Move elements of arr[0..i-1],
                // that are greater than key,
                // to one position ahead of
                // their current position
                while (j >= 0 && model.priorityNumber(arrayToSort[j].data.TypeOfReservation) > key)
                {
                    arrayToSort[j + 1] = arrayToSort[j];
                    j = j - 1;
                }
                arrayToSort[j + 1] = currentNode;
            }
        }
    }
}