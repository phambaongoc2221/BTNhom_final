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
    public partial class FormNhapHang : Form
    {
        Connect_db kn = new Connect_db();
        DataTable dta = new DataTable();
        public FormNhapHang()
        {
            InitializeComponent();
        }
        private void BangNH()
        {
            dta = kn.Lay_DulieuBang("select * from nhapHang");
            GridViewCTNH.DataSource = dta;
            Hienthi_Dulieu();
        }
        private void BangNCC()
        {
            dta = kn.Lay_DulieuBang("select * from nhaCungCap");
            cboNCC.DataSource = dta;
            cboNCC.DisplayMember = "mancc";
            cboNCC.ValueMember = "mancc";
        }
        private void Hienthi_Dulieu()
        {

            txtMaNH.DataBindings.Clear();
            txtMaNH.DataBindings.Add("Text", GridViewCTNH.DataSource, "manhap");

            cboNCC.DataBindings.Clear();
            cboNCC.DataBindings.Add("Text", GridViewCTNH.DataSource, "mancc");

            txtNgaynhap.DataBindings.Clear();
            txtNgaynhap.DataBindings.Add("Text", GridViewCTNH.DataSource, "ngaynhap");

            GridViewCTNH.Columns[0].HeaderText = "Mã Nhập Hàng";
            GridViewCTNH.Columns[1].HeaderText = "Mã Nhà cung cấp";
            GridViewCTNH.Columns[2].HeaderText = "Ngày nhập hàng";
            GridViewCTNH.Columns[3].HeaderText = "Tổng tiền nhập";
            GridViewCTNH.Columns[0].Width = 170;
            GridViewCTNH.Columns[1].Width = 170;
            GridViewCTNH.Columns[2].Width = 200;
            GridViewCTNH.Columns[3].Width = 250;
            GridViewCTNH.AllowUserToAddRows = false;
            GridViewCTNH.EditMode = DataGridViewEditMode.EditProgrammatically;

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTao_Click_1(object sender, EventArgs e)
        {
            txtMaNH.Text = "";
            txtNgaynhap.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql_ktra = "Select manhap From nhapHang Where manhap ='" + txtMaNH.Text + "'";
            SqlCommand cmd = new SqlCommand(sql_ktra, kn.cnn);
            SqlDataReader doc_d1 = cmd.ExecuteReader();
            if (doc_d1.Read() == true)
            {
                MessageBox.Show("Mã nhập hàng đã tồn tại, nhập lại mã mới", "Thông báo");
                txtMaNH.Focus();
                doc_d1.Close();
                doc_d1.Dispose();
            }
            else
            {
                string sql_luu = "Insert into nhapHang(manhap,mancc,ngaynhap) Values('" + txtMaNH.Text + "', '" + cboNCC.Text + "','" +txtNgaynhap.Text+ "')";
                kn.ThucThi(sql_luu);
                BangNH();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn có muốn xóa dữ liệu này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (thongbao == DialogResult.Yes)
            {
                string sql_xoa = "Delete nhapHang where manhap = '" + txtMaNH.Text + "'";
                BangNH();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql_sua = "Update nhapHang set ngaynhap ='" + txtNgaynhap.Text + "' where manhap = '" + txtMaNH.Text + "'";
            kn.ThucThi(sql_sua);
            BangNH();
        }

        private void FormNhapHang_Load(object sender, EventArgs e)
        {
            BangNH();
            BangNCC();
            Hienthi_Dulieu();
        }

        private void GridViewCTNH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Hienthi_Dulieu();
        }
    }
}
