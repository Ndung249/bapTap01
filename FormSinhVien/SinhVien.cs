namespace FormSinhVien
{
    public class SinhVien
    {
        public int MaSV { get; set; }
        public string TenSV { get; set; }
        public string LopSV { get; set; }
        public double DiemToan { get; set; }
        public double DiemLy { get; set; }
        public double DiemHoa { get; set; }
        public double TinhDTB()
        {
            return (DiemToan + DiemLy + DiemHoa) / 3;
        }
    }
}
