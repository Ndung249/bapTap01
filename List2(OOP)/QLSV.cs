namespace List2_OOP_
{
    //Tạo 1 class QlSV với các phương thức hiện menu lựa chọn, thêm sinh viên, xóa sinh viên theo id, tìm kiếm sinh viên theo điểm trung bình 

    //validate dữ liệu của sinh viên và sinh viên không được trùng id.
    public class QLSV
    {
        private List<SinhVien> dsSinhVien = new List<SinhVien>();

        public void ShowMenu()
        {

            int luaChon = 0;
            do
            {
                Console.WriteLine("1. Them sinh vien ");
                Console.WriteLine("2. Xoa sinh vien (id)");
                Console.WriteLine("3. Tim kiem sinh vien (diem trung binh)");
                Console.WriteLine("4. Thoat");
                Console.Write("Nhap lua chon 1->3: ");

                bool isValidLC = int.TryParse(Console.ReadLine(), out luaChon);
                switch (luaChon)
                {
                    case 1:
                        {
                            Console.Write("Nhap ma sinh vien: ");
                            bool isValidId = int.TryParse(Console.ReadLine(), out int id);
                            do
                            {

                                if (!isValidId)
                                {
                                    Console.Write("Nhap lai ma sinh vien di: ");
                                    isValidId = int.TryParse(Console.ReadLine(), out id);
                                }


                            } while (!isValidId);
                            do
                            {
                                if (CheckExistsByID(id))
                                {
                                    Console.Write("Ma sinh vien da bi trung, nhap lai: ");
                                    isValidId = int.TryParse(Console.ReadLine(), out id);
                                    do
                                    {

                                        if (!isValidId)
                                        {
                                            Console.Write("Nhap lai ma sinh vien di: ");
                                            isValidId = int.TryParse(Console.ReadLine(), out id);
                                        }


                                    } while (!isValidId);
                                }

                            } while (CheckExistsByID(id));

                            Console.Write("Nhap ten sinh vien: ");
                            string tenSV = Console.ReadLine();
                            do
                            {
                                if (string.IsNullOrEmpty(tenSV))
                                {
                                    Console.Write("Ban can nhap lai ten: ");
                                    tenSV = Console.ReadLine();
                                }
                            } while (string.IsNullOrEmpty(tenSV));
                            Console.Write("Nhap lop sinh vien: ");
                            string lopSV = Console.ReadLine();
                            do
                            {
                                if (string.IsNullOrEmpty(lopSV))
                                {
                                    Console.WriteLine("Can nhap lai lop sinh vien: ");
                                    lopSV = Console.ReadLine();
                                }
                            } while (string.IsNullOrEmpty(lopSV));
                            Console.Write("Nhap diem Toan sinh vien: ");
                            bool isValidDT = double.TryParse(Console.ReadLine(), out double diemToan);
                            do
                            {

                                if (!isValidDT)
                                {
                                    Console.Write("Nhap lai diem toan di: ");
                                    isValidDT = double.TryParse(Console.ReadLine(), out diemToan);
                                }

                            } while (!isValidDT);
                            Console.Write("Nhap diem Ly sinh vien: ");
                            bool isValidDL = double.TryParse(Console.ReadLine(), out double diemLy);
                            do
                            {

                                if (!isValidDL)
                                {
                                    Console.Write("Nhap lai diem ly di: ");
                                    isValidDL = double.TryParse(Console.ReadLine(), out diemLy);
                                }

                            } while (!isValidDL);
                            Console.Write("Nhap diem Hoa sinh vien: ");
                            bool isValidDH = double.TryParse(Console.ReadLine(), out double diemHoa);
                            do
                            {

                                if (!isValidDH)
                                {
                                    Console.Write("Nhap lai diem Hoa di: ");
                                    isValidDH = double.TryParse(Console.ReadLine(), out diemHoa);
                                }

                            } while (!isValidDH);
                            SinhVien xinhZien = new SinhVien()
                            {
                                TenSV = tenSV,
                                MaSV = id,
                                LopSV = lopSV,
                                DiemHoa = diemHoa,
                                DiemLy = diemLy,
                                DiemToan = diemToan,
                            };
                            AddSinhVien(xinhZien);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Nhap id cua sinh vien: ");
                            bool isValidId = int.TryParse(Console.ReadLine(), out int id);
                            do
                            {
                                if (!isValidId)
                                {
                                    Console.Write("Nhap lai id nhe ban yeu: ");
                                    isValidId = int.TryParse(Console.ReadLine(), out id);
                                }

                            } while (!isValidId);
                            DeleteById(id);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Nhap diem trung binh: ");
                            bool isValidDTB = double.TryParse(Console.ReadLine(), out double dTB);
                            do
                            {
                                if (!isValidDTB)
                                {
                                    Console.WriteLine("Can nhap lai diem trung binh: ");
                                    isValidDTB = double.TryParse(Console.ReadLine(), out dTB);
                                }
                            } while (!isValidDTB);
                            FindByDTB(dTB);
                            break;
                        }
                    default:
                        break;

                }
            } while (luaChon != 4);
        }
        private void AddSinhVien(SinhVien sinhVien)
        {
            dsSinhVien.Add(sinhVien);
        }
        private void DeleteById(int id)
        {
            for (int i = 0; i < dsSinhVien.Count; i++)
            {
                if (dsSinhVien[i].MaSV == id)
                {
                    dsSinhVien.Remove(dsSinhVien[i]);
                    return;
                }
            }
        }
        private void FindByDTB(double dTB)
        {
            foreach (SinhVien sinhVien in dsSinhVien)
            {
                if (sinhVien.TinhDTB() == dTB)
                {
                    sinhVien.DisplayInfo();
                    return;
                }
            }
        }
        private bool CheckExistsByID(int id)
        {
            foreach (SinhVien sinhVien in dsSinhVien)
            {
                if (sinhVien.MaSV == id)
                {
                    return true;
                }

            }
            return false;

        }
    }
}
