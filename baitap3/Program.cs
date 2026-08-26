using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap nhiet do celcius ");
            double c = double.Parse(Console.ReadLine());
            double k = c + 273;
            double f = 18.0 / 10.0 + 32;
            Console.WriteLine($" nhiet do kelvin la: {k}");
            Console.WriteLine($"nhiet do fahrenheit la: {f}");
            Console.ReadKey();  


        }
    }
}
