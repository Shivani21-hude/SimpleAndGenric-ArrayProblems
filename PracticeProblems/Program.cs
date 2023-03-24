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
                Console.WriteLine("Select given option : \n 1) Delete array elements using int ,double,char " +
                    "\n 2) Delete array elements using generics method  " +
                    "\n 3) Delete array elements using generic class");
                int select = Convert.ToInt32(Console.ReadLine());
                switch (select)
                {
                    case 1:

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

                                Console.WriteLine("Enter int type elements 1 by 1 :");
                                for (int i = 0; i < size; i++)
                                {
                                    arr[i] = Convert.ToInt32(Console.ReadLine());
                                }

                                Console.WriteLine("\n please pickup any one element that you want to delete");
                                int delete = Convert.ToInt32(Console.ReadLine());
                                DeleteArrayElements.DeleteIntElements(arr, delete);
                                break;

                            case 2:

                                Console.WriteLine("How many elements you want to add into array");
                                int size1 = Convert.ToInt32(Console.ReadLine());
                                double[] arr1 = new double[size1];

                                Console.WriteLine("Enter double type elements 1 by 1 :");
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
                            default:
                                Console.WriteLine("Enter correct option");
                                break;

                        }
                        break;

                    case 2:

                        Console.WriteLine("\n Select from given options : \n 1) Delete int array element" +
                            "\n 2) Delete double element \n 3) Delete char element ");
                        int genericOption = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("How many elements you want to add into array : ");
                        int genericsize = Convert.ToInt32(Console.ReadLine());
                        int[] intArray = new int[genericsize];
                        double[] doubleArray = new double[genericsize];
                        char[] charArray = new char[genericsize];   


                        switch (genericOption)
                        {
                            case 1:

                                Console.WriteLine("Enter the int elements 1 by 1 : ");
                                for (int i = 0; i < genericsize; i++)
                                {
                                    intArray[i] = Convert.ToInt32(Console.ReadLine());
                                }
                               Console.WriteLine("\n please pickup any one element that you want to delete ");
                                int delete3 = Convert.ToInt32(Console.ReadLine());
                               
                                GenericMethod.DeleteElement<int>(intArray, delete3);
                                break;

                            case 2:
 
                                Console.WriteLine("Enter the double elements 1 by 1 : ");
                                for (int i = 0; i < genericsize; i++)
                                {
                                    doubleArray[i] = Convert.ToDouble(Console.ReadLine());
                                }

                                Console.WriteLine("\n please pickup any one element that you want to delete ");
                                double delete4 = Convert.ToDouble(Console.ReadLine());
                               
                                GenericMethod.DeleteElement<double>(doubleArray, delete4);
                                break;

                            case 3:
                                Console.WriteLine("Enter the letters 1 by 1 : ");
                                for (int i = 0; i < charArray.Length; i++)
                                {
                                    charArray[i] = Convert.ToChar(Console.ReadLine());
                                }

                                Console.WriteLine("\n please pickup any one element that you want to delete ");
                                char delete5 = Convert.ToChar(Console.ReadLine());

                                GenericMethod.DeleteElement<char>(charArray, delete5);
                                break;
                        }
                        break;
                    case 3:

                        Console.WriteLine("\n Select from given options : \n 1) Delete int array element" +
                           "\n 2) Delete double element \n 3) Delete char element ");
                        int genericOption1 = Convert.ToInt32(Console.ReadLine());
                        
                        Console.WriteLine("How many elements you want to add into array : ");
                        int genericsize1 = Convert.ToInt32(Console.ReadLine());
                        int[] intArray1 = new int[genericsize1];
                        double[] doubleArray1 = new double[genericsize1];
                        char[] charArray1 = new char[genericsize1];

                        switch (genericOption1)
                        {

                            case 1:
                                Console.WriteLine("Enter the int elements 1 by 1 : ");
                                for (int i = 0; i < genericsize1; i++)
                                {
                                    intArray1[i] = Convert.ToInt32(Console.ReadLine());
                                }
                                Console.WriteLine("\n please pickup any one element that you want to delete ");
                                int delete3 = Convert.ToInt32(Console.ReadLine());

                                GenericClass<int> deleteelement1 = new GenericClass<int>(intArray1, delete3);
                                deleteelement1.DeleteElement();
                                break;

                            case 2:
                                Console.WriteLine("Enter the double elements 1 by 1 : ");
                                for (int i = 0; i < genericsize1; i++)
                                {
                                    doubleArray1[i] = Convert.ToDouble(Console.ReadLine());
                                }

                                Console.WriteLine("\n please pickup any one element that you want to delete ");
                                double delete4 = Convert.ToDouble(Console.ReadLine());

                                GenericClass<double> deleteelement = new GenericClass<double>(doubleArray1, delete4);
                                deleteelement.DeleteElement();
                               
                                break;

                            case 3:
                                Console.WriteLine("Enter the letters 1 by 1 : ");
                                for (int i = 0; i < charArray1.Length; i++)
                                {
                                    charArray1[i] = Convert.ToChar(Console.ReadLine());
                                }

                                Console.WriteLine("\n please pickup any one element that you want to delete ");
                                char delete5 = Convert.ToChar(Console.ReadLine());

                                GenericClass<char> deleteelement2 = new GenericClass<char>(charArray1, delete5);
                                deleteelement2.DeleteElement();
                                break;
                        }
                        break;

                
                }
            
            }
        }
    }
}
