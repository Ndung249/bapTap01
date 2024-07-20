namespace BaiTapOOP
{
    public class HinhVuong : Hinh
    {
        public double Canh { get; set; }
        public override double TinhDienTich()
        {
            return Canh * Canh;
        }
    }
}
