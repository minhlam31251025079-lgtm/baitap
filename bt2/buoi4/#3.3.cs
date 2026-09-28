using System;


    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Nhập cạnh thứ 1 của tam giác: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Nhập cạnh thứ 2 của tam giác: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Nhập cạnh thứ 3 của tam giác: ");
        int c = int.Parse(Console.ReadLine());

        if (a + b > c && a + c > b && b + c > a)
        {
            if (a == b && b == c)
                Console.WriteLine("Đây là tam giác đều.");
            else if (a == b || a == c || b == c)
                Console.WriteLine("Đây là tam giác cân.");
            else
                Console.WriteLine("Đây là tam giác thường.");
        }
        else
        {
            Console.WriteLine("Ba độ dài này không thể tạo thành một tam giác.");
        }
    }

