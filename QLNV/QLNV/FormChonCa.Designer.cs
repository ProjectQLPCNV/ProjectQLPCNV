namespace QLNV
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
            this.NhanViencheckedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.ChonCacomboBox = new System.Windows.Forms.ComboBox();
            this.NVtrongCadataGridView = new System.Windows.Forms.DataGridView();
            this.SaveButton = new System.Windows.Forms.Button();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.RanDomButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NVtrongCadataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // NhanViencheckedListBox1
            // 
            this.NhanViencheckedListBox1.FormattingEnabled = true;
            this.NhanViencheckedListBox1.Location = new System.Drawing.Point(12, 91);
            this.NhanViencheckedListBox1.Name = "NhanViencheckedListBox1";
            this.NhanViencheckedListBox1.Size = new System.Drawing.Size(279, 310);
            this.NhanViencheckedListBox1.TabIndex = 0;
            // 
            // ChonCacomboBox
            // 
            this.ChonCacomboBox.FormattingEnabled = true;
            this.ChonCacomboBox.Location = new System.Drawing.Point(956, 57);
            this.ChonCacomboBox.Name = "ChonCacomboBox";
            this.ChonCacomboBox.Size = new System.Drawing.Size(92, 24);
            this.ChonCacomboBox.TabIndex = 1;
            this.ChonCacomboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // NVtrongCadataGridView
            // 
            this.NVtrongCadataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NVtrongCadataGridView.Location = new System.Drawing.Point(314, 91);
            this.NVtrongCadataGridView.Name = "NVtrongCadataGridView";
            this.NVtrongCadataGridView.RowTemplate.Height = 24;
            this.NVtrongCadataGridView.Size = new System.Drawing.Size(734, 314);
            this.NVtrongCadataGridView.TabIndex = 2;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(973, 415);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "Lưu";
            this.SaveButton.UseVisualStyleBackColor = true;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(270, 91);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(21, 310);
            this.vScrollBar1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(966, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Chọn Ca";
            // 
            // RanDomButton
            // 
            this.RanDomButton.Location = new System.Drawing.Point(876, 415);
            this.RanDomButton.Name = "RanDomButton";
            this.RanDomButton.Size = new System.Drawing.Size(75, 23);
            this.RanDomButton.TabIndex = 6;
            this.RanDomButton.Text = "Random";
            this.RanDomButton.UseVisualStyleBackColor = true;
            // 
            // FormChonCa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 450);
            this.Controls.Add(this.RanDomButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.NVtrongCadataGridView);
            this.Controls.Add(this.ChonCacomboBox);
            this.Controls.Add(this.NhanViencheckedListBox1);
            this.Name = "FormChonCa";
            this.Text = "ChonCa";
            ((System.ComponentModel.ISupportInitialize)(this.NVtrongCadataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox NhanViencheckedListBox1;
        private System.Windows.Forms.ComboBox ChonCacomboBox;
        private System.Windows.Forms.DataGridView NVtrongCadataGridView;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RanDomButton;
    }
}