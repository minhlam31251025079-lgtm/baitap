using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thuchanh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bangcuuchuong();
        }
        static void bangcuuchuong()
        {
            for (int i = 2; i <= 9; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{i} * {j} = {i * j}");
                }
                Console.WriteLine();
            }
        }
    }
}
