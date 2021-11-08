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
    public partial class FormBC_HangHoa : Form
    {
        public FormBC_HangHoa()
        {
            InitializeComponent();
        }
        Connect_db connect_db = new Connect_db();
        private void FormBC_HangHoa_Load(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            dta = connect_db.Lay_DulieuBang("Select * from hangHoa");
            BC_HangHoa bc_hh = new BC_HangHoa();  // khởi tạo báo cáo
            bc_hh.SetDataSource(dta);
            crystalReportViewer1.ReportSource = bc_hh;
        }
    }
}
