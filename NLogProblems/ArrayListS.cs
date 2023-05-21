using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLogProblems
{
    public class ArrayListS
    {
        public void ArrayMethod()
        { 
    // Create an ArrayList to hold some data
            ArrayListS list = new ArrayListS();

            // Add some data to the list
            list.Add("Apple");
            list.Add("Banana");
            list.Add("Cherry");
            list.Add("Durian");

            // Display the contents of the list
            Console.WriteLine("Initial contents of list:");
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            // Update an item in the list
            list[1] = "Blackberry";

            // Display the contents of the list after the update
            Console.WriteLine("Contents of list after update:");
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            // Remove an item from the list
            list.Remove("Cherry");

            // Display the contents of the list after the removal
            Console.WriteLine("Contents of list after removal:");
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            // Insert an item into the list
            list.Insert(0, "Apricot");

            // Display the contents of the list after the insertion
            Console.WriteLine("Contents of list after insertion:");
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            // Clear the list
            list.Clear();

            // Display the contents of the list after the clear
            Console.WriteLine("Contents of list after clear:");
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
        }
    }

}
