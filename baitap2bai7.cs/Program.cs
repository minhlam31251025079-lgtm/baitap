using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap2bai7.cs
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
