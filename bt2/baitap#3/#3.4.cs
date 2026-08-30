using System;





{ 

    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Nhập tọa độ X: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Nhập tọa độ Y: ");
            int y = int.Parse(Console.ReadLine());

            if (x > 0 && y > 0)
                Console.WriteLine($"Tọa độ ({x},{y}) nằm ở góc phần tư thứ I.");
            else if (x < 0 && y > 0)
                Console.WriteLine($"Tọa độ ({x},{y}) nằm ở góc phần tư thứ II.");
            else if (x < 0 && y < 0)
                Console.WriteLine($"Tọa độ ({x},{y}) nằm ở góc phần tư thứ III.");
            else if (x > 0 && y < 0)
                Console.WriteLine($"Tọa độ ({x},{y}) nằm ở góc phần tư thứ IV.");
            else if (x == 0 && y == 0)
                Console.WriteLine($"Tọa độ ({x},{y}) nằm tại gốc tọa độ (O).");
            else if (x == 0)
                Console.WriteLine($"Tọa độ ({x},{y}) nằm trên trục tung (Oy).");
            else
                Console.WriteLine($"Tọa độ ({x},{y}) nằm trên trục hoành (Ox).");
        }
    }
}

