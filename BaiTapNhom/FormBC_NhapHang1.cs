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
    public partial class FormBC_NhapHang1 : Form
    {
        public FormBC_NhapHang1()
        {
            InitializeComponent();
        }

        Connect_db testConnect = new Connect_db();

        private void FormBC_NhapHang1_Load(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            dta = testConnect.Lay_DulieuBang("SELECT * FROM nhapHang");
            BC_NhapHang1 bC_NhapHang1 = new BC_NhapHang1();
            bC_NhapHang1.SetDataSource(dta);
            CRV_NhapHang.ReportSource = bC_NhapHang1;
        }
    }
}
