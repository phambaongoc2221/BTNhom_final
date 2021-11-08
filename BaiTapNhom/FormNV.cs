using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapNhom
{
    public partial class FormNV : Form
    {
        Connect_db connectDB = new Connect_db();

        DataTable dta = new DataTable();
        public FormNV()
        {
            InitializeComponent();
        }
        private void BANG_NHANVIEN()
        {
            dta = connectDB.Lay_DulieuBang("SELECT * FROM nhanVien");
            DataGrid_NhanVien1.DataSource = dta;
        }
        private void HienThiDuLieu()
        {
            BANG_NHANVIEN();
           
            txtMaNV.DataBindings.Clear();
            txtMaNV.DataBindings.Add("Text", DataGrid_NhanVien1.DataSource, "manv");

            txtTenNV.DataBindings.Clear();
            txtTenNV.DataBindings.Add("Text", DataGrid_NhanVien1.DataSource, "tennv");

            txtGioiTinh.DataBindings.Clear();
            txtGioiTinh.DataBindings.Add("Text", DataGrid_NhanVien1.DataSource, "gioitinh");

            txtNgaySinh.DataBindings.Clear();
            txtNgaySinh.DataBindings.Add("Text", DataGrid_NhanVien1.DataSource, "ngaysinh");

            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", DataGrid_NhanVien1.DataSource, "diachi");

            txtSdt.DataBindings.Clear();
            txtSdt.DataBindings.Add("Text", DataGrid_NhanVien1.DataSource, "sdt");

            txtEmail.DataBindings.Clear();
            txtEmail.DataBindings.Add("Text", DataGrid_NhanVien1.DataSource, "email");
            DataGrid_NhanVien1.Columns[0].HeaderText = "Mã Nhân Viên";
            DataGrid_NhanVien1.Columns[1].HeaderText = "Họ Tên Nhân Viên";
            DataGrid_NhanVien1.Columns[2].HeaderText = "Giới tính";
            DataGrid_NhanVien1.Columns[3].HeaderText = "Ngày sinh";
            DataGrid_NhanVien1.Columns[4].HeaderText = "Địa chỉ";
            DataGrid_NhanVien1.Columns[5].HeaderText = "Số điện thoại";
            DataGrid_NhanVien1.Columns[6].HeaderText = "Email";
            DataGrid_NhanVien1.Columns[0].Width = 100;
            DataGrid_NhanVien1.Columns[1].Width = 150;
            DataGrid_NhanVien1.Columns[2].Width = 80;
            DataGrid_NhanVien1.Columns[3].Width = 80;
            DataGrid_NhanVien1.Columns[4].Width = 150;
            DataGrid_NhanVien1.Columns[5].Width = 100;
            DataGrid_NhanVien1.Columns[6].Width = 250;
            DataGrid_NhanVien1.AllowUserToAddRows = false;
            DataGrid_NhanVien1.EditMode = DataGridViewEditMode.EditProgrammatically;
            
        }
        private void FormNV_Load(object sender, EventArgs e)
        {
            BANG_NHANVIEN();
            HienThiDuLieu();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string sql_ktra = "Select manv From nhanVien Where manv ='" + txtMaNV.Text + "'";
            SqlCommand cmd = new SqlCommand(sql_ktra, connectDB.cnn);
            SqlDataReader doc_d1 = cmd.ExecuteReader();
            if (doc_d1.Read() == true)
            {
                MessageBox.Show("Nhân viên đã tồn tại, nhập lại mã mới", "Thông báo");
                txtMaNV.Focus();
                doc_d1.Close();
                doc_d1.Dispose();
            }
            else
            {
                string sql_them;
                sql_them = " INSERT INTO nhanVien VALUES ('" + txtMaNV.Text + "', '" + txtTenNV.Text + "', '" + txtGioiTinh.Text + "', '" + txtNgaySinh.Text + "','" + txtDiaChi.Text + "', '" + txtSdt.Text + "', '" + txtEmail.Text + "')";
                connectDB.ThucThi(sql_them);
                BANG_NHANVIEN();
            }
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql_Sua;
            sql_Sua = "UPDATE nhanVien SET tennv =  '" + txtTenNV.Text + "', gioitinh = '" + txtGioiTinh.Text + "', ngaysinh =  '" + txtNgaySinh.Text + "', diachi =  '" + txtDiaChi.Text + "', sdt =  '" + txtSdt.Text + "', email =  '" + txtEmail.Text + "' WHERE manv = '" + txtMaNV.Text + "'";
            connectDB.ThucThi(sql_Sua);
            BANG_NHANVIEN();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql_Xoa;
            sql_Xoa = " DELETE nhanVien WHERE manv = '" + txtMaNV.Text + "' ";
            connectDB.ThucThi(sql_Xoa);
            BANG_NHANVIEN();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DataGrid_NhanVien1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            HienThiDuLieu();
        }

        private void btnTaomoi_Click(object sender, EventArgs e)
        {
            txtMaNV.Text = "";
            txtTenNV.Text = "";
            txtNgaySinh.Text = "";
            txtGioiTinh.Text = "";
            txtDiaChi.Text = "";
            txtSdt.Text = "";
            txtEmail.Text = "";
            txtMaNV.Focus();
        }
    }
}
