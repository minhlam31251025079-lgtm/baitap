using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btthuchanh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine(" nhap vao so nguyen n:");
             n =  int.Parse(Console.ReadLine());
            Console.WriteLine("Ban vua nhap vao so {0}", n);
            Console.ReadKey();
            if (n % 2 == 0)
                Console.WriteLine("n la so chan", n);
            else
                Console.WriteLine("n la so le", n);
            Console.ReadKey();
        }
    }
}
