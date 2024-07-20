using System;
using System.Windows.Forms;

/*
Tạo 1 class sinh viên với các thuộc tính maSV,tenSV, lopSV, diemToan, diemLy, diemHoa và 
các phương thức in thông tin của sinh viên, tính trung bình điểm của sinh viên 

Tạo 1 class QlSV với các phương thức hiện thêm sinh viên, xóa sinh viên theo id, tìm kiếm sinh viên theo khoảng điểm trung bình 

validate dữ liệu của sinh viên và sinh viên không được trùng id. Tạo các control để thực hiện các thao tác trên

       Tìm hiểu trước : TextField, gridview, button, dialogwindowform


*/

namespace FormSinhVien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLuaChon_Click(object sender, EventArgs e)
        {
            switch (txtLuaChon.Text)

            {
                case "1":
                    FrmAddSinhVien frmAdd = new FrmAddSinhVien();
                    frmAdd.ShowDialog();

                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
                    FrmListSV frmList = new FrmListSV();
                    frmList.ShowDialog();
                    break;
                default:
                    break;
            }
        }
    }
}
