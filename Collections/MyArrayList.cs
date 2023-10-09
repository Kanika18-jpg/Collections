using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class MyArrayList
    {
        static void Main(string[] args)
        {
            // Creating an ArrayList 
            ArrayList myList = new ArrayList();

            // Adding elements to ArrayList 
            myList.Add(11);
            myList.Add(12);
            myList.Add(32);
            myList.Add(41);
            myList.Add(5);

            myList.Sort();
            myList.Remove(1);
            myList.RemoveAt(2);

            //myList.Clear();

            foreach(var i in myList)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Number of elements: " + myList.Count);

            Console.WriteLine("Current capacity: " + myList.Capacity);

            Console.ReadLine();

        }

        
    }
}
