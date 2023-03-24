using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    internal class GenericClass<T>
    {
        public T[] arr;
        public T delete;
        public GenericClass(T[] arr, T delete)
        {
            this.arr = arr;
            this.delete = delete;
        }

        public void DeleteElement()
        {
            int k = 0;
            T[] result = new T[arr.Length - 1];

            Console.WriteLine("The remaing elements are : ");

            for (int i = 0; i < arr.Length; i++)
            {
                if (!delete.Equals(arr[i]))
                {
                    result[k] = arr[i];
                    k++;
                }
            }
            foreach (var i in result)
            {
                Console.WriteLine(i);
            }

        }

    }
}
