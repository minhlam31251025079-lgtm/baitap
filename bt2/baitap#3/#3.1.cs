using System;





{ 
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Nhập vào một số nguyên: ");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
                Console.WriteLine($"{num} là số chẵn.");
            else
                Console.WriteLine($"{num} là số lẻ.");
        }
    }
}

