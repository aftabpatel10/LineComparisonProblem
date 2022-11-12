using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation");
            Console.WriteLine("Enter value for line1 x1,x2,y1,y2");
            int x1 = Convert.ToInt32(Console.ReadLine());
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value for line2 c1,c2,b1,b2");
            int c1 = Convert.ToInt32(Console.ReadLine());
            int c2 = Convert.ToInt32(Console.ReadLine());
            int b1 = Convert.ToInt32(Console.ReadLine());
            int b2 = Convert.ToInt32(Console.ReadLine());
            var a = Math.Sqrt((Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)));
            Console.WriteLine("Length of line1 is :" + a);
            var b = Math.Sqrt((Math.Pow(c1 - c2, 2) + Math.Pow(b1 - b2, 2)));
            Console.WriteLine("Length of line2 is: " + b);
            int result = a.CompareTo(b);
          
            if (result >0)
            {
                Console.WriteLine("length of line1 is Greater than line2");

            }
            else if (result <0)
            {
                Console.WriteLine("length of line 1 less than line 2");
            }
            else
            {
                Console.WriteLine("length of both lines are equal");
            }
            Console.ReadLine();
        }
    }
}
