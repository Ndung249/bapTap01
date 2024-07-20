namespace BaiTapOOP
{
    public class HinhTron : Hinh
    {
        public double BanKinh { get; set; }
        public override double TinhDienTich()
        {
            return BanKinh * BanKinh * Math.PI;
        }
    }
}
