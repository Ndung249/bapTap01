//Viết lớp Book với các thuộc tính tên sách, tác giả, giá và phương thức in thông tin sách.
namespace BaiTapOOP
{
    public class Sach
    {
        public string TenSach { get; set; }
        public string TacGia { get; set; }
        public double GiaBan { get; set; }

        public Sach(string tenSach, string tacGia, double giaBan)
        {
            this.TenSach = tenSach;
            this.GiaBan = giaBan;
            this.TacGia = tacGia;

        }
        //overLoading
        public Sach()
        {
            this.TenSach = "";
            this.TacGia = "";
            this.GiaBan = 3;
        }
        public Sach(string tenSach)
        {
            this.TenSach = tenSach;
        }
        public void In()
        {
            Console.WriteLine(this.TenSach);
            Console.WriteLine(this.TacGia);
            Console.WriteLine(this.GiaBan);
        }
        public void In(double currentPrice)
        {
            if (currentPrice <= this.GiaBan)
            {
                Console.WriteLine(currentPrice);

            }

        }

    }

}
