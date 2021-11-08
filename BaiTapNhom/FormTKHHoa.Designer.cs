
namespace BaiTapNhom
{
    partial class FormTKHHoa
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
            this.txtGia = new System.Windows.Forms.TextBox();
            this.radioNhapGia = new System.Windows.Forms.RadioButton();
            this.radioNhapNCC = new System.Windows.Forms.RadioButton();
            this.radioNhapTen = new System.Windows.Forms.RadioButton();
            this.txtNhapTen = new System.Windows.Forms.TextBox();
            this.radioNhapMa = new System.Windows.Forms.RadioButton();
            this.DataGrid_KetQua = new System.Windows.Forms.DataGridView();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.cboMaHH = new System.Windows.Forms.ComboBox();
            this.cboNCC = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_KetQua)).BeginInit();
            this.SuspendLayout();
            // 
            // txtGia
            // 
            this.txtGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGia.Location = new System.Drawing.Point(186, 207);
            this.txtGia.Margin = new System.Windows.Forms.Padding(2);
            this.txtGia.Multiline = true;
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(344, 31);
            this.txtGia.TabIndex = 88;
            // 
            // radioNhapGia
            // 
            this.radioNhapGia.AutoSize = true;
            this.radioNhapGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radioNhapGia.Location = new System.Drawing.Point(24, 213);
            this.radioNhapGia.Margin = new System.Windows.Forms.Padding(2);
            this.radioNhapGia.Name = "radioNhapGia";
            this.radioNhapGia.Size = new System.Drawing.Size(150, 29);
            this.radioNhapGia.TabIndex = 86;
            this.radioNhapGia.TabStop = true;
            this.radioNhapGia.Text = "Nhập giá HH:";
            this.radioNhapGia.UseVisualStyleBackColor = true;
            this.radioNhapGia.CheckedChanged += new System.EventHandler(this.radioNhapGia_CheckedChanged);
            // 
            // radioNhapNCC
            // 
            this.radioNhapNCC.AutoSize = true;
            this.radioNhapNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radioNhapNCC.Location = new System.Drawing.Point(24, 166);
            this.radioNhapNCC.Margin = new System.Windows.Forms.Padding(2);
            this.radioNhapNCC.Name = "radioNhapNCC";
            this.radioNhapNCC.Size = new System.Drawing.Size(167, 29);
            this.radioNhapNCC.TabIndex = 85;
            this.radioNhapNCC.TabStop = true;
            this.radioNhapNCC.Text = "Nhập mã NCC:";
            this.radioNhapNCC.UseVisualStyleBackColor = true;
            this.radioNhapNCC.CheckedChanged += new System.EventHandler(this.radioNhapNCC_CheckedChanged);
            // 
            // radioNhapTen
            // 
            this.radioNhapTen.AutoSize = true;
            this.radioNhapTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radioNhapTen.Location = new System.Drawing.Point(24, 123);
            this.radioNhapTen.Margin = new System.Windows.Forms.Padding(2);
            this.radioNhapTen.Name = "radioNhapTen";
            this.radioNhapTen.Size = new System.Drawing.Size(151, 29);
            this.radioNhapTen.TabIndex = 84;
            this.radioNhapTen.TabStop = true;
            this.radioNhapTen.Text = "Nhập tên HH:";
            this.radioNhapTen.UseVisualStyleBackColor = true;
            this.radioNhapTen.CheckedChanged += new System.EventHandler(this.radioNhapTen_CheckedChanged);
            // 
            // txtNhapTen
            // 
            this.txtNhapTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhapTen.Location = new System.Drawing.Point(186, 119);
            this.txtNhapTen.Margin = new System.Windows.Forms.Padding(2);
            this.txtNhapTen.Multiline = true;
            this.txtNhapTen.Name = "txtNhapTen";
            this.txtNhapTen.Size = new System.Drawing.Size(344, 31);
            this.txtNhapTen.TabIndex = 83;
            // 
            // radioNhapMa
            // 
            this.radioNhapMa.AutoSize = true;
            this.radioNhapMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radioNhapMa.Location = new System.Drawing.Point(24, 78);
            this.radioNhapMa.Margin = new System.Windows.Forms.Padding(2);
            this.radioNhapMa.Name = "radioNhapMa";
            this.radioNhapMa.Size = new System.Drawing.Size(151, 29);
            this.radioNhapMa.TabIndex = 82;
            this.radioNhapMa.TabStop = true;
            this.radioNhapMa.Text = "Nhập mã HH:";
            this.radioNhapMa.UseVisualStyleBackColor = true;
            this.radioNhapMa.CheckedChanged += new System.EventHandler(this.radioNhapMa_CheckedChanged);
            // 
            // DataGrid_KetQua
            // 
            this.DataGrid_KetQua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_KetQua.Location = new System.Drawing.Point(35, 260);
            this.DataGrid_KetQua.Margin = new System.Windows.Forms.Padding(2);
            this.DataGrid_KetQua.Name = "DataGrid_KetQua";
            this.DataGrid_KetQua.RowHeadersWidth = 51;
            this.DataGrid_KetQua.RowTemplate.Height = 24;
            this.DataGrid_KetQua.Size = new System.Drawing.Size(700, 160);
            this.DataGrid_KetQua.TabIndex = 81;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(586, 106);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(138, 44);
            this.btnTimKiem.TabIndex = 80;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(586, 167);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(138, 45);
            this.btnThoat.TabIndex = 79;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(178, 19);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(415, 44);
            this.label13.TabIndex = 77;
            this.label13.Text = "TÌM KIẾM HÀNG HÓA";
            // 
            // cboMaHH
            // 
            this.cboMaHH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaHH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaHH.FormattingEnabled = true;
            this.cboMaHH.Location = new System.Drawing.Point(186, 78);
            this.cboMaHH.Name = "cboMaHH";
            this.cboMaHH.Size = new System.Drawing.Size(344, 33);
            this.cboMaHH.TabIndex = 89;
            // 
            // cboNCC
            // 
            this.cboNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNCC.FormattingEnabled = true;
            this.cboNCC.Location = new System.Drawing.Point(186, 166);
            this.cboNCC.Name = "cboNCC";
            this.cboNCC.Size = new System.Drawing.Size(344, 33);
            this.cboNCC.TabIndex = 90;
            // 
            // FormTKHHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.cboNCC);
            this.Controls.Add(this.cboMaHH);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.radioNhapGia);
            this.Controls.Add(this.radioNhapNCC);
            this.Controls.Add(this.radioNhapTen);
            this.Controls.Add(this.txtNhapTen);
            this.Controls.Add(this.radioNhapMa);
            this.Controls.Add(this.DataGrid_KetQua);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.label13);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormTKHHoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TÌM KIẾM HÀNG HÓA";
            this.Load += new System.EventHandler(this.FormTKHHoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_KetQua)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.RadioButton radioNhapGia;
        private System.Windows.Forms.RadioButton radioNhapNCC;
        private System.Windows.Forms.RadioButton radioNhapTen;
        private System.Windows.Forms.TextBox txtNhapTen;
        private System.Windows.Forms.RadioButton radioNhapMa;
        private System.Windows.Forms.DataGridView DataGrid_KetQua;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cboMaHH;
        private System.Windows.Forms.ComboBox cboNCC;
    }
}