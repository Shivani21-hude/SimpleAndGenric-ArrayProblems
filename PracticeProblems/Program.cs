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
                
               
                Console.WriteLine("\n \nChoose a number from following \n 1)  To Delete and print remaining array elements of int " +
                    " \n 2)  To Delete and print remaining array elements of double  " +
                    "\n 3)  To Delete and print remaining array elements of char \n");

                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("How many elements you want to add into array");
                        int size = Convert.ToInt32(Console.ReadLine());
                        int[] arr = new int[size];

                        Console.WriteLine("Enter the elements 1 by 1 :");
                        for (int i = 0; i < size; i++)
                        {
                            arr[i] = Convert.ToInt32(Console.ReadLine());
                        }

                        Console.WriteLine("\n please pickup any one element that you want to delete");
                        int delete = Convert.ToInt32(Console.ReadLine());
                        DeleteArrayElements.DeleteIntElements(arr,delete);
                        break;

                    case 2:
           
                        Console.WriteLine("How many elements you want to add into array");
                        int size1 = Convert.ToInt32(Console.ReadLine());
                        double[] arr1 = new double[size1];

                        Console.WriteLine("Enter the elements 1 by 1 :");
                        for (int i = 0; i < size1; i++)
                        {
                            arr1[i] = Convert.ToDouble(Console.ReadLine());
                        }

                        Console.WriteLine("\n please pickup any one element that you want to delete");
                        double delete1 = Convert.ToDouble(Console.ReadLine());
                        DeleteArrayElements.DeleteDoubleElements(arr1, delete1);
                        break;

                    case 3:

                        Console.WriteLine("How many elements you want to add into array");
                        int size2 = Convert.ToInt32(Console.ReadLine());
                        char[] arr2 = new char[size2];

                        Console.WriteLine("Enter the letters 1 by 1 :");
                        for (int i = 0; i < size2; i++)
                        {
                            arr2[i] = Convert.ToChar(Console.ReadLine());
                        }

                        Console.WriteLine("\n please pickup any one letter that you want to delete");
                        char delete2 = Convert.ToChar(Console.ReadLine());
                        DeleteArrayElements.DeleteCharElements(arr2, delete2);
                        break;
                }
            }
        }
    }
}
