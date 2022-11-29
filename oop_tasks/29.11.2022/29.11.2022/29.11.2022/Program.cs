﻿using System;
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

    abstract class Car
    {

        public abstract void StartEngine();
        public abstract void StopEngine();
        public abstract void OpenDoor();
        public abstract void CloseDoor();
        public abstract void Honk();
        public abstract void IncreaseSpeed();
        public abstract void DecreaseSpeed();
        public abstract void Breaks();
        public abstract void OpenWindow();
        public abstract void CloseWindow();
        public abstract void AdjustSeat();
        public abstract void CleanGlass();
        public abstract void ChangeGear();
    }
}