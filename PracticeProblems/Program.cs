using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                
               
                Console.WriteLine("\n \nChoose a number from following \n 1) To print remaining int elements after deleteing 1 element \n");

                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("How many elements to add into array");
                        int size = Convert.ToInt32(Console.ReadLine());
                        int[] arr = new int[size];

                        Console.WriteLine("Enter the elements 1 by 1 :");
                        for (int i = 0; i < size; i++)
                        {
                            arr[i] = Convert.ToInt32(Console.ReadLine());
                        }

                        Console.WriteLine("\n please pickup any one element from this array");
                        int delete = Convert.ToInt32(Console.ReadLine());
                        DeleteArrayElements.DeleteIntElements(arr,delete);
                        break;
                }
            }
        }
    }
}
