using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Programming
{
   public class Program
    {
        int a = 10;
        int b = 20;
        Program()
        {
            Console.WriteLine("B");
        }
        static Program()
        {
            Console.WriteLine("A");
        }
    
        static void Main(string[] args)
        {
            //Program p= new Program();
            ////Console.WriteLine(p.a +p.b);
            //Console.ReadLine();
            //--Push ZeroToBackEnd--

            // int[] arr = { 1, 9, 8, 4, 0, 0, 2, 7, 0, 6, 0, 9 };
            // int n = arr.Length;
            //PushZeroToBackEnd.pushZerosToEnd(arr, n);
            // Console.WriteLine("Array after pushing all zeros to the back: ");
            // for (int i = 0; i < n; i++)
            //     Console.Write(arr[i] + " ");
            // Console.ReadLine();


            //   int[] arr = new int[] { 12, 13, 1, 10, 34, 1 };
            //   int n = arr.Length;
            //Largest_three_elements.print2largest(arr, n);
            //  Console.ReadLine();




            // int[] arr = { 1, 3, 0, 2 };
            // int n = arr.Length;

            //Console.WriteLine("Given array is ");
            // Rearrange_an_array.printArray(arr, n);

            // Rearrange_an_array.rearrange(arr, n);

            // Console.WriteLine("Modified array is ");
            // Rearrange_an_array.printArray(arr, n);












            //int[] a = { 1, 2,3, 4, 5, 6,8,10 };
            //int t=a.Length;
            //int miss = FindtheMissingNo.getMissingNo(a, t);
            //Console.Write(miss);
            //Console.ReadLine();


            //ReverseString.Reverse();
            //Console.ReadLine();


            //SelectionSort s = new SelectionSort();
            //s.Selectionsort();
            //   int[] numbers = new int[10] { 2, 5, -4, 11, 0, 18, 22, 67, 51, 6 };
            ////   Console.WriteLine("\nOriginal Array Elements :");
            ////InsertionSort.InsertionSortAlgo(numbers);

            //InsertionSort.InsertionSortAlgo(numbers);
            //Console.ReadLine();
            //   Console.WriteLine("\nSorted Array Elements :");
            //   InsertionSort.PrintIntegerArray(InsertionSort.InsertionSortAlgo(numbers));
            //   Console.WriteLine("\n");
            //   Console.ReadLine();
            Factorial.Fact();

        }
    }
}
