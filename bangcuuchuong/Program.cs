using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bangcuuchuong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i=1; i<=10;i++)
            {
                Console.WriteLine($"bang cuu chuong {i}");
                for (int j = 1; j <= 10; j++) 
                {
                    Console.WriteLine($"{i}X{j}={i*j}");
                }

            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
