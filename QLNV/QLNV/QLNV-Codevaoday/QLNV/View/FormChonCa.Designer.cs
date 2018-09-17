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
            this.dtGribPhai = new System.Windows.Forms.DataGridView();
            this.btnPhai = new System.Windows.Forms.Button();
            this.btnTrai = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnRandom = new System.Windows.Forms.Button();
            this.cbxChonCa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtBatDau = new System.Windows.Forms.DateTimePicker();
            this.dtKetThuc = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dtGridTrai = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.canBoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.canBoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.canBoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Chon = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Chon1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.canBoIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoTenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinhDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donViDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chucVuDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtGribPhai)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridTrai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.canBoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.canBoBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.canBoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGribPhai
            // 
            this.dtGribPhai.AllowUserToAddRows = false;
            this.dtGribPhai.AllowUserToDeleteRows = false;
            this.dtGribPhai.AutoGenerateColumns = false;
            this.dtGribPhai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGribPhai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Chon1,
            this.canBoIDDataGridViewTextBoxColumn,
            this.hoTenDataGridViewTextBoxColumn,
            this.ngaySinhDataGridViewTextBoxColumn1,
            this.donViDataGridViewTextBoxColumn1,
            this.chucVuDataGridViewTextBoxColumn1});
            this.dtGribPhai.DataSource = this.canBoBindingSource1;
            this.dtGribPhai.Location = new System.Drawing.Point(718, 68);
            this.dtGribPhai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtGribPhai.Name = "dtGribPhai";
            this.dtGribPhai.RowTemplate.Height = 24;
            this.dtGribPhai.Size = new System.Drawing.Size(616, 364);
            this.dtGribPhai.TabIndex = 1;
            // 
            // btnPhai
            // 
            this.btnPhai.Location = new System.Drawing.Point(646, 248);
            this.btnPhai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPhai.Name = "btnPhai";
            this.btnPhai.Size = new System.Drawing.Size(59, 47);
            this.btnPhai.TabIndex = 2;
            this.btnPhai.Text = ">>";
            this.btnPhai.UseVisualStyleBackColor = true;
            this.btnPhai.Click += new System.EventHandler(this.btnPhai_Click);
            // 
            // btnTrai
            // 
            this.btnTrai.Location = new System.Drawing.Point(646, 178);
            this.btnTrai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTrai.Name = "btnTrai";
            this.btnTrai.Size = new System.Drawing.Size(59, 47);
            this.btnTrai.TabIndex = 3;
            this.btnTrai.Text = "<<";
            this.btnTrai.UseVisualStyleBackColor = true;
            this.btnTrai.Click += new System.EventHandler(this.btnTrai_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(1183, 556);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 38);
            this.btnLuu.TabIndex = 4;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(16, 556);
            this.btnRandom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(91, 38);
            this.btnRandom.TabIndex = 5;
            this.btnRandom.Text = "RanDom";
            this.btnRandom.UseVisualStyleBackColor = true;
            // 
            // cbxChonCa
            // 
            this.cbxChonCa.FormattingEnabled = true;
            this.cbxChonCa.Location = new System.Drawing.Point(88, 26);
            this.cbxChonCa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxChonCa.Name = "cbxChonCa";
            this.cbxChonCa.Size = new System.Drawing.Size(164, 24);
            this.cbxChonCa.TabIndex = 7;
            this.cbxChonCa.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Chọn Ca";
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(259, 27);
            this.btnXem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(71, 25);
            this.btnXem.TabIndex = 9;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtBatDau);
            this.groupBox1.Controls.Add(this.dtKetThuc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnXem);
            this.groupBox1.Controls.Add(this.cbxChonCa);
            this.groupBox1.Location = new System.Drawing.Point(12, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1334, 65);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn Ca";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(825, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Kết Thúc";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(432, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Bắt Đầu";
            // 
            // dtBatDau
            // 
            this.dtBatDau.Location = new System.Drawing.Point(501, 27);
            this.dtBatDau.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtBatDau.Name = "dtBatDau";
            this.dtBatDau.Size = new System.Drawing.Size(265, 22);
            this.dtBatDau.TabIndex = 11;
            this.dtBatDau.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dtKetThuc
            // 
            this.dtKetThuc.Location = new System.Drawing.Point(901, 27);
            this.dtKetThuc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtKetThuc.Name = "dtKetThuc";
            this.dtKetThuc.Size = new System.Drawing.Size(265, 22);
            this.dtKetThuc.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTrai);
            this.groupBox2.Controls.Add(this.btnPhai);
            this.groupBox2.Controls.Add(this.dtGribPhai);
            this.groupBox2.Controls.Add(this.tabControl1);
            this.groupBox2.Location = new System.Drawing.Point(12, 75);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(1334, 475);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dữ Liệu Nhân Viên";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(5, 41);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(636, 396);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dtGridTrai);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(628, 367);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Xưởng 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dtGridTrai
            // 
            this.dtGridTrai.AllowUserToAddRows = false;
            this.dtGridTrai.AllowUserToDeleteRows = false;
            this.dtGridTrai.AutoGenerateColumns = false;
            this.dtGridTrai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridTrai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Chon,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dtGridTrai.DataSource = this.canBoBindingSource2;
            this.dtGridTrai.Location = new System.Drawing.Point(9, 2);
            this.dtGridTrai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtGridTrai.Name = "dtGridTrai";
            this.dtGridTrai.RowTemplate.Height = 24;
            this.dtGridTrai.Size = new System.Drawing.Size(616, 358);
            this.dtGridTrai.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Size = new System.Drawing.Size(628, 367);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Đã Chọn";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // canBoBindingSource1
            // 
            this.canBoBindingSource1.DataSource = typeof(QLNV.Model.CanBo);
            // 
            // canBoBindingSource2
            // 
            this.canBoBindingSource2.DataSource = typeof(QLNV.Model.CanBo);
            // 
            // canBoBindingSource
            // 
            this.canBoBindingSource.DataSource = typeof(QLNV.Model.CanBo);
            // 
            // Chon
            // 
            this.Chon.HeaderText = "Chon";
            this.Chon.Name = "Chon";
            this.Chon.Width = 49;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CanBoID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 30;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "HoTen";
            this.dataGridViewTextBoxColumn2.HeaderText = "Họ và Tên";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 120;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NgaySinh";
            this.dataGridViewTextBoxColumn3.HeaderText = "Ngày Sinh";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 75;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DonVi";
            this.dataGridViewTextBoxColumn4.HeaderText = "Đơn Vị";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 58;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ChucVu";
            this.dataGridViewTextBoxColumn5.HeaderText = "Chức Vụ";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 58;
            // 
            // Chon1
            // 
            this.Chon1.HeaderText = "Chon";
            this.Chon1.Name = "Chon1";
            this.Chon1.Width = 49;
            // 
            // canBoIDDataGridViewTextBoxColumn
            // 
            this.canBoIDDataGridViewTextBoxColumn.DataPropertyName = "CanBoID";
            this.canBoIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.canBoIDDataGridViewTextBoxColumn.Name = "canBoIDDataGridViewTextBoxColumn";
            this.canBoIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.canBoIDDataGridViewTextBoxColumn.Width = 30;
            // 
            // hoTenDataGridViewTextBoxColumn
            // 
            this.hoTenDataGridViewTextBoxColumn.DataPropertyName = "HoTen";
            this.hoTenDataGridViewTextBoxColumn.HeaderText = "Họ và Tên";
            this.hoTenDataGridViewTextBoxColumn.Name = "hoTenDataGridViewTextBoxColumn";
            this.hoTenDataGridViewTextBoxColumn.ReadOnly = true;
            this.hoTenDataGridViewTextBoxColumn.Width = 120;
            // 
            // ngaySinhDataGridViewTextBoxColumn1
            // 
            this.ngaySinhDataGridViewTextBoxColumn1.DataPropertyName = "NgaySinh";
            this.ngaySinhDataGridViewTextBoxColumn1.HeaderText = "Ngày Sinh";
            this.ngaySinhDataGridViewTextBoxColumn1.Name = "ngaySinhDataGridViewTextBoxColumn1";
            this.ngaySinhDataGridViewTextBoxColumn1.ReadOnly = true;
            this.ngaySinhDataGridViewTextBoxColumn1.Width = 75;
            // 
            // donViDataGridViewTextBoxColumn1
            // 
            this.donViDataGridViewTextBoxColumn1.DataPropertyName = "DonVi";
            this.donViDataGridViewTextBoxColumn1.HeaderText = "Đơn Vị";
            this.donViDataGridViewTextBoxColumn1.Name = "donViDataGridViewTextBoxColumn1";
            this.donViDataGridViewTextBoxColumn1.ReadOnly = true;
            this.donViDataGridViewTextBoxColumn1.Width = 58;
            // 
            // chucVuDataGridViewTextBoxColumn1
            // 
            this.chucVuDataGridViewTextBoxColumn1.DataPropertyName = "ChucVu";
            this.chucVuDataGridViewTextBoxColumn1.HeaderText = "Chức Vụ";
            this.chucVuDataGridViewTextBoxColumn1.Name = "chucVuDataGridViewTextBoxColumn1";
            this.chucVuDataGridViewTextBoxColumn1.ReadOnly = true;
            this.chucVuDataGridViewTextBoxColumn1.Width = 58;
            // 
            // FormChonCa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1369, 652);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.btnLuu);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormChonCa";
            this.Text = "FormChonCa";
            this.Load += new System.EventHandler(this.FormChonCa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGribPhai)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridTrai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.canBoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.canBoBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.canBoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dtGribPhai;
        private System.Windows.Forms.Button btnPhai;
        private System.Windows.Forms.Button btnTrai;
        private System.Windows.Forms.BindingSource canBoBindingSource;
        private System.Windows.Forms.BindingSource canBoBindingSource1;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.BindingSource canBoBindingSource2;
        private System.Windows.Forms.ComboBox cbxChonCa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtBatDau;
        private System.Windows.Forms.DateTimePicker dtKetThuc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dtGridTrai;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Chon1;
        private System.Windows.Forms.DataGridViewTextBoxColumn canBoIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinhDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn donViDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn chucVuDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Chon;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}