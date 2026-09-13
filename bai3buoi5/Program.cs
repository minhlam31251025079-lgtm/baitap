using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai3buoi5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            nhapsobatky();
        }
        static void nhapsobatky()
        {
            Console.WriteLine("nhao vao mot so nguyen bat ky:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"bang cuu chuong {a}");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($" {a} * {i} = {a * i}");
            }
            Console.ReadLine();
        }
    }
}
