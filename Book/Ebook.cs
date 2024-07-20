namespace Book
{
    //Lớp Ebook kế thừa từ Book:
    //Thuộc tính bổ sung: FileSize (kích thước tệp), Format(định dạng tệp).
    //Phương thức DisplayInfo() được ghi đè để hiển thị thông tin sách điện tử.

    public class Ebook : Book
    {
        public double FileSize { get; set; }
        public string Format { get; set; }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Kich thuoc tep  " + this.FileSize);
            Console.WriteLine("Dinh dang tep  " + this.Format);
        }
    }
}
