namespace Book
{
    //Lớp cơ sở Book:
    //Thuộc tính: Title(tên sách), Author(tác giả), ISBN(mã số sách quốc tế).
    //Phương thức: DisplayInfo() để hiển thị thông tin sách.
    //Các lớp kế thừa:


    //Danh sách sách:
    //Tạo danh sách chứa các đối tượng sách khác nhau(bao gồm cả sách điện tử và sách in).
    //Sử dụng tính đa hình để hiển thị thông tin của tất cả các sách trong danh sách.
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int ISBN { get; set; }

        public virtual void DisplayInfo()
        {
            Console.WriteLine("BookName " + this.Title);
            Console.WriteLine("AuthorName " + this.Author);
            Console.WriteLine("InternalNumber " + this.ISBN);

        }
    }
}
