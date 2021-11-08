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
    public partial class FormHoaDon : Form
    {
        Connect_db kn = new Connect_db();
        public FormHoaDon()
        {
            InitializeComponent();
        }
        private void BangHoaDon()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DulieuBang("select * from hoaDon");
            GridViewHoaDon.DataSource = dta;
            Hienthi_Dulieu();
        }
        private void BangKhachHang()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DulieuBang("select * from khachHang");
            cboKhachHang.DataSource = dta;
            cboKhachHang.DisplayMember = "makh";
            cboKhachHang.ValueMember = "makh";
        }

        private void BangNhanVien()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DulieuBang("select * from nhanVien");
            cboNhanVien.DataSource = dta;
            cboNhanVien.DisplayMember = "manv";
            cboNhanVien.ValueMember = "manv";
        }
        private void Hienthi_Dulieu()
        {

            txtMaHD.DataBindings.Clear();
            txtMaHD.DataBindings.Add("Text", GridViewHoaDon.DataSource, "mahd");

            cboKhachHang.DataBindings.Clear();
            cboKhachHang.DataBindings.Add("Text", GridViewHoaDon.DataSource, "makh");

            cboNhanVien.DataBindings.Clear();
            cboNhanVien.DataBindings.Add("Text", GridViewHoaDon.DataSource, "manv");

            txtNgay.DataBindings.Clear();
            txtNgay.DataBindings.Add("Text", GridViewHoaDon.DataSource, "ngaytao");

            GridViewHoaDon.Columns[0].HeaderText = "Mã Hóa đơn";
            GridViewHoaDon.Columns[1].HeaderText = "Mã Khách hàng";
            GridViewHoaDon.Columns[2].HeaderText = "Mã Nhân viên";
            GridViewHoaDon.Columns[3].HeaderText = "Ngày tạo";
            GridViewHoaDon.Columns[4].HeaderText = "Tổng tiền nhập";
            GridViewHoaDon.Columns[0].Width = 150;
            GridViewHoaDon.Columns[1].Width = 150;
            GridViewHoaDon.Columns[2].Width = 150;
            GridViewHoaDon.Columns[3].Width = 200;
            GridViewHoaDon.Columns[4].Width = 250;
            GridViewHoaDon.AllowUserToAddRows = false;
            GridViewHoaDon.EditMode = DataGridViewEditMode.EditProgrammatically;

        }
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormHoaDon_Load(object sender, EventArgs e)
        {
            BangHoaDon();
            BangKhachHang();
            BangNhanVien();
            Hienthi_Dulieu();
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            txtMaHD.Text = "";
            txtNgay.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql_ktra = "Select mahd From hoaDon Where mahd ='" + txtMaHD.Text + "'";
            SqlCommand cmd = new SqlCommand(sql_ktra, kn.cnn);
            SqlDataReader doc_d1 = cmd.ExecuteReader();
            if (doc_d1.Read() == true)
            {
                MessageBox.Show("Mã hóa đơn đã tồn tại, nhập lại mã mới", "Thông báo");
                txtMaHD.Focus();
                doc_d1.Close();
                doc_d1.Dispose();
            }
            else
            {
                string sql_them;
                sql_them = " INSERT INTO hoaDon(mahd, makh, manv, ngaytao) VALUES ('" + txtMaHD.Text + "', '" + cboKhachHang.Text + "', '" + cboNhanVien.Text + "', '" + txtNgay.Text + "')";
                kn.ThucThi(sql_them);
                BangHoaDon();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn có muốn xóa dữ liệu này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (thongbao == DialogResult.Yes)
            {
                string sql3 = "Delete hoaDon where mahd = '" + txtMaHD.Text + "'";
                kn.ThucThi(sql3);
                BangHoaDon();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql2;
            sql2 = "Update hoaDon Set ngaytao = '" + txtNgay.Text + "' where mahd = '" + txtMaHD.Text + "'";
            kn.ThucThi(sql2);
            BangHoaDon();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GridViewHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Hienthi_Dulieu();
        }
    }
}
