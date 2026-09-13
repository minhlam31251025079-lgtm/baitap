using System;
using System.Collections.Generic;
using System.Text;

namespace bai_tap.baitapbuoi5
{
    internal class baitap4
    {
        static void Main()
        {
            int rows = 4;
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
