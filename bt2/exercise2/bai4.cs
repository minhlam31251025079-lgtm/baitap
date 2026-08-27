using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace bai_tap.exercise2
{
    

class bai4
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Nhập ngày sinh (dd/MM/yyyy): ");
            string input = Console.ReadLine();

            if (!DateTime.TryParseExact(input, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime ngaySinh))
            {
                Console.WriteLine("Định dạng ngày không hợp lệ!");
                return;
            }

            DateTime ngayHienTai = DateTime.Now.Date;

            int tuoi = ngayHienTai.Year - ngaySinh.Year;
            if (ngayHienTai < ngaySinh.AddYears(tuoi)) tuoi--;

            TimeSpan daSong = ngayHienTai - ngaySinh;

            DateTime sinhNhatTiep = new DateTime(ngayHienTai.Year, ngaySinh.Month, ngaySinh.Day);
            if (sinhNhatTiep < ngayHienTai)
            {
                sinhNhatTiep = sinhNhatTiep.AddYears(1);
            }

            int demNguoc = (sinhNhatTiep - ngayHienTai).Days;

            Console.WriteLine($"\nTuổi hiện tại: {tuoi} tuổi");
            Console.WriteLine($"Bạn đã sống tổng cộng: {daSong.TotalDays:N0} ngày");
            Console.WriteLine($"Sinh nhật tiếp theo còn: {demNguoc} ngày nữa");
        }
    }
}

