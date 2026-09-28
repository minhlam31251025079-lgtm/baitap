using System;
using System.Collections.Generic;
using System.Text;

namespace bai_tap.baitapslidebuoi6
{
    internal class bai1
    {
        static int timsolonnhattrong3so(int sothunhat, int sothuhai, int sothuba)
        {
            int solonnhat = sothunhat;
            if (sothuhai > solonnhat) solonnhat = sothuhai;
            if (sothuba > solonnhat) solonnhat = sothuba;
            return solonnhat;
        }
        static void Main(string[] args)
        {
            Console.Write("Nhap so thu nhat: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap so thu hai: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap so thu ba: ");
            int c = Convert.ToInt32(Console.ReadLine());
            int ketqua = timsolonnhattrong3so(a, b, c);
            Console.WriteLine("so lon nhat trng ba so la:" + ketqua);
            Console.ReadKey();
        }
    }
}

  

