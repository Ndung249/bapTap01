namespace List2_OOP_
{
    public class SinhVien
    {
        public int MaSV { get; set; }
        public string TenSV { get; set; }
        public string LopSV { get; set; }
        public double DiemToan { get; set; }
        public double DiemLy { get; set; }
        public double DiemHoa { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine("Ma sinh vien la: " + this.MaSV);
            Console.WriteLine("Ten sinh vien la: " + this.TenSV);
            Console.WriteLine("Lop sinh vien la: " + this.LopSV);

        }
        public double TinhDTB()
        {
            return (DiemHoa + DiemToan + DiemLy) / 3;
        }
    }
}
