using System;

class TinhToan
{
    static void Main()
    {
        Console.Write("Nhập số nguyên thứ nhất: ");
        int soThuNhat = int.Parse(Console.ReadLine());

        Console.Write("Nhập số nguyên thứ hai: ");
        int soThuHai = int.Parse(Console.ReadLine());

        int tong = soThuNhat + soThuHai;
        int hieu = soThuNhat - soThuHai;
        int nhan = soThuNhat * soThuHai;
        double chia = soThuNhat / soThuHai;
        double du =soThuHai % soThuHai;

        Console.WriteLine($"Tổng là: {tong}\n Hiệu là: {hieu}\n Nhân là: {nhan}\n Chia là: {chia}\n Du là: {du}");
    }
}
