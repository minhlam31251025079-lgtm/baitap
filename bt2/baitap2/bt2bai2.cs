using System;
namespace bt2
{
    internal class bt2bai2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap so a:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nhap so b:");
            int b = Convert.ToInt32(Console.ReadLine());
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"sau khi hoan doi: a = {a}, b = {b}");
        }
    }
}