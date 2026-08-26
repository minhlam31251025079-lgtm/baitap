using System;
using System.Collections.Generic;
using System.Text;

namespace bt2.bt2._1
{
    internal class bt2bai5
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap do C: ");
            double celsius = Convert.ToDouble(Console.ReadLine());

            double fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine($"{celsius}°C = {fahrenheit}°F");
        }

    }
}
