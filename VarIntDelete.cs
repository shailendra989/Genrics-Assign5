using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_Assign
{
    internal class VarIntDelete
    {
        
        public static void Delete(int[] arr,int delete)
        {
            int k = 0;
            
            int[] result = new int[arr.Length - 1];

            for (int i = 0; i <= arr.Length - 1; i++)
            {
                if (delete != arr[i])
                {
                    result[k] = arr[i];
                    k++;
                }
            }
            foreach (int j in result)
            {
                Console.WriteLine(j + "  ");
            }
        }

        public static void Delete(double[] arr, double delete)
        {
            int k = 0;

            double[] result = new double[arr.Length - 1];

            for (int i = 0; i <= arr.Length - 1; i++)
            {
                if (delete != arr[i])
                {
                    result[k] = arr[i];
                    k++;
                }
            }
            foreach (double j in result)
            {
                Console.WriteLine(j + "  ");
            }
        }

        public static void Delete(char[] arr, char delete)
        {
            int k = 0;

            char[] result = new char[arr.Length - 1];

            for (int i = 0; i <= arr.Length - 1; i++)
            {
                if (delete != arr[i])
                {
                    result[k] = arr[i];
                    k++;
                }
            }
            foreach (int j in result)
            {
                Console.WriteLine((char)j+ "  "); // typecast because it was printing ascii value
            }
        }
    }
    
}
