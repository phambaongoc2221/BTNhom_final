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
    public partial class FormBC_HoaDon : Form
    {
        public FormBC_HoaDon()
        {
            InitializeComponent();
        }
        Connect_db testConnect = new Connect_db();
        private void FormBC_HoaDon_Load(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            dta = testConnect.Lay_DulieuBang("SELECT * FROM hoaDon");
            BC_HoaDon bC_HoaDon = new BC_HoaDon();
            bC_HoaDon.SetDataSource(dta);
            crystalReportViewer1.ReportSource = bC_HoaDon;
        }
    }
}
