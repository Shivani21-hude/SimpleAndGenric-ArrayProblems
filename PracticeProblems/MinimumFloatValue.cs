using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    internal class MinimumFloatValue
    {
        public static void MiminumFloat()
        {
            Console.WriteLine("Find minimum float value from 3 values ----");
            Console.WriteLine("Enter 3 float values : ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            if (a < b && a < c)
            {
                Console.WriteLine("{0} is minimum ", a);
            }
            else if (b < a && b < c)
            {
                Console.WriteLine("{0} is minimum ", b);
            }
            else
            {
                Console.WriteLine("{0} is minimum ", c);
            }
        }
    }
}
