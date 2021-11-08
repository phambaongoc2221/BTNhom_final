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

    public partial class FormHanghoa : Form
    {
        Connect_db kn = new Connect_db();
        public FormHanghoa()
        {
            InitializeComponent();
        }
        private void Bang_HangHoa()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DulieuBang("select * from hangHoa");
            dataGrid_HangHoa.DataSource = dta;

            HIENTHI_DULIEU();
        }

        public void Bang_NhaCungCap()// hiện thị ConboBox
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DulieuBang("Select * From nhaCungCap order by mancc");
            cboNCC.DataSource = dta;
            cboNCC.DisplayMember = "mancc";
            cboNCC.ValueMember = "mancc";
        }

        private void HIENTHI_DULIEU()
        {
            Bang_NhaCungCap();
            txtMaHangHoa.DataBindings.Clear();
            txtMaHangHoa.DataBindings.Add("Text", dataGrid_HangHoa.DataSource, "mahh");

            cboNCC.DataBindings.Clear();
            cboNCC.DataBindings.Add("Text", dataGrid_HangHoa.DataSource, "mancc");

            txtTenHH.DataBindings.Clear();
            txtTenHH.DataBindings.Add("Text", dataGrid_HangHoa.DataSource, "tenhh");

            txtTrangThai.DataBindings.Clear();
            txtTrangThai.DataBindings.Add("Text", dataGrid_HangHoa.DataSource, "trangthai");

            numSoLuong.DataBindings.Clear();
            numSoLuong.DataBindings.Add("Value", dataGrid_HangHoa.DataSource, "soluong");

            numDonGia.DataBindings.Clear();
            numDonGia.DataBindings.Add("Value", dataGrid_HangHoa.DataSource, "dongia");

            dataGrid_HangHoa.Columns[0].HeaderText = "Mã Hàng";
            dataGrid_HangHoa.Columns[1].HeaderText = "Mã NCC";
            dataGrid_HangHoa.Columns[2].HeaderText = "Tên Hàng";
            dataGrid_HangHoa.Columns[3].HeaderText = "Trạng thái";
            dataGrid_HangHoa.Columns[4].HeaderText = "Số lượng";
            dataGrid_HangHoa.Columns[5].HeaderText = "Đơn giá";
            dataGrid_HangHoa.Columns[0].Width = 120;
            dataGrid_HangHoa.Columns[1].Width = 120;
            dataGrid_HangHoa.Columns[2].Width = 200;
            dataGrid_HangHoa.Columns[3].Width = 120;
            dataGrid_HangHoa.Columns[4].Width = 120;
            dataGrid_HangHoa.Columns[5].Width = 200;
            dataGrid_HangHoa.AllowUserToAddRows = false;
            dataGrid_HangHoa.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void FormHanghoa_Load(object sender, EventArgs e)
        {
            Bang_HangHoa();
            Bang_NhaCungCap();
            HIENTHI_DULIEU();
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            txtMaHangHoa.Text = "";
            txtTenHH.Text = "";
            txtTrangThai.Text = "";
            numSoLuong.Value = 0;
            numDonGia.Value = 0;
            txtMaHangHoa.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string strKtra = "select mahh from hangHoa where mahh = '" + txtMaHangHoa.Text + "'";
            SqlCommand cmd = new SqlCommand(strKtra, kn.cnn);
            SqlDataReader doc_dl = cmd.ExecuteReader();

            if (doc_dl.Read() == true)
            {
                MessageBox.Show("Hàng hóa này đã tồn tại, nhập lại mã khác", "Thông báo");
                txtMaHangHoa.Focus();
                doc_dl.Close();
                doc_dl.Dispose();
            }
            else
            {
                string sql_luu;
                sql_luu = "insert into hangHoa values('" + txtMaHangHoa.Text + "','" + cboNCC.Text + "','" + txtTenHH.Text + "','" + txtTrangThai.Text + "','" + numSoLuong.Value + "','" + numDonGia.Value + "')";

                kn.ThucThi(sql_luu);
                Bang_HangHoa();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql_sua;
            sql_sua = "update hangHoa set mancc= '" + cboNCC.Text + "', tenhh= '" + txtTenHH.Text + "', trangthai= '" + txtTrangThai.Text + "', soluong = " + numSoLuong.Value + ", dongia = " + numDonGia.Value + " where mahh = '" + txtMaHangHoa.Text + "'";

            kn.ThucThi(sql_sua);
            Bang_HangHoa();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn có muốn xóa k ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (thongbao == DialogResult.Yes)
            {
                string sql_xoa;
                sql_xoa = " delete hangHoa where mahh = '" + txtMaHangHoa.Text + "'";

                kn.ThucThi(sql_xoa);
                Bang_HangHoa();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGrid_HangHoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            HIENTHI_DULIEU();
        }
    }
}
