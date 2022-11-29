using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace _29_11_tasks
{


    internal class Program
    {

        //Overriding ..........................................
        class person
        {
            public virtual void IAM()
            {
                Console.WriteLine("Iam person");
            }
        }
        class employee : person
        {
            public override void IAM()
            {
                Console.WriteLine("Iam employee");
            }
        }
        class customer : person
        {
            public override void IAM()
            {
                Console.WriteLine("Iam customer");
            }
        }
        //overload.............................
        static int plus(int x, int y)
        {
            return x + y;
        }
        static double plus(double x, double y)
        {
            return x + y;
        }


        //Abstraction........................................................
        //abstract class Animal
        //{
        //    public abstract void sound();
        //    public void farm() { 
        //        Console.WriteLine("welcome to our farm");
        //    }
        //}

        //class Cow : Animal
        //{
        //    public override void sound()
        //    {
        //        Console.WriteLine("this is cow");
        //    }
        //}



        //interface...................................................................
        interface Animal
        {
            void sound();
            void farm();

        }
        class Cow : Animal
        {
            public void sound()
            {
                Console.WriteLine("this is cow");
            }
            public void farm()
            {
                Console.WriteLine("welcome to our farm");
            }
        }

        // multiple interfaces.............................................................
        interface IFirstInterface
        {
            void myMethod();
        }

        interface ISecondInterface
        {
            void myOtherMethod();
        }
        class DemoClass : IFirstInterface, ISecondInterface
        {
            public void myMethod()
            {
                Console.WriteLine("from first interface..");
            }
            public void myOtherMethod()
            {
                Console.WriteLine("from second interface...");
            }
        }

       

        static void Main(string[] args)
        {
            //Overriding .........................................................
            person p = new person();
            employee e = new employee();
            customer c = new customer();
            p.IAM();
            c.IAM();
            e.IAM();

            //overload...............................................................
            int num1 = plus(1, 2);
            double num2 = plus(2.5, 3.6);
            Console.WriteLine("the sum= " + num1);
            Console.WriteLine("the sum= " + num2);


            //Abstraction and interface..........................................
            Cow animal1 = new Cow();
            animal1.farm();
            animal1.sound();


            //multi interface.....................................................
            DemoClass myObj = new DemoClass();
            myObj.myMethod();
            myObj.myOtherMethod();

            //Exception.............................................................
            try
            {
                int[] myNumbers = { 1, 2, 3 };
                Console.WriteLine(myNumbers[10]);
            }
            catch (Exception r)
            {
                Console.WriteLine(r);
            }
            Console.ReadKey();
        }





    }
}
