
namespace BaiTapNhom
{
    partial class FormTKNCC
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
            this.txtDT = new System.Windows.Forms.TextBox();
            this.radDT = new System.Windows.Forms.RadioButton();
            this.txtTenNCC = new System.Windows.Forms.TextBox();
            this.radTenNCC = new System.Windows.Forms.RadioButton();
            this.radMaNCC = new System.Windows.Forms.RadioButton();
            this.DataGrid_TimKiemNCC = new System.Windows.Forms.DataGridView();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.cboMaNCC = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_TimKiemNCC)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDT
            // 
            this.txtDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDT.Location = new System.Drawing.Point(200, 188);
            this.txtDT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDT.Name = "txtDT";
            this.txtDT.Size = new System.Drawing.Size(392, 30);
            this.txtDT.TabIndex = 115;
            // 
            // radDT
            // 
            this.radDT.AutoSize = true;
            this.radDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radDT.Location = new System.Drawing.Point(22, 189);
            this.radDT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radDT.Name = "radDT";
            this.radDT.Size = new System.Drawing.Size(118, 29);
            this.radDT.TabIndex = 122;
            this.radDT.Text = "Nhập ĐT:";
            this.radDT.UseVisualStyleBackColor = true;
            this.radDT.CheckedChanged += new System.EventHandler(this.radDT_CheckedChanged);
            // 
            // txtTenNCC
            // 
            this.txtTenNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNCC.Location = new System.Drawing.Point(200, 139);
            this.txtTenNCC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenNCC.Name = "txtTenNCC";
            this.txtTenNCC.Size = new System.Drawing.Size(392, 30);
            this.txtTenNCC.TabIndex = 117;
            // 
            // radTenNCC
            // 
            this.radTenNCC.AutoSize = true;
            this.radTenNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTenNCC.Location = new System.Drawing.Point(22, 140);
            this.radTenNCC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radTenNCC.Name = "radTenNCC";
            this.radTenNCC.Size = new System.Drawing.Size(167, 29);
            this.radTenNCC.TabIndex = 124;
            this.radTenNCC.Text = "Nhập tên NCC:";
            this.radTenNCC.UseVisualStyleBackColor = true;
            this.radTenNCC.CheckedChanged += new System.EventHandler(this.radTenNCC_CheckedChanged);
            // 
            // radMaNCC
            // 
            this.radMaNCC.AutoSize = true;
            this.radMaNCC.Checked = true;
            this.radMaNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMaNCC.Location = new System.Drawing.Point(22, 96);
            this.radMaNCC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radMaNCC.Name = "radMaNCC";
            this.radMaNCC.Size = new System.Drawing.Size(167, 29);
            this.radMaNCC.TabIndex = 125;
            this.radMaNCC.TabStop = true;
            this.radMaNCC.Text = "Nhập mã NCC:";
            this.radMaNCC.UseVisualStyleBackColor = true;
            this.radMaNCC.CheckedChanged += new System.EventHandler(this.radMaNCC_CheckedChanged);
            // 
            // DataGrid_TimKiemNCC
            // 
            this.DataGrid_TimKiemNCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_TimKiemNCC.Location = new System.Drawing.Point(104, 245);
            this.DataGrid_TimKiemNCC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DataGrid_TimKiemNCC.Name = "DataGrid_TimKiemNCC";
            this.DataGrid_TimKiemNCC.RowHeadersWidth = 51;
            this.DataGrid_TimKiemNCC.Size = new System.Drawing.Size(582, 179);
            this.DataGrid_TimKiemNCC.TabIndex = 120;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(633, 162);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(136, 39);
            this.btnThoat.TabIndex = 119;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(633, 96);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(136, 41);
            this.btnTimKiem.TabIndex = 118;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimKiem.Location = new System.Drawing.Point(162, 21);
            this.lblTimKiem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(505, 44);
            this.lblTimKiem.TabIndex = 121;
            this.lblTimKiem.Text = "TÌM KIẾM NHÀ CUNG CẤP";
            // 
            // cboMaNCC
            // 
            this.cboMaNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaNCC.FormattingEnabled = true;
            this.cboMaNCC.Location = new System.Drawing.Point(200, 91);
            this.cboMaNCC.Name = "cboMaNCC";
            this.cboMaNCC.Size = new System.Drawing.Size(392, 33);
            this.cboMaNCC.TabIndex = 126;
            // 
            // FormTKNCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.cboMaNCC);
            this.Controls.Add(this.txtDT);
            this.Controls.Add(this.radDT);
            this.Controls.Add(this.txtTenNCC);
            this.Controls.Add(this.radTenNCC);
            this.Controls.Add(this.radMaNCC);
            this.Controls.Add(this.DataGrid_TimKiemNCC);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.lblTimKiem);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormTKNCC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TÌM KIẾM NHÀ CUNG CẤP";
            this.Load += new System.EventHandler(this.FormTKNCC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_TimKiemNCC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDT;
        private System.Windows.Forms.RadioButton radDT;
        private System.Windows.Forms.TextBox txtTenNCC;
        private System.Windows.Forms.RadioButton radTenNCC;
        private System.Windows.Forms.RadioButton radMaNCC;
        private System.Windows.Forms.DataGridView DataGrid_TimKiemNCC;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.ComboBox cboMaNCC;
    }
}