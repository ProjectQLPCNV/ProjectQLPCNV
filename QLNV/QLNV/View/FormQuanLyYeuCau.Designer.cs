namespace QLNV
{
    partial class FormQuanLyYeuCau
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
            this.components = new System.ComponentModel.Container();
            this.gridYeuCau = new System.Windows.Forms.DataGridView();
            this.PhanCong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.BtnTaoCa = new System.Windows.Forms.Button();
            this.txtSoLuongCa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.txtSoNguoiLam = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.yeuCauIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayTrucDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongCaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongNguoiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caTrucDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yeuCauBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridYeuCau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yeuCauBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridYeuCau
            // 
            this.gridYeuCau.AllowUserToAddRows = false;
            this.gridYeuCau.AllowUserToDeleteRows = false;
            this.gridYeuCau.AutoGenerateColumns = false;
            this.gridYeuCau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridYeuCau.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.yeuCauIDDataGridViewTextBoxColumn,
            this.ngayTrucDataGridViewTextBoxColumn,
            this.soLuongCaDataGridViewTextBoxColumn,
            this.soLuongNguoiDataGridViewTextBoxColumn,
            this.caTrucDataGridViewTextBoxColumn,
            this.PhanCong});
            this.gridYeuCau.DataSource = this.yeuCauBindingSource;
            this.gridYeuCau.Location = new System.Drawing.Point(12, 12);
            this.gridYeuCau.Name = "gridYeuCau";
            this.gridYeuCau.RowTemplate.Height = 24;
            this.gridYeuCau.Size = new System.Drawing.Size(788, 273);
            this.gridYeuCau.TabIndex = 0;
            this.gridYeuCau.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridYeuCau_CellClick);
            // 
            // PhanCong
            // 
            this.PhanCong.DataPropertyName = "PhanCong";
            this.PhanCong.HeaderText = "PhanCong";
            this.PhanCong.Name = "PhanCong";
            this.PhanCong.Width = 90;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(570, 317);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 1;
            this.btnTimKiem.Text = "Tìm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(651, 317);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(732, 317);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // BtnTaoCa
            // 
            this.BtnTaoCa.Location = new System.Drawing.Point(725, 380);
            this.BtnTaoCa.Name = "BtnTaoCa";
            this.BtnTaoCa.Size = new System.Drawing.Size(75, 23);
            this.BtnTaoCa.TabIndex = 5;
            this.BtnTaoCa.Text = "Them Ca";
            this.BtnTaoCa.UseVisualStyleBackColor = true;
            this.BtnTaoCa.Click += new System.EventHandler(this.BtnTaoCa_Click);
            // 
            // txtSoLuongCa
            // 
            this.txtSoLuongCa.Location = new System.Drawing.Point(318, 381);
            this.txtSoLuongCa.Name = "txtSoLuongCa";
            this.txtSoLuongCa.Size = new System.Drawing.Size(177, 22);
            this.txtSoLuongCa.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 361);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ngày / Tháng /Năm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(315, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Số Lượng Ca";
            // 
            // dtNgayNhap
            // 
            this.dtNgayNhap.Location = new System.Drawing.Point(12, 382);
            this.dtNgayNhap.Name = "dtNgayNhap";
            this.dtNgayNhap.Size = new System.Drawing.Size(300, 22);
            this.dtNgayNhap.TabIndex = 10;
            // 
            // txtSoNguoiLam
            // 
            this.txtSoNguoiLam.Location = new System.Drawing.Point(501, 381);
            this.txtSoNguoiLam.Name = "txtSoNguoiLam";
            this.txtSoNguoiLam.Size = new System.Drawing.Size(206, 22);
            this.txtSoNguoiLam.TabIndex = 11;
            this.txtSoNguoiLam.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(498, 361);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Số Người Làm";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 318);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(471, 22);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // yeuCauIDDataGridViewTextBoxColumn
            // 
            this.yeuCauIDDataGridViewTextBoxColumn.DataPropertyName = "YeuCauID";
            this.yeuCauIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.yeuCauIDDataGridViewTextBoxColumn.Name = "yeuCauIDDataGridViewTextBoxColumn";
            this.yeuCauIDDataGridViewTextBoxColumn.Width = 40;
            // 
            // ngayTrucDataGridViewTextBoxColumn
            // 
            this.ngayTrucDataGridViewTextBoxColumn.DataPropertyName = "NgayTruc";
            this.ngayTrucDataGridViewTextBoxColumn.HeaderText = "NgayTruc";
            this.ngayTrucDataGridViewTextBoxColumn.Name = "ngayTrucDataGridViewTextBoxColumn";
            this.ngayTrucDataGridViewTextBoxColumn.Width = 170;
            // 
            // soLuongCaDataGridViewTextBoxColumn
            // 
            this.soLuongCaDataGridViewTextBoxColumn.DataPropertyName = "SoLuongCa";
            this.soLuongCaDataGridViewTextBoxColumn.HeaderText = "SLCa";
            this.soLuongCaDataGridViewTextBoxColumn.Name = "soLuongCaDataGridViewTextBoxColumn";
            this.soLuongCaDataGridViewTextBoxColumn.Width = 75;
            // 
            // soLuongNguoiDataGridViewTextBoxColumn
            // 
            this.soLuongNguoiDataGridViewTextBoxColumn.DataPropertyName = "SoLuongNguoi";
            this.soLuongNguoiDataGridViewTextBoxColumn.HeaderText = "SLNguoi";
            this.soLuongNguoiDataGridViewTextBoxColumn.Name = "soLuongNguoiDataGridViewTextBoxColumn";
            this.soLuongNguoiDataGridViewTextBoxColumn.Width = 75;
            // 
            // caTrucDataGridViewTextBoxColumn
            // 
            this.caTrucDataGridViewTextBoxColumn.DataPropertyName = "CaTruc";
            this.caTrucDataGridViewTextBoxColumn.HeaderText = "CaTruc";
            this.caTrucDataGridViewTextBoxColumn.Name = "caTrucDataGridViewTextBoxColumn";
            this.caTrucDataGridViewTextBoxColumn.Width = 75;
            // 
            // yeuCauBindingSource
            // 
            this.yeuCauBindingSource.DataSource = typeof(QLNV.Model.YeuCau);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(489, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "XemCa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormQuanLyYeuCau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 454);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSoNguoiLam);
            this.Controls.Add(this.dtNgayNhap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSoLuongCa);
            this.Controls.Add(this.BtnTaoCa);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.gridYeuCau);
            this.Name = "FormQuanLyYeuCau";
            this.Text = "QuanLyYeuCau";
            this.Load += new System.EventHandler(this.FormQuanLyYeuCau_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridYeuCau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yeuCauBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridYeuCau;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button BtnTaoCa;
        private System.Windows.Forms.TextBox txtSoLuongCa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtNgayNhap;
        private System.Windows.Forms.TextBox txtSoNguoiLam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.BindingSource yeuCauBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn yeuCauIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayTrucDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongCaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongNguoiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn caTrucDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhanCong;
        private System.Windows.Forms.Button button1;
    }
}