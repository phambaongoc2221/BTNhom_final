
namespace BaiTapNhom
{
    partial class FormTKNVien
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
            this.DataGrid_TimKiemNV = new System.Windows.Forms.DataGridView();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtSoDT = new System.Windows.Forms.TextBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.cboMaNV = new System.Windows.Forms.ComboBox();
            this.radioSoDT = new System.Windows.Forms.RadioButton();
            this.radioTenNV = new System.Windows.Forms.RadioButton();
            this.radioMaNV = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_TimKiemNV)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGrid_TimKiemNV
            // 
            this.DataGrid_TimKiemNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_TimKiemNV.Location = new System.Drawing.Point(30, 259);
            this.DataGrid_TimKiemNV.Name = "DataGrid_TimKiemNV";
            this.DataGrid_TimKiemNV.RowHeadersWidth = 51;
            this.DataGrid_TimKiemNV.RowTemplate.Height = 24;
            this.DataGrid_TimKiemNV.Size = new System.Drawing.Size(723, 182);
            this.DataGrid_TimKiemNV.TabIndex = 25;
            this.DataGrid_TimKiemNV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_TimKiemNV_CellContentClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(619, 187);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(134, 39);
            this.btnThoat.TabIndex = 23;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(619, 123);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(134, 39);
            this.btnTimKiem.TabIndex = 24;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtSoDT
            // 
            this.txtSoDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoDT.Location = new System.Drawing.Point(204, 211);
            this.txtSoDT.Name = "txtSoDT";
            this.txtSoDT.Size = new System.Drawing.Size(363, 30);
            this.txtSoDT.TabIndex = 21;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNV.Location = new System.Drawing.Point(204, 162);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(363, 30);
            this.txtTenNV.TabIndex = 22;
            // 
            // cboMaNV
            // 
            this.cboMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaNV.FormattingEnabled = true;
            this.cboMaNV.Location = new System.Drawing.Point(204, 109);
            this.cboMaNV.Name = "cboMaNV";
            this.cboMaNV.Size = new System.Drawing.Size(363, 33);
            this.cboMaNV.TabIndex = 20;
            // 
            // radioSoDT
            // 
            this.radioSoDT.AutoSize = true;
            this.radioSoDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioSoDT.Location = new System.Drawing.Point(30, 213);
            this.radioSoDT.Name = "radioSoDT";
            this.radioSoDT.Size = new System.Drawing.Size(147, 29);
            this.radioSoDT.TabIndex = 17;
            this.radioSoDT.TabStop = true;
            this.radioSoDT.Text = "Số điện thoại";
            this.radioSoDT.UseVisualStyleBackColor = true;
            this.radioSoDT.CheckedChanged += new System.EventHandler(this.radioSoDT_CheckedChanged);
            // 
            // radioTenNV
            // 
            this.radioTenNV.AutoSize = true;
            this.radioTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioTenNV.Location = new System.Drawing.Point(30, 164);
            this.radioTenNV.Name = "radioTenNV";
            this.radioTenNV.Size = new System.Drawing.Size(165, 29);
            this.radioTenNV.TabIndex = 18;
            this.radioTenNV.TabStop = true;
            this.radioTenNV.Text = "Tên Nhân Viên";
            this.radioTenNV.UseVisualStyleBackColor = true;
            this.radioTenNV.CheckedChanged += new System.EventHandler(this.radioTenNV_CheckedChanged);
            // 
            // radioMaNV
            // 
            this.radioMaNV.AutoSize = true;
            this.radioMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioMaNV.Location = new System.Drawing.Point(30, 113);
            this.radioMaNV.Name = "radioMaNV";
            this.radioMaNV.Size = new System.Drawing.Size(158, 29);
            this.radioMaNV.TabIndex = 19;
            this.radioMaNV.TabStop = true;
            this.radioMaNV.Text = "Mã Nhân Viên";
            this.radioMaNV.UseVisualStyleBackColor = true;
            this.radioMaNV.CheckedChanged += new System.EventHandler(this.radioMaNV_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(418, 44);
            this.label1.TabIndex = 16;
            this.label1.Text = "TÌM KIẾM NHÂN VIÊN";
            // 
            // FormTKNVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.DataGrid_TimKiemNV);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtSoDT);
            this.Controls.Add(this.txtTenNV);
            this.Controls.Add(this.cboMaNV);
            this.Controls.Add(this.radioSoDT);
            this.Controls.Add(this.radioTenNV);
            this.Controls.Add(this.radioMaNV);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormTKNVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TÌM KIẾM NHÂN VIÊN";
            this.Load += new System.EventHandler(this.FormTKNVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_TimKiemNV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGrid_TimKiemNV;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtSoDT;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.ComboBox cboMaNV;
        private System.Windows.Forms.RadioButton radioSoDT;
        private System.Windows.Forms.RadioButton radioTenNV;
        private System.Windows.Forms.RadioButton radioMaNV;
        private System.Windows.Forms.Label label1;
    }
}