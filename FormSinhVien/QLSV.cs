using System.Collections.Generic;

namespace FormSinhVien
{
    public static class QLSV
    {
        private static List<SinhVien> listSV = new List<SinhVien>()
        {
            new SinhVien()
            {
                DiemHoa=1,
                DiemLy=1,
                DiemToan=1,
                LopSV="11",
                MaSV=1,
                TenSV = "1",
            }
        };
        public static bool AddSV(SinhVien sv)
        {
            listSV.Add(sv);
            return true;
        }
        public static List<SinhVien> GetListSV() { return listSV; }
        public static bool XoaSVTheoID(int id)
        {
            foreach (SinhVien sv in listSV)
            {
                if (sv.MaSV == id)
                {
                    listSV.Remove(sv);
                    return true;
                }
            }
            return true;
        }

    }
}
