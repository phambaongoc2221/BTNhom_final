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
    public partial class FormTKKHang : Form
    {
        public FormTKKHang()
        {
            InitializeComponent();
        }
        Connect_db connect_db = new Connect_db();

        DataTable dta = new DataTable();

        private void FormTKKHang_Load(object sender, EventArgs e)
        {
            DataTable dta = connect_db.Lay_DulieuBang("SELECT * FROM khachHang ORDER BY makh");
            cboMaKH.DataSource = dta;
            cboMaKH.DisplayMember = "makh";
        }
        private void radioMaKH_CheckedChanged(object sender, EventArgs e)
        {
            cboMaKH.Focus();

            cboMaKH.Enabled = true;
            //txtTenKH.Clear();

            txtTenKH.Enabled = false;
            txtSoDT.Enabled = false;
        }

        private void radioTenKH_CheckedChanged(object sender, EventArgs e)
        {
            txtTenKH.Focus();

            txtTenKH.Enabled = true;
            //txtTenKH.Clear();

            cboMaKH.Enabled = false;
            txtSoDT.Enabled = false;
        }

        private void radioSoDT_CheckedChanged(object sender, EventArgs e)
        {
            txtSoDT.Focus();

            txtSoDT.Enabled = true;
            // txtTenKH.Clear();

            cboMaKH.Enabled = false;
            txtTenKH.Enabled = false;
        }

        private void cboMaKH_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string sqltk;

            if (radioMaKH.Checked == true)
            {
                sqltk = "SELECT * FROM khachHang WHERE makh LIKE '" + cboMaKH.Text + "'";
                dta = connect_db.Lay_DulieuBang(sqltk);
            }

            if (radioTenKH.Checked == true)
            {
                sqltk = "SELECT * FROM khachHang WHERE tenkh LIKE  '%" + txtTenKH.Text + "%'";
                dta = connect_db.Lay_DulieuBang(sqltk);
            }

            if (radioSoDT.Checked == true)
            {
                sqltk = "SELECT * FROM khachHang WHERE sdt LIKE '" + txtSoDT.Text + "'";
                dta = connect_db.Lay_DulieuBang(sqltk);
            }

            DataGrid_TimKiemKH.DataSource = dta;

            DataGrid_TimKiemKH.Columns[0].HeaderText = "Mã KH";
            DataGrid_TimKiemKH.Columns[1].HeaderText = "Họ và Tên";
            DataGrid_TimKiemKH.Columns[2].HeaderText = "Số điện thoại";
            DataGrid_TimKiemKH.Columns[3].HeaderText = "Địa chỉ";
            DataGrid_TimKiemKH.Columns[0].Width = 150;
            DataGrid_TimKiemKH.Columns[1].Width = 150;
            DataGrid_TimKiemKH.Columns[2].Width = 150;
            DataGrid_TimKiemKH.Columns[3].Width = 250;
            DataGrid_TimKiemKH.AllowUserToAddRows = false;
            DataGrid_TimKiemKH.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
