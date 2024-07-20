using System;
using System.Windows.Forms;

namespace FormSinhVien2
{
    public partial class FrmAddSinhVien : Form
    {
        public FrmAddSinhVien()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            bool isValidMaSV = int.TryParse(txtMaSV.Text, out int masv);
            if (!isValidMaSV)
            {
                MessageBox.Show("Sai ma sinh vien roi!!");
                return;
            }
            if (string.IsNullOrEmpty(txtTenSV.Text))
            {
                MessageBox.Show("Khong duoc de trong ten!!!!");
                return;
            }
            if (string.IsNullOrEmpty(txtMaLop.Text))
            {
                MessageBox.Show("Khong duoc de trong lop!!!!");
                return;
            }
            bool isValidDiemToan = int.TryParse(txtDiemToan.Text, out int diemToan);
            if (!isValidDiemToan)
            {
                MessageBox.Show("Sai dinh dang roi!!");
                return;
            }
            if (diemToan < 0 || diemToan > 10)
            {
                MessageBox.Show("Diem khong ton tai!!");
                return;
            }

            bool isValidDiemLy = int.TryParse(txtDiemLy.Text, out int diemLy);
            if (!isValidDiemLy)
            {
                MessageBox.Show("Sai dinh dang roi!!");
                return;
            }
            if (diemLy < 0 || diemLy > 10)
            {
                MessageBox.Show("Diem khong ton tai!!");
                return;
            }

            bool isValidDiemHoa = int.TryParse(txtDiemHoa.Text, out int diemHoa);
            if (!isValidDiemHoa)
            {
                MessageBox.Show("Sai dinh dang roi!!");
                return;
            }
            if (diemHoa < 0 || diemHoa > 10)
            {
                MessageBox.Show("Diem khong ton tai!!");
                return;
            }
            SinhVien sinhVien = new SinhVien()
            {
                MaSV = masv,
                TenSV = txtTenSV.Text,
                MaLop = txtMaLop.Text,
                DiemToan = diemToan,
                DiemLy = diemLy,
                DiemG = diemHoa,
            };
            bool isSucess = LopHoc.AddSV(sinhVien);
            if (isSucess)
            {
                MessageBox.Show("Da them thanh cong");
            }
        }
    }
}
