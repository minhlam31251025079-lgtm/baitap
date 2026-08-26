using System;
using System.Collections.Generic;
using System.Text;

namespace bai_tap.baitap2
{
    internal class baitap2bai9
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap do dai canh a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            double area = a * a;
            Console.WriteLine($"Dien tich hinh vuong: {area}");
        }
    }
}
