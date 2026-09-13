using System;
using System.Collections.Generic;
using System.Text;

namespace bai_tap.baitapbuoi5
{
    internal class bt6
    {
        static void Main()
        {
            Console.Write("Nhập số lượng n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            double sum = 0.0;
            for (int i = 1; i <= n; i++)
            {
                Console.Write($"1/{i}" + (i < n ? " + " : ""));
                sum += 1.0 / i;
            }

            Console.WriteLine($"\nTổng chuỗi Harmonic là: {sum}");
        }
    }
}
