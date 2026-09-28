using System;
using System.Collections.Generic;
using System.Text;

namespace bai_tap.exercise
{
    

class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Nhập chỉ số điện cũ (kWh): ");
            if (!decimal.TryParse(Console.ReadLine(), out decimal chiSoCu)) return;

            Console.Write("Nhập chỉ số điện mới (kWh): ");
            if (!decimal.TryParse(Console.ReadLine(), out decimal chiSoMoi) || chiSoMoi < chiSoCu)
            {
                Console.WriteLine("Chỉ số mới phải lớn hơn hoặc bằng chỉ số cũ!");
                return;
            }

            decimal kw = chiSoMoi - chiSoCu;
            decimal kwGoc = kw;
            decimal tienDien = 0;

            if (kw > 300) { tienDien += (kw - 300) * 3050m; kw = 300; }
            if (kw > 200) { tienDien += (kw - 200) * 2729m; kw = 200; }
            if (kw > 100) { tienDien += (kw - 100) * 2167m; kw = 100; }
            if (kw > 50) { tienDien += (kw - 50) * 1866m; kw = 50; }
            if (kw > 0) { tienDien += kw * 1806m; }

            decimal vat = tienDien * 0.08m;
            decimal tongTien = tienDien + vat;

            Console.WriteLine($"\nSố điện tiêu thụ: {kwGoc} kWh");
            Console.WriteLine($"Tiền điện chưa thuế: {tienDien:N0} VNĐ");
            Console.WriteLine($"Thuế VAT (8%): {vat:N0} VNĐ");
            Console.WriteLine($"Tổng thanh toán: {tongTien:N0} VNĐ");
        }
    
}
}
