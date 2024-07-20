

class MyClass
{

    static void Main()
    {
        //    Viết hàm tính diện tích và chu vi hình chữ nhật.
        //    Viết hàm kiểm tra số nguyên tố.
        //    Viết hàm tính giai thừa của một số nguyên.
        //    Viết lớp MathOperations với các phương thức tính tổng, hiệu, tích, thương của hai số..
        long x = 17;
        Console.WriteLine(GiaiThua(x));

    }
    public static int GiaiThua(long x)
    {
        int tong = 1;
        for (int i = 1; i <= x; i++)
        {
            tong = tong * i;
        }
        return tong;
    }


}






