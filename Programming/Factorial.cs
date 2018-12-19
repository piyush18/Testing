using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming
{
  public static class Factorial
    {
        public static void Fact()
        {
            int i, fact = 1, number;
            Console.WriteLine("Enter the Number"); ;
            number = int.Parse(Console.ReadLine());
            for (i = 1; i <=number; i++)
            {
                fact = fact * i;

            }
            Console.WriteLine("Factorial of" +number+ "is " +fact);
            Console.ReadLine();

        }

    }
}
