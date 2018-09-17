namespace QLNV.View
{
    partial class FormTKCanBo
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
            this.fromDateSticker = new System.Windows.Forms.DateTimePicker();
            this.toDateSticker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.dtGridTKCanBo = new System.Windows.Forms.DataGridView();
            this.canBoIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoTenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donViIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chucVuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donViDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phanCongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.canBoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yeuCauBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridTKCanBo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.canBoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yeuCauBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // fromDateSticker
            // 
            this.fromDateSticker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fromDateSticker.Location = new System.Drawing.Point(45, 51);
            this.fromDateSticker.Name = "fromDateSticker";
            this.fromDateSticker.Size = new System.Drawing.Size(150, 22);
            this.fromDateSticker.TabIndex = 1;
            this.fromDateSticker.ValueChanged += new System.EventHandler(this.fromDate_ValueChanged);
            // 
            // toDateSticker
            // 
            this.toDateSticker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.toDateSticker.Location = new System.Drawing.Point(333, 51);
            this.toDateSticker.Name = "toDateSticker";
            this.toDateSticker.Size = new System.Drawing.Size(139, 22);
            this.toDateSticker.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Từ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Đến";
            // 
            // btnThongKe
            // 
            this.btnThongKe.Location = new System.Drawing.Point(582, 48);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(95, 33);
            this.btnThongKe.TabIndex = 3;
            this.btnThongKe.Text = "Thống Kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // dtGridTKCanBo
            // 
            this.dtGridTKCanBo.AutoGenerateColumns = false;
            this.dtGridTKCanBo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridTKCanBo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.canBoIDDataGridViewTextBoxColumn,
            this.hoTenDataGridViewTextBoxColumn,
            this.ngaySinhDataGridViewTextBoxColumn,
            this.donViIDDataGridViewTextBoxColumn,
            this.chucVuDataGridViewTextBoxColumn,
            this.donViDataGridViewTextBoxColumn,
            this.phanCongDataGridViewTextBoxColumn});
            this.dtGridTKCanBo.DataSource = this.canBoBindingSource;
            this.dtGridTKCanBo.Location = new System.Drawing.Point(12, 100);
            this.dtGridTKCanBo.Name = "dtGridTKCanBo";
            this.dtGridTKCanBo.RowTemplate.Height = 24;
            this.dtGridTKCanBo.Size = new System.Drawing.Size(776, 338);
            this.dtGridTKCanBo.TabIndex = 5;
            // 
            // canBoIDDataGridViewTextBoxColumn
            // 
            this.canBoIDDataGridViewTextBoxColumn.DataPropertyName = "CanBoID";
            this.canBoIDDataGridViewTextBoxColumn.HeaderText = "CanBoID";
            this.canBoIDDataGridViewTextBoxColumn.Name = "canBoIDDataGridViewTextBoxColumn";
            // 
            // hoTenDataGridViewTextBoxColumn
            // 
            this.hoTenDataGridViewTextBoxColumn.DataPropertyName = "HoTen";
            this.hoTenDataGridViewTextBoxColumn.HeaderText = "HoTen";
            this.hoTenDataGridViewTextBoxColumn.Name = "hoTenDataGridViewTextBoxColumn";
            // 
            // ngaySinhDataGridViewTextBoxColumn
            // 
            this.ngaySinhDataGridViewTextBoxColumn.DataPropertyName = "NgaySinh";
            this.ngaySinhDataGridViewTextBoxColumn.HeaderText = "NgaySinh";
            this.ngaySinhDataGridViewTextBoxColumn.Name = "ngaySinhDataGridViewTextBoxColumn";
            // 
            // donViIDDataGridViewTextBoxColumn
            // 
            this.donViIDDataGridViewTextBoxColumn.DataPropertyName = "DonViID";
            this.donViIDDataGridViewTextBoxColumn.HeaderText = "DonViID";
            this.donViIDDataGridViewTextBoxColumn.Name = "donViIDDataGridViewTextBoxColumn";
            // 
            // chucVuDataGridViewTextBoxColumn
            // 
            this.chucVuDataGridViewTextBoxColumn.DataPropertyName = "ChucVu";
            this.chucVuDataGridViewTextBoxColumn.HeaderText = "ChucVu";
            this.chucVuDataGridViewTextBoxColumn.Name = "chucVuDataGridViewTextBoxColumn";
            // 
            // donViDataGridViewTextBoxColumn
            // 
            this.donViDataGridViewTextBoxColumn.DataPropertyName = "DonVi";
            this.donViDataGridViewTextBoxColumn.HeaderText = "DonVi";
            this.donViDataGridViewTextBoxColumn.Name = "donViDataGridViewTextBoxColumn";
            // 
            // phanCongDataGridViewTextBoxColumn
            // 
            this.phanCongDataGridViewTextBoxColumn.DataPropertyName = "PhanCong";
            this.phanCongDataGridViewTextBoxColumn.HeaderText = "PhanCong";
            this.phanCongDataGridViewTextBoxColumn.Name = "phanCongDataGridViewTextBoxColumn";
            // 
            // canBoBindingSource
            // 
            this.canBoBindingSource.DataSource = typeof(QLNV.Model.CanBo);
            // 
            // yeuCauBindingSource
            // 
            this.yeuCauBindingSource.DataSource = typeof(QLNV.Model.YeuCau);
            // 
            // FormTKCanBo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtGridTKCanBo);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toDateSticker);
            this.Controls.Add(this.fromDateSticker);
            this.Name = "FormTKCanBo";
            this.Text = "Thống Kê Cán Bộ";
            ((System.ComponentModel.ISupportInitialize)(this.dtGridTKCanBo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.canBoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yeuCauBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource canBoBindingSource;
        private System.Windows.Forms.DateTimePicker fromDateSticker;
        private System.Windows.Forms.DateTimePicker toDateSticker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.BindingSource yeuCauBindingSource;
        private System.Windows.Forms.DataGridView dtGridTKCanBo;
        private System.Windows.Forms.DataGridViewTextBoxColumn canBoIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donViIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chucVuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donViDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phanCongDataGridViewTextBoxColumn;
    }
}