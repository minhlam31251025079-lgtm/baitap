using System;
using System.Collections.Generic;
using System.Text;

namespace bai_tap.baitapbuoi5
{
    internal class baitap2
    {
        static void Main()
        {
            double sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"Nhập số thứ {i}: ");
                sum += Convert.ToDouble(Console.ReadLine());
            }

            double average = sum / 10;
            Console.WriteLine($"Tổng: {sum}");
            Console.WriteLine($"Trung bình cộng: {average}");
        }
    }
}
