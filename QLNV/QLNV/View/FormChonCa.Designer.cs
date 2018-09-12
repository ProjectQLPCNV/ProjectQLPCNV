namespace QLNV.View
{
    partial class FormChonCa
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
            this.dtGridTrai = new System.Windows.Forms.DataGridView();
            this.dtGribPhai = new System.Windows.Forms.DataGridView();
            this.btnPhai = new System.Windows.Forms.Button();
            this.btnTrai = new System.Windows.Forms.Button();
            this.canBoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.canBoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hoTenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Chon = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ngaySinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donViDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chucVuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoTenDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Chon1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ngaySinhDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donViDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chucVuDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridTrai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGribPhai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.canBoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.canBoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGridTrai
            // 
            this.dtGridTrai.AllowUserToAddRows = false;
            this.dtGridTrai.AllowUserToDeleteRows = false;
            this.dtGridTrai.AutoGenerateColumns = false;
            this.dtGridTrai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridTrai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hoTenDataGridViewTextBoxColumn,
            this.Chon,
            this.ngaySinhDataGridViewTextBoxColumn,
            this.donViDataGridViewTextBoxColumn,
            this.chucVuDataGridViewTextBoxColumn});
            this.dtGridTrai.DataSource = this.canBoBindingSource;
            this.dtGridTrai.Location = new System.Drawing.Point(12, 92);
            this.dtGridTrai.Name = "dtGridTrai";
            this.dtGridTrai.RowTemplate.Height = 24;
            this.dtGridTrai.Size = new System.Drawing.Size(546, 336);
            this.dtGridTrai.TabIndex = 0;
            // 
            // dtGribPhai
            // 
            this.dtGribPhai.AllowUserToAddRows = false;
            this.dtGribPhai.AllowUserToDeleteRows = false;
            this.dtGribPhai.AutoGenerateColumns = false;
            this.dtGribPhai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGribPhai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hoTenDataGridViewTextBoxColumn1,
            this.Chon1,
            this.ngaySinhDataGridViewTextBoxColumn1,
            this.donViDataGridViewTextBoxColumn1,
            this.chucVuDataGridViewTextBoxColumn1});
            this.dtGribPhai.DataSource = this.canBoBindingSource1;
            this.dtGribPhai.Location = new System.Drawing.Point(664, 92);
            this.dtGribPhai.Name = "dtGribPhai";
            this.dtGribPhai.RowTemplate.Height = 24;
            this.dtGribPhai.Size = new System.Drawing.Size(544, 336);
            this.dtGribPhai.TabIndex = 1;
            // 
            // btnPhai
            // 
            this.btnPhai.Location = new System.Drawing.Point(583, 204);
            this.btnPhai.Name = "btnPhai";
            this.btnPhai.Size = new System.Drawing.Size(75, 23);
            this.btnPhai.TabIndex = 2;
            this.btnPhai.Text = ">>";
            this.btnPhai.UseVisualStyleBackColor = true;
            this.btnPhai.Click += new System.EventHandler(this.btnPhai_Click);
            // 
            // btnTrai
            // 
            this.btnTrai.Location = new System.Drawing.Point(583, 308);
            this.btnTrai.Name = "btnTrai";
            this.btnTrai.Size = new System.Drawing.Size(75, 23);
            this.btnTrai.TabIndex = 3;
            this.btnTrai.Text = "<<";
            this.btnTrai.UseVisualStyleBackColor = true;
            this.btnTrai.Click += new System.EventHandler(this.btnTrai_Click);
            // 
            // canBoBindingSource1
            // 
            this.canBoBindingSource1.DataSource = typeof(QLNV.Model.CanBo);
            // 
            // canBoBindingSource
            // 
            this.canBoBindingSource.DataSource = typeof(QLNV.Model.CanBo);
            // 
            // hoTenDataGridViewTextBoxColumn
            // 
            this.hoTenDataGridViewTextBoxColumn.DataPropertyName = "HoTen";
            this.hoTenDataGridViewTextBoxColumn.HeaderText = "HoTen";
            this.hoTenDataGridViewTextBoxColumn.Name = "hoTenDataGridViewTextBoxColumn";
            // 
            // Chon
            // 
            this.Chon.HeaderText = "Chon";
            this.Chon.Name = "Chon";
            // 
            // ngaySinhDataGridViewTextBoxColumn
            // 
            this.ngaySinhDataGridViewTextBoxColumn.DataPropertyName = "NgaySinh";
            this.ngaySinhDataGridViewTextBoxColumn.HeaderText = "NgaySinh";
            this.ngaySinhDataGridViewTextBoxColumn.Name = "ngaySinhDataGridViewTextBoxColumn";
            // 
            // donViDataGridViewTextBoxColumn
            // 
            this.donViDataGridViewTextBoxColumn.DataPropertyName = "DonVi";
            this.donViDataGridViewTextBoxColumn.HeaderText = "DonVi";
            this.donViDataGridViewTextBoxColumn.Name = "donViDataGridViewTextBoxColumn";
            // 
            // chucVuDataGridViewTextBoxColumn
            // 
            this.chucVuDataGridViewTextBoxColumn.DataPropertyName = "ChucVu";
            this.chucVuDataGridViewTextBoxColumn.HeaderText = "ChucVu";
            this.chucVuDataGridViewTextBoxColumn.Name = "chucVuDataGridViewTextBoxColumn";
            // 
            // hoTenDataGridViewTextBoxColumn1
            // 
            this.hoTenDataGridViewTextBoxColumn1.DataPropertyName = "HoTen";
            this.hoTenDataGridViewTextBoxColumn1.HeaderText = "HoTen";
            this.hoTenDataGridViewTextBoxColumn1.Name = "hoTenDataGridViewTextBoxColumn1";
            // 
            // Chon1
            // 
            this.Chon1.HeaderText = "Chon1";
            this.Chon1.Name = "Chon1";
            // 
            // ngaySinhDataGridViewTextBoxColumn1
            // 
            this.ngaySinhDataGridViewTextBoxColumn1.DataPropertyName = "NgaySinh";
            this.ngaySinhDataGridViewTextBoxColumn1.HeaderText = "NgaySinh";
            this.ngaySinhDataGridViewTextBoxColumn1.Name = "ngaySinhDataGridViewTextBoxColumn1";
            // 
            // donViDataGridViewTextBoxColumn1
            // 
            this.donViDataGridViewTextBoxColumn1.DataPropertyName = "DonVi";
            this.donViDataGridViewTextBoxColumn1.HeaderText = "DonVi";
            this.donViDataGridViewTextBoxColumn1.Name = "donViDataGridViewTextBoxColumn1";
            // 
            // chucVuDataGridViewTextBoxColumn1
            // 
            this.chucVuDataGridViewTextBoxColumn1.DataPropertyName = "ChucVu";
            this.chucVuDataGridViewTextBoxColumn1.HeaderText = "ChucVu";
            this.chucVuDataGridViewTextBoxColumn1.Name = "chucVuDataGridViewTextBoxColumn1";
            // 
            // FormChonCa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 533);
            this.Controls.Add(this.btnTrai);
            this.Controls.Add(this.btnPhai);
            this.Controls.Add(this.dtGribPhai);
            this.Controls.Add(this.dtGridTrai);
            this.Name = "FormChonCa";
            this.Text = "FormChonCa";
            this.Load += new System.EventHandler(this.FormChonCa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridTrai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGribPhai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.canBoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.canBoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGridTrai;
        private System.Windows.Forms.DataGridView dtGribPhai;
        private System.Windows.Forms.Button btnPhai;
        private System.Windows.Forms.Button btnTrai;
        private System.Windows.Forms.BindingSource canBoBindingSource;
        private System.Windows.Forms.BindingSource canBoBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Chon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donViDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chucVuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTenDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Chon1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinhDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn donViDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn chucVuDataGridViewTextBoxColumn1;
    }
}