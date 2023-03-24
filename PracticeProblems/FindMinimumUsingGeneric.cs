using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    internal class FindMinimumUsingGeneric 
    {
        public static void MinimumValue<T>(T FirstValue,T SecondValue,T ThirdValue) where T : IComparable
        {
            
            if (FirstValue.CompareTo(SecondValue) < 0 && FirstValue.CompareTo(ThirdValue) < 0)
            {
                Console.WriteLine("=> {0} is minimum ", FirstValue);
            }
            else if (SecondValue.CompareTo(FirstValue) < 0 && SecondValue.CompareTo(ThirdValue) < 0)
            {
                Console.WriteLine("=> {0} is minimum ", SecondValue);
            }
            else if (SecondValue.CompareTo(FirstValue) < 0 && SecondValue.CompareTo(ThirdValue) < 0)
            {
                Console.WriteLine("=> {0} is minimum ", ThirdValue);
            }
           
        }
    
    }
}
