using System;
using System.Collections.Generic;
using System.Text;

namespace bai_tap.exercise2
{
   

class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Chiều cao (m): ");
            if (!double.TryParse(Console.ReadLine(), out double chieuCao) || chieuCao <= 0) return;

            Console.Write("Cân nặng (kg): ");
            if (!double.TryParse(Console.ReadLine(), out double canNang) || canNang <= 0) return;

            double bmi = canNang / Math.Pow(chieuCao, 2);
            string phanLoai = "";

            if (bmi < 18.5) phanLoai = "Gầy (Thiếu cân)";
            else if (bmi < 23.0) phanLoai = "Bình thường (Lý tưởng)";
            else if (bmi < 25.0) phanLoai = "Thừa cân (Tiền béo phì)";
            else phanLoai = "Béo phì";

            double minWeight = 18.5 * Math.Pow(chieuCao, 2);
            double maxWeight = 22.9 * Math.Pow(chieuCao, 2);

            Console.WriteLine($"\nChỉ số BMI của bạn: {bmi:F2}");
            Console.WriteLine($"Phân loại sức khỏe: {phanLoai}");
            Console.WriteLine($"Khuyên dùng: Cân nặng lý tưởng của bạn nên từ {minWeight:F2} kg đến {maxWeight:F2} kg.");
        }
    }
}

