using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B0226497_段昱如_PDPR__Week6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("B0226497_段昱如_PDPR__Week6_1");
            Console.WriteLine("請輸入x:");
            int x = Int32.Parse(Console.ReadLine());
            Console.WriteLine("請輸入y:");
            int y = Int32.Parse(Console.ReadLine());
            Console.WriteLine("x={0},y={1}", x, y);
            Console.WriteLine("A.   x^2 –y^2 ="+ ((x*x)-(y*y)));
            Console.WriteLine("B.   x^2 + 2x + 1 ="+x*x + 2*x + 1);
            Console.WriteLine("C.   x^2 + 2xy + y^2 + 20  ="+x*x + 2*x*y + y*y + 20);
            Console.WriteLine("D.   x^3 + 3y + 5  =" + x * x *x + 3 * y + 5);
            Console.WriteLine("E.   (x+y)^3 + 50  =" + (x + y)* (x + y)* (x + y) + 50);
            Console.ReadLine();


        }
    }
}
