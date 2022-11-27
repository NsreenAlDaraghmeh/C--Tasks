using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        //task1
        static double add(double x, double y)
        {
            return x + y;
        }
        //task2
        static double subtract(double x, double y)
        {
            return x - y;
        }
        static void Main(string[] args)
        {
            //task1
            Console.WriteLine("task1");
            Console.WriteLine();
            double num1=Convert.ToDouble(Console.ReadLine());
            double num2 = Convert.ToDouble(Console.ReadLine());
            double sum = add(num1,num2);
            Console.WriteLine(sum);
            //task2
            Console.WriteLine("task2");
            Console.WriteLine();
            double num3 = Convert.ToDouble(Console.ReadLine());
            double num4 = Convert.ToDouble(Console.ReadLine());
            double sum1 = subtract(num3, num4);
            Console.WriteLine(sum1);
        }
    }
}
