using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace truefalse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool ketqua;
            int a = 4 ; int b = 5;
            ketqua = ((a != b) && (a < 3));
            Console.WriteLine("gia tri cua ket qua la:" +ketqua);
            Console.ReadKey();
        }
    }
}
