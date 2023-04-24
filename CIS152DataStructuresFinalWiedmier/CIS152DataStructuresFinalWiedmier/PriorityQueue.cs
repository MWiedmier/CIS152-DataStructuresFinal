using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CIS152DataStructuresFinalWiedmier;


/***************************************************************
* Name        : Priority Queue
* Author      : Mandy Wiedmier
* Created     : 02/22/2023
* Edited      : 03/22/2023
***************************************************************/

namespace CIS152DataStructuresFinalWiedmier
{
    public class PriorityQueue
    {
        private int queueSize;
        private LinkedList<Node> pQueue;
        public const int MAX = 70;
        private Node Head;

        /**************************************************************
        * Constructors
        ***************************************************************/
        /**************************************************************
        * Name: queue
        * Description: Default no-arg constructor
        * Input parameters: none
        ***************************************************************/
        public PriorityQueue()
        {
            pQueue = new LinkedList<Node>();
        }

        /**************************************************************
        * Methods
        ***************************************************************/
        /**************************************************************
        * Name: newNode
        * Description: Makes a new node
        * Input: 
        * Output: node newData
        ***************************************************************/
        public Node newNode(string name, string reservationType, string day, int people, string phonenumber)
        {
            Node newData = new Node();
            newData.data.ReservationName = name;
            newData.data.TypeOfReservation = reservationType;
            newData.data.DayOfWeek = day;
            newData.data.NumOfPeople = people;
            newData.data.PhoneNumber = phonenumber;

            return newData;
        }

        /**************************************************************
        * Name: priorityNumber
        * Description: Compares the priority of queue items
        * Input: 
        * Output: bool
        ***************************************************************/
        public int priorityNumber(string priority)
        {
            int pNumber = 0;
            if(priority.ToLower() == "vip")
            {
                pNumber = 3;
            }
            else if(priority.ToLower() == "party")
            {
                pNumber = 2;
            }
            else if(priority.ToLower() == "regular")
            {
                pNumber = 1;
            }
            return pNumber;
        }


        /**************************************************************
        * Name: checkPriority
        * Description: Compares the priority of queue items
        * Input: 
        * Output: bool
        ***************************************************************/
        public bool checkPriority(string originalString, string incomingString)
        {
            string[] reservationType = { "VIP", "Party", "Regular" };

            int indexOriginal = 0;
            int indexIncoming = 0;
            int positionOriginal = 0;
            int positionIncoming = 0;

            foreach(string rType in reservationType)
            {
                if (originalString == reservationType[indexOriginal])
                {
                    positionOriginal = indexOriginal;
                    break;
                }
                else
                {
                    indexOriginal++;
                }
            }
            
            foreach(string rType in reservationType)
            {
                if (incomingString == reservationType[indexIncoming])
                {
                    positionIncoming = indexIncoming;
                    break;
                }
                else
                {
                    indexIncoming++;
                }
            }
            
            //Returns True if Incoming Node has a lesser priority
            return positionOriginal <= positionIncoming;
        }
        /**************************************************************
        * Name: isEmpty
        * Description: Checks to see if queue is empty
        * Input: 
        * Output: bool
        ***************************************************************/
        public bool isEmpty()
        {
            return queueSize == 0;
        }

        /**************************************************************
        * Name: size
        * Description: Checks how many elements are in the queue
        * Input: 
        * Output: int queueSize
        ***************************************************************/
        public int size()
        {
            queueSize = pQueue.Count;
            return queueSize;
        }

        /**************************************************************
		* Name: peek
		* Description: Checks what the first higest priority object is in the queue. If queue is empty it will throw an empty exception.
		* Input: 
		* Output: string item
		***************************************************************/
        public Node peek()
        {
            Node queueItem;
            if (!this.isEmpty())
            {
                queueItem = pQueue.First.Value;
                return queueItem;
            }
            else
            {
                throw new queueEmptyException();
            }
        }

        /**************************************************************
		* Name: dequeue
		* Description: This method removes the first highest priority object of the queue. If queue is empty it will throw an empty exception.
		* Input: 
		* Output: string item
		***************************************************************/
        public Node dequeue()
        {
            Node queueItem;
            if (!this.isEmpty())
            {
                queueItem = pQueue.First.Value;
                pQueue.RemoveFirst();
                return queueItem;
            }
            else
            {
                throw new queueEmptyException();
            }
        }

        /**************************************************************
		* Name: enqueue
		* Description: This method adds an object to an empty queue.
		* Input: Node head
		* Output: 
		***************************************************************/
        public void enqueue(Node head)
        {
            Node currentNode = head;

            if (pQueue.Count == 0) //If there are no elements in queue
            {
                pQueue.AddFirst(head);
                queueSize++;
            }
        }

        /**************************************************************
		* Name: enqueue
		* Description: This method adds an object to the back of the queue.
		* Input: Node head, int jobNum, char priority
		* Output: 
		***************************************************************/
        public void enqueue(Node head, Node incomingData)
        {
            Node currentNode = head;
            Node insertingData = incomingData;
            int index = 0;

            //Node pointingData = pQueue.First.Value;
            if (pQueue.Count == 0) //If there are no elements in queue
            {
                pQueue.AddFirst(head);
                queueSize++;
            }
            else
            {
                if (!checkPriority(currentNode.data.TypeOfReservation, insertingData.data.TypeOfReservation)) //If the inserted priority is greater than the starting node
                {
                    pQueue.AddBefore(pQueue.First, insertingData);
                    queueSize++;
                }
                else //If the inserted data has a lesser prioirity
                {
                    if (pQueue.First.Next == null)//If there is only one node in the list
                    {
                        pQueue.AddAfter(pQueue.First, insertingData);
                    }
                    else//If there are more elements in the queue
                    {
                        foreach (Node data in pQueue)
                        {
                            index++;
                            if (!checkPriority(data.data.TypeOfReservation, insertingData.data.TypeOfReservation))//If the inserted prioirity is GREATER than the current node
                            {
                                pQueue.AddBefore(pQueue.Find(data), insertingData);
                                break;
                            }
                        }
                        if (index == pQueue.Count)
                        {
                            pQueue.AddLast(insertingData);
                        }
                    }
                }
            }
        }

        //      /**************************************************************
        //* Name: printQueue
        //* Description: This method prints the elements of the queue. If queue is empty will throw an empty exception.
        //* Input: 
        //* Output: string queueString
        //***************************************************************/
        //      public string printQueue()
        //      {

        //          if (!this.isEmpty())
        //          {
        //              string queueString = "";

        //              foreach (Node str in pQueue)
        //              {
        //                  queueString = queueString + "Job Number " + str.jobNumber + ", Job Priority " + str.priority + "\n";
        //              }
        //              return queueString;
        //          }
        //          else
        //          {
        //              throw new queueEmptyException();
        //          }
        //      }

  //      /**************************************************************
		//* Name: printQueue
		//* Description: This method prints the elements of the queue. If queue is empty will throw an empty exception.
		//* Input: 
		//* Output: string queueString
		//***************************************************************/
  //      public List<Node> returnNodes(string tableFilter)
  //      {
  //          List<Node> nodeList = new List<Node>();
  //          nodeList = DaysOfWeek.returnList(tableFilter);
  //          return nodeList;
  //      }


    }
}
