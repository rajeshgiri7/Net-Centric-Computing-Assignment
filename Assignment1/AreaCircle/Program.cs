using System;
using System.Runtime.ConstrainedExecution;

namespace AreaCircle
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Area of Circle");
            Console.Write("Enter radius (r) : ");
            double r = double.Parse(Console.ReadLine());
            double a = Math.PI * r * r;
            Console.WriteLine($"Area = {a} r^2");
        }
    }
}
