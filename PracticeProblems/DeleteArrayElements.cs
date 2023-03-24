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
                                                                    //size = 3
            int k = 0;                                              //arr =  1 4 5
            int[] result=new int[arr.Length-1];                     //delete = 4
                                                                    //result = 1 5
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
                Console.Write(i + " , ");
            }
        }

        public static void DeleteDoubleElements(double[]arr1, double delete1)
        {

            int k = 0;
            double[] result = new double[arr1.Length - 1];

            Console.WriteLine("The remaining elements are : ");
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] != delete1)
                {
                    result[k] = arr1[i];
                    k++;
                }
            }

            foreach (var i in result)
            {
                Console.Write(i + " , ");
            }
        }

        public static void DeleteCharElements(char[] arr2, char delete1)
        {

            int k = 0;
            char[] result = new char[arr2.Length - 1];

            Console.WriteLine("The remaining elements are : ");
            for (int i = 0; i < arr2.Length; i++)
            {
                if (arr2[i] != delete1)
                {
                    result[k] = arr2[i];
                    k++;
                }
            }

            foreach (var i in result)
            {
                Console.Write(i + " , ");
            }
        }
    }
}
