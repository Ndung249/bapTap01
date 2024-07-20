namespace FormSinhVien3
{
    /*
      Tạo Class SinhVien với các thuộc tính Mã Sinh Viên, Tên Sinh Viên, Mã Lớp, Điểm Toán, Lý, Hóa
        Tạo Class Lớp Học với các thuộc tính Mã Lớp, Tên Lớp
    Yêu Cầu chức năng
    Hiển thị danh sách sinh viên theo lớp và hiểm thị loại sinh viên (Giỏi, Khá, Trung Bình, Yếu)
    Thêm sinh viên
    Xóa Sinh Viên theo Id
    Sửa sinh viên
     */
    public class SinhVien
    {
        public int MaSV { get; set; }
        public string TenSV { get; set; }
        public int MaLop { get; set; }
        public double DiemToan { get; set; }
        public double DiemLy { get; set; }
        public double DiemHoa { get; set; }
    }
}
