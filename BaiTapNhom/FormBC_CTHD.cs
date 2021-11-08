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
    public partial class FormBC_CTHD : Form
    {
        public FormBC_CTHD()
        {
            InitializeComponent();
        }
        Connect_db testConnect = new Connect_db();
        private void FormBC_CTHD_Load(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            dta = testConnect.Lay_DulieuBang("SELECT * FROM chiTiet_hoaDon");
            BC_CTHD bC_ChiTietHoaDon = new BC_CTHD();
            bC_ChiTietHoaDon.SetDataSource(dta);
            crystalReportViewer1.ReportSource = bC_ChiTietHoaDon;
        }
    }
}
