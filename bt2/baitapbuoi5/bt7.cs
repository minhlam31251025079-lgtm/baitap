using System;
using System.Collections.Generic;
using System.Text;

namespace bai_tap.baitapbuoi5
{
    internal class bt7
    {
        static void Main()
        {
            Console.Write("Nhập giới hạn trên: ");
            int limit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Các số hoàn hảo từ 1 đến {limit} là:");
            for (int num = 1; num <= limit; num++)
            {
                int sum = 0;
                for (int i = 1; i <= num / 2; i++)
                {
                    if (num % i == 0) sum += i;
                }

                if (sum == num && num != 0)
                {
                    Console.Write(num + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
