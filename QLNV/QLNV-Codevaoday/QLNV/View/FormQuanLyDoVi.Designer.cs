namespace QLNV.View
{
    partial class FormQuanLyDoVi
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
            this.dtGridQLDonVi = new System.Windows.Forms.DataGridView();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtThem = new System.Windows.Forms.TextBox();
            this.txtSua = new System.Windows.Forms.TextBox();
            this.donViBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.donViIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDonVIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridQLDonVi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donViBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGridQLDonVi
            // 
            this.dtGridQLDonVi.AutoGenerateColumns = false;
            this.dtGridQLDonVi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridQLDonVi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.donViIDDataGridViewTextBoxColumn,
            this.tenDonVIDataGridViewTextBoxColumn});
            this.dtGridQLDonVi.DataSource = this.donViBindingSource;
            this.dtGridQLDonVi.Location = new System.Drawing.Point(10, 35);
            this.dtGridQLDonVi.Name = "dtGridQLDonVi";
            this.dtGridQLDonVi.RowTemplate.Height = 24;
            this.dtGridQLDonVi.Size = new System.Drawing.Size(372, 150);
            this.dtGridQLDonVi.TabIndex = 0;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(10, 220);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(12, 249);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(10, 191);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(252, 220);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(130, 22);
            this.txtTim.TabIndex = 5;
            this.txtTim.TextChanged += new System.EventHandler(this.txtTim_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(300, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tìm";
            // 
            // txtThem
            // 
            this.txtThem.Location = new System.Drawing.Point(91, 192);
            this.txtThem.Name = "txtThem";
            this.txtThem.Size = new System.Drawing.Size(155, 22);
            this.txtThem.TabIndex = 7;
            // 
            // txtSua
            // 
            this.txtSua.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.donViBindingSource, "TenDonVI", true));
            this.txtSua.Location = new System.Drawing.Point(91, 220);
            this.txtSua.Name = "txtSua";
            this.txtSua.Size = new System.Drawing.Size(155, 22);
            this.txtSua.TabIndex = 8;
            this.txtSua.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // donViBindingSource
            // 
            this.donViBindingSource.DataSource = typeof(QLNV.Model.DonVi);
            // 
            // donViIDDataGridViewTextBoxColumn
            // 
            this.donViIDDataGridViewTextBoxColumn.DataPropertyName = "DonViID";
            this.donViIDDataGridViewTextBoxColumn.HeaderText = "Đơn Vị ID";
            this.donViIDDataGridViewTextBoxColumn.Name = "donViIDDataGridViewTextBoxColumn";
            // 
            // tenDonVIDataGridViewTextBoxColumn
            // 
            this.tenDonVIDataGridViewTextBoxColumn.DataPropertyName = "TenDonVI";
            this.tenDonVIDataGridViewTextBoxColumn.HeaderText = "Tên Đơn Vị";
            this.tenDonVIDataGridViewTextBoxColumn.Name = "tenDonVIDataGridViewTextBoxColumn";
            // 
            // FormQuanLyDoVi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 291);
            this.Controls.Add(this.txtSua);
            this.Controls.Add(this.txtThem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.dtGridQLDonVi);
            this.Name = "FormQuanLyDoVi";
            this.Text = "FormQuanLyDoVi";
            this.Load += new System.EventHandler(this.FormQuanLyDoVi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridQLDonVi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donViBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGridQLDonVi;
        private System.Windows.Forms.BindingSource donViBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn donViIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDonVIDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtThem;
        private System.Windows.Forms.TextBox txtSua;
    }
}