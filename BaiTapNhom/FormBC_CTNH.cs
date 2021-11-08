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
    public partial class FormBC_CTNH : Form
    {
        public FormBC_CTNH()
        {
            InitializeComponent();
        }
        Connect_db testConnect = new Connect_db();
        private void FormBC_CTNH_Load(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            dta = testConnect.Lay_DulieuBang("SELECT * FROM chiTiet_nhapHang");
            BC_CTNH bC_ChiTietNhapHang = new BC_CTNH();
            bC_ChiTietNhapHang.SetDataSource(dta);
            crystalReportViewer1.ReportSource = bC_ChiTietNhapHang;
        }
    }
}
