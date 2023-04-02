using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5_assignment
{
    public  class FloatMinimum
    {
        public static void MinimumFloat()
        {
            float a=0, b=0, c=0;
            try
            {
                Console.WriteLine("1st number -:");
                a = float.Parse(Console.ReadLine());

                Console.WriteLine("2nd number -:");
                 b = float.Parse(Console.ReadLine());

                Console.WriteLine("3rd number -:");
                 c = float.Parse(Console.ReadLine());

            }

             catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            if (a < b && a < c)
            {
                Console.WriteLine(a + " is smallest number");
            }

            if (b < a && b < c)
            {
                Console.WriteLine(b + " is smallest number");
            }

            if (c < a && c < b)
            {
                Console.WriteLine(c + " is smallest number");
            }
        }
    }
}
