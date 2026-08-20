using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so thuc thu nhat: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap so thuc thu hai: ");
            double b = Convert.ToDouble(Console.ReadLine());

            double tích = a * b;
            Console.WriteLine($"Tich hai so thuc la: {tích}");
        }
    }
}
