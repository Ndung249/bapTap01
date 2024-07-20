namespace BaiTapOOP
{
    public class HinhChuNhat : Hinh
    {
        public double ChieuDai { get; set; }
        public double ChieuRong { get; set; }
        public override double TinhDienTich()
        {
            return ChieuDai * ChieuRong;
        }
    }
}
