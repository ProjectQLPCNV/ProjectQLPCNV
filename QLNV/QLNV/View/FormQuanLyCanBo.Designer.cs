namespace QLNV
{
    partial class FormQuanLyCanBo
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
            this.dtGridQLCanBo = new System.Windows.Forms.DataGridView();
            this.CanBoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.txtDonVi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtChuVu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.hoTenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donViDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chucVuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phanCongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.canBoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.formQuanLyCanBoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.canBoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.canBoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridQLCanBo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.canBoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formQuanLyCanBoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.canBoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.canBoBindingSource2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtGridQLCanBo
            // 
            this.dtGridQLCanBo.AllowUserToAddRows = false;
            this.dtGridQLCanBo.AllowUserToDeleteRows = false;
            this.dtGridQLCanBo.AutoGenerateColumns = false;
            this.dtGridQLCanBo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridQLCanBo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CanBoID,
            this.hoTenDataGridViewTextBoxColumn,
            this.ngaySinhDataGridViewTextBoxColumn,
            this.donViDataGridViewTextBoxColumn,
            this.chucVuDataGridViewTextBoxColumn,
            this.phanCongDataGridViewTextBoxColumn});
            this.dtGridQLCanBo.DataSource = this.canBoBindingSource;
            this.dtGridQLCanBo.Location = new System.Drawing.Point(12, 12);
            this.dtGridQLCanBo.Name = "dtGridQLCanBo";
            this.dtGridQLCanBo.RowTemplate.Height = 24;
            this.dtGridQLCanBo.Size = new System.Drawing.Size(874, 382);
            this.dtGridQLCanBo.TabIndex = 0;
            // 
            // CanBoID
            // 
            this.CanBoID.DataPropertyName = "CanBoID";
            this.CanBoID.HeaderText = "Cán Bộ ID";
            this.CanBoID.Name = "CanBoID";
            this.CanBoID.ReadOnly = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(819, 458);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(67, 26);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(674, 458);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(67, 26);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(746, 458);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(67, 26);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(6, 58);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(124, 26);
            this.txtTimKiem.TabIndex = 6;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // txtDonVi
            // 
            this.txtDonVi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonVi.Location = new System.Drawing.Point(266, 58);
            this.txtDonVi.Name = "txtDonVi";
            this.txtDonVi.Size = new System.Drawing.Size(139, 26);
            this.txtDonVi.TabIndex = 8;
            this.txtDonVi.TextChanged += new System.EventHandler(this.txtDonVi_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Chức Vụ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tên";
            // 
            // txtChuVu
            // 
            this.txtChuVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChuVu.Location = new System.Drawing.Point(136, 58);
            this.txtChuVu.Name = "txtChuVu";
            this.txtChuVu.Size = new System.Drawing.Size(124, 26);
            this.txtChuVu.TabIndex = 13;
            this.txtChuVu.TextChanged += new System.EventHandler(this.txtChuVu_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Đơn Vị";
            // 
            // hoTenDataGridViewTextBoxColumn
            // 
            this.hoTenDataGridViewTextBoxColumn.DataPropertyName = "HoTen";
            this.hoTenDataGridViewTextBoxColumn.HeaderText = "Họ và Tên";
            this.hoTenDataGridViewTextBoxColumn.Name = "hoTenDataGridViewTextBoxColumn";
            this.hoTenDataGridViewTextBoxColumn.Width = 125;
            // 
            // ngaySinhDataGridViewTextBoxColumn
            // 
            this.ngaySinhDataGridViewTextBoxColumn.DataPropertyName = "NgaySinh";
            this.ngaySinhDataGridViewTextBoxColumn.HeaderText = "Ngày Sinh";
            this.ngaySinhDataGridViewTextBoxColumn.Name = "ngaySinhDataGridViewTextBoxColumn";
            // 
            // donViDataGridViewTextBoxColumn
            // 
            this.donViDataGridViewTextBoxColumn.DataPropertyName = "DonVi";
            this.donViDataGridViewTextBoxColumn.HeaderText = "Đơn Vị";
            this.donViDataGridViewTextBoxColumn.Name = "donViDataGridViewTextBoxColumn";
            this.donViDataGridViewTextBoxColumn.Width = 75;
            // 
            // chucVuDataGridViewTextBoxColumn
            // 
            this.chucVuDataGridViewTextBoxColumn.DataPropertyName = "ChucVu";
            this.chucVuDataGridViewTextBoxColumn.HeaderText = "Chức Vụ";
            this.chucVuDataGridViewTextBoxColumn.Name = "chucVuDataGridViewTextBoxColumn";
            this.chucVuDataGridViewTextBoxColumn.Width = 75;
            // 
            // phanCongDataGridViewTextBoxColumn
            // 
            this.phanCongDataGridViewTextBoxColumn.DataPropertyName = "PhanCong";
            this.phanCongDataGridViewTextBoxColumn.HeaderText = "Phân Công";
            this.phanCongDataGridViewTextBoxColumn.Name = "phanCongDataGridViewTextBoxColumn";
            // 
            // canBoBindingSource
            // 
            this.canBoBindingSource.DataSource = typeof(QLNV.Model.CanBo);
            // 
            // formQuanLyCanBoBindingSource
            // 
            this.formQuanLyCanBoBindingSource.DataSource = typeof(QLNV.FormQuanLyCanBo);
            // 
            // canBoBindingSource1
            // 
            this.canBoBindingSource1.DataSource = typeof(QLNV.Model.CanBo);
            // 
            // canBoBindingSource2
            // 
            this.canBoBindingSource2.DataSource = typeof(QLNV.Model.CanBo);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDonVi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtChuVu);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtTimKiem);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 400);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(606, 100);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Kiếm";
            // 
            // FormQuanLyCanBo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 496);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.dtGridQLCanBo);
            this.Name = "FormQuanLyCanBo";
            this.Text = "Quản Lý Cán Bộ";
            this.Load += new System.EventHandler(this.FormQuanLyCanBo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridQLCanBo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.canBoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formQuanLyCanBoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.canBoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.canBoBindingSource2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGridQLCanBo;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.BindingSource canBoBindingSource;
        private System.Windows.Forms.TextBox txtDonVi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource formQuanLyCanBoBindingSource;
        private System.Windows.Forms.BindingSource canBoBindingSource1;
        private System.Windows.Forms.BindingSource canBoBindingSource2;
        private System.Windows.Forms.TextBox txtChuVu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn CanBoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donViDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chucVuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phanCongDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}