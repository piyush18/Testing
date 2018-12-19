using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming
{
  public static  class ReverseString
    {
        public static void Reverse()
        {
            string str = "",reverse = "";
            int Lenght = 0;
            Console.WriteLine("Enter a word");
            str = Console.ReadLine();
            Lenght = str.Length-1;
            while (Lenght>=0)
            {
                reverse = reverse + str[Lenght];
                Lenght--;

            }
            Console.WriteLine("Reverse word is {0}", reverse);
            Console.ReadLine();
        }
    }
}
