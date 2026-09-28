using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dowhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int tong = 0;
            do
            {
                tong += a;//tong=tong +a
                a++; //a=a+1

            }
            while (a <= 5);
            {
                Console.WriteLine("tong tu 1 den 5 la:" + tong);
            }
            Console.ReadKey();
        }
    }
}
