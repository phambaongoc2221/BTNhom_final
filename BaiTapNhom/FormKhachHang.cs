using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BaiTapNhom
{
    public partial class FormKhachHang : Form
    {
        public FormKhachHang()
        {
            InitializeComponent();
        }
        Connect_db kn = new Connect_db();
        private void BANG_KHACHHANG()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DulieuBang("SELECT * FROM khachHang");
            DataGrid_KhachHang.DataSource = dta;
        }

        private void HienThiDuLieu()
        {
            BANG_KHACHHANG();
            txtMaKH.DataBindings.Clear();
            txtMaKH.DataBindings.Add("Text", DataGrid_KhachHang.DataSource, "makh");

            txtTenKH.DataBindings.Clear();
            txtTenKH.DataBindings.Add("Text", DataGrid_KhachHang.DataSource, "tenkh");

            txtSdt.DataBindings.Clear();
            txtSdt.DataBindings.Add("Text", DataGrid_KhachHang.DataSource, "sdt");

            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", DataGrid_KhachHang.DataSource, "diachi");

           
            DataGrid_KhachHang.Columns[0].HeaderText = "Mã Khách Hàng";
            DataGrid_KhachHang.Columns[1].HeaderText = "Họ Tên Khách Hàng";
            DataGrid_KhachHang.Columns[2].HeaderText = "Số điện thoại";
            DataGrid_KhachHang.Columns[3].HeaderText = "Địa chỉ";
            DataGrid_KhachHang.Columns[0].Width = 150;
            DataGrid_KhachHang.Columns[1].Width = 200;
            DataGrid_KhachHang.Columns[2].Width = 200;
            DataGrid_KhachHang.Columns[3].Width = 250;
            DataGrid_KhachHang.AllowUserToAddRows = false;
            DataGrid_KhachHang.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

            private void FormKhachHang_Load(object sender, EventArgs e)
        {
            BANG_KHACHHANG();
            HienThiDuLieu();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string sql_ktra = "Select makh From khachHang Where makh ='" + txtMaKH.Text + "'";
            SqlCommand cmd = new SqlCommand(sql_ktra, kn.cnn);
            SqlDataReader doc_d1 = cmd.ExecuteReader();
            if (doc_d1.Read() == true)
            {
                MessageBox.Show("Khách hàng đã tồn tại, nhập lại mã mới", "Thông báo");
                txtMaKH.Focus();
                doc_d1.Close();
                doc_d1.Dispose();
            }
            else
            {
                string sql_them;
                sql_them = " INSERT INTO khachHang VALUES ('" + txtMaKH.Text + "', '" + txtTenKH.Text + "', '" + txtSdt.Text + "', '" + txtDiaChi.Text + "')";
                kn.ThucThi(sql_them);
                BANG_KHACHHANG();
            }
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql_Sua;
            sql_Sua = "UPDATE khachHang SET tenkh =  '" + txtTenKH.Text + "', sdt = '" + txtSdt.Text + "', diachi =  '" + txtDiaChi.Text + "' WHERE makh = '" + txtMaKH.Text + "'";
            kn.ThucThi(sql_Sua);
            BANG_KHACHHANG();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql_Xoa;
            sql_Xoa = " DELETE khachHang WHERE makh = '" + txtMaKH.Text + "' ";
            kn.ThucThi(sql_Xoa);
            BANG_KHACHHANG();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DataGrid_KhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            HienThiDuLieu();
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            txtMaKH.Text = "";
            txtTenKH.Text = "";
            txtSdt.Text = "";
            txtDiaChi.Text = "";
            txtMaKH.Focus();
        }
    }
}
