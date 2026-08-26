using System;
using System.Collections.Generic;
using System.Text;

namespace bai_tap.bt2._1
{
    internal class bt2bai8
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap ban kính R: ");
            double r = Convert.ToDouble(Console.ReadLine());

            double area = Math.PI * r * r;
            Console.WriteLine($"Dien tich hinh tron: {area}");
        }
    }
}
