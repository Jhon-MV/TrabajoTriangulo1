using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            double t = 0;
            double y = 0;
            double z = 0;
            double a = 0;
            double c = 0;
            double b = 90;

            Console.WriteLine("inserte el valor de Y");
            y = double.Parse(Console.ReadLine());
            Console.WriteLine("inserte el valor de Z");
            z = double.Parse(Console.ReadLine());
            t = Math.Sqrt((y * y) + (z * z));
            a = (Math.Sinh(y / t))* 180 / Math.PI;
            c = 180 - (b + a);
            Console.WriteLine("Angulos");
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("c = " + c);
            Console.WriteLine("Lados");
            Console.WriteLine("t = " + t);
            Console.WriteLine("y = " + y);
            Console.WriteLine("z = " + z);
        }
    }
}
