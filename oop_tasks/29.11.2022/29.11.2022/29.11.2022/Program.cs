using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace _29._11._2022
{
    class Employee
    {

        protected string Employee_Name;
        protected DateTime Birth_of_date;
        protected int Employee_Id;

        public Employee(string employeename, DateTime birthofdate, int employeeid)
        {
            Employee_Name = employeename;
            Birth_of_date = birthofdate;
            Employee_Id = employeeid;

        }

        public virtual void wellcom()
        {
            Console.WriteLine("Hello");
        }
        public virtual void age()
        {
            int x = Convert.ToInt32(DateTime.Now.Year);
            int y = Convert.ToInt32(Birth_of_date.Year);
            int z = x - y;
            Console.WriteLine("the age is : " + z);
        }


    }
    class Manager : Employee
    {
        public Manager(string employeename, DateTime birthofdate, int employeeid) : base(employeename, birthofdate, employeeid)
        {
        }

        public override void age()
        {
            base.age();
        }

        public void print()
        {

            Console.WriteLine("Manager_Name  " + Employee_Name);
            Console.WriteLine("Manager_Id    " + Employee_Id);
        }
        public override void wellcom()
        {
            Console.WriteLine("Wellcom");
        }

    }
    internal class Program
    {

        static void Main(string[] args)
        {
            DateTime dateTime = new DateTime(1996, 02, 04);
            Employee myobj = new Manager("Nsreen", dateTime, 22);
            myobj.wellcom();
            myobj.age();
            Manager Myobj = new Manager("Nsreen", dateTime, 22);
            Myobj.wellcom();
            Myobj.print();
        }
    }

    interface ICar

    {

         void StartEngine();
         void StopEngine();
         void OpenDoor();
         void CloseDoor();
         void Honk();
         void IncreaseSpeed();
         void DecreaseSpeed();
         void Breaks();
         void OpenWindow();
         void CloseWindow();
         void AdjustSeat();
         void CleanGlass();
         void ChangeGear();
    }
    class Toyota : ICar
    {
        public void AdjustSeat()
        {
            throw new NotImplementedException();
        }

        public void Breaks()
        {
            throw new NotImplementedException();
        }

        public void ChangeGear()
        {
            throw new NotImplementedException();
        }

        public void CleanGlass()
        {
            throw new NotImplementedException();
        }

        public void CloseDoor()
        {
            throw new NotImplementedException();
        }

        public void CloseWindow()
        {
            throw new NotImplementedException();
        }

        public void DecreaseSpeed()
        {
            throw new NotImplementedException();
        }

        public void Honk()
        {
            throw new NotImplementedException();
        }

        public void IncreaseSpeed()
        {
            throw new NotImplementedException();
        }

        public void OpenDoor()
        {
            throw new NotImplementedException();
        }

        public void OpenWindow()
        {
            throw new NotImplementedException();
        }

        public void StartEngine()
        {
            throw new NotImplementedException();
        }

        public void StopEngine()
        {
            throw new NotImplementedException();
        }
    }
}