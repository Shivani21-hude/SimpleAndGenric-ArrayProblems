using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    public class Icomparable_GenericClassL<T> where T : IComparable
    {
        public T FirstValue;
        public T SecondValue;
        public T ThirdValue;
        public Icomparable_GenericClassL(T FirstValue, T SecondValue, T ThirdValue) 
        { 
            this.FirstValue = FirstValue;
            this.SecondValue = SecondValue;
            this.ThirdValue = ThirdValue;
        }
        public void Minimum()
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
