using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    internal class DeleteArrayElements
    {
        public static void DeleteIntElements(int[] arr , int delete)
        { 

            int k = 0;
            int[] result=new int[arr.Length-1];

            Console.WriteLine("The remaining elements are : ");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != delete)
                {
                    result[k] = arr[i];
                    k++;
                }
            }
           
            foreach(int i in result)
            {
                Console.Write(i + " ");
            }
        }
    }
}
