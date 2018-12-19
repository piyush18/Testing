using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming
{
   public static class Largest_three_elements
    {
        // Function to print three 
        // largest elements
     public  static void print2largest(int[] arr,
                                  int arr_size)
        {
            int i, first, second, third;

            // There should be atleast two elements
            if (arr_size < 3)
            {
                Console.WriteLine("Invalid Input");
                return;
            }

            third = first = second = 000;
            for (i = 0; i < arr_size; i++)
            {
                // If current element is 
                // smaller than first
                if (arr[i] > first)
                {
                    third = second;
                    second = first;
                    first = arr[i];
                }

                // If arr[i] is in between first
                // and second then update second
                else if (arr[i] > second)
                {
                    third = second;
                    second = arr[i];
                }

                else if (arr[i] > third)
                    third = arr[i];
            }

            Console.WriteLine("Three largest elements are " + first + " " + second + " " + third);
        }
    }
}
