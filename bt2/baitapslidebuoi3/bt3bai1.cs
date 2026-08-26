using System;
using System.Collections.Generic;
using System.Text;

namespace bai_tap.baitapslidebuoi3
{
    internal class bt3bai1
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
