using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task1
            Console.WriteLine("task1");
            int[] ARR = { 1, 7, 9, 45 } ;
            Console.WriteLine(ARR[0]+" " +ARR[1]+" " + ARR[2]+" " + ARR[3]);
            string []arr2 = { "Str", "alex", "moh" };
            Console.WriteLine(arr2[0] + " " + arr2[1] + " " + arr2[2] );
            string[] arr3 = { "the", "fox", "over", "lazy", "dog" };
            Console.WriteLine(arr3[0] + " " + arr3[1] + " " + arr3[2]+" " + arr3[3]+" " + arr3[4]);
            Console.WriteLine("...............................................................");
            //task2
            Console.WriteLine("task2");
            Console.WriteLine("What the index of \"Banana\", \"Tomato\" ?");
            String[] fruits = { "Tomato", "Banana", "Watermelon" };
            int index1 = Array.IndexOf(fruits,"Banana");
            Console.WriteLine("The index of Banana is : " + index1);
            int index2 = Array.IndexOf(fruits,"Watermelon");
            Console.WriteLine("The index of Watermelon is : " + index2);
            Console.WriteLine("...............................................................");
            //task3
            Console.WriteLine("task3");
            string[] foods = { "pasta", "kabseh", "banana", "mansaf", "futetchenni" };
            foreach (string food in foods)
            {
                Console.WriteLine(food);
            }
            string[] sports = { "football", "basketball", "tennis" };
            foreach (string sport in sports)
            {
                Console.WriteLine(sport);
            }
            string[] movies = { "princess", "fast and ferious", "the boss", "cindrella"};
            foreach (string movie in movies)
            {
                Console.WriteLine(movie);
            }
            Console.WriteLine("...............................................................");
            //task4
            Console.WriteLine("task4");
            Console.WriteLine("Expected Output:");
            Console.WriteLine("Input three numbers separated by comma: ");
            string number = Console.ReadLine();
            string[]numbers=number.Split(',');
            int[] numbers2 = new int[3];
            for(int i=0; i<3; i++)
            {
                
                numbers2[i] = Convert.ToInt32(numbers[i]);
            }
            int sum = numbers2[0] + numbers2[1] + numbers2[2];
            Console.WriteLine(sum);
            Console.WriteLine("...............................................................");
            //task5
            Console.WriteLine("task5");
            Console.WriteLine("Test Data");
            Console.WriteLine("The odd numbers are: ");
            int sum1 = 0;
            for(int k=0;k<100;k++)
            {
                if (k % 2 != 0)
                {
                    Console.Write(k+" ");
                    sum1 += k;
                }
            }
            Console.WriteLine("/ n");
            Console.WriteLine("The Sum of odd Numbers is: " + sum1);
            Console.WriteLine("...............................................................");
            //task6
            Console.WriteLine("task6");
            Console.WriteLine("The pattern like:");
            for(int p=0;p<4;p++)
            {
                for(int l = 4 - p; l > 0; l--)
                {
                    Console.Write(" ");
                }
                for(int t = 0; t <= p; t++)
                {
                    Console.Write("*"+" ");
                }
                Console.Write("\n");

            }
            Console.WriteLine("...............................................................");
            //task7
            Console.WriteLine("task7");
            Console.WriteLine("The pattern like:");
            int D = 1;
            for (int n =0; n < 4; n++)
            {
                for(int b=4-n;b>0;b--)
                {
                    Console.Write(" ");
                }
                for (int m = 0; m <= n; m++)
                {
                    Console.Write(D+" ");
                    D++;
                }
                Console.Write("\n");
            }
        }
    }
}
