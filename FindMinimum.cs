using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5_assignment
{
    public  class FindMinimum
    {
        public static void Minimum()
        {
            Console.WriteLine("1st number -:");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("1st number -:");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("1st number -:");
            int c = Convert.ToInt32(Console.ReadLine());
            FinMin(a, b, c);


        }

        public static void FinMin<T>(T a, T b, T c) where T : IComparable<T>
        {

            if (a.CompareTo(b) < 0 && a.CompareTo(c) < 0)
            {
                Console.WriteLine(a + " is smallest number");
            }

            if (b.CompareTo(a) < 0 && b.CompareTo(c) < 0)
            {
                Console.WriteLine(b + " is smallest number");
            }

            if (c.CompareTo(a) < 0 && c.CompareTo(b) < 0)
            
            {
                Console.WriteLine(c + " is smallest number");
            }
        }
    }
}
