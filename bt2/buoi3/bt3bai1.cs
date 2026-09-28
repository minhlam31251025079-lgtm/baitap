using System;
using System.Collections.Generic;
using System.Text;

namespace bai_tap.baitapslidebuoi3
{
    internal class bt3bai1
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Nhập vào một số nguyên: ");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
                Console.WriteLine($"{num} là số chẵn.");
            else
                Console.WriteLine($"{num} là số lẻ.");


        }
    }
}
