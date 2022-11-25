using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        //task1
        static void Mymethod()
        {
            Console.WriteLine("Input the 10 numbers :");
            int[] num = new int[10];
            for (int i = 0; i < 10; i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                sum = sum + num[i];
            }
            Console.WriteLine("The sum of 10 no is : " + sum);
            double avg = Convert.ToDouble(sum);
            Console.WriteLine("The Average is :  " + avg / 10);
        }
        //task2
        static void Mymethod2()
        {
            Console.WriteLine("Input number of terms : ");
            int[] num = new int[5];
            for (int i = 0; i < 5; i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < 5; i++) {
                int cube = num[i] * num[i] * num[i];
                Console.WriteLine("Number is :" + num[i] + " and cube of the  " + num[i] + " is : " + cube);
            }
        }

       //task3
        static void getYears()
        {

             int[] years = { 1763, 1972, 1925, 1916, 1984, 1124, 1950, 2020 };
            int more = 0;
            for (int i = 0; i < years.Length; i++)
            {

                if (years[i] > 1950)
                {
                    Console.WriteLine(years[i]);
                    more++;
                }
            }
            Console.WriteLine("The number of years that greater than 1950 is :  "+more);
        }
        //task4
        static int age(int x)
        {
            return x * 365;
        }
        //task5
        static int animals(int chickens , int cows , int pigs)
        {
            return chickens*2 +cows*4 +pigs*4;
        }
        //task6
        static void login( string username,string password)
        {
            string[] usernames = { "nsreen","salma","razan"};
            string[] passwords = {"9944","8866","1234"};
            for(int i=0;i<3;i++)
            {
                if (usernames[i]==username && passwords[i] == password)
                {
                    Console.WriteLine("success login");
                    break;
                }
                else if (i == usernames.Length - 1)
                {
                    Console.WriteLine("faild login");

                }
            }
        }
        //task7
        static int power(int x , int y)
        {
            int num = x;
            if (y == 0)
            {
                return 1;
            }
            else if (y == 1)
            {
                return num;
            }
            else {
               
            for(int i=1; i<y;i++)
                {
                     x = x * num;
                }
            return x;
            }
        }
        //task8
        static void leap(int x)
        {
            if (x >= 1900 && x <= 2024)
            {
                if ((x % 4 == 0 && x % 100 != 0) || x % 400 == 0)
                {
                    Console.WriteLine("The year is leap year");
                }
                else
                {
                    Console.WriteLine("The year is not leap year");
                }
            }
            else
            {
                Console.WriteLine("Wrong year");
            }
        }
        //task9
        static void prime(int x)
        {
            bool flag= false;
            for(int i = 2; i <= x / 2; i++)
            {
                if (x % i == 0)
                {
                    flag = true;
                    break;
                }
            }
            if (flag == true)
            {
                Console.WriteLine("The number is not prime");
            }
            else
            {
                Console.WriteLine("The number is prime");
            }

        }
        //task10
        static int words(string h)
        {
            string[]word= h.Split(' ');
            int counter = 0;
            foreach(string d in word)
            {
                counter++;
            }
            return counter;
        }



        static void Main(string[] args)
        {
            //task1
            Console.WriteLine("task1");
            Mymethod();
            //task2
            Console.WriteLine("task2");
            Mymethod2();
            //task3
            Console.WriteLine("task3");
            getYears();
            //task4
            Console.WriteLine("task4");
            Console.WriteLine("Inter age in years");
            int age1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("age in days : ");
            Console.WriteLine(age(age1));
            //task5
            Console.WriteLine("task5");
            //Console.WriteLine("Enter the number of chicken in farm : ");
            int chicken = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the number of cows in farm : ");
            int cows = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the number of pigs in farm : ");
            int pigs = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(animals(chicken, cows, pigs));
            //task6
            Console.WriteLine("task6");
            string username = (Console.ReadLine());
            string password = (Console.ReadLine());
            login(username, password);


            //task7
            Console.WriteLine("task7");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(power(x, y));

            //task8
            Console.WriteLine("task8");
            Console.WriteLine("input the year :");
            int v = Convert.ToInt32(Console.ReadLine());
            leap(v);
            //task9
            Console.WriteLine("task9");
            Console.WriteLine("input the number :");
            int u = Convert.ToInt32(Console.ReadLine());
            prime(u);
            //task10
            Console.WriteLine("task10");
            Console.WriteLine("input a sentence :");
            string f = Console.ReadLine();
            Console.WriteLine(words(f));
        }
    } 

    
}
