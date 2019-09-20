using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasics
{
    class EnumeratingCollectionDemo
    {
        public object Current => throw new NotImplementedException();

        public static void Main(string[] args)
        {

            //The IEnumerable interface actually uses IEnumerator. 
            //The main reason to create an IEnumerable is to make the syntax shorter and simpler.
            //The main difference between IEnumerable and IEnumerator is an IEnumerator retains its cursor's current state
            List<string> lstCollection = new List<string>();
            lstCollection.Add("Jan");
            lstCollection.Add("Feb");
            lstCollection.Add("Mar");
            lstCollection.Add("Apr");
            lstCollection.Add("MAy");
            lstCollection.Add("Jun");
            lstCollection.Add("Jul");
            lstCollection.Add("Aug");
            lstCollection.Add("Sep");
            lstCollection.Add("Oct");
            lstCollection.Add("Nov");
            lstCollection.Add("Dec");

            IEnumerator<string> iEnumeratingString = lstCollection.GetEnumerator();
            while (iEnumeratingString.MoveNext())
            {
             
                if (iEnumeratingString.Current=="Oct")
                {
                    iEnumeratingString.MoveNext(); 
                }
                else
                {
                    Console.WriteLine(iEnumeratingString.Current);
                }
            }
            Console.WriteLine("IEnnumerable");
            IEnumerable<string> objIEnumerable = lstCollection;
            foreach (var item in objIEnumerable)
            {
                Console.WriteLine(item);
            }

            BasicCollection<string> objCollection = new BasicCollection<string>();
            objCollection.FillList("Ankit", "Hira", "Kapil", "Jyoti");
            foreach (string item in objCollection)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Reverse");
            foreach (string item in objCollection.Reverse)
            {
                Console.WriteLine(item);
            }
            
        
            Console.ReadKey();
        }


        
    }
    public class BasicCollection<T> : IEnumerable<T>
    {
        private List<T> data = new List<T>();
        public void FillList(params T[] items)
        {
            foreach (var item in items)
            {
                data.Add(item);
            }
        }
        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            foreach (var item in data)
            {
                //The yield keyword indicates the value that should be returned by each iterator
                yield return item;
            }
        }
        public IEnumerable<T> Reverse
        {
            get
            {
                for (int i = data.Count-1; i>=0; i--)
                {
                  yield return data[i];
                }

            }
        }
        //public IEnumerator<T> GetEnumerator()
        //{
        //    throw new NotImplementedException();
        //}

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

}
