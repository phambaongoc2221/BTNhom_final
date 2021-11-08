using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapNhom
{
    public partial class FormTKNVien : Form
    {
        public FormTKNVien()
        {
            InitializeComponent();
        }

        Connect_db connect_db = new Connect_db();

        DataTable dta = new DataTable();
        private void FormTKNVien_Load(object sender, EventArgs e)
        {
            DataTable dta = connect_db.Lay_DulieuBang("SELECT * FROM nhanVien ORDER BY manv");
            cboMaNV.DataSource = dta;
            cboMaNV.DisplayMember = "manv";
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string sqltk;

            if (radioMaNV.Checked == true)
            {
                sqltk = "SELECT * FROM nhanVien WHERE manv LIKE '" + cboMaNV.Text + "'";
                dta = connect_db.Lay_DulieuBang(sqltk);
            }

            if (radioTenNV.Checked == true)
            {
                sqltk = "SELECT * FROM nhanVien WHERE tennv LIKE  '%" + txtTenNV.Text + "%'";
                dta = connect_db.Lay_DulieuBang(sqltk);
            }

            if (radioSoDT.Checked == true)
            {
                sqltk = "SELECT * FROM nhanVien WHERE sdt LIKE '" + txtSoDT.Text + "'";
                dta = connect_db.Lay_DulieuBang(sqltk);
            }

            DataGrid_TimKiemNV.DataSource = dta;

            DataGrid_TimKiemNV.Columns[0].HeaderText = "Mã Nhân Viên";
            DataGrid_TimKiemNV.Columns[1].HeaderText = "Họ Tên Nhân Viên";
            DataGrid_TimKiemNV.Columns[2].HeaderText = "Giới tính";
            DataGrid_TimKiemNV.Columns[3].HeaderText = "Ngày sinh";
            DataGrid_TimKiemNV.Columns[4].HeaderText = "Địa chỉ";
            DataGrid_TimKiemNV.Columns[5].HeaderText = "Số điện thoại";
            DataGrid_TimKiemNV.Columns[6].HeaderText = "Email";
            DataGrid_TimKiemNV.Columns[0].Width = 50;
            DataGrid_TimKiemNV.Columns[1].Width = 100;
            DataGrid_TimKiemNV.Columns[2].Width = 50;
            DataGrid_TimKiemNV.Columns[3].Width = 100;
            DataGrid_TimKiemNV.Columns[4].Width = 120;
            DataGrid_TimKiemNV.Columns[5].Width = 100;
            DataGrid_TimKiemNV.Columns[6].Width = 150;
            DataGrid_TimKiemNV.AllowUserToAddRows = false;
            DataGrid_TimKiemNV.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void radioMaNV_CheckedChanged(object sender, EventArgs e)
        {
            cboMaNV.Focus();

            cboMaNV.Enabled = true;
            txtTenNV.Enabled = false;
            txtSoDT.Enabled = false;
        }

        private void radioTenNV_CheckedChanged(object sender, EventArgs e)
        {
            txtTenNV.Focus();

            txtTenNV.Enabled = true;
            cboMaNV.Enabled = false;
            txtSoDT.Enabled = false;
        }

        private void radioSoDT_CheckedChanged(object sender, EventArgs e)
        {
            txtSoDT.Focus();

            txtSoDT.Enabled = true;
            cboMaNV.Enabled = false;
            txtTenNV.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DataGrid_TimKiemNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
