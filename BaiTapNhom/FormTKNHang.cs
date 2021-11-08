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
    public partial class FormTKNHang : Form
    {
        public FormTKNHang()
        {
            InitializeComponent();
        }
        Connect_db connect_db = new Connect_db();

        DataTable dta = new DataTable();
        private void FormTKNHang_Load(object sender, EventArgs e)
        {
            DataTable dta = connect_db.Lay_DulieuBang("SELECT * FROM nhapHang ORDER BY manhap");
            cboMaNhap.DataSource = dta;
            cboMaNhap.DisplayMember = "manhap";
            cboMaNCC.DataSource = dta;
            cboMaNCC.DisplayMember = "mancc";
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string sqltk;

            if (radioMaNhap.Checked == true)
            {
                sqltk = "SELECT * FROM nhapHang WHERE manhap LIKE '" + cboMaNhap.Text + "'";
                dta = connect_db.Lay_DulieuBang(sqltk);
            }

            if (radioMaNCC.Checked == true)
            {
                sqltk = "SELECT * FROM nhapHang WHERE mancc LIKE  '" + cboMaNCC.Text + "'";
                dta = connect_db.Lay_DulieuBang(sqltk);
            }

            if (radioNgaynhap.Checked == true)
            {
                sqltk = "SELECT * FROM nhapHang WHERE ngaynhap LIKE '" + txtNgaynhap.Text + "'";
                dta = connect_db.Lay_DulieuBang(sqltk);
            }

            DataGrid_TimKiemNH.DataSource = dta;

            DataGrid_TimKiemNH.Columns[0].HeaderText = "Mã nhập";
            DataGrid_TimKiemNH.Columns[1].HeaderText = "Mã nhà cung cấp";
            DataGrid_TimKiemNH.Columns[2].HeaderText = "Ngày nhập";
            DataGrid_TimKiemNH.Columns[3].HeaderText = "Tổng tiền";
            DataGrid_TimKiemNH.Columns[0].Width = 150;
            DataGrid_TimKiemNH.Columns[1].Width = 150;
            DataGrid_TimKiemNH.Columns[2].Width = 150;
            DataGrid_TimKiemNH.Columns[3].Width = 250;
            DataGrid_TimKiemNH.AllowUserToAddRows = false;
            DataGrid_TimKiemNH.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void radioMaNhap_CheckedChanged(object sender, EventArgs e)
        {
            cboMaNhap.Focus();

            cboMaNhap.Enabled = true;

            cboMaNCC.Enabled = false;
            txtNgaynhap.Enabled = false;
        }

        private void radioMaNCC_CheckedChanged(object sender, EventArgs e)
        {
            cboMaNCC.Focus();

            cboMaNCC.Enabled = true;

            cboMaNhap.Enabled = false;
            txtNgaynhap.Enabled = false;
        }

        private void radioNgaynhap_CheckedChanged(object sender, EventArgs e)
        {
            txtNgaynhap.Focus();
            txtNgaynhap.Enabled = true;
            cboMaNCC.Enabled = false;
            cboMaNhap.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
