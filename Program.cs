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
            Console.WriteLine("Enter value for x1,x2,y1,y2");
            int x1 = Convert.ToInt32(Console.ReadLine());
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());
            var length = Math.Sqrt((Math.Pow(x1 - x2,2) + Math.Pow(y1 - y2, 2)));
            Console.WriteLine("Length of line is :" + length);
            Console.ReadLine();
        }
    }
}
