using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
         //task1
          int firstnum = Convert.ToInt32(Console.ReadLine());
          int secondnum = Convert.ToInt32(Console.ReadLine());

            if (firstnum < secondnum)
            {
                Console.WriteLine("The smaller number is : "+ firstnum);
            }
            else
            {
                Console.WriteLine("The smaller number is : " + secondnum);
            }
            //task2
            int number = Convert.ToInt32(Console.ReadLine());
            if (number > 0)
            {
                Console.WriteLine("The Sign is + ");
            }
            else
            {
                Console.WriteLine("The Sign is - ");
            }
            //task3
            int firstnumber = Convert.ToInt32(Console.ReadLine());
            int secondnumber = Convert.ToInt32(Console.ReadLine());
            int thirdnumber = Convert.ToInt32(Console.ReadLine());
            if (firstnumber > secondnumber && firstnumber > thirdnumber)
            {
                if (secondnumber > thirdnumber)
                {
                    Console.WriteLine(firstnumber + " "+ secondnumber + " "+ thirdnumber);
                }
                else
                {
                    Console.WriteLine(firstnumber+" "+thirdnumber+" "+ secondnumber);
                }
            }
            else if (secondnumber > firstnumber && secondnumber > thirdnumber)
            {
                if (firstnumber > thirdnumber)
                {
                    Console.WriteLine(secondnumber+" "+ firstnumber+" "+ thirdnumber);
                }
                else
                {
                    Console.WriteLine(secondnumber+" "+ thirdnumber+" "+ firstnumber);
                }
            }
            else if (thirdnumber > firstnumber && thirdnumber > secondnumber)
            {
                if (firstnumber > secondnumber)
                {
                    Console.WriteLine(thirdnumber+" "+ firstnumber+" "+ secondnumber);
                }
                else
                {
                    Console.WriteLine(thirdnumber+" "+secondnumber+" "+ firstnumber);
                }
            }
            //task4
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());
            int number3 = Convert.ToInt32(Console.ReadLine());
            int number4 = Convert.ToInt32(Console.ReadLine());
            int number5 = Convert.ToInt32(Console.ReadLine());
            int maxnumber = number1;
            if (number2 > maxnumber)
            {
                 maxnumber = number2;
            }
            if (number3 > maxnumber)
            {
                maxnumber = number3;
            }
            if (number4 > maxnumber)
            {
                maxnumber = number4;
            }
            if (number5 > maxnumber)
            {
                maxnumber = number5;
            }
            Console.WriteLine("The max number is : "+maxnumber);

            //task5
            Console.WriteLine("Input kilometers per hour: ");
            int distance = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(distance* 0.621371192 + " : miles per hour ");

            //task6
            Console.WriteLine("Input hours ");
            int hours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input minutes ");
            int minutes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine( " Total : "+((hours*60)+minutes)+"Minutes");
        }
    }
}
        