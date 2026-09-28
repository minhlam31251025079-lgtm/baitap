using System;
using System.Collections.Generic;
using System.Text;

namespace bai_tap.baitapbuoi5
{
    internal class baitap1
    {
        static void Main()
        {
            Console.Write("Nhập cạnh a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhập cạnh b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhập cạnh c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            if (a == b && b == c)
            {
                Console.WriteLine("Tam giác đều (Equilateral).");
            }
            else if (a == b || b == c || a == c)
            {
                Console.WriteLine("Tam giác cân (Isosceles).");
            }
            else
            {
                Console.WriteLine("Tam giác thường (Scalene).");
            }
        }
    }
}

