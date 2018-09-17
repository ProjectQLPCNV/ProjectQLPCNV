namespace QLNV.View
{
    partial class FormSuaYeuCau
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
            this.txtSLNguoi = new System.Windows.Forms.TextBox();
            this.yeuCauBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtSLCa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.yeuCauBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSLNguoi
            // 
            this.txtSLNguoi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.yeuCauBindingSource, "SoLuongNguoi", true));
            this.txtSLNguoi.Location = new System.Drawing.Point(130, 59);
            this.txtSLNguoi.Name = "txtSLNguoi";
            this.txtSLNguoi.Size = new System.Drawing.Size(189, 22);
            this.txtSLNguoi.TabIndex = 0;
            // 
            // yeuCauBindingSource
            // 
            this.yeuCauBindingSource.DataSource = typeof(QLNV.Model.YeuCau);
            // 
            // txtSLCa
            // 
            this.txtSLCa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.yeuCauBindingSource, "SoLuongCa", true));
            this.txtSLCa.Location = new System.Drawing.Point(130, 104);
            this.txtSLCa.Name = "txtSLCa";
            this.txtSLCa.Size = new System.Drawing.Size(189, 22);
            this.txtSLCa.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "SL Người";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "SL Ca Trực";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(244, 146);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 2;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // FormSuaYeuCau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 199);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSLCa);
            this.Controls.Add(this.txtSLNguoi);
            this.Name = "FormSuaYeuCau";
            this.Text = "Sửa Yêu Cầu";
            this.Load += new System.EventHandler(this.FormSuaYeuCau_Load);
            ((System.ComponentModel.ISupportInitialize)(this.yeuCauBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSLNguoi;
        private System.Windows.Forms.TextBox txtSLCa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource yeuCauBindingSource;
        private System.Windows.Forms.Button btnLuu;
    }
}