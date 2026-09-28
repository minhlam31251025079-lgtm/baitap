using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // tim x ,y khi biet tong va hieu cua chung
            double tong, hieu;
            Console.WriteLine("moi nhap vao tong hai so:");
            tong = double.Parse(Console.ReadLine());
            Console.WriteLine("moi nhap vao hieu hai so:");
            hieu = double.Parse(Console.ReadLine());
            double x = (tong + hieu) / 2;
            double y =( tong - x);
            Console.WriteLine("vay x la:" +x);
            Console.WriteLine("vay y la:" +y);
            Console.ReadKey();  
        }
    }
}
