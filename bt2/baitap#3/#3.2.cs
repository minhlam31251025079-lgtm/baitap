using System;


{
	{
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Nhập số thứ nhất: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Nhập số thứ hai: ");
        int num2 = int.Parse(Console.ReadLine());
        Console.Write("Nhập số thứ ba: ");
        int num3 = int.Parse(Console.ReadLine());

        int max = num1;
        if (num2 > max) max = num2;
        if (num3 > max) max = num3;

        Console.WriteLine($"Số thứ nhất là: {num1}");
        Console.WriteLine($"Số thứ hai là: {num2}");
        Console.WriteLine($"Số thứ ba là: {num3}");
        Console.WriteLine($"Số lớn nhất trong ba số là: {max}");
    }
}
