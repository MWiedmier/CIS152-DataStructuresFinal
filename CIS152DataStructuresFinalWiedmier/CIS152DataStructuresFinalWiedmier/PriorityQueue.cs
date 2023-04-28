using System;
using System.Collections.Generic;

/***************************************************************
* Name        : PriorityQueue
* Author      : Mandy Wiedmier
* Created     : 02/22/2023
* Edited      : 03/22/2023
***************************************************************/

namespace CIS152DataStructuresFinalWiedmier
{
    public class PriorityQueue
    {
        /**************************************************************
        * Variables
        ***************************************************************/
        private int queueSize;
        private LinkedList<Node> pQueue;
        public const int MAX = 70;
        private DaysOfWeek dow;

        /**************************************************************
        * Getters and Setters
        ***************************************************************/
        public LinkedList<Node> PQueue { get => pQueue; set => pQueue = value; }

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
            PQueue = new LinkedList<Node>();
            dow = new DaysOfWeek();
        }

        /**************************************************************
        * Methods
        ***************************************************************/
        /**************************************************************
        * Name: newNode
        * Description: Makes a new node
        * Input: Reservation inputData
        * Output: node newData
        ***************************************************************/
        public Node newNode(Reservation inputData)
        {
            Node newData = new Node();
            newData.data = inputData;
            return newData;
        }

        /**************************************************************
        * Name: priorityNumber
        * Description: Compares the priority of queue items
        * Input: string priority
        * Output: int pNumber
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
        * Input: string originalString, string incomingString
        * Output: bool
        ***************************************************************/
        public bool checkPriority(string originalString, string incomingString)
        {
            string[] reservationType = { "vip", "party", "regular" };
            int indexOriginal = 0;
            int indexIncoming = 0;
            int positionOriginal = 0;
            int positionIncoming = 0;

            foreach(string rType in reservationType)
            {
                if (originalString.ToLower() == reservationType[indexOriginal])
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
                if (incomingString.ToLower() == reservationType[indexIncoming])
                {
                    positionIncoming = indexIncoming;
                    break;
                }
                else
                {
                    indexIncoming++;
                }
            }
            return positionOriginal <= positionIncoming; //Returns True if Incoming Node has a lesser priority
        }
        /**************************************************************
        * Name: isEmpty
        * Description: Checks if queue is empty
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
            queueSize = PQueue.Count;
            return queueSize;
        }

        /**************************************************************
		* Name: peek
		* Description: Checks what the first higest priority object is in the queue. If queue is empty it will throw an empty exception.
		* Input: 
		* Output: Node queueItem
		***************************************************************/
        public Node peek()
        {
            Node queueItem;
            if (!this.isEmpty())
            {
                queueItem = PQueue.First.Value;
                return queueItem;
            }
            else
            {
                throw new QueueEmptyException();
            }
        }

        /**************************************************************
		* Name: dequeue
		* Description: This method removes the first highest priority object of the queue. If queue is empty it will throw an empty exception.
		* Input: 
		* Output: Node item
		***************************************************************/
        public Node dequeue()
        {
            Node queueItem;
            if (!this.isEmpty())
            {
                queueItem = PQueue.First.Value;
                PQueue.RemoveFirst();
                return queueItem;
            }
            else
            {
                throw new QueueEmptyException();
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

            if (PQueue.Count == 0) //If there are no elements in queue
            {
                PQueue.AddFirst(head);
                queueSize++;
            }
        }

        /**************************************************************
		* Name: enqueue
		* Description: This method adds an object to the queue based on priority.
		* Input: Node head, Node incomingData
		* Output: 
		***************************************************************/
        public void enqueue(Node head, Node incomingData)
        {
            Node currentNode = head;
            Node insertingData = incomingData;
            int index = 0;

            if (PQueue.Count == 0) //If there are no elements in queue
            {
                PQueue.AddFirst(head);
                queueSize++;
            }
            else
            {
                if (!checkPriority(currentNode.data.TypeOfReservation, insertingData.data.TypeOfReservation)) //If the inserted priority is greater than the starting node
                {
                    PQueue.AddBefore(PQueue.First, insertingData);
                    queueSize++;
                }
                else //If the inserted data has a lesser prioirity
                {
                    if (PQueue.First.Next == null)//If there is only one node in the list
                    {
                        PQueue.AddAfter(PQueue.First, insertingData);
                    }
                    else//If there are more elements in the queue
                    {
                        foreach (Node data in PQueue)
                        {
                            index++;
                            if (!checkPriority(data.data.TypeOfReservation, insertingData.data.TypeOfReservation))//If the inserted prioirity is GREATER than the current node
                            {
                                PQueue.AddBefore(PQueue.Find(data), insertingData);
                                break;
                            }
                        }
                        if (index == PQueue.Count)
                        {
                            PQueue.AddLast(insertingData);
                        }
                    }
                }
            }
        }

        /**************************************************************
        * Name: weekdayListInsert
        * Description: This method inserts data into the weekly lists.
        * Input: LinkedList<Node> queueData
        * Output: 
        ***************************************************************/
        public void weekdayListInsert(LinkedList<Node> queueData)
        {
            LinkedList<Node> newQueue = new LinkedList<Node>(queueData);
            foreach (Node data in newQueue)
            {
                //Node insertingNode = newQueue.First();
                try
                {
                    dow.insert(data);
                }
                catch(Exception e)
                {
                    Console.WriteLine(data.data.DayOfWeek + " " + e.Message + " " + data.data.ReservationName + "'s Reservation Dequeued. Call " + data.data.PhoneNumber + " to inform them.");
                    queueData.Remove(data);
                }
            }
        }

        /**************************************************************
        * Name: getReservationList
        * Description: This method gets the list from the weekly lists.
        * Input: string day
        * Output: List<Node> returningList
        ***************************************************************/
        public List<Node> getReservationList(string day)
        {
            List<Node> returningList = new List<Node>();
            try
            {
                returningList = dow.returnList(day);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return returningList;
        }

        /**************************************************************
        * Name: printQueue
        * Description: This method prints the elements of the queue. If queue is empty will throw an empty exception.
        * Input: 
        * Output: string queueString
        ***************************************************************/
        public string printQueue()
        {

            if (!this.isEmpty())
            {
                string queueString = "";

                foreach (Node str in PQueue)
                {
                    queueString = queueString + "Reservation Name: " + str.data.ReservationName + ", Reservation Day " + str.data.DayOfWeek + ", Reservation Type " + str.data.TypeOfReservation + "\n";
                }
                return queueString;
            }
            else
            {
                throw new QueueEmptyException();
            }
        }
    }
}
