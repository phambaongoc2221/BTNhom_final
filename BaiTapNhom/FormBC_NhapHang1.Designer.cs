
namespace BaiTapNhom
{
    partial class FormBC_NhapHang1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CRV_NhapHang = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // CRV_NhapHang
            // 
            this.CRV_NhapHang.ActiveViewIndex = -1;
            this.CRV_NhapHang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CRV_NhapHang.Cursor = System.Windows.Forms.Cursors.Default;
            this.CRV_NhapHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CRV_NhapHang.Location = new System.Drawing.Point(0, 0);
            this.CRV_NhapHang.Name = "CRV_NhapHang";
            this.CRV_NhapHang.Size = new System.Drawing.Size(800, 450);
            this.CRV_NhapHang.TabIndex = 0;
            // 
            // FormBC_NhapHang1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CRV_NhapHang);
            this.Name = "FormBC_NhapHang1";
            this.Text = "BÁO CÁO NHẬP HÀNG";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormBC_NhapHang1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer CRV_NhapHang;
    }
}