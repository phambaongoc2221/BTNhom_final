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
    public partial class FormBC_BanHang : Form
    {
        public FormBC_BanHang()
        {
            InitializeComponent();
        }

        Connect_db testConnect = new Connect_db();

        private void FormBC_BanHang_Load(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            dta = testConnect.Lay_DulieuBang("SELECT * FROM hoaDon");
            BC_BanHang bC_BanHang = new BC_BanHang();
            bC_BanHang.SetDataSource(dta);
            CRV_BanHang.ReportSource = bC_BanHang;
        }
    }
}
