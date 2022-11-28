using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class Point
    {
        protected int x;
        protected int y;
    }

    class DerivedPoint : Point
    {
        static void Main()
        {
            var dpoint = new DerivedPoint();

            dpoint.x = 10;
            dpoint.y = 15;
            Console.WriteLine($"x = {dpoint.x}, y = {dpoint.y}");
        }
    }
    // Output: x = 10, y = 15
   
    
}
