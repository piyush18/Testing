using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming
{
    class PrintAlternateRecord
    {
        public static void PrintAlternate()
        {
            int i = 0;
            //declaring array of integers
            int[] arr = new int[5];

            //reading the elements
            Console.WriteLine("Enter array elements : ");
            for (i = 0; i < arr.Length; i++)
            {
                Console.Write("Element[" + (i + 1) + "]: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            //checking and printing all odd numbers
            Console.WriteLine("List of odd  numbers : ");
            for (i = 0; i < arr.Length; i++)
            {
                //condition to check ODD number
                if (arr[i] % 2 != 0)
                    Console.Write(arr[i] + " ");
            }
            Console.WriteLine();

        }
    }
}
