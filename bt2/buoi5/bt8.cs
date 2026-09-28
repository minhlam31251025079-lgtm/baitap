using System;
using System.Collections.Generic;
using System.Text;

namespace bai_tap.baitapbuoi5
{
    internal class bt8
    {
        static void Main()
        {
            Console.Write("Nhập vào một số nguyên: ");
            int n = Convert.ToInt32(Console.ReadLine());

            bool isPrime = true;

            if (n <= 1)
            {
                isPrime = false;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }

            if (isPrime)
                Console.WriteLine($"{n} là số nguyên tố.");
            else
                Console.WriteLine($"{n} KHÔNG PHẢI là số nguyên tố.");
        }
    }
}
