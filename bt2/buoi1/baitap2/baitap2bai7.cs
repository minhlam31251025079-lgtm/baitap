using System;
using System.Collections.Generic;
using System.Text;

namespace bai_tap.bt2._1
{
    internal class baitap2bai7
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.Write("Nhap mot ky tu: ");
                char ch = Convert.ToChar(Console.ReadLine());

                int asciiValue = (int)ch;
                Console.WriteLine($"Gia tri ASCII cua '{ch}' la: {asciiValue}");
            }
        }
    }
}