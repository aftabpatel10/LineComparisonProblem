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
            var length1 = Math.Sqrt((Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)));
            Console.WriteLine("Length of line1 is :" + length1);

            int c1 = Convert.ToInt32(Console.ReadLine());
            int c2 = Convert.ToInt32(Console.ReadLine());
            int b1 = Convert.ToInt32(Console.ReadLine());
            int b2 = Convert.ToInt32(Console.ReadLine());
           
            var length2 = Math.Sqrt((Math.Pow(c1 - c2, 2) + Math.Pow(b1 - b2, 2)));
            
            
            Console.WriteLine("Length of line2 is: " + length2);
            var result = Equals(length1, length2);
            if (result == false)
            {
                Console.WriteLine("lines are not equal");

            }
            else
            {
                Console.WriteLine("lines are equal");
            }
            Console.ReadLine();
        }
    }
}
