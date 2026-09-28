using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace timthangtrongnam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap toa do x:");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("nhap toa do y:");
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine($"diem ({x};{y})");
            if (x==0 && y==00)
            {
                Console.WriteLine("diem dat goc toa do tai O");
            }
            else if (x==0)
            {
                Console.WriteLine("diem nam tren truc toa do Oy");
            }
            else if (y==0)
            {
                Console.WriteLine("diem nam tren truc toa do Ox");

            }
            else if ( x>0 && y>0 )
            {
                Console.WriteLine("diem nam tren goc phan tu thu I");
            }
            else if (x>0 && y<0)
            { 
                Console.WriteLine("diem naM tren goc phan tu thu IV"); 
            }
            else if (x<0 && y>0)
            {
                Console.WriteLine("diem nam tren goc phan tu thu II");
            }
            else 
              {
                Console.WriteLine("diem nam tren goc phan tu thu III");
              }
            }
        }
    }

