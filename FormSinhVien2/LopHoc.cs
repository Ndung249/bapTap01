using System.Collections.Generic;

namespace FormSinhVien2
{
    public abstract class LopHoc
    {
        public int MaLop { get; set; }
        public abstract string TenLop { get; set; }
        private static List<SinhVien> listSV = new List<SinhVien>()
        {

        };
        public static bool AddSV(SinhVien sv)
        {
            listSV.Add(sv);
            return true;
        }
        public static List<SinhVien> GetListSV() { return listSV; }

    }
}
