using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // de bai: nhap vao 1 so de kiem tra chan le
            int a;
            Console.WriteLine("moi nhap vao so nguyen a:");
            a = int.Parse(Console.ReadLine());
            int div = a % 2;
            switch (div)
            {
                case 0:
                    Console.WriteLine("so {0} la so chan", a);
                    break;
                default:
                    Console.WriteLine("so {0} la so le",a);
                    break;
            }
            Console.ReadKey();




        }
    }
}
