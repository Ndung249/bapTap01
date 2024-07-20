using System.Collections.Generic;
using System.Windows.Forms;

namespace FormSinhVien3
{
    public partial class Form1 : Form
    {
        public static BindingSource bindingSourceSinhVien;
        public Form1()
        {
            InitializeComponent();
            bindingSourceSinhVien = new BindingSource();
        }
        private void Form1_Load(object sender, System.EventArgs e)
        {
            cboLopHoc.DataSource = QLSV.GetLopHocs();
            cboLopHoc.DisplayMember = "TenLop";
            cboLopHoc.ValueMember = "MaLop";

            bindingSourceSinhVien.DataSource = QLSV.GetSinhViens();
            dgvSinhVien.DataSource = bindingSourceSinhVien;
        }

        private void btnLuaChon_Click(object sender, System.EventArgs e)
        {
            int luaChon = int.Parse(txtLuaChon.Text);
            if (luaChon == 1)
            {
                AddSinhVien frmAddSinhVien = new AddSinhVien();
                frmAddSinhVien.ShowDialog();
            }
        }

        private void Form1_Activated(object sender, System.EventArgs e)
        {
            int maLop = (int)cboLopHoc.SelectedValue;
            List<SinhVien> filterSinhViens = new List<SinhVien>();

            foreach (var sinhVien in QLSV.GetSinhViens())
            {
                if (sinhVien.MaLop == maLop)
                {
                    filterSinhViens.Add(sinhVien);
                }
            }

            bindingSourceSinhVien.DataSource = filterSinhViens;
        }

        private void cboLopHoc_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (cboLopHoc.Focused)
            {
                int maLop = (int)cboLopHoc.SelectedValue;
                List<SinhVien> filterSinhViens = new List<SinhVien>();

                foreach (var sinhVien in QLSV.GetSinhViens())
                {
                    if (sinhVien.MaLop == maLop)
                    {
                        filterSinhViens.Add(sinhVien);
                    }
                }

                bindingSourceSinhVien.DataSource = filterSinhViens;
            }
        }
    }
}
