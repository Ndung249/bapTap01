using System;
using System.Windows.Forms;

namespace FormSinhVien2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLuaChon_Click(object sender, EventArgs e)
        {
            switch (txtNhap.Text)
            {
                case "1":
                    FrmAddSinhVien frmAdd = new FrmAddSinhVien();
                    frmAdd.ShowDialog();

                    break;
                case "2":
                    break;
                default:
                    break;
            }
        }
    }
}
