using System;
using System.Collections.Generic;
using System.Text;

namespace bai_tap.baitap2
{
    internal class bt2bai4
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap chieu dai (feet): ");
            double feet = Convert.ToDouble(Console.ReadLine());

            double meters = feet * 0.3048;
            Console.WriteLine($"{feet} feet = {meters} meters");
        }
    }
}
