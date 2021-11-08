
namespace BaiTapNhom
{
    partial class FormNhapHang
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBoxThongtinchung = new System.Windows.Forms.GroupBox();
            this.cboNCC = new System.Windows.Forms.ComboBox();
            this.txtNgaynhap = new System.Windows.Forms.TextBox();
            this.txtMaNH = new System.Windows.Forms.TextBox();
            this.lblMaNCC = new System.Windows.Forms.Label();
            this.lblNgaynhap = new System.Windows.Forms.Label();
            this.lblmanhap1 = new System.Windows.Forms.Label();
            this.lblDM = new System.Windows.Forms.Label();
            this.grBoxCTNH = new System.Windows.Forms.GroupBox();
            this.GridViewCTNH = new System.Windows.Forms.DataGridView();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnTao = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBoxThongtinchung.SuspendLayout();
            this.grBoxCTNH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewCTNH)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxThongtinchung);
            this.splitContainer1.Panel1.Controls.Add(this.lblDM);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.grBoxCTNH);
            this.splitContainer1.Size = new System.Drawing.Size(969, 532);
            this.splitContainer1.SplitterDistance = 210;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 3;
            // 
            // groupBoxThongtinchung
            // 
            this.groupBoxThongtinchung.Controls.Add(this.cboNCC);
            this.groupBoxThongtinchung.Controls.Add(this.txtNgaynhap);
            this.groupBoxThongtinchung.Controls.Add(this.txtMaNH);
            this.groupBoxThongtinchung.Controls.Add(this.lblMaNCC);
            this.groupBoxThongtinchung.Controls.Add(this.lblNgaynhap);
            this.groupBoxThongtinchung.Controls.Add(this.lblmanhap1);
            this.groupBoxThongtinchung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBoxThongtinchung.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBoxThongtinchung.Location = new System.Drawing.Point(13, 79);
            this.groupBoxThongtinchung.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxThongtinchung.Name = "groupBoxThongtinchung";
            this.groupBoxThongtinchung.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxThongtinchung.Size = new System.Drawing.Size(943, 101);
            this.groupBoxThongtinchung.TabIndex = 1;
            this.groupBoxThongtinchung.TabStop = false;
            // 
            // cboNCC
            // 
            this.cboNCC.FormattingEnabled = true;
            this.cboNCC.Location = new System.Drawing.Point(447, 42);
            this.cboNCC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboNCC.Name = "cboNCC";
            this.cboNCC.Size = new System.Drawing.Size(124, 33);
            this.cboNCC.TabIndex = 18;
            // 
            // txtNgaynhap
            // 
            this.txtNgaynhap.Location = new System.Drawing.Point(731, 45);
            this.txtNgaynhap.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNgaynhap.Name = "txtNgaynhap";
            this.txtNgaynhap.Size = new System.Drawing.Size(192, 30);
            this.txtNgaynhap.TabIndex = 17;
            // 
            // txtMaNH
            // 
            this.txtMaNH.Location = new System.Drawing.Point(121, 42);
            this.txtMaNH.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMaNH.Name = "txtMaNH";
            this.txtMaNH.Size = new System.Drawing.Size(130, 30);
            this.txtMaNH.TabIndex = 7;
            // 
            // lblMaNCC
            // 
            this.lblMaNCC.AutoSize = true;
            this.lblMaNCC.Location = new System.Drawing.Point(276, 48);
            this.lblMaNCC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaNCC.Name = "lblMaNCC";
            this.lblMaNCC.Size = new System.Drawing.Size(163, 25);
            this.lblMaNCC.TabIndex = 3;
            this.lblMaNCC.Text = "Mã nhà cung cấp";
            // 
            // lblNgaynhap
            // 
            this.lblNgaynhap.AutoSize = true;
            this.lblNgaynhap.Location = new System.Drawing.Point(628, 47);
            this.lblNgaynhap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNgaynhap.Name = "lblNgaynhap";
            this.lblNgaynhap.Size = new System.Drawing.Size(107, 25);
            this.lblNgaynhap.TabIndex = 1;
            this.lblNgaynhap.Text = "Ngày nhập";
            // 
            // lblmanhap1
            // 
            this.lblmanhap1.AutoSize = true;
            this.lblmanhap1.Location = new System.Drawing.Point(24, 47);
            this.lblmanhap1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmanhap1.Name = "lblmanhap1";
            this.lblmanhap1.Size = new System.Drawing.Size(89, 25);
            this.lblmanhap1.TabIndex = 0;
            this.lblmanhap1.Text = "Mã nhập";
            // 
            // lblDM
            // 
            this.lblDM.AutoSize = true;
            this.lblDM.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDM.Location = new System.Drawing.Point(248, 18);
            this.lblDM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDM.Name = "lblDM";
            this.lblDM.Size = new System.Drawing.Size(473, 44);
            this.lblDM.TabIndex = 0;
            this.lblDM.Text = "DANH MỤC NHẬP HÀNG";
            // 
            // grBoxCTNH
            // 
            this.grBoxCTNH.Controls.Add(this.GridViewCTNH);
            this.grBoxCTNH.Controls.Add(this.btnThoat);
            this.grBoxCTNH.Controls.Add(this.btnSua);
            this.grBoxCTNH.Controls.Add(this.btnHuy);
            this.grBoxCTNH.Controls.Add(this.btnLuu);
            this.grBoxCTNH.Controls.Add(this.btnTao);
            this.grBoxCTNH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grBoxCTNH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grBoxCTNH.Location = new System.Drawing.Point(42, 30);
            this.grBoxCTNH.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grBoxCTNH.Name = "grBoxCTNH";
            this.grBoxCTNH.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grBoxCTNH.Size = new System.Drawing.Size(894, 274);
            this.grBoxCTNH.TabIndex = 0;
            this.grBoxCTNH.TabStop = false;
            // 
            // GridViewCTNH
            // 
            this.GridViewCTNH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewCTNH.Location = new System.Drawing.Point(30, 19);
            this.GridViewCTNH.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GridViewCTNH.Name = "GridViewCTNH";
            this.GridViewCTNH.RowHeadersWidth = 51;
            this.GridViewCTNH.RowTemplate.Height = 24;
            this.GridViewCTNH.Size = new System.Drawing.Size(830, 180);
            this.GridViewCTNH.TabIndex = 22;
            this.GridViewCTNH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewCTNH_CellContentClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(754, 217);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(110, 34);
            this.btnThoat.TabIndex = 21;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(566, 217);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(144, 34);
            this.btnSua.TabIndex = 20;
            this.btnSua.Text = "Sửa đơn nhập";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(361, 217);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(159, 34);
            this.btnHuy.TabIndex = 19;
            this.btnHuy.Text = "Hủy đơn nhập";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(182, 217);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(153, 34);
            this.btnLuu.TabIndex = 18;
            this.btnLuu.Text = "Lưu đơn nhập";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnTao
            // 
            this.btnTao.Location = new System.Drawing.Point(34, 217);
            this.btnTao.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnTao.Name = "btnTao";
            this.btnTao.Size = new System.Drawing.Size(109, 34);
            this.btnTao.TabIndex = 17;
            this.btnTao.Text = "Tạo đơn nhập mới";
            this.btnTao.UseVisualStyleBackColor = true;
            this.btnTao.Click += new System.EventHandler(this.btnTao_Click_1);
            // 
            // FormNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 532);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormNhapHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DANH MỤC NHẬP HÀNG";
            this.Load += new System.EventHandler(this.FormNhapHang_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBoxThongtinchung.ResumeLayout(false);
            this.groupBoxThongtinchung.PerformLayout();
            this.grBoxCTNH.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewCTNH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBoxThongtinchung;
        private System.Windows.Forms.TextBox txtMaNH;
        private System.Windows.Forms.Label lblMaNCC;
        private System.Windows.Forms.Label lblNgaynhap;
        private System.Windows.Forms.Label lblmanhap1;
        private System.Windows.Forms.Label lblDM;
        private System.Windows.Forms.GroupBox grBoxCTNH;
        private System.Windows.Forms.DataGridView GridViewCTNH;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnTao;
        private System.Windows.Forms.TextBox txtNgaynhap;
        private System.Windows.Forms.ComboBox cboNCC;
    }
}