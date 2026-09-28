using System;
using System.Collections.Generic;
using System.Text;

namespace bai_tap.buoi7
{
    internal class baitapbuoi7
    {
        using System;
using System.Linq;

class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("==================================================");
                Console.WriteLine("       CHƯƠNG TRÌNH TỔNG HỢP BÀI TẬP C#          ");
                Console.WriteLine("==================================================");
                Console.WriteLine("1. Bài 1: Các thao tác trên Mảng 1 chiều");
                Console.WriteLine("2. Bài 2: Bubble Sort & Tim kiem tuyen tinh (Linear Search)");
                Console.WriteLine("3. Bài 3: Thao tác trên Ma trận N x M (Mảng 2 chiều)");
                Console.WriteLine("0. Thoát chương trình");
                Console.WriteLine("==================================================");
                Console.Write("Mời bạn chọn bài tập (0-3): ");

                string choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        ChayBai1();
                        break;
                    case "2":
                        ChayBai2();
                        break;
                    case "3":
                        ChayBai3();
                        break;
                    case "0":
                        Console.WriteLine("Đã thoát chương trình. Tạm biệt!");
                        return;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ! Nhấn phím bất kỳ để chọn lại.");
                        break;
                }

                Console.WriteLine("\nNhấn phím bất kỳ để quay lại Menu...");
                Console.ReadKey();
            }
        }

        #region BÀI 1: CÁC THAO TÁC TRÊN MẢNG 1 CHIỀU
        static void ChayBai1()
        {
            Console.WriteLine("--- BÀI 1: CÁC THAO TÁC TRÊN MẢNG 1 CHIỀU ---");

            Random rand = new Random();
            int[] arr = new int[10];
            for (int i = 0; i < arr.Length; i++) arr[i] = rand.Next(1, 21);

            Console.WriteLine("Mảng ngẫu nhiên ban đầu: " + string.Join(", ", arr));
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("1. Giá trị trung bình của mảng: " + TinhTrungBinh(arr));

            int valueToFind = 5;
            Console.WriteLine($"2. Mảng có chứa số {valueToFind} không? " + KiemTraTontai(arr, valueToFind));
            Console.WriteLine($"3. Vị trí (index) đầu tiên của số {valueToFind}: " + TimViTri(arr, valueToFind));

            int[] arrDaXoa = XoaPhanTu(arr, valueToFind);
            Console.WriteLine($"4. Mảng sau khi xóa số {valueToFind} đầu tiên: " + string.Join(", ", arrDaXoa));

            TimMinMax(arr, out int min, out int max);
            Console.WriteLine($"5. Giá trị Nhỏ nhất (Min): {min}, Lớn nhất (Max): {max}");

            int[] arrDaoNguoc = DaoNguocMang(arr);
            Console.WriteLine("6. Mảng sau khi đảo ngược: " + string.Join(", ", arrDaoNguoc));

            Console.Write("7. Các giá trị bị trùng lặp trong mảng: ");
            TimPhanTuTrungLap(arr);

            int[] arrDuyNhat = XoaPhanTuTrungLap(arr);
            Console.WriteLine("8. Mảng sau khi loại bỏ các phần tử trùng lặp: " + string.Join(", ", arrDuyNhat));
        }

        static double TinhTrungBinh(int[] arr)
        {
            int sum = 0;
            foreach (int x in arr) sum += x;
            return (double)sum / arr.Length;
        }

        static bool KiemTraTontai(int[] arr, int val)
        {
            foreach (int x in arr)
                if (x == val) return true;
            return false;
        }

        static int TimViTri(int[] arr, int val)
        {
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] == val) return i;
            return -1;
        }

        static int[] XoaPhanTu(int[] arr, int val)
        {
            int index = TimViTri(arr, val);
            if (index == -1) return arr;

            int[] newArr = new int[arr.Length - 1];
            for (int i = 0, j = 0; i < arr.Length; i++)
            {
                if (i == index) continue;
                newArr[j++] = arr[i];
            }
            return newArr;
        }

        static void TimMinMax(int[] arr, out int min, out int max)
        {
            min = arr[0];
            max = arr[0];
            foreach (int x in arr)
            {
                if (x < min) min = x;
                if (x > max) max = x;
            }
        }

        static int[] DaoNguocMang(int[] arr)
        {
            int[] result = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
                result[i] = arr[arr.Length - 1 - i];
            return result;
        }

        static void TimPhanTuTrungLap(int[] arr)
        {
            bool coTrung = false;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        Console.Write(arr[i] + " ");
                        coTrung = true;
                        break;
                    }
                }
            }
            if (!coTrung) Console.Write("Không có phần tử trùng lặp.");
            Console.WriteLine();
        }

        static int[] XoaPhanTuTrungLap(int[] arr)
        {
            return arr.Distinct().ToArray();
        }
        #endregion

        #region BÀI 2: BUBBLE SORT & TÌM KIẾM TUYẾN TÍNH
        static void ChayBai2()
        {
            Console.WriteLine("--- BÀI 2: BUBBLE SORT & TÌM KIẾM TUYẾN TÍNH ---");

            int[] numbers = new int[10];
            Console.WriteLine("1. SẮP XẾP BUBBLE SORT:");
            Console.WriteLine("Vui lòng nhập vào 10 số nguyên:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Số thứ {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = 0; j < numbers.Length - 1 - i; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("Mảng sau khi sắp xếp tăng dần: " + string.Join(", ", numbers));

            Console.WriteLine("\n2. TÌM KIẾM TUYẾN TÍNH (LINEAR SEARCH):");
            Console.Write("Nhập một câu văn bất kỳ: ");
            string sentence = Console.ReadLine();

            Console.Write("Nhập từ bạn muốn tìm kiếm trong câu: ");
            string word = Console.ReadLine();

            string[] words = sentence.Split(new char[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            bool found = false;
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Equals(word, StringComparison.OrdinalIgnoreCase))
                {
                    found = true;
                    break;
                }
            }

            if (found)
                Console.WriteLine($"=> Kết quả: Từ '{word}' CÓ xuất hiện trong câu.");
            else
                Console.WriteLine($"=> Kết quả: Từ '{word}' KHÔNG xuất hiện trong câu.");
        }
        #endregion

        #region BÀI 3: THAO TÁC TRÊN MA TRẬN N x M
        static void ChayBai3()
        {
            Console.WriteLine("--- BÀI 3: THAO TÁC TRÊN MA TRẬN N x M ---");
            Console.Write("Nhập số hàng N: ");
            int N = int.Parse(Console.ReadLine());
            Console.Write("Nhập số cột M: ");
            int M = int.Parse(Console.ReadLine());

            int[,] matrix = TaoMaTranNgauNhien(N, M);

            Console.WriteLine("\n--- MA TRẬN ĐƯỢC TẠO NGẪU NHIÊN ---");
            InMaTran(matrix);

            Console.Write($"\nNhập chỉ số hàng i muốn in (0 đến {N - 1}): ");
            int rIndex = int.Parse(Console.ReadLine());
            InHang(matrix, rIndex);

            Console.Write($"Nhập chỉ số cột i muốn in (0 đến {M - 1}): ");
            int cIndex = int.Parse(Console.ReadLine());
            InCot(matrix, cIndex);

            Console.WriteLine($"\nGiá trị lớn nhất (Max) trong toàn bộ ma trận: {TimMaxMaTran(matrix)}");

            Console.WriteLine($"Giá trị nhỏ nhất (Min) của hàng {rIndex}: {TimMinHang(matrix, rIndex)}");
            Console.WriteLine($"Giá trị nhỏ nhất (Min) của cột {cIndex}: {TimMinCot(matrix, cIndex)}");

            Console.WriteLine("\n--- MA TRẬN CHUYỂN VỊ (TRANSPOSE) ---");
            int[,] transposed = ChuyenViMaTran(matrix);
            InMaTran(transposed);

            if (N == M)
            {
                Console.WriteLine("\n--- CÁC ĐƯỜNG CHÉO (MA TRẬN VUÔNG) ---");
                InDuongCheo(matrix);
            }
            else
            {
                Console.WriteLine("\n(Vì N != M nên đây không phải ma trận vuông -> Không có đường chéo)");
            }
        }

        static int[,] TaoMaTranNgauNhien(int r, int c)
        {
            Random rand = new Random();
            int[,] mat = new int[r, c];
            for (int i = 0; i < r; i++)
                for (int j = 0; j < c; j++)
                    mat[i, j] = rand.Next(1, 100);
            return mat;
        }

        static void InMaTran(int[,] mat)
        {
            int r = mat.GetLength(0);
            int c = mat.GetLength(1);
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                    Console.Write($"{mat[i, j],5}");
                Console.WriteLine();
            }
        }

        static void InHang(int[,] mat, int row)
        {
            Console.Write($"Các phần tử thuộc hàng {row}: ");
            for (int j = 0; j < mat.GetLength(1); j++)
                Console.Write(mat[row, j] + " ");
            Console.WriteLine();
        }

        static void InCot(int[,] mat, int col)
        {
            Console.Write($"Các phần tử thuộc cột {col}: ");
            for (int i = 0; i < mat.GetLength(0); i++)
                Console.Write(mat[i, col] + " ");
            Console.WriteLine();
        }

        static int TimMaxMaTran(int[,] mat)
        {
            int max = mat[0, 0];
            foreach (int val in mat)
                if (val > max) max = val;
            return max;
        }

        static int TimMinHang(int[,] mat, int row)
        {
            int min = mat[row, 0];
            for (int j = 1; j < mat.GetLength(1); j++)
                if (mat[row, j] < min) min = mat[row, j];
            return min;
        }

        static int TimMinCot(int[,] mat, int col)
        {
            int min = mat[0, col];
            for (int i = 1; i < mat.GetLength(0); i++)
                if (mat[i, col] < min) min = mat[i, col];
            return min;
        }

        static int[,] ChuyenViMaTran(int[,] mat)
        {
            int r = mat.GetLength(0);
            int c = mat.GetLength(1);
            int[,] result = new int[c, r];

            for (int i = 0; i < r; i++)
                for (int j = 0; j < c; j++)
                    result[j, i] = mat[i, j];

            return result;
        }

        static void InDuongCheo(int[,] mat)
        {
            int size = mat.GetLength(0);
            Console.Write("Đường chéo chính: ");
            for (int i = 0; i < size; i++) Console.Write(mat[i, i] + " ");

            Console.Write("\nĐường chéo phụ: ");
            for (int i = 0; i < size; i++) Console.Write(mat[i, size - 1 - i] + " ");
            Console.WriteLine();
        }
        #endregion
    }
}
}
