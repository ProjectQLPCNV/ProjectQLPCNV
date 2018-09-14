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
            this.Chon = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CanBoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donViDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chucVuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.canBoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtGribPhai = new System.Windows.Forms.DataGridView();
            this.Chon1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.canBoIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoTenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinhDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donViDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chucVuDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.canBoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnPhai = new System.Windows.Forms.Button();
            this.btnTrai = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnRandom = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.canBoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.cbxChonCa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridTrai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.canBoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGribPhai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.canBoBindingSource1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.canBoBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGridTrai
            // 
            this.dtGridTrai.AllowUserToAddRows = false;
            this.dtGridTrai.AllowUserToDeleteRows = false;
            this.dtGridTrai.AutoGenerateColumns = false;
            this.dtGridTrai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridTrai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Chon,
            this.CanBoID,
            this.HoTen,
            this.ngaySinhDataGridViewTextBoxColumn,
            this.donViDataGridViewTextBoxColumn,
            this.chucVuDataGridViewTextBoxColumn});
            this.dtGridTrai.DataSource = this.canBoBindingSource;
            this.dtGridTrai.Location = new System.Drawing.Point(6, 6);
            this.dtGridTrai.Name = "dtGridTrai";
            this.dtGridTrai.RowTemplate.Height = 24;
            this.dtGridTrai.Size = new System.Drawing.Size(616, 436);
            this.dtGridTrai.TabIndex = 0;
            // 
            // Chon
            // 
            this.Chon.HeaderText = "Chon";
            this.Chon.Name = "Chon";
            this.Chon.Width = 49;
            // 
            // CanBoID
            // 
            this.CanBoID.DataPropertyName = "CanBoID";
            this.CanBoID.HeaderText = "ID";
            this.CanBoID.Name = "CanBoID";
            this.CanBoID.ReadOnly = true;
            this.CanBoID.Width = 30;
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "HoTen";
            this.HoTen.Name = "HoTen";
            this.HoTen.ReadOnly = true;
            this.HoTen.Width = 120;
            // 
            // ngaySinhDataGridViewTextBoxColumn
            // 
            this.ngaySinhDataGridViewTextBoxColumn.DataPropertyName = "NgaySinh";
            this.ngaySinhDataGridViewTextBoxColumn.HeaderText = "NgaySinh";
            this.ngaySinhDataGridViewTextBoxColumn.Name = "ngaySinhDataGridViewTextBoxColumn";
            this.ngaySinhDataGridViewTextBoxColumn.ReadOnly = true;
            this.ngaySinhDataGridViewTextBoxColumn.Width = 75;
            // 
            // donViDataGridViewTextBoxColumn
            // 
            this.donViDataGridViewTextBoxColumn.DataPropertyName = "DonVi";
            this.donViDataGridViewTextBoxColumn.HeaderText = "DonVi";
            this.donViDataGridViewTextBoxColumn.Name = "donViDataGridViewTextBoxColumn";
            this.donViDataGridViewTextBoxColumn.ReadOnly = true;
            this.donViDataGridViewTextBoxColumn.Width = 58;
            // 
            // chucVuDataGridViewTextBoxColumn
            // 
            this.chucVuDataGridViewTextBoxColumn.DataPropertyName = "ChucVu";
            this.chucVuDataGridViewTextBoxColumn.HeaderText = "ChucVu";
            this.chucVuDataGridViewTextBoxColumn.Name = "chucVuDataGridViewTextBoxColumn";
            this.chucVuDataGridViewTextBoxColumn.ReadOnly = true;
            this.chucVuDataGridViewTextBoxColumn.Width = 58;
            // 
            // canBoBindingSource
            // 
            this.canBoBindingSource.DataSource = typeof(QLNV.Model.CanBo);
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
            this.dtGribPhai.Location = new System.Drawing.Point(719, 104);
            this.dtGribPhai.Name = "dtGribPhai";
            this.dtGribPhai.RowTemplate.Height = 24;
            this.dtGribPhai.Size = new System.Drawing.Size(616, 436);
            this.dtGribPhai.TabIndex = 1;
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
            this.hoTenDataGridViewTextBoxColumn.HeaderText = "HoTen";
            this.hoTenDataGridViewTextBoxColumn.Name = "hoTenDataGridViewTextBoxColumn";
            this.hoTenDataGridViewTextBoxColumn.ReadOnly = true;
            this.hoTenDataGridViewTextBoxColumn.Width = 120;
            // 
            // ngaySinhDataGridViewTextBoxColumn1
            // 
            this.ngaySinhDataGridViewTextBoxColumn1.DataPropertyName = "NgaySinh";
            this.ngaySinhDataGridViewTextBoxColumn1.HeaderText = "NgaySinh";
            this.ngaySinhDataGridViewTextBoxColumn1.Name = "ngaySinhDataGridViewTextBoxColumn1";
            this.ngaySinhDataGridViewTextBoxColumn1.ReadOnly = true;
            this.ngaySinhDataGridViewTextBoxColumn1.Width = 75;
            // 
            // donViDataGridViewTextBoxColumn1
            // 
            this.donViDataGridViewTextBoxColumn1.DataPropertyName = "DonVi";
            this.donViDataGridViewTextBoxColumn1.HeaderText = "DonVi";
            this.donViDataGridViewTextBoxColumn1.Name = "donViDataGridViewTextBoxColumn1";
            this.donViDataGridViewTextBoxColumn1.ReadOnly = true;
            this.donViDataGridViewTextBoxColumn1.Width = 58;
            // 
            // chucVuDataGridViewTextBoxColumn1
            // 
            this.chucVuDataGridViewTextBoxColumn1.DataPropertyName = "ChucVu";
            this.chucVuDataGridViewTextBoxColumn1.HeaderText = "ChucVu";
            this.chucVuDataGridViewTextBoxColumn1.Name = "chucVuDataGridViewTextBoxColumn1";
            this.chucVuDataGridViewTextBoxColumn1.ReadOnly = true;
            this.chucVuDataGridViewTextBoxColumn1.Width = 58;
            // 
            // canBoBindingSource1
            // 
            this.canBoBindingSource1.DataSource = typeof(QLNV.Model.CanBo);
            // 
            // btnPhai
            // 
            this.btnPhai.Location = new System.Drawing.Point(654, 315);
            this.btnPhai.Name = "btnPhai";
            this.btnPhai.Size = new System.Drawing.Size(59, 47);
            this.btnPhai.TabIndex = 2;
            this.btnPhai.Text = ">>";
            this.btnPhai.UseVisualStyleBackColor = true;
            this.btnPhai.Click += new System.EventHandler(this.btnPhai_Click);
            // 
            // btnTrai
            // 
            this.btnTrai.Location = new System.Drawing.Point(654, 204);
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
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 38);
            this.btnLuu.TabIndex = 4;
            this.btnLuu.Text = "Luu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(16, 556);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(91, 38);
            this.btnRandom.TabIndex = 5;
            this.btnRandom.Text = "RanDom";
            this.btnRandom.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(12, 73);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(636, 477);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dtGridTrai);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(628, 448);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Xuong 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(628, 448);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Xuong2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dataGridView1.DataSource = this.canBoBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(616, 436);
            this.dataGridView1.TabIndex = 1;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.HeaderText = "Chon";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 49;
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
            this.dataGridViewTextBoxColumn2.HeaderText = "HoTen";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 120;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NgaySinh";
            this.dataGridViewTextBoxColumn3.HeaderText = "NgaySinh";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 75;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DonVi";
            this.dataGridViewTextBoxColumn4.HeaderText = "DonVi";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 58;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ChucVu";
            this.dataGridViewTextBoxColumn5.HeaderText = "ChucVu";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 58;
            // 
            // canBoBindingSource2
            // 
            this.canBoBindingSource2.DataSource = typeof(QLNV.Model.CanBo);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(628, 448);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Da chon";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(628, 448);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Xuong4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(628, 448);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Xuong5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // cbxChonCa
            // 
            this.cbxChonCa.FormattingEnabled = true;
            this.cbxChonCa.Location = new System.Drawing.Point(1137, 43);
            this.cbxChonCa.Name = "cbxChonCa";
            this.cbxChonCa.Size = new System.Drawing.Size(121, 24);
            this.cbxChonCa.TabIndex = 7;
            this.cbxChonCa.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1064, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Chon Ca";
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(1264, 43);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(71, 24);
            this.btnXem.TabIndex = 9;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            // 
            // FormChonCa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1347, 652);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxChonCa);
            this.Controls.Add(this.dtGribPhai);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.btnTrai);
            this.Controls.Add(this.btnPhai);
            this.Controls.Add(this.btnLuu);
            this.Name = "FormChonCa";
            this.Text = "FormChonCa";
            this.Load += new System.EventHandler(this.FormChonCa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridTrai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.canBoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGribPhai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.canBoBindingSource1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.canBoBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGridTrai;
        private System.Windows.Forms.DataGridView dtGribPhai;
        private System.Windows.Forms.Button btnPhai;
        private System.Windows.Forms.Button btnTrai;
        private System.Windows.Forms.BindingSource canBoBindingSource;
        private System.Windows.Forms.BindingSource canBoBindingSource1;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Chon;
        private System.Windows.Forms.DataGridViewTextBoxColumn CanBoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donViDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chucVuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Chon1;
        private System.Windows.Forms.DataGridViewTextBoxColumn canBoIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinhDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn donViDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn chucVuDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.BindingSource canBoBindingSource2;
        private System.Windows.Forms.ComboBox cbxChonCa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXem;
    }
}