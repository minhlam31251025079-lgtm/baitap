using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chuvivadientichinhtron
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float r, dt, cv;
            const float PI = 3.14f;
            Console.WriteLine("hay nhap vao ban kinh r cua duong tron:");
            r = float.Parse(Console.ReadLine());
            cv = 2 * PI * r;
            dt = PI * r * r;
            Console.WriteLine("chu vi hinh tron la:" +cv);
            Console.WriteLine("dienn tich hinh trn la:" +dt);
            Console.ReadKey();
        }
    }
}
