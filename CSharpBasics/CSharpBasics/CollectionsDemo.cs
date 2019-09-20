using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasics
{
    class CollectionsDemo
    {
        //public static void Main(string[] args)
        //{
        //    //LIST
        //    //ListDemo();
        //    //LinkedListDemo();
        //    //QueueDemo();
        //    // StackDemo();
        //    HashSetDemo();
        //}
        public static void HashSetDemo()
        {
            HashSet<string> objEmplotyee = new HashSet<string>() { "Ankit", "Kapil", "Hira", "Avantika", "Chetna", "Neha" };
            HashSet<string> objCustomers = new HashSet<string>() { "Ankit", "Gaurav", "Hira", "Avantika", "Chetna", "Shilpa" };

           
            objEmplotyee.IntersectWith(objCustomers);
            foreach (var item in objEmplotyee)
            {
                Console.WriteLine(item);
            }
            objEmplotyee.Overlaps(objCustomers);
            foreach (var item in objEmplotyee)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
        public static void StackDemo()
        {
            Stack<int> objStack = new Stack<int>();
            objStack.Push(100);
            objStack.Push(200);

            //Peek - get last element without removing
            Console.WriteLine(  objStack.Peek());
            //Pop the last element from the stack
            int item = objStack.Pop();
            Console.WriteLine(item);
                
        }
        public static void QueueDemo()
        {
            Queue<int> objQueue = new Queue<int>();
            int result;
            objQueue.Enqueue(1500);
            objQueue.Enqueue(200);
            Console.WriteLine(objQueue.Peek());
            objQueue.TryPeek(out result);
            Console.WriteLine(result);
            objQueue.TryDequeue(out result);
            Console.WriteLine(result);
          
            foreach (var item in objQueue)
            {
                Console.WriteLine(item);
            }
        }
        static void LinkedListDemo()
        {
            LinkedList<int> objLinkedList = new LinkedList<int>();

          
            // Case 1 - Add First - add new item in the first location
            objLinkedList.AddFirst(100);
            objLinkedList.AddFirst(200);
            LinkedListNode<int> node = objLinkedList.Last;
            objLinkedList.AddBefore(node, 350);
            //Find the specific node
            node = objLinkedList.Find(100);
            Console.WriteLine("Node previous address {0}",node.Previous);
            Console.WriteLine("Node next     address {0}", node.Next);

            node = objLinkedList.AddAfter(node, 230);

            //Remove the specific elemt one the first occurance
            bool result = objLinkedList.Remove(100);
           var lsit= objLinkedList.GetEnumerator();
            foreach (int numbe in objLinkedList)
            {
                Console.WriteLine(numbe);
            }
            Console.ReadKey();
        }
        static void ListDemo()
        {
            List<int> objLst = new List<int>();
            foreach (int item in new int[] { 10, 20, 15, 30, 30, 33, 21, 22, -11 })
            {
                objLst.Add(item);

            }

            //Operations
            //Case 1: Count property
            int lstCOunt = objLst.Count;
            Console.WriteLine("List Count {0}", lstCOunt);

            // Case 2: Remove - Specify the item name and the first occurance will remove first and return bool if exist
            bool removestatus = objLst.Remove(50);
            Console.WriteLine("Item remove {0}", (removestatus == true ? "Removed" : "No removed"));
            //Case 3 : Remove At - Specify the position and return void
            objLst.RemoveAt(1);
            Console.WriteLine("List Count {0}", objLst.Count);

            //Case 4:Remove ALl - it will remove all the element from the list and return the no of item removed list

            //Case 5: RemoveRange - Remove from specific range starting from the index to number of element i.e count and return void
            //objLst.RemoveRange(0, 4);

            //Case 6 - add the item at the end of list
            objLst.Add(77);

            //Case 7 - Add to specfic range by defining the IEnmerable<object> and add at the last of list
            objLst.AddRange(new int[] { 65, 12, 45, -15 });

            // Case 8 - Return a zerobased index of the element
            int itemSearch = objLst.BinarySearch(45);

            Console.WriteLine("Binary search item index : {0}", itemSearch);

            //Case 9
            //this is used to set the capacity tohold the items in the list
            // objLst.Capacity = 10;

            //Case 10 : 
            //Predicate<int> objPred = IsGreaterThanZero;
            // bool CheckNumber = objPred(20);
            bool status = objLst.Exists(x => x == 200);

            // Many more there



        }

    }

}
