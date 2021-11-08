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
    public partial class FormTKNCC : Form
    {
        public FormTKNCC()
        {
            InitializeComponent();
        }

        Connect_db connect_db = new Connect_db();

        DataTable dta = new DataTable();

        private void FormTKNCC_Load(object sender, EventArgs e)
        {
            DataTable dta = connect_db.Lay_DulieuBang("SELECT * FROM nhaCungCap ORDER BY mancc");
            cboMaNCC.DataSource = dta;
            cboMaNCC.DisplayMember = "mancc";
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string sqltk;
            DataTable dta = new DataTable();
            if (radMaNCC.Checked == true)
            {
                sqltk = "Select * from nhaCungCap where mancc like '" + cboMaNCC.Text + "'";
                dta = connect_db.Lay_DulieuBang(sqltk);
            }
            if (radTenNCC.Checked == true)
            {
                sqltk = "Select * from nhaCungCap where tenncc like '%" + txtTenNCC.Text + "%'";
                dta = connect_db.Lay_DulieuBang(sqltk);
            }
           
            if (radDT.Checked == true)
            {
                sqltk = "Select * from nhaCungCap where sdt like '" + txtDT.Text + "%'";
                dta = connect_db.Lay_DulieuBang(sqltk);
            }
            DataGrid_TimKiemNCC.DataSource = dta;

            DataGrid_TimKiemNCC.Columns[0].HeaderText = "Mã NCC";
            DataGrid_TimKiemNCC.Columns[1].HeaderText = "Tên Nhà cung cấp";
            DataGrid_TimKiemNCC.Columns[2].HeaderText = "Địa chỉ";
            DataGrid_TimKiemNCC.Columns[3].HeaderText = "Số điện thoại";
            DataGrid_TimKiemNCC.Columns[0].Width = 80;
            DataGrid_TimKiemNCC.Columns[1].Width = 150;
            DataGrid_TimKiemNCC.Columns[2].Width = 150;
            DataGrid_TimKiemNCC.Columns[3].Width = 150;
            DataGrid_TimKiemNCC.AllowUserToAddRows = false;
            DataGrid_TimKiemNCC.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (thongbao == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void radMaNCC_CheckedChanged(object sender, EventArgs e)
        {
            cboMaNCC.Focus();
            txtTenNCC.Clear();
            txtDT.Clear();
            cboMaNCC.Enabled = true;
            txtTenNCC.Enabled = false;
            txtDT.Enabled = false;
        }

        private void radTenNCC_CheckedChanged(object sender, EventArgs e)
        {
            txtTenNCC.Focus();
            txtDT.Clear();
            txtTenNCC.Enabled = true;
            cboMaNCC.Enabled = false;
            txtDT.Enabled = false;
        }

        private void radDT_CheckedChanged(object sender, EventArgs e)
        {
            txtDT.Focus();
            txtTenNCC.Clear();
            txtTenNCC.Enabled = false;
            cboMaNCC.Enabled = false;
            txtDT.Enabled = true;
        }
    }
}
