
namespace BaiTapNhom
{
    partial class FormBC_BanHang
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
            this.CRV_BanHang = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // CRV_BanHang
            // 
            this.CRV_BanHang.ActiveViewIndex = -1;
            this.CRV_BanHang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CRV_BanHang.Cursor = System.Windows.Forms.Cursors.Default;
            this.CRV_BanHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CRV_BanHang.Location = new System.Drawing.Point(0, 0);
            this.CRV_BanHang.Name = "CRV_BanHang";
            this.CRV_BanHang.Size = new System.Drawing.Size(800, 450);
            this.CRV_BanHang.TabIndex = 0;
            // 
            // FormBC_BanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CRV_BanHang);
            this.Name = "FormBC_BanHang";
            this.Text = "BÁO CÁO BÁN HÀNG";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormBC_BanHang_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer CRV_BanHang;
    }
}