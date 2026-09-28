using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b = 2;
            Console.WriteLine("nhap vao so nguyen a:");
            a = int.Parse(Console.ReadLine());
            a -= b + 7;
            Console.WriteLine("a=" + a);
            Console.ReadKey(); 
        }
    }
}
