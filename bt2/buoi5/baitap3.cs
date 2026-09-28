using System;
using System.Collections.Generic;
using System.Text;

namespace bai_tap.baitapbuoi5
{
    internal class baitap3
    {
        static void Main(string[] args)
        {
            nhapsobatky();
        }
        static void nhapsobatky()
        {
            Console.WriteLine("nhao vao mot so nguyen bat ky:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"bang cuu chuong {a}");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($" {a} * {i} = {a * i}");
            }
            Console.ReadLine();
        }
    }
}
