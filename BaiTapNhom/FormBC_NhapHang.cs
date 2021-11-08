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
    public partial class FormBC_NhapHang : Form
    {
        public FormBC_NhapHang()
        {
            InitializeComponent();
        }
        Connect_db testConnect = new Connect_db();
        private void FormBC_NhapHang_Load(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            dta = testConnect.Lay_DulieuBang("SELECT * FROM nhapHang");
            BC_NhapHang bC_NhapHang = new BC_NhapHang();
            bC_NhapHang.SetDataSource(dta);
            crystalReportViewer1.ReportSource = bC_NhapHang;
        }
    }
}
