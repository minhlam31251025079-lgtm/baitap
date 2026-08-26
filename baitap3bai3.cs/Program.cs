using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap3bai3.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap so thu nhat (a):");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("nhap so thu hai (b):");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("  KET QUA PHEP TINH LA   ");
            Console.WriteLine($"PHEP CONG (a + b): {a + b}");
            Console.WriteLine($"PHEP TRU (a - b): {a-b}");
            Console.WriteLine($"PHEP NHAN (a  *b): {a * b}");
            if (b != 0)
            {
                Console.WriteLine($"PHEP CHIA (a/b): {a / b:F2}");
                Console.WriteLine($"CHIA LAY DU (a % b): {a % b}");
            }
            
            else
                Console.WriteLine("Phép chia & Chia lấy dư: Không thể thực hiện vì số chia b = 0!");
               


            
        }
    }
}
