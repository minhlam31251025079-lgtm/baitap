using System;
using System.Collections.Generic;
using System.Text;

namespace bai_tap.baitapslidebuoi3
{
    internal class bt3bai2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap ban kinh hinh cau (r):");
            double r = double.Parse(Console.ReadLine());
            if (r <= 0)
            {
                Console.WriteLine("ban kinh phai lon hon 0!");
                return;
            }
            double surfaceArea = 4 * Math.PI * Math.Pow(r, 2);
            double volume = (4.0 / 3.0) * Math.PI * Math.Pow(r, 3);
            Console.WriteLine($"dien tich be mat la: {surfaceArea:F2}");
            Console.WriteLine($"the tich hinh cau la: {volume:F2}");
            Console.ReadKey();
        }
    }
}
