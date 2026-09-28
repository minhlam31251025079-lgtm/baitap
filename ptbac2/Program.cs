using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ptbac2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // phuong trinh bac 2;
            float a, b, c, delta;
           
            Console.WriteLine("moi nhap vao a:");
            a = float.Parse(Console.ReadLine());
          
            Console.WriteLine("moi nhao vao b:");
            b = float.Parse(Console.ReadLine());
            
            Console.WriteLine("moi nhap vao c:");
            c = float.Parse(Console.ReadLine());
            Console.ReadKey();
            delta = (b * b) - (4 * a * c);
            if (delta < 0)
                Console.WriteLine("phuong trinh vo nghiem");
            else if (delta == 0)
            {
                float x = -b / (2 * a);
                Console.WriteLine("phuong trinh co nghiem kep la {0} ",x);
            }
            else
            { double x1 =(-b+Math.Sqrt(delta))/(2*a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("phuong trinh co 2 nghiem phan biet x1 va x2");
                Console.WriteLine("nghiem x1={0}",x1);
                Console.WriteLine("nghiem x1={0}", x2);
            }
            Console.ReadKey();
        }
    }
}
