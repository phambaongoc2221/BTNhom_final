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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form NhaCC = new FormNCC();
            NhaCC.Show();
        }

        private void hàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form HangHoa = new FormHanghoa();
            HangHoa.Show();
        }

        private void nhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form NH = new FormNhapHang();
            NH.Show();
        }

        private void chiTiếtNhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form CTNH = new FormCTNH();
            CTNH.Show();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form KH = new FormKhachHang();
            KH.Show();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form NV = new FormNV();
            NV.Show();
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form HD = new FormHoaDon();
            HD.Show();
        }

        private void chiTiếtHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form CTHD = new FormCTHD();
            CTHD.Show();
        }

        private void kháchHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form TKKH = new FormTKKHang();
            TKKH.Show();
        }

        private void nhânViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form TKNV = new FormTKNVien();
            TKNV.Show();
        }

        private void nhậpHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form TKNH = new FormTKNHang();
            TKNH.Show();
        }

        private void bCHàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form BCHH = new FormBC_HangHoa();
            BCHH.Show();
        }

        private void hàngHóaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form TKHH = new FormTKHHoa();
            TKHH.Show();
        }

        private void bCNhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form BCNH = new FormBC_NhapHang();
            BCNH.Show();
        }

        private void bCHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form BCHD = new FormBC_HoaDon();
            BCHD.Show();
        }

        private void bCChiTiếtHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form BCCTHD = new FormBC_CTHD();
            BCCTHD.Show();
        }

        private void bCChiTiếtNhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form BCCTNH = new FormBC_CTNH();
            BCCTNH.Show();
        }

        private void nhàCungCấpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form TKNCC = new FormTKNCC();
            TKNCC.Show();
        }
    }
}
