using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    internal class GenericMethod
    {
        public static void DeleteElement<T>(T[] arr3,T delete3)
        {
            int k = 0;
            T[] result = new T[arr3.Length - 1];

            Console.WriteLine("The remaing elements are : ");

            for(int i = 0; i < arr3.Length; i++)
            {
                if (!delete3.Equals(arr3[i]))
                {
                    result[k] = arr3[i];
                    k++;
                }
            }
            foreach(var i in result)
            {
                Console.WriteLine(i);   
            }

        } 
        

    }
}
