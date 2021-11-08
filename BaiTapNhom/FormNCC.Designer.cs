
namespace BaiTapNhom
{
    partial class FormNCC
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
            this.DataGrid_NhaCungCap = new System.Windows.Forms.DataGridView();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnTaomoi = new System.Windows.Forms.Button();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lblDiachi = new System.Windows.Forms.Label();
            this.txtDT = new System.Windows.Forms.TextBox();
            this.lblDT = new System.Windows.Forms.Label();
            this.txtTenNCC = new System.Windows.Forms.TextBox();
            this.lblTenNCC = new System.Windows.Forms.Label();
            this.txtMaNCC = new System.Windows.Forms.TextBox();
            this.lblMaNCC = new System.Windows.Forms.Label();
            this.lblPhongBan = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_NhaCungCap)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGrid_NhaCungCap
            // 
            this.DataGrid_NhaCungCap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_NhaCungCap.Location = new System.Drawing.Point(76, 198);
            this.DataGrid_NhaCungCap.Margin = new System.Windows.Forms.Padding(4);
            this.DataGrid_NhaCungCap.Name = "DataGrid_NhaCungCap";
            this.DataGrid_NhaCungCap.RowHeadersWidth = 51;
            this.DataGrid_NhaCungCap.Size = new System.Drawing.Size(806, 226);
            this.DataGrid_NhaCungCap.TabIndex = 123;
            this.DataGrid_NhaCungCap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_NhaCungCap_CellContentClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(788, 460);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(94, 32);
            this.btnThoat.TabIndex = 117;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(572, 460);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(93, 32);
            this.btnXoa.TabIndex = 116;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(409, 460);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(85, 32);
            this.btnSua.TabIndex = 115;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(230, 460);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(91, 32);
            this.btnLuu.TabIndex = 114;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnTaomoi
            // 
            this.btnTaomoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaomoi.Location = new System.Drawing.Point(76, 460);
            this.btnTaomoi.Margin = new System.Windows.Forms.Padding(4);
            this.btnTaomoi.Name = "btnTaomoi";
            this.btnTaomoi.Size = new System.Drawing.Size(100, 32);
            this.btnTaomoi.TabIndex = 113;
            this.btnTaomoi.Text = "Tạo mới";
            this.btnTaomoi.UseVisualStyleBackColor = true;
            this.btnTaomoi.Click += new System.EventHandler(this.btnTaomoi_Click);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(595, 130);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(287, 30);
            this.txtDiaChi.TabIndex = 111;
            // 
            // lblDiachi
            // 
            this.lblDiachi.AutoSize = true;
            this.lblDiachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiachi.Location = new System.Drawing.Point(482, 135);
            this.lblDiachi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiachi.Name = "lblDiachi";
            this.lblDiachi.Size = new System.Drawing.Size(77, 25);
            this.lblDiachi.TabIndex = 119;
            this.lblDiachi.Text = "Địa chỉ:";
            // 
            // txtDT
            // 
            this.txtDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDT.Location = new System.Drawing.Point(595, 85);
            this.txtDT.Margin = new System.Windows.Forms.Padding(4);
            this.txtDT.Name = "txtDT";
            this.txtDT.Size = new System.Drawing.Size(210, 30);
            this.txtDT.TabIndex = 112;
            // 
            // lblDT
            // 
            this.lblDT.AutoSize = true;
            this.lblDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDT.Location = new System.Drawing.Point(482, 90);
            this.lblDT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDT.Name = "lblDT";
            this.lblDT.Size = new System.Drawing.Size(105, 25);
            this.lblDT.TabIndex = 120;
            this.lblDT.Text = "Điện thoại:";
            // 
            // txtTenNCC
            // 
            this.txtTenNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNCC.Location = new System.Drawing.Point(242, 130);
            this.txtTenNCC.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenNCC.Name = "txtTenNCC";
            this.txtTenNCC.Size = new System.Drawing.Size(207, 30);
            this.txtTenNCC.TabIndex = 110;
            // 
            // lblTenNCC
            // 
            this.lblTenNCC.AutoSize = true;
            this.lblTenNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenNCC.Location = new System.Drawing.Point(65, 137);
            this.lblTenNCC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenNCC.Name = "lblTenNCC";
            this.lblTenNCC.Size = new System.Drawing.Size(176, 25);
            this.lblTenNCC.TabIndex = 121;
            this.lblTenNCC.Text = "Tên nhà cung cấp:";
            this.lblTenNCC.Click += new System.EventHandler(this.lblTenNCC_Click);
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNCC.Location = new System.Drawing.Point(242, 83);
            this.txtMaNCC.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.Size = new System.Drawing.Size(143, 30);
            this.txtMaNCC.TabIndex = 109;
            // 
            // lblMaNCC
            // 
            this.lblMaNCC.AutoSize = true;
            this.lblMaNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNCC.Location = new System.Drawing.Point(65, 88);
            this.lblMaNCC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaNCC.Name = "lblMaNCC";
            this.lblMaNCC.Size = new System.Drawing.Size(169, 25);
            this.lblMaNCC.TabIndex = 122;
            this.lblMaNCC.Text = "Mã nhà cung cấp:";
            // 
            // lblPhongBan
            // 
            this.lblPhongBan.AutoSize = true;
            this.lblPhongBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhongBan.Location = new System.Drawing.Point(222, 18);
            this.lblPhongBan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhongBan.Name = "lblPhongBan";
            this.lblPhongBan.Size = new System.Drawing.Size(540, 44);
            this.lblPhongBan.TabIndex = 118;
            this.lblPhongBan.Text = "DANH MỤC NHÀ CUNG CẤP";
            // 
            // FormNCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 532);
            this.Controls.Add(this.DataGrid_NhaCungCap);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnTaomoi);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.lblDiachi);
            this.Controls.Add(this.txtDT);
            this.Controls.Add(this.lblDT);
            this.Controls.Add(this.txtTenNCC);
            this.Controls.Add(this.lblTenNCC);
            this.Controls.Add(this.txtMaNCC);
            this.Controls.Add(this.lblMaNCC);
            this.Controls.Add(this.lblPhongBan);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormNCC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DANH MỤC NHÀ CUNG CẤP";
            this.Load += new System.EventHandler(this.FormNCC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_NhaCungCap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGrid_NhaCungCap;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnTaomoi;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label lblDiachi;
        private System.Windows.Forms.TextBox txtDT;
        private System.Windows.Forms.Label lblDT;
        private System.Windows.Forms.TextBox txtTenNCC;
        private System.Windows.Forms.Label lblTenNCC;
        private System.Windows.Forms.TextBox txtMaNCC;
        private System.Windows.Forms.Label lblMaNCC;
        private System.Windows.Forms.Label lblPhongBan;
    }
}