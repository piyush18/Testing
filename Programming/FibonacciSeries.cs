using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming
{
    public static class FibonacciSeries
    {
        public static void fibo()
        {
            int a = 0;
            int b = 1;
            int c = 0;
            int i = 0;

            Console.Write(a + ", " + b);

            for (i = 1; i < 10; i++)
            {
                c = a + b;
                Console.Write(", " + c);

                a = b;
                b = c;
            }

            Console.WriteLine();

            //int num1 = 0;
            //int num2 = 1;
            //int sum = 1;
            //while (num1 <= 250)
            //{
            //    sum = num1 + num2;
            //    num1 = num2;
            //    num2 = sum;
            //    Console.WriteLine(num2);
            //}
            //Console.ReadLine();
        }
    }
}
