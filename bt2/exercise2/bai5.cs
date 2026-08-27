using System;
using System.Collections.Generic;
using System.Text;

namespace bai_tap.exercise2
{
   
class bai5
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("C# (4 TC): ");
            if (!double.TryParse(Console.ReadLine(), out double diemCS)) return;

            Console.Write("Toán (3 TC): ");
            if (!double.TryParse(Console.ReadLine(), out double diemToan)) return;

            Console.Write("Tiếng Anh (2 TC): ");
            if (!double.TryParse(Console.ReadLine(), out double diemAnh)) return;

            int tcCS = 4, tcToan = 3, tcAnh = 2;
            double scoreAvg = (diemCS * tcCS + diemToan * tcToan + diemAnh * tcAnh) / (tcCS + tcToan + tcAnh);

            char diemChu;
            double gpa4;
            string xepLoai;

            if (scoreAvg >= 8.5) { diemChu = 'A'; gpa4 = 4.0; xepLoai = "Xuất sắc / Giỏi"; }
            else if (scoreAvg >= 7.0) { diemChu = 'B'; gpa4 = 3.0; xepLoai = "Khá"; }
            else if (scoreAvg >= 5.5) { diemChu = 'C'; gpa4 = 2.0; xepLoai = "Trung bình"; }
            else if (scoreAvg >= 4.0) { diemChu = 'D'; gpa4 = 1.0; xepLoai = "Yếu"; }
            else { diemChu = 'F'; gpa4 = 0.0; xepLoai = "Kém (Trượt)"; }

            Console.WriteLine($"\nĐiểm TB Thang 10: {scoreAvg:F2}");
            Console.WriteLine($"Điểm Chữ Quy Đổi: {diemChu}");
            Console.WriteLine($"Điểm GPA Thang 4: {gpa4:F1}");
            Console.WriteLine($"Xếp Loại Học Lực: {xepLoai}");
        }
    }
}

