using System;
using System.Windows.Forms;

namespace FormSinhVien3
{
    public partial class AddSinhVien : Form
    {
        public AddSinhVien()
        {
            InitializeComponent();
        }

        private void AddSinhVien_Load(object sender, EventArgs e)
        {
            cboLop.DataSource = QLSV.GetLopHocs();
            cboLop.ValueMember = "Ma Lop";
            cboLop.DisplayMember = "TenLop";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            int maSV = int.Parse(txtMSV.Text);
            // Kiểm tra trùng lặp mã sinh viên trong danh sách sinh viên
            foreach (var sinhVien in QLSV.GetSinhViens())
            {
                if (sinhVien.MaSV == maSV)
                {
                    MessageBox.Show("Mã sinh viên đã tồn tại!, vui lòng thử lại");
                    txtMSV.Focus();
                    return;
                }
            }

            string tenSV = txtTenSV.Text;
            int maLop = (int)cboLop.SelectedValue;
            double diemToan = double.Parse(txtDiemToan.Text);
            double diemLy = double.Parse(txtDiemLy.Text);
            double diemHoa = double.Parse(txtDiemHoa.Text);

            SinhVien createSinhVien = new SinhVien()
            {
                MaSV = maSV,
                MaLop = maLop,
                DiemHoa = diemHoa,
                DiemLy = diemLy,
                DiemToan = diemToan,
                TenSV = tenSV
            };

            bool isCreatedSuccess = QLSV.AddSinhVien(createSinhVien);
            if (isCreatedSuccess)
            {
                Form1.bindingSourceSinhVien.DataSource = QLSV.GetSinhViens();
                this.Dispose();
            }

        }
    }
}
