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
    public partial class FormTKHDon : Form
    {
        public FormTKHDon()
        {
            InitializeComponent();
        }

        private void FormTKHDon_Load(object sender, EventArgs e)
        {

        }

        Connect_db connect_db = new Connect_db();

        DataTable dta = new DataTable();

        private void BangKhachHang()
        {
            dta = connect_db.Lay_DulieuBang("Select * From khachHang order by makh");
            cboMkh.DataSource = dta;
            cboMkh.DisplayMember = "makh";
            cboMkh.ValueMember = "makh";
        }

        private void BangNhanVien()
        {
            dta = connect_db.Lay_DulieuBang("Select * From nhanVien order by manv");
            cboMnv.DataSource = dta;
            cboMnv.DisplayMember = "manv";
            cboMnv.ValueMember = "manv";
        }
        private void FormTKHDon_Load_1(object sender, EventArgs e)
        {
            DataTable dta = connect_db.Lay_DulieuBang("SELECT * FROM hoaDon ORDER BY mahd");
            cboMhd.DataSource = dta;
            cboMhd.DisplayMember = "mahd";
            BangKhachHang();
            BangNhanVien();
        }

        private void buttonTimkiem_Click(object sender, EventArgs e)
        {
            string sqltk;

            if (radioMhd.Checked == true)
            {
                sqltk = "SELECT * FROM hoaDon WHERE mahd LIKE '" + cboMhd.Text + "'";
                dta = connect_db.Lay_DulieuBang(sqltk);
            }

            if (radioMkh.Checked == true)
            {
                sqltk = "SELECT * FROM hoaDon WHERE makh LIKE  '" + cboMkh.Text + "'";
                dta = connect_db.Lay_DulieuBang(sqltk);
            }

            if (radioMnv.Checked == true)
            {
                sqltk = "SELECT * FROM hoaDon WHERE manv LIKE '" + cboMnv.Text + "'";
                dta = connect_db.Lay_DulieuBang(sqltk);
            }
            

            dataGridViewTKHD.DataSource = dta;

            dataGridViewTKHD.Columns[0].HeaderText = "Mã hóa đơn";
            dataGridViewTKHD.Columns[1].HeaderText = "Mã khách hàng";
            dataGridViewTKHD.Columns[2].HeaderText = "Mã nhân viên";
            dataGridViewTKHD.Columns[3].HeaderText = "Ngày tạo";
            dataGridViewTKHD.Columns[4].HeaderText = "Tổng tiền";
            dataGridViewTKHD.Columns[0].Width = 100;
            dataGridViewTKHD.Columns[1].Width = 100;
            dataGridViewTKHD.Columns[2].Width = 100;
            dataGridViewTKHD.Columns[3].Width = 170;
            dataGridViewTKHD.Columns[4].Width = 170;
            dataGridViewTKHD.AllowUserToAddRows = false;
            dataGridViewTKHD.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void radioMhd_CheckedChanged(object sender, EventArgs e)
        {
            cboMhd.Focus();

            cboMhd.Enabled = true;

            cboMkh.Enabled = false;
            cboMnv.Enabled = false;
            //textNgaytao.Enabled = false;
        }

        private void radioMkh_CheckedChanged(object sender, EventArgs e)
        {
            cboMkh.Focus();

            cboMkh.Enabled = true;

            cboMhd.Enabled = false;
            cboMnv.Enabled = false;
            //textNgaytao.Enabled = false;
        }

        private void radioMnv_CheckedChanged(object sender, EventArgs e)
        {
            cboMnv.Focus();

            cboMnv.Enabled = true;

            cboMhd.Enabled = false;
            cboMkh.Enabled = false;
            //textNgaytao.Enabled = false;
        }

        
        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
