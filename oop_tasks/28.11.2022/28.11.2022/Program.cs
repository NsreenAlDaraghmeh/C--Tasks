using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28._11._2022
{
    internal class Car
    {
        public string cars_make { set; get; }
        public int year { set; get; }
        public string type { set; get; }
        public int price { set; get; }
        public string model { set; get; }
        public string pallet_number { set; get; }
        public string color { set; get; }

        public Car(string Carmake, int Year,string Type ,int Price,string Model , string Pallet_num,string Color)
        {
            cars_make = Carmake;
            year = Year;
            type = Type;
            price = Price;
            model = Model;
            pallet_number = Pallet_num;
            color = Color;

        }
        

        public void start()
        {
            Console.WriteLine("start engine");
        }

        public void stop()
        {
            Console.WriteLine("stop engine");
        }

      

    }
    class car_test : Car
    {
        public car_test(string Carmake, int Year, string Type, int Price, string Model, string Pallet_num, string Color) :base(Carmake,  Year,  Type,  Price,  Model,  Pallet_num,  Color)
        {

        }
        public int litter(int x)
        {
            int y = x * 20;
            return y;
        }
    }
   
    internal class program
    {
        static void Main(string[] args)
        {
            Car op = new Car("Germany", 1990, "Hyprid", 40000, "Toyota", "43-45678", "Black");
            Console.WriteLine($"car's make : {op.cars_make}  year : {op.year}  type : {op.type}  price : {op.price}  model : {op.model}  pallet-number : {op.pallet_number} color : {op.color}  ");
            op.start();
            op.stop();
            car_test op1 = new car_test("japan", 1980, "Automatic", 50000, "Mercedes", "43-45000", "red");
            Console.WriteLine($"car's make : {op1.cars_make}  year : {op1.year}  type : {op1.type}  price : {op1.price}  model : {op1.model}  pallet-number : {op1.pallet_number} color : {op1.color}  ");

            Console.WriteLine("Enter the litter");
            int lit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(op1.litter(lit));

        }
    }
  
}
