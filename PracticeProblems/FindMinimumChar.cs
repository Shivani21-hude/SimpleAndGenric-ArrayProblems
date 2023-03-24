using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    internal class FindMinimumChar
    {
        public static void MinimumChar()
        {
            Console.WriteLine("Find minimum char value from 3 values ----");
            Console.WriteLine("Enter 3 strings : ");
            string FirstValue =Console.ReadLine();
            string SecondValue = Console.ReadLine();
            string ThirdValue = Console.ReadLine();

             if (FirstValue.CompareTo(SecondValue) < 0 && FirstValue.CompareTo(ThirdValue) < 0)
            {
                Console.WriteLine("{0} is minimum " , FirstValue);
            }
            else if (SecondValue.CompareTo(FirstValue) < 0 && SecondValue.CompareTo(ThirdValue) < 0)
            {
                Console.WriteLine("{0} is minimum ", SecondValue);
            }
            else if(SecondValue.CompareTo(FirstValue) < 0 && SecondValue.CompareTo(ThirdValue) < 0)
            {
                Console.WriteLine("{0} is minimum ", ThirdValue);
            }
            else
            {
                Console.WriteLine("The 3 strings are same");
            }
        }
    }
}
