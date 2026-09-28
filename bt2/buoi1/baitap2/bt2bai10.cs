using System;
using System.Collections.Generic;
using System.Text;

namespace bai_tap.baitap2
{
    internal class bt2bai10
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so ngay: ");
            int totalDays = Convert.ToInt32(Console.ReadLine());

            int years = totalDays / 365;
            int remainingDaysAfterYears = totalDays % 365;

            int weeks = remainingDaysAfterYears / 7;
            int days = remainingDaysAfterYears % 7;

            Console.WriteLine($"{totalDays} ngay = {years} nam, {weeks} tuan, va {days} ngay");
        }
    }
}
