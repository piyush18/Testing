using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming
{
  public  static class PushZeroToBackEnd
    {
      public   static void pushZerosToEnd(int[] arr, int n)
        {
            // Count of non-zero elements
            int count = 0;

            // Traverse the array. If element encountered is
            // non-zero, then replace the element 
            // at index â..countâ.. with this element
            for (int i = 0; i < n; i++)
                if (arr[i] != 0)

                    // here count is incremented
                    arr[count++] = arr[i];

            // Now all non-zero elements have been shifted to
            // front and â..countâ.. is set as index of first 0.
            // Make all elements 0 from count to end.
            while (count < n)
            arr[count++] = 0;
        }
    }
}
