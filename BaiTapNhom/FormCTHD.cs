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
    public partial class FormCTHD : Form
    {
        Connect_db kn = new Connect_db();
        DataTable dta = new DataTable();
        public FormCTHD()
        {
            InitializeComponent();
        }

        private void BangCTHD()
        {
          
            dta = kn.Lay_DulieuBang("select * from chiTiet_hoaDon");
            GridViewCTHD.DataSource = dta;
            Hienthi_Dulieu();
        }
        private void BangHD()
        {
            dta = kn.Lay_DulieuBang("select * from hoaDon");
            cboHoadon.DataSource = dta;
            cboHoadon.DisplayMember = "mahd";
            cboHoadon.ValueMember = "mahd";
        }
        private void BangHH()
        {
            dta = kn.Lay_DulieuBang("select * from hangHoa");
            cboHang.DataSource = dta;
            cboHang.DisplayMember = "mahh";
            cboHang.ValueMember = "mahh";
        }
        private void Hienthi_Dulieu()
        {

            txtMaCTHD.DataBindings.Clear();
            txtMaCTHD.DataBindings.Add("Text", GridViewCTHD.DataSource, "macthd");
            cboHoadon.DataBindings.Clear();
            cboHoadon.DataBindings.Add("Text", GridViewCTHD.DataSource, "mahd");
            cboHang.DataBindings.Clear();
            cboHang.DataBindings.Add("Text", GridViewCTHD.DataSource, "mahh");
            numSL.DataBindings.Clear();
            numSL.DataBindings.Add("Value", GridViewCTHD.DataSource, "soluong");

            GridViewCTHD.Columns[0].HeaderText = "Mã CTHD";
            GridViewCTHD.Columns[1].HeaderText = "Mã HD";
            GridViewCTHD.Columns[2].HeaderText = "Mã Hàng ";
            GridViewCTHD.Columns[3].HeaderText = "Số lượng";
            GridViewCTHD.Columns[4].HeaderText = "Thành tiền";
            GridViewCTHD.Columns[0].Width = 100;
            GridViewCTHD.Columns[1].Width = 100;
            GridViewCTHD.Columns[2].Width = 100;
            GridViewCTHD.Columns[3].Width = 150;
            GridViewCTHD.Columns[4].Width = 150;
            GridViewCTHD.AllowUserToAddRows = false;
            GridViewCTHD.EditMode = DataGridViewEditMode.EditProgrammatically;

        }
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormCTHD_Load(object sender, EventArgs e)
        {
            BangCTHD();
            Hienthi_Dulieu();
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            txtMaCTHD.Text = "";
            numSL.Value = 0;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql_ktra = "Select macthd From chiTiet_hoaDon Where macthd ='" + txtMaCTHD.Text + "'";
            SqlCommand cmd = new SqlCommand(sql_ktra, kn.cnn);
            SqlDataReader doc_d1 = cmd.ExecuteReader();
            if (doc_d1.Read() == true)
            {
                MessageBox.Show("Mã chi tiết hóa đơn đã tồn tại, nhập lại mã mới", "Thông báo");
                txtMaCTNH.Focus();
                doc_d1.Close();
                doc_d1.Dispose();
            }
            else
            {
                string sql_luu = "Insert into chiTiet_hoaDon (macthd,mahd,mahh,soluong) Values('" + txtMaCTHD.Text + "', '" + cboHoadon.Text + "','" + cboHang.Text + "','" + numSL.Value + "')";
                kn.ThucThi(sql_luu);
                BangCTHD();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn có muốn xóa dữ liệu này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (thongbao == DialogResult.Yes)
            {
                string sql_xoa = "Delete chiTiet_hoaDon where macthd = '" + txtMaCTHD.Text + "'";
                kn.ThucThi(sql_xoa);
                BangCTHD();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql_sua = "Update chiTiet_hoaDon set soluong ='" + numSL.Value + "' Where macthd = '" + txtMaCTHD.Text + "'";
            kn.ThucThi(sql_sua);
            BangCTHD();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GridViewCTHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BangCTHD();
            BangHD();
            BangHH();
            Hienthi_Dulieu();
        }
    }
}
