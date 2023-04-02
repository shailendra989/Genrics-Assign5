using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_Assign
{
    internal class Q2Genric<T>
    {
        public void Delete(T[] arr, T d)
        {
            int k = 0;

            T[] result = new T[arr.Length - 1];

            for (int i = 0; i <= arr.Length - 1; i++)
            {
                if (!EqualityComparer<T>.Default.Equals(d, arr[i]))
                {
                    result[k] = arr[i];
                    k++;
                }
            }
            foreach (T j in result)
            {
                Console.WriteLine((T)j + "  ");

            }
        }

       
    }
}
