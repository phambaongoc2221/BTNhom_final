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
    public partial class FormNCC : Form
    {
        Connect_db kn = new Connect_db();
        public FormNCC()
        {
            InitializeComponent();
        }

        private void BANG_NHACUNGCAP()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DulieuBang("Select * From nhaCungCap");
            DataGrid_NhaCungCap.DataSource = dta;
            HIENTHI_DULIEU();
        }

        private void HIENTHI_DULIEU()
        {
            //BANG_NHACUNGCAP();
            txtMaNCC.DataBindings.Clear();
            txtMaNCC.DataBindings.Add("Text", DataGrid_NhaCungCap.DataSource, "mancc");
            txtTenNCC.DataBindings.Clear();
            txtTenNCC.DataBindings.Add("Text", DataGrid_NhaCungCap.DataSource, "tenncc");
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", DataGrid_NhaCungCap.DataSource, "diachi");
            txtDT.DataBindings.Clear();
            txtDT.DataBindings.Add("Text", DataGrid_NhaCungCap.DataSource, "sdt");

            DataGrid_NhaCungCap.Columns[0].HeaderText = "Mã NCC";
            DataGrid_NhaCungCap.Columns[1].HeaderText = "Tên NCC";
            DataGrid_NhaCungCap.Columns[2].HeaderText = "Địa chỉ";
            DataGrid_NhaCungCap.Columns[3].HeaderText = "Số điện thoại";
            DataGrid_NhaCungCap.Columns[0].Width = 150;
            DataGrid_NhaCungCap.Columns[1].Width = 200;
            DataGrid_NhaCungCap.Columns[2].Width = 200;
            DataGrid_NhaCungCap.Columns[3].Width = 250;
            DataGrid_NhaCungCap.AllowUserToAddRows = false;
            DataGrid_NhaCungCap.EditMode = DataGridViewEditMode.EditProgrammatically;

        }
        private void btnTaomoi_Click(object sender, EventArgs e)
        {
            txtMaNCC.Text = "";
            txtTenNCC.Text = "";
            txtDT.Text = "";
            txtDiaChi.Text = "";
            txtMaNCC.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql_ktra = "Select mancc From nhaCungCap Where mancc ='" + txtMaNCC.Text + "'";
            SqlCommand cmd = new SqlCommand(sql_ktra, kn.cnn);
            SqlDataReader doc_d1 = cmd.ExecuteReader();
            if (doc_d1.Read() == true)
            {
                MessageBox.Show("Nhà cung cấp đã tồn tại, nhập lại mã mới", "Thông báo");
                txtMaNCC.Focus();
                doc_d1.Close();
                doc_d1.Dispose();
            }
            else
            {
                string sql1;
                sql1 = " INSERT INTO nhaCungCap VALUES ('" + txtMaNCC.Text + "', '" + txtTenNCC.Text + "', '" + txtDiaChi.Text + "', '" + txtDT.Text + "')";
                kn.ThucThi(sql1);
                BANG_NHACUNGCAP();
            }
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql2;
            sql2 = "UPDATE nhaCungCap SET tenncc =  '" + txtTenNCC.Text + "', diachi = '" + txtDiaChi.Text + "', sdt = '" + txtDT.Text + "' WHERE mancc = '" + txtMaNCC.Text + "'";
            kn.ThucThi(sql2);
            BANG_NHACUNGCAP();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn có muốn xóa dữ liệu này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (thongbao == DialogResult.Yes)
            {
                string sql_xoa = "Delete nhaCungCap where mancc = '" + txtMaNCC.Text + "'";
                kn.ThucThi(sql_xoa);
                BANG_NHACUNGCAP();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DataGrid_NhaCungCap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            HIENTHI_DULIEU();
        }

        private void FormNCC_Load(object sender, EventArgs e)
        {
            BANG_NHACUNGCAP();
            HIENTHI_DULIEU();
        }

        private void lblTenNCC_Click(object sender, EventArgs e)
        {

        }
    }
}
