namespace QLNV.View
{
    partial class FormTKCa
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
            this.btnThongKe = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toDate = new System.Windows.Forms.DateTimePicker();
            this.fromDate = new System.Windows.Forms.DateTimePicker();
            this.dtGridTKCanBo = new System.Windows.Forms.DataGridView();
            this.yeuCauIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayTrucDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongCaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongNguoiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yeuCauBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridTKCanBo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yeuCauBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThongKe
            // 
            this.btnThongKe.Location = new System.Drawing.Point(693, 25);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(95, 33);
            this.btnThongKe.TabIndex = 9;
            this.btnThongKe.Text = "Thống Kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(291, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Đến";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Từ";
            // 
            // toDate
            // 
            this.toDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.toDate.Location = new System.Drawing.Point(331, 33);
            this.toDate.Name = "toDate";
            this.toDate.Size = new System.Drawing.Size(120, 22);
            this.toDate.TabIndex = 5;
            // 
            // fromDate
            // 
            this.fromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fromDate.Location = new System.Drawing.Point(43, 33);
            this.fromDate.Name = "fromDate";
            this.fromDate.Size = new System.Drawing.Size(122, 22);
            this.fromDate.TabIndex = 6;
            // 
            // dtGridTKCanBo
            // 
            this.dtGridTKCanBo.AutoGenerateColumns = false;
            this.dtGridTKCanBo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridTKCanBo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.yeuCauIDDataGridViewTextBoxColumn,
            this.ngayTrucDataGridViewTextBoxColumn,
            this.soLuongCaDataGridViewTextBoxColumn,
            this.soLuongNguoiDataGridViewTextBoxColumn});
            this.dtGridTKCanBo.DataSource = this.yeuCauBindingSource;
            this.dtGridTKCanBo.Location = new System.Drawing.Point(12, 84);
            this.dtGridTKCanBo.Name = "dtGridTKCanBo";
            this.dtGridTKCanBo.RowTemplate.Height = 24;
            this.dtGridTKCanBo.Size = new System.Drawing.Size(776, 354);
            this.dtGridTKCanBo.TabIndex = 10;
            this.dtGridTKCanBo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridTKCanBo_CellContentClick);
            // 
            // yeuCauIDDataGridViewTextBoxColumn
            // 
            this.yeuCauIDDataGridViewTextBoxColumn.DataPropertyName = "YeuCauID";
            this.yeuCauIDDataGridViewTextBoxColumn.HeaderText = "YeuCauID";
            this.yeuCauIDDataGridViewTextBoxColumn.Name = "yeuCauIDDataGridViewTextBoxColumn";
            // 
            // ngayTrucDataGridViewTextBoxColumn
            // 
            this.ngayTrucDataGridViewTextBoxColumn.DataPropertyName = "NgayTruc";
            this.ngayTrucDataGridViewTextBoxColumn.HeaderText = "NgayTruc";
            this.ngayTrucDataGridViewTextBoxColumn.Name = "ngayTrucDataGridViewTextBoxColumn";
            // 
            // soLuongCaDataGridViewTextBoxColumn
            // 
            this.soLuongCaDataGridViewTextBoxColumn.DataPropertyName = "SoLuongCa";
            this.soLuongCaDataGridViewTextBoxColumn.HeaderText = "SoLuongCa";
            this.soLuongCaDataGridViewTextBoxColumn.Name = "soLuongCaDataGridViewTextBoxColumn";
            // 
            // soLuongNguoiDataGridViewTextBoxColumn
            // 
            this.soLuongNguoiDataGridViewTextBoxColumn.DataPropertyName = "SoLuongNguoi";
            this.soLuongNguoiDataGridViewTextBoxColumn.HeaderText = "SoLuongNguoi";
            this.soLuongNguoiDataGridViewTextBoxColumn.Name = "soLuongNguoiDataGridViewTextBoxColumn";
            // 
            // yeuCauBindingSource
            // 
            this.yeuCauBindingSource.DataSource = typeof(QLNV.Model.YeuCau);
            // 
            // FormTKCa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtGridTKCanBo);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toDate);
            this.Controls.Add(this.fromDate);
            this.Name = "FormTKCa";
            this.Text = "FormTKCa";
            this.Load += new System.EventHandler(this.FormTKCa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridTKCanBo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yeuCauBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker toDate;
        private System.Windows.Forms.DateTimePicker fromDate;
        private System.Windows.Forms.DataGridView dtGridTKCanBo;
        private System.Windows.Forms.BindingSource yeuCauBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn yeuCauIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayTrucDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongCaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongNguoiDataGridViewTextBoxColumn;
    }
}