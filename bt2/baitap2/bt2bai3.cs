using System;
using System.Collections.Generic;
using System.Text;

namespace bt2.bt2._1
{
    internal class bt2bai3
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so thuc thu nhat: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap so thuc thu hai: ");
            double b = Convert.ToDouble(Console.ReadLine());

            double tích = a * b;
            Console.WriteLine($"Tich hai so thuc la: {tích}");
        }
    }
}
