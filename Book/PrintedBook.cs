namespace Book
{
    internal class PrintedBook : Book
    {
        //Lớp PrintedBook kế thừa từ Book:
        //Thuộc tính bổ sung: PageCount(số trang), Publisher(nhà xuất bản).
        //Phương thức DisplayInfo() được ghi đè để hiển thị thông tin sách in.
        public double PageCount { get; set; }
        public string Publisher { get; set; }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("So trang  " + this.PageCount);
            Console.WriteLine("Nha xuat ban  " + this.Publisher);
        }
    }
}
