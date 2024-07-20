using System;

class SoSanh
{
    static void Main()
    {
        Console.Write("Nhập số nguyên thứ nhất: ");
        int soThuNhat = int.Parse(Console.ReadLine());

        Console.Write("Nhập số nguyên thứ hai: ");
        int soThuHai = int.Parse(Console.ReadLine());

        if (soThuNhat > soThuHai)
        {
            Console.WriteLine($"{soThuNhat} lớn hơn {soThuHai}");
        }
        else if (soThuNhat < soThuHai)
        {
            Console.WriteLine($"{soThuNhat} nhỏ hơn {soThuHai}");
        }
        else
        {
            Console.WriteLine($"{soThuNhat} bằng {soThuHai}");
        }
    }
}
