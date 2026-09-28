using System;
using System.Collections.Generic;
using System.Text;

namespace bai_tap.exercise2
{
 

enum CurrencyType { USD = 1, EUR, JPY, GBP }

    class bai3
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Nhập số tiền VNĐ: ");
            if (!decimal.TryParse(Console.ReadLine(), out decimal vnd) || vnd <= 0) return;

            Console.WriteLine("Chọn ngoại tệ (1-USD, 2-EUR, 3-JPY, 4-GBP): ");
            if (!int.TryParse(Console.ReadLine(), out int choice) || !Enum.IsDefined(typeof(CurrencyType), choice)) return;

            CurrencyType selectedType = (CurrencyType)choice;
            decimal tyGia = 0;

            switch (selectedType)
            {
                case CurrencyType.USD: tyGia = 25400m; break;
                case CurrencyType.EUR: tyGia = 27200m; break;
                case CurrencyType.JPY: tyGia = 165m; break;
                case CurrencyType.GBP: tyGia = 32100m; break;
            }

            decimal phiDichVu = vnd * 0.005m;
            decimal vndSauPhi = vnd - phiDichVu;
            decimal ngoaiTeNhan = vndSauPhi / tyGia;

            Console.WriteLine($"\nPhí dịch vụ (0.5%): {phiDichVu:N0} VNĐ");
            Console.WriteLine($"Số tiền VNĐ tính đổi: {vndSauPhi:N0} VNĐ");
            Console.WriteLine($"Số tiền {selectedType} nhận được: {ngoaiTeNhan:N2} {selectedType}");
        }
    }
}

