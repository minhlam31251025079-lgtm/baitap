using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap2bai8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap ban kính R: ");
            double r = Convert.ToDouble(Console.ReadLine());

            double area = Math.PI * r * r;
            Console.WriteLine($"Dien tich hinh tron: {area}");
        }
    }
}
