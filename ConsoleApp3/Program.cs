using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap chieu dai (feet): ");
            double feet = Convert.ToDouble(Console.ReadLine());

            double meters = feet * 0.3048;
            Console.WriteLine($"{feet} feet = {meters} meters");
        }
    }
}
