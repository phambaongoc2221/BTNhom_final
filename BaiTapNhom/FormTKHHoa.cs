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
    public partial class FormTKHHoa : Form
    {
        public FormTKHHoa()
        {
            InitializeComponent();
        }
        Connect_db connect_db = new Connect_db();

        DataTable dta = new DataTable();
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string sqltk;

            if (radioNhapMa.Checked == true)
            {
                sqltk = "select * from hangHoa where mahh like '" + cboMaHH.Text + "'";
                dta = connect_db.Lay_DulieuBang(sqltk);
            }

            if (radioNhapTen.Checked == true)
            {
                sqltk = "select * from hangHoa where tenhh like '%" + txtNhapTen.Text + "%'";
                dta = connect_db.Lay_DulieuBang(sqltk);
            }

            if (radioNhapNCC.Checked == true)
            {
                sqltk = "select * from hangHoa where mancc like '" + cboNCC.Text + "'";
                dta = connect_db.Lay_DulieuBang(sqltk);
            }
            if (radioNhapGia.Checked == true)
            {
                sqltk = "select * from hangHoa where dongia like '" + txtGia.Text + "'";
                dta = connect_db.Lay_DulieuBang(sqltk);
            }

            DataGrid_KetQua.DataSource = dta;
            DataGrid_KetQua.Columns[0].HeaderText = "Mã Hàng";
            DataGrid_KetQua.Columns[1].HeaderText = "Mã NCC";
            DataGrid_KetQua.Columns[2].HeaderText = "Tên Hàng";
            DataGrid_KetQua.Columns[3].HeaderText = "Trạng thái";
            DataGrid_KetQua.Columns[4].HeaderText = "Số lượng";
            DataGrid_KetQua.Columns[5].HeaderText = "Đơn giá";
            DataGrid_KetQua.Columns[0].Width = 100;
            DataGrid_KetQua.Columns[1].Width = 100;
            DataGrid_KetQua.Columns[2].Width = 120;
            DataGrid_KetQua.Columns[3].Width = 100;
            DataGrid_KetQua.Columns[4].Width = 100;
            DataGrid_KetQua.Columns[5].Width = 170;
            DataGrid_KetQua.AllowUserToAddRows = false;
            DataGrid_KetQua.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void BangNCC()
        {
            dta = connect_db.Lay_DulieuBang("Select * From nhaCungCap order by mancc");
            cboNCC.DataSource = dta;
            cboNCC.DisplayMember = "mancc";
            cboNCC.ValueMember = "mancc";
        }
        private void FormTKHHoa_Load(object sender, EventArgs e)
        {
            dta = connect_db.Lay_DulieuBang("Select * From hangHoa order by mahh");
            cboMaHH.DataSource = dta;
            cboMaHH.DisplayMember = "mahh";
            cboMaHH.ValueMember = "mahh";
            BangNCC();
        }

        private void radioNhapMa_CheckedChanged(object sender, EventArgs e)
        {
            cboMaHH.Focus();
            cboMaHH.Enabled = true;
            txtNhapTen.Enabled = false;
            cboNCC.Enabled = false;
            txtGia.Enabled = false;
        }

        private void radioNhapTen_CheckedChanged(object sender, EventArgs e)
        {
            txtNhapTen.Focus();
            txtNhapTen.Clear();
            txtNhapTen.Enabled = true;
            cboMaHH.Enabled = false;
            cboNCC.Enabled = false;
            txtGia.Enabled = false;
        }

        private void radioNhapNCC_CheckedChanged(object sender, EventArgs e)
        {
            cboNCC.Focus();
            cboNCC.Enabled = true;
            txtNhapTen.Enabled = false;
            cboNCC.Enabled = false;
            txtGia.Enabled = false;
        }

        private void radioNhapGia_CheckedChanged(object sender, EventArgs e)
        {
            txtGia.Focus();
            txtGia.Enabled = true;
            txtGia.Clear();
            txtNhapTen.Enabled = false;
            cboNCC.Enabled = false;
            cboMaHH.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
