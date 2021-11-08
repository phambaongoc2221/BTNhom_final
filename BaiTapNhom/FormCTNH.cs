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

    public partial class FormCTNH : Form
    {
        Connect_db kn = new Connect_db();
        public FormCTNH()
        {
            InitializeComponent();
        }
        private void BangCTNH()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DulieuBang("select * from chiTiet_nhapHang");
            GridViewCTNH.DataSource = dta;
            cboManhap.DataSource = dta;
            cboManhap.DisplayMember = "manhap";
            cboManhap.ValueMember = "manhap";
            cboMahang.DataSource = dta;
            cboMahang.DisplayMember = "mahh";
            cboMahang.ValueMember = "mahh";
            Hienthi_Dulieu();
        }

        private void Hienthi_Dulieu()
        {

            cboManhap.DataBindings.Clear();
            cboManhap.DataBindings.Add("Text", GridViewCTNH.DataSource, "manhap");

            txtMaCTNH.DataBindings.Clear();
            txtMaCTNH.DataBindings.Add("Text", GridViewCTNH.DataSource, "mactnh");

            cboMahang.DataBindings.Clear();
            cboMahang.DataBindings.Add("Text", GridViewCTNH.DataSource, "mahh");

            numSoluong.DataBindings.Clear();
            numSoluong.DataBindings.Add("Value", GridViewCTNH.DataSource, "soluong");

            numSLH.DataBindings.Clear();
            numSLH.DataBindings.Add("Value", GridViewCTNH.DataSource, "soluonghong");

            GridViewCTNH.Columns[0].HeaderText = "Mã Nhập";
            GridViewCTNH.Columns[1].HeaderText = "Mã CTNH";
            GridViewCTNH.Columns[2].HeaderText = "Mã Hàng";
            GridViewCTNH.Columns[3].HeaderText = "Số lượng";
            GridViewCTNH.Columns[4].HeaderText = "Số lượng hỏng";
            GridViewCTNH.Columns[5].HeaderText = "Thành tiền";
            GridViewCTNH.Columns[0].Width = 120;
            GridViewCTNH.Columns[1].Width = 120;
            GridViewCTNH.Columns[2].Width = 120;
            GridViewCTNH.Columns[3].Width = 150;
            GridViewCTNH.Columns[4].Width = 150;
            GridViewCTNH.Columns[5].Width = 300;
            GridViewCTNH.AllowUserToAddRows = false;
            GridViewCTNH.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormCTNH_Load(object sender, EventArgs e)
        {
            BangCTNH();
            Hienthi_Dulieu();
        }

        private void GridViewCTNH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Hienthi_Dulieu();
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            txtMaCTNH.Text = "";
            numSoluong.Value = 0;
            numSLH.Value = 0;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql_ktra = "Select mactnh From chiTiet_nhapHang Where mactnh ='" + txtMaCTNH.Text + "'";
            SqlCommand cmd = new SqlCommand(sql_ktra, kn.cnn);
            SqlDataReader doc_d1 = cmd.ExecuteReader();
            if (doc_d1.Read() == true)
            {
                MessageBox.Show("Mã chi tiết nhập hàng đã tồn tại, nhập lại mã mới", "Thông báo");
                txtMaCTNH.Focus();
                doc_d1.Close();
                doc_d1.Dispose();
            }
            else
            {
                string sql_luu = "Insert into chiTiet_nhapHang (mactnh, manhap, mahh,soluong,soluonghong)Values('" + txtMaCTNH.Text + "', '" + cboManhap.Text + "','" + cboMahang.Text + "','" + numSoluong.Value + "','" + numSLH.Value + "')";
                kn.ThucThi(sql_luu);
                BangCTNH();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn có muốn xóa dữ liệu này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (thongbao == DialogResult.Yes)
            {
                string sql_xoa = "Delete chiTiet_nhapHang where mactnh = '" + txtMaCTNH.Text + "'";
                kn.ThucThi(sql_xoa);
                BangCTNH();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql_sua = "Update chiTiet_nhapHang set soluong ='" + numSoluong.Value + "', soluonghong = '" + numSLH.Value + "' Where mactnh = '" + txtMaCTNH.Text + "'";
            kn.ThucThi(sql_sua);
            BangCTNH();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
