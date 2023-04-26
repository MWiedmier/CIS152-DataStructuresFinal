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
                while (j >= 0 && model.priorityNumber(arrayToSort[j].data.TypeOfReservation) > key)
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