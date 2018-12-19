using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming
{
    public class Armstrong
    {
        public void armstrong()
        {

            int n, r, sum = 0, rem;
            Console.Write("Enter the Number= ");
            n = int.Parse(Console.ReadLine());
            rem = n;
            while (n > 0)
            {
                r = n % 10;
                sum = sum + (r * r * r);
                n = n / 10;
            }
            if (rem == sum)
                Console.Write("Armstrong Number.");
            else
                Console.Write("Not Armstrong Number.");
        }
    }
}