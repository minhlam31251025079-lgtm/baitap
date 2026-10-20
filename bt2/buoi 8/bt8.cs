

    
using System.IO;
using System.Linq;
using System.Text;

namespace BaiTap8
{
    class Program
    {
        static string Dir = Path.Combine(AppContext.BaseDirectory, "BaiTap8_Data");
        static string P(string name) => Path.Combine(Dir, name);

        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Directory.CreateDirectory(Dir);

            while (true)
            {
                Console.WriteLine("\n===== BÀI TẬP #8 - FILE I/O =====");
                Console.WriteLine("1. Tạo file rỗng");
                Console.WriteLine("2. Xóa file");
                Console.WriteLine("3. Tạo file và ghi text");
                Console.WriteLine("4. Tạo file text và đọc");
                Console.WriteLine("5. Ghi mảng chuỗi vào file");
                Console.WriteLine("6. Ghi nối (append) text vào file");
                Console.WriteLine("7. Copy file sang tên khác và hiển thị nội dung");
                Console.WriteLine("8. Đổi tên (move) file trong cùng thư mục");
                Console.WriteLine("9. Đọc dòng đầu của file");
                Console.WriteLine("10. Tạo file và đọc dòng cuối");
                Console.WriteLine("11. Đọc n dòng cuối của file");
                Console.WriteLine("12. Đọc một dòng cụ thể");
                Console.WriteLine("13. Đếm số dòng của file");
                Console.WriteLine("14. In cấu trúc thư mục (gồm file)");
                Console.WriteLine("15. Thống kê ký tự và chữ số trong file");
                Console.WriteLine("0. Thoát");
                Console.Write("Chọn: ");

                if (!int.TryParse(Console.ReadLine(), out int c)) continue;
                if (c == 0) break;

                try
                {
                    switch (c)
                    {
                        case 1: Bai1(); break;
                        case 2: Bai2(); break;
                        case 3: Bai3(); break;
                        case 4: Bai4(); break;
                        case 5: Bai5(); break;
                        case 6: Bai6(); break;
                        case 7: Bai7(); break;
                        case 8: Bai8(); break;
                        case 9: Bai9(); break;
                        case 10: Bai10(); break;
                        case 11: Bai11(); break;
                        case 12: Bai12(); break;
                        case 13: Bai13(); break;
                        case 14: Bai14(); break;
                        case 15: Bai15(); break;
                        default: Console.WriteLine("Lựa chọn không hợp lệ."); break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lỗi: " + ex.Message);
                }
            }
        }

        static string TaoFileMau(string name = "mau.txt")
        {
            string path = P(name);
            File.WriteAllLines(path, new[]
            {
                "Dong 1: Hello C# 2026",
                "Dong 2: Xin chao",
                "Dong 3: File I/O 123",
                "Dong 4: Bai tap so 8",
                "Dong 5: Het"
            });
            return path;
        }

        static void Bai1()
        {
            string path = P("rong.txt");
            File.Create(path).Close();
            Console.WriteLine("Đã tạo file rỗng: " + path);
        }

        static void Bai2()
        {
            string path = P("xoa.txt");
            File.WriteAllText(path, "file tam");
            if (File.Exists(path))
            {
                File.Delete(path);
                Console.WriteLine("Đã xóa file: " + path);
            }
        }

        static void Bai3()
        {
            string path = P("ghi.txt");
            File.WriteAllText(path, "Xin chào, đây là nội dung đầu tiên.");
            Console.WriteLine("Đã ghi text vào: " + path);
        }

        static void Bai4()
        {
            string path = P("doc.txt");
            File.WriteAllText(path, "Dòng A\nDòng B\nDòng C");
            Console.WriteLine("Nội dung file:");
            Console.WriteLine(File.ReadAllText(path));
        }

        static void Bai5()
        {
            string path = P("mang.txt");
            string[] ds = { "An", "Bình", "Cường", "Dũng" };
            File.WriteAllLines(path, ds);
            Console.WriteLine("Đã ghi mảng chuỗi. Đọc lại:");
            foreach (string s in File.ReadAllLines(path))
                Console.WriteLine(s);
        }

        static void Bai6()
        {
            string path = P("noi.txt");
            File.WriteAllText(path, "Dòng gốc" + Environment.NewLine);
            File.AppendAllText(path, "Dòng được thêm vào" + Environment.NewLine);
            Console.WriteLine("Sau khi append:");
            Console.WriteLine(File.ReadAllText(path));
        }

        static void Bai7()
        {
            string src = P("goc.txt");
            string dst = P("goc_copy.txt");
            File.WriteAllText(src, "Nội dung file gốc.\nDòng thứ hai.");
            File.Copy(src, dst, true);
            Console.WriteLine("Nội dung file đã copy (" + dst + "):");
            Console.WriteLine(File.ReadAllText(dst));
        }

        static void Bai8()
        {
            string src = P("cu.txt");
            string dst = P("moi.txt");
            File.WriteAllText(src, "File sẽ được đổi tên");
            if (File.Exists(dst)) File.Delete(dst);
            File.Move(src, dst);
            Console.WriteLine("Đã đổi tên cu.txt -> moi.txt");
            Console.WriteLine("cu.txt còn tồn tại? " + File.Exists(src));
            Console.WriteLine("moi.txt tồn tại? " + File.Exists(dst));
        }

        static void Bai9()
        {
            string path = TaoFileMau();
            string dong = File.ReadLines(path).FirstOrDefault();
            Console.WriteLine("Dòng đầu: " + dong);
        }

        static void Bai10()
        {
            string path = TaoFileMau();
            string dong = File.ReadAllLines(path).LastOrDefault();
            Console.WriteLine("Dòng cuối: " + dong);
        }

        static void Bai11()
        {
            string path = TaoFileMau();
            string[] lines = File.ReadAllLines(path);
            Console.Write("Nhập n: ");
            if (!int.TryParse(Console.ReadLine(), out int n) || n < 0)
            {
                Console.WriteLine("n không hợp lệ.");
                return;
            }
            int batDau = Math.Max(0, lines.Length - n);
            Console.WriteLine($"{Math.Min(n, lines.Length)} dòng cuối:");
            for (int i = batDau; i < lines.Length; i++)
                Console.WriteLine(lines[i]);
        }

        static void Bai12()
        {
            string path = TaoFileMau();
            string[] lines = File.ReadAllLines(path);
            Console.Write($"Nhập số dòng cần đọc (1..{lines.Length}): ");
            if (int.TryParse(Console.ReadLine(), out int k) && k >= 1 && k <= lines.Length)
                Console.WriteLine($"Dòng {k}: {lines[k - 1]}");
            else
                Console.WriteLine("Số dòng không hợp lệ.");
        }

        static void Bai13()
        {
            string path = TaoFileMau();
            int dem = 0;
            using (StreamReader sr = new StreamReader(path))
            {
                while (sr.ReadLine() != null)
                    dem++;
            }
            Console.WriteLine("Số dòng của file: " + dem);
        }

        static void Bai14()
        {
            Directory.CreateDirectory(P("demo/con1"));
            Directory.CreateDirectory(P("demo/con2/chau"));
            File.WriteAllText(P("demo/a.txt"), "a");
            File.WriteAllText(P("demo/con1/b.txt"), "b");
            File.WriteAllText(P("demo/con2/chau/c.txt"), "c");

            Console.Write("Nhập đường dẫn thư mục (Enter = thư mục demo): ");
            string path = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(path)) path = P("demo");

            if (!Directory.Exists(path))
            {
                Console.WriteLine("Thư mục không tồn tại.");
                return;
            }
            Console.WriteLine("[" + Path.GetFileName(path) + "]");
            InCay(path, "");
        }

        static void InCay(string thuMuc, string tienTo)
        {
            string[] dirs = Directory.GetDirectories(thuMuc);
            string[] files = Directory.GetFiles(thuMuc);
            int tong = dirs.Length + files.Length;
            int i = 0;

            foreach (string d in dirs)
            {
                i++;
                bool cuoi = (i == tong);
                Console.WriteLine(tienTo + (cuoi ? "└── " : "├── ") + "[" + Path.GetFileName(d) + "]");
                InCay(d, tienTo + (cuoi ? "    " : "│   "));
            }
            foreach (string f in files)
            {
                i++;
                bool cuoi = (i == tong);
                Console.WriteLine(tienTo + (cuoi ? "└── " : "├── ") + Path.GetFileName(f));
            }
        }

        static int Idx(char ch)
        {
            ch = char.ToLower(ch);
            if (ch >= 'a' && ch <= 'z') return ch - 'a';
            if (ch >= '0' && ch <= '9') return 26 + (ch - '0');
            return -1;
        }

        static char TenKyTu(int idx) => idx < 26 ? (char)('a' + idx) : (char)('0' + idx - 26);

        static void Bai15()
        {
            string path = P("thongke.txt");
            File.WriteAllLines(path, new[]
            {
                "Hello World 2026",
                "C# la ngon ngu lap trinh",
                "So dien thoai: 0123456789",
                "abc ABC 111"
            });
            string[] lines = File.ReadAllLines(path);

            int[,] cnt = new int[2, 26];
            foreach (string line in lines)
                foreach (char ch in line)
                {
                    int k = Idx(ch);
                    if (k < 0) continue;
                    if (k < 26) cnt[0, k]++;
                    else cnt[1, k - 26]++;
                }

            int[][] dong = new int[36][];
            int[][] cot = new int[36][];
            for (int k = 0; k < 36; k++)
            {
                int n = k < 26 ? cnt[0, k] : cnt[1, k - 26];
                dong[k] = new int[n];
                cot[k] = new int[n];
            }

            int[] vt = new int[36];
            for (int i = 0; i < lines.Length; i++)
            {
                for (int j = 0; j < lines[i].Length; j++)
                {
                    int k = Idx(lines[i][j]);
                    if (k < 0) continue;
                    dong[k][vt[k]] = i + 1;
                    cot[k][vt[k]] = j + 1;
                    vt[k]++;
                }
            }

            Console.WriteLine("Nội dung file:");
            foreach (string l in lines)
                Console.WriteLine("  " + l);

            Console.WriteLine("\nKý tự | Số lần | Vị trí (dòng,cột)");
            for (int k = 0; k < 36; k++)
            {
                if (dong[k].Length == 0) continue;
                var vitri = dong[k].Select((d, t) => "(" + d + "," + cot[k][t] + ")");
                Console.WriteLine("  " + TenKyTu(k) + "   |   " + dong[k].Length + "   | " + string.Join(" ", vitri));
            }
            Console.WriteLine("\n(Chữ cái không phân biệt hoa/thường)");
        }
    }
}

