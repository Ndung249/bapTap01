using System.Collections.Generic;

namespace FormSinhVien3
{
    public static class QLSV
    {
        private static List<SinhVien> sinhviens = new List<SinhVien>
         {
             new SinhVien()
             {
                 TenSV="Tran Nguyen Nhat Dung",
                 MaSV=001,
                 MaLop=2,
                 DiemToan=5,
                 DiemLy=5,
                 DiemHoa=5,
             },
             new SinhVien()
             {

                 TenSV="Tran Nguyen Nhat Tai",
                 MaSV=004,
                 MaLop=1,
                 DiemToan=8,
                 DiemLy=8,
                 DiemHoa=8,
             },
              new SinhVien()
             {

                 TenSV="Tran Thien Tai",
                 MaSV=002,
                 MaLop=1,
                 DiemToan=7,
                 DiemLy=7,
                 DiemHoa=6,
             },
               new SinhVien()
             {

                 TenSV="Tran Van A",
                 MaSV=003,
                 MaLop=2,
                 DiemToan=1,
                 DiemLy=1,
                 DiemHoa=1,
             }
         };
        private static List<LopHoc> lopHocs;
        public static List<SinhVien> GetSinhViens()
        {

            return sinhviens;
        }

        public static List<LopHoc> GetLopHocs()
        {
            lopHocs = new List<LopHoc> { new LopHoc() { TenLop = "Lop Gioi", MaLop = 1 }, new LopHoc() { TenLop = "Lop Ngu", MaLop = 2 } };
            return lopHocs;
        }


        public static bool AddSinhVien(SinhVien sv)
        {
            sinhviens.Add(sv);
            return true;
        }
    }
}
