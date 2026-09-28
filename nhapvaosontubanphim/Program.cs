using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nhapvaosontubanphim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //viet chuong trinh nhap vao so n tu ban phim
            int n;
            Console.WriteLine("moi nhap vao so nguyen n tu 1 den 99:");
            n = int.Parse(Console.ReadLine());
            while(n<1 || n>99)
            {
                Console.WriteLine("do n chi thoa tu 1 den 99 moi nhap lai so  nguyen n:");
                n = int.Parse(Console.ReadLine()) ;
            }
            Console.WriteLine("ban da nhap xong n= {0}",n);
            Console.ReadKey();
        }
    }
}
