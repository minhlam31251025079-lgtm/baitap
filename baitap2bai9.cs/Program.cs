using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap2bai9.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap do dai canh a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            double area = a * a;
            Console.WriteLine($"Dien tich hinh vuong: {area}");
        }
    }
}
