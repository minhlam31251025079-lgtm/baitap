using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ifelse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float diemTN;
            Console.WriteLine("moi nhap vao diem tot nghiep");
            diemTN = float.Parse(Console.ReadLine());
            if (diemTN >= 7)
                Console.WriteLine("diem tot nghiep cua ban la {0}, ban da do", diemTN);
            else
                Console.WriteLine("diem tot nghiep cua may la {0}, may da rot ,MAY QUA NGU", diemTN);
            Console.ReadKey();


        }
    }
}
