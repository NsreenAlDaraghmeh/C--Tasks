using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27._11._2022
{


    class Account
    {
        int age ;
        string gender;
        string name;
        string email;
        int id;
        string phonenumber;

        public Account(int age1,string gender1,string name1, string email1, int id1, string phonenumber1)
        {
            
            gender = gender1;
            name = name1;
            email = email1;
            id = id1;
            
            if (age1 >= 18 && age1 <= 60)
            {
                age = age1;
            }
            else
            {
                Console.WriteLine("The age not in range Please enter the correct age : ");
                int x=Convert.ToInt32( Console.ReadLine());
                age = x;
            }

            if(phonenumber1.Substring(0,3)=="077"|| phonenumber1.Substring(0, 3) == "079" || phonenumber1.Substring(0, 3) == "078")
            {
                phonenumber = phonenumber1;
            }
            else
            {
                Console.WriteLine("Wrong phone number Please enter the correct number : ");
                string y=Console.ReadLine();
                phonenumber = y;
            }
        }
        
        //public static void print(int my_age,string my_gender,string my_name,string my_email,int my_id,int my_phonenumber)
        //{

        //    Console.WriteLine(my_age+ my_gender + my_name + my_email + my_id + my_phonenumber);
            
        //}
        



        static void Main(string[] args)
        {
            Account Nsreen = new Account(26,"Female","Nsreen","nsreendaraghmeh@yahoo.com",22, "0799374127");
            Console.WriteLine(Nsreen.age);
            Console.WriteLine(Nsreen.gender);
            Console.WriteLine(Nsreen.name);
            Console.WriteLine(Nsreen.email);
            Console.WriteLine(Nsreen.id);
            Console.WriteLine(Nsreen.phonenumber);

            Account Salma = new Account(12, "Female", "Salma", "salmadaraghmeh@yahoo.com", 1, "0766163849");
            Console.WriteLine(Salma.age);
            Console.WriteLine(Salma.gender);
            Console.WriteLine(Salma.name);
            Console.WriteLine(Salma.email);
            Console.WriteLine(Salma.id);
            Console.WriteLine(Salma.phonenumber);
        }


    }
}
