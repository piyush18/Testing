using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming
{
  public static  class Rearrange_an_array
    {
      public static  void rearrange(int[] arr, int n)
        {
            int [] temp = new int[n];
            int i;
            for (i = 0; i < n; i++)
                temp[arr[i]] = i;
            for ( i = 0; i < n; i++)
                arr[i] = temp[i];
            
        }

        public static void printArray(int [] arr,int n)
        {
            int i;
            for ( i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i] + " ");
            }
            Console.WriteLine("");

        }

    }
}
