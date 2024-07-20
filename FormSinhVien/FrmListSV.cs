using System.Collections.Generic;
using System.Windows.Forms;

namespace FormSinhVien
{
    public partial class FrmListSV : Form
    {
        BindingSource listSVBindingSource;
        List<SinhVien> listSV;
        public FrmListSV()
        {

            InitializeComponent();
        }

        private void FrmListSV_Load(object sender, System.EventArgs e)
        {
            listSVBindingSource = new BindingSource();
            listSV = QLSV.GetListSV();
            listSVBindingSource.DataSource = listSV;
            dgvListSV.DataSource = listSVBindingSource;
        }

        private void btnXoa_Click(object sender, System.EventArgs e)
        {
            int id = 0;
            int rowIndex = dgvListSV.SelectedRows[0].Index;
            int colunmIndex = 0;
            id = (int)dgvListSV.Rows[rowIndex].Cells[colunmIndex].Value;
            bool isDeletedSuccess = QLSV.XoaSVTheoID(id);
            if (isDeletedSuccess)
            {
                MessageBox.Show("Xóa Sinh Viên Thành Công");
            }
            else
            {
                MessageBox.Show("Xóa Không Thành Công");
            }
            dgvListSV.DataSource = QLSV.GetListSV();
        }

        private void btnTimKiem_Click(object sender, System.EventArgs e)
        {
            double fromDTB = double.Parse(txtFromDTB.Text);
            double toDTB = double.Parse(txtToDTB.Text);
            List<SinhVien> listNewSV = new List<SinhVien>();
            foreach (SinhVien sinhVien in listSV)
            {
                if (sinhVien.TinhDTB() >= fromDTB && sinhVien.TinhDTB() <= toDTB)
                {
                    listNewSV.Add(sinhVien);
                }
            }
            listSVBindingSource.DataSource = listNewSV;
            dgvListSV.DataSource = listSVBindingSource;
        }

        private void dgvListSV_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
