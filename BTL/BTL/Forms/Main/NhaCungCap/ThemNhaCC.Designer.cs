﻿
namespace BTL.Forms.Main.NhaCungCap
{
    partial class ThemNhaCC
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.txtTenNhaCC = new System.Windows.Forms.TextBox();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.txtSoTK = new System.Windows.Forms.TextBox();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnhuy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên nhà cung cấp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Điện thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(374, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Địa chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(374, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fax";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(69, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Số tài khoản";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(446, 110);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(110, 23);
            this.txtDiaChi.TabIndex = 6;
            this.txtDiaChi.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtFax
            // 
            this.txtFax.Location = new System.Drawing.Point(446, 149);
            this.txtFax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(110, 23);
            this.txtFax.TabIndex = 6;
            // 
            // txtTenNhaCC
            // 
            this.txtTenNhaCC.Location = new System.Drawing.Point(212, 110);
            this.txtTenNhaCC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenNhaCC.Name = "txtTenNhaCC";
            this.txtTenNhaCC.Size = new System.Drawing.Size(110, 23);
            this.txtTenNhaCC.TabIndex = 6;
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(212, 152);
            this.txtDienThoai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDienThoai.MaxLength = 11;
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(110, 23);
            this.txtDienThoai.TabIndex = 6;
            this.txtDienThoai.WordWrap = false;
            // 
            // txtSoTK
            // 
            this.txtSoTK.Location = new System.Drawing.Point(212, 197);
            this.txtSoTK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoTK.Name = "txtSoTK";
            this.txtSoTK.Size = new System.Drawing.Size(110, 23);
            this.txtSoTK.TabIndex = 6;
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(361, 269);
            this.btnthem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(82, 35);
            this.btnthem.TabIndex = 7;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnhuy
            // 
            this.btnhuy.Location = new System.Drawing.Point(229, 269);
            this.btnhuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(82, 35);
            this.btnhuy.TabIndex = 8;
            this.btnhuy.Text = "Hủy";
            this.btnhuy.UseVisualStyleBackColor = true;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(230, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 28);
            this.label1.TabIndex = 9;
            this.label1.Text = "THÊM NHÀ CUNG CẤP";
            // 
            // ThemNhaCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.txtDienThoai);
            this.Controls.Add(this.txtFax);
            this.Controls.Add(this.txtTenNhaCC);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtSoTK);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ThemNhaCC";
            this.Text = "ThemNhaCC";
            this.Load += new System.EventHandler(this.ThemNhaCC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtFax;
        private System.Windows.Forms.TextBox txtTenNhaCC;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.TextBox txtSoTK;
        private System.Windows.Forms.Label label1;
    }
}