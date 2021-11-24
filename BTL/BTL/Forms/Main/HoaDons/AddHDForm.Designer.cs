
namespace BTL.Forms.Main.HoaDon
{
    partial class AddHDForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.iBtnAdd = new FontAwesome.Sharp.IconButton();
            this.txtGKM = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.iBtnLoadSP = new FontAwesome.Sharp.IconButton();
            this.txtDG = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.iBtnCheckSP = new FontAwesome.Sharp.IconButton();
            this.txtSLTon = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.iBtnLoadKH = new FontAwesome.Sharp.IconButton();
            this.ibtnCheckKH = new FontAwesome.Sharp.IconButton();
            this.txtTichDiem = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataSP = new System.Windows.Forms.DataGridView();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iBtnThoat = new FontAwesome.Sharp.IconButton();
            this.iBtnThanhToan = new FontAwesome.Sharp.IconButton();
            this.iBtnSdd = new FontAwesome.Sharp.IconButton();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.labTongTien = new System.Windows.Forms.Label();
            this.labChietKhau = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSP)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.iBtnAdd);
            this.groupBox2.Controls.Add(this.txtGKM);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.iBtnLoadSP);
            this.groupBox2.Controls.Add(this.txtDG);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.iBtnCheckSP);
            this.groupBox2.Controls.Add(this.txtSLTon);
            this.groupBox2.Controls.Add(this.txtTenSP);
            this.groupBox2.Controls.Add(this.txtMaSP);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(10, 244);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(492, 362);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin sản phẩm";
            // 
            // iBtnAdd
            // 
            this.iBtnAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iBtnAdd.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.iBtnAdd.IconColor = System.Drawing.Color.Black;
            this.iBtnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnAdd.IconSize = 30;
            this.iBtnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnAdd.Location = new System.Drawing.Point(393, 104);
            this.iBtnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iBtnAdd.Name = "iBtnAdd";
            this.iBtnAdd.Size = new System.Drawing.Size(87, 30);
            this.iBtnAdd.TabIndex = 75;
            this.iBtnAdd.Text = "Thêm";
            this.iBtnAdd.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.iBtnAdd.UseVisualStyleBackColor = true;
            this.iBtnAdd.Click += new System.EventHandler(this.iBtnAdd_Click);
            // 
            // txtGKM
            // 
            this.txtGKM.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtGKM.ForeColor = System.Drawing.Color.Black;
            this.txtGKM.Location = new System.Drawing.Point(169, 284);
            this.txtGKM.MaxLength = 11;
            this.txtGKM.Multiline = true;
            this.txtGKM.Name = "txtGKM";
            this.txtGKM.ReadOnly = true;
            this.txtGKM.Size = new System.Drawing.Size(211, 29);
            this.txtGKM.TabIndex = 74;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(24, 284);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 21);
            this.label9.TabIndex = 73;
            this.label9.Text = "Giá Khuyến Mãi";
            // 
            // iBtnLoadSP
            // 
            this.iBtnLoadSP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iBtnLoadSP.IconChar = FontAwesome.Sharp.IconChar.SyncAlt;
            this.iBtnLoadSP.IconColor = System.Drawing.Color.Black;
            this.iBtnLoadSP.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnLoadSP.IconSize = 30;
            this.iBtnLoadSP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnLoadSP.Location = new System.Drawing.Point(393, 164);
            this.iBtnLoadSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iBtnLoadSP.Name = "iBtnLoadSP";
            this.iBtnLoadSP.Size = new System.Drawing.Size(87, 30);
            this.iBtnLoadSP.TabIndex = 72;
            this.iBtnLoadSP.Text = "Tải Lại";
            this.iBtnLoadSP.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.iBtnLoadSP.UseVisualStyleBackColor = true;
            this.iBtnLoadSP.Click += new System.EventHandler(this.iBtnLoadSP_Click);
            // 
            // txtDG
            // 
            this.txtDG.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDG.ForeColor = System.Drawing.Color.Black;
            this.txtDG.Location = new System.Drawing.Point(169, 224);
            this.txtDG.MaxLength = 11;
            this.txtDG.Multiline = true;
            this.txtDG.Name = "txtDG";
            this.txtDG.ReadOnly = true;
            this.txtDG.Size = new System.Drawing.Size(211, 29);
            this.txtDG.TabIndex = 69;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(24, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 21);
            this.label7.TabIndex = 68;
            this.label7.Text = "Đơn Giá";
            // 
            // iBtnCheckSP
            // 
            this.iBtnCheckSP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iBtnCheckSP.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iBtnCheckSP.IconColor = System.Drawing.Color.Black;
            this.iBtnCheckSP.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnCheckSP.IconSize = 30;
            this.iBtnCheckSP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnCheckSP.Location = new System.Drawing.Point(393, 44);
            this.iBtnCheckSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iBtnCheckSP.Name = "iBtnCheckSP";
            this.iBtnCheckSP.Size = new System.Drawing.Size(87, 28);
            this.iBtnCheckSP.TabIndex = 67;
            this.iBtnCheckSP.Text = "Tìm";
            this.iBtnCheckSP.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.iBtnCheckSP.UseVisualStyleBackColor = true;
            this.iBtnCheckSP.Click += new System.EventHandler(this.iBtnCheckSP_Click);
            // 
            // txtSLTon
            // 
            this.txtSLTon.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSLTon.ForeColor = System.Drawing.Color.Black;
            this.txtSLTon.Location = new System.Drawing.Point(169, 164);
            this.txtSLTon.MaxLength = 10;
            this.txtSLTon.Multiline = true;
            this.txtSLTon.Name = "txtSLTon";
            this.txtSLTon.ReadOnly = true;
            this.txtSLTon.Size = new System.Drawing.Size(211, 29);
            this.txtSLTon.TabIndex = 66;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTenSP.ForeColor = System.Drawing.Color.Black;
            this.txtTenSP.Location = new System.Drawing.Point(169, 104);
            this.txtTenSP.MaxLength = 11;
            this.txtTenSP.Multiline = true;
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.ReadOnly = true;
            this.txtTenSP.Size = new System.Drawing.Size(211, 29);
            this.txtTenSP.TabIndex = 65;
            // 
            // txtMaSP
            // 
            this.txtMaSP.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMaSP.ForeColor = System.Drawing.Color.Black;
            this.txtMaSP.Location = new System.Drawing.Point(169, 44);
            this.txtMaSP.Multiline = true;
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(211, 29);
            this.txtMaSP.TabIndex = 64;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(24, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 21);
            this.label2.TabIndex = 63;
            this.label2.Text = "Mã Sản Phẩm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(22, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 21);
            this.label5.TabIndex = 62;
            this.label5.Text = "Số Lượng Tồn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(24, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 21);
            this.label6.TabIndex = 61;
            this.label6.Text = "Tên Sản Phẩm";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.iBtnLoadKH);
            this.groupBox1.Controls.Add(this.ibtnCheckKH);
            this.groupBox1.Controls.Add(this.txtTichDiem);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(10, 9);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(492, 230);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            // 
            // iBtnLoadKH
            // 
            this.iBtnLoadKH.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iBtnLoadKH.IconChar = FontAwesome.Sharp.IconChar.SyncAlt;
            this.iBtnLoadKH.IconColor = System.Drawing.Color.Black;
            this.iBtnLoadKH.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnLoadKH.IconSize = 30;
            this.iBtnLoadKH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnLoadKH.Location = new System.Drawing.Point(393, 106);
            this.iBtnLoadKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iBtnLoadKH.Name = "iBtnLoadKH";
            this.iBtnLoadKH.Size = new System.Drawing.Size(87, 30);
            this.iBtnLoadKH.TabIndex = 75;
            this.iBtnLoadKH.Text = "Tải Lại";
            this.iBtnLoadKH.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.iBtnLoadKH.UseVisualStyleBackColor = true;
            this.iBtnLoadKH.Click += new System.EventHandler(this.iBtnLoadKH_Click);
            // 
            // ibtnCheckKH
            // 
            this.ibtnCheckKH.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ibtnCheckKH.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.ibtnCheckKH.IconColor = System.Drawing.Color.Black;
            this.ibtnCheckKH.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnCheckKH.IconSize = 30;
            this.ibtnCheckKH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnCheckKH.Location = new System.Drawing.Point(393, 44);
            this.ibtnCheckKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ibtnCheckKH.Name = "ibtnCheckKH";
            this.ibtnCheckKH.Size = new System.Drawing.Size(87, 30);
            this.ibtnCheckKH.TabIndex = 60;
            this.ibtnCheckKH.Text = "Tìm";
            this.ibtnCheckKH.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.ibtnCheckKH.UseVisualStyleBackColor = true;
            this.ibtnCheckKH.Click += new System.EventHandler(this.IbtnCheck_Click);
            // 
            // txtTichDiem
            // 
            this.txtTichDiem.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTichDiem.ForeColor = System.Drawing.Color.Black;
            this.txtTichDiem.Location = new System.Drawing.Point(169, 170);
            this.txtTichDiem.MaxLength = 10;
            this.txtTichDiem.Multiline = true;
            this.txtTichDiem.Name = "txtTichDiem";
            this.txtTichDiem.ReadOnly = true;
            this.txtTichDiem.Size = new System.Drawing.Size(211, 29);
            this.txtTichDiem.TabIndex = 59;
            this.txtTichDiem.Text = "0";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtHoTen.ForeColor = System.Drawing.Color.Black;
            this.txtHoTen.Location = new System.Drawing.Point(169, 106);
            this.txtHoTen.MaxLength = 11;
            this.txtHoTen.Multiline = true;
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.ReadOnly = true;
            this.txtHoTen.Size = new System.Drawing.Size(211, 29);
            this.txtHoTen.TabIndex = 58;
            // 
            // txtSDT
            // 
            this.txtSDT.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSDT.ForeColor = System.Drawing.Color.Black;
            this.txtSDT.Location = new System.Drawing.Point(169, 44);
            this.txtSDT.MaxLength = 11;
            this.txtSDT.Multiline = true;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(211, 29);
            this.txtSDT.TabIndex = 57;
            this.txtSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSDT_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(24, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 21);
            this.label4.TabIndex = 56;
            this.label4.Text = "Số điện thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(23, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 21);
            this.label3.TabIndex = 55;
            this.label3.Text = "Điểm tích lũy";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(24, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 21);
            this.label1.TabIndex = 54;
            this.label1.Text = "Tên khách hàng";
            // 
            // dataSP
            // 
            this.dataSP.AllowUserToAddRows = false;
            this.dataSP.AllowUserToDeleteRows = false;
            this.dataSP.AllowUserToOrderColumns = true;
            this.dataSP.AllowUserToResizeRows = false;
            this.dataSP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataSP.BackgroundColor = System.Drawing.Color.White;
            this.dataSP.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataSP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSP,
            this.TenSP,
            this.SoLuong,
            this.DonGia,
            this.ThanhTien});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataSP.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataSP.EnableHeadersVisualStyles = false;
            this.dataSP.Location = new System.Drawing.Point(508, 9);
            this.dataSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataSP.Name = "dataSP";
            this.dataSP.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataSP.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataSP.RowHeadersVisible = false;
            this.dataSP.RowHeadersWidth = 51;
            this.dataSP.RowTemplate.Height = 29;
            this.dataSP.Size = new System.Drawing.Size(537, 420);
            this.dataSP.TabIndex = 2;
            // 
            // MaSP
            // 
            this.MaSP.HeaderText = "Mã Sản Phẩm";
            this.MaSP.MinimumWidth = 6;
            this.MaSP.Name = "MaSP";
            this.MaSP.ReadOnly = true;
            // 
            // TenSP
            // 
            this.TenSP.HeaderText = "Tên Sản Phẩm";
            this.TenSP.MinimumWidth = 6;
            this.TenSP.Name = "TenSP";
            this.TenSP.ReadOnly = true;
            // 
            // SoLuong
            // 
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            // 
            // DonGia
            // 
            this.DonGia.HeaderText = "Đơn Giá";
            this.DonGia.MinimumWidth = 6;
            this.DonGia.Name = "DonGia";
            this.DonGia.ReadOnly = true;
            // 
            // ThanhTien
            // 
            this.ThanhTien.HeaderText = "Thành Tiền";
            this.ThanhTien.MinimumWidth = 6;
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.iBtnThoat);
            this.panel1.Controls.Add(this.iBtnThanhToan);
            this.panel1.Controls.Add(this.iBtnSdd);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.labTongTien);
            this.panel1.Controls.Add(this.labChietKhau);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(511, 445);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(533, 160);
            this.panel1.TabIndex = 3;
            // 
            // iBtnThoat
            // 
            this.iBtnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.iBtnThoat.FlatAppearance.BorderSize = 0;
            this.iBtnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iBtnThoat.ForeColor = System.Drawing.Color.Black;
            this.iBtnThoat.IconChar = FontAwesome.Sharp.IconChar.PaperPlane;
            this.iBtnThoat.IconColor = System.Drawing.Color.DimGray;
            this.iBtnThoat.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iBtnThoat.IconSize = 25;
            this.iBtnThoat.Location = new System.Drawing.Point(413, 73);
            this.iBtnThoat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.iBtnThoat.Name = "iBtnThoat";
            this.iBtnThoat.Size = new System.Drawing.Size(116, 40);
            this.iBtnThoat.TabIndex = 7;
            this.iBtnThoat.Text = "Thoát";
            this.iBtnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtnThoat.UseVisualStyleBackColor = false;
            this.iBtnThoat.Click += new System.EventHandler(this.iBtnThoat_Click);
            // 
            // iBtnThanhToan
            // 
            this.iBtnThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.iBtnThanhToan.FlatAppearance.BorderSize = 0;
            this.iBtnThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtnThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iBtnThanhToan.ForeColor = System.Drawing.Color.Black;
            this.iBtnThanhToan.IconChar = FontAwesome.Sharp.IconChar.MoneyBillAlt;
            this.iBtnThanhToan.IconColor = System.Drawing.Color.DimGray;
            this.iBtnThanhToan.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iBtnThanhToan.IconSize = 25;
            this.iBtnThanhToan.Location = new System.Drawing.Point(411, 27);
            this.iBtnThanhToan.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.iBtnThanhToan.Name = "iBtnThanhToan";
            this.iBtnThanhToan.Size = new System.Drawing.Size(116, 40);
            this.iBtnThanhToan.TabIndex = 6;
            this.iBtnThanhToan.Text = "Thanh Toán";
            this.iBtnThanhToan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtnThanhToan.UseVisualStyleBackColor = false;
            this.iBtnThanhToan.Click += new System.EventHandler(this.iBtnThanhToan_Click);
            // 
            // iBtnSdd
            // 
            this.iBtnSdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.iBtnSdd.FlatAppearance.BorderSize = 0;
            this.iBtnSdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtnSdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iBtnSdd.ForeColor = System.Drawing.Color.Black;
            this.iBtnSdd.IconChar = FontAwesome.Sharp.IconChar.Star;
            this.iBtnSdd.IconColor = System.Drawing.Color.DimGray;
            this.iBtnSdd.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iBtnSdd.IconSize = 25;
            this.iBtnSdd.Location = new System.Drawing.Point(289, 73);
            this.iBtnSdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.iBtnSdd.Name = "iBtnSdd";
            this.iBtnSdd.Size = new System.Drawing.Size(116, 40);
            this.iBtnSdd.TabIndex = 5;
            this.iBtnSdd.Text = "Sử Dụng Điểm";
            this.iBtnSdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtnSdd.UseVisualStyleBackColor = false;
            this.iBtnSdd.Click += new System.EventHandler(this.iBtnSdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnDelete.IconColor = System.Drawing.Color.DimGray;
            this.btnDelete.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnDelete.IconSize = 25;
            this.btnDelete.Location = new System.Drawing.Point(289, 27);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(116, 40);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Xóa Hàng";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // labTongTien
            // 
            this.labTongTien.AutoSize = true;
            this.labTongTien.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labTongTien.Location = new System.Drawing.Point(143, 92);
            this.labTongTien.Name = "labTongTien";
            this.labTongTien.Size = new System.Drawing.Size(19, 21);
            this.labTongTien.TabIndex = 3;
            this.labTongTien.Text = "0";
            // 
            // labChietKhau
            // 
            this.labChietKhau.AutoSize = true;
            this.labChietKhau.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labChietKhau.Location = new System.Drawing.Point(143, 28);
            this.labChietKhau.Name = "labChietKhau";
            this.labChietKhau.Size = new System.Drawing.Size(19, 21);
            this.labChietKhau.TabIndex = 2;
            this.labChietKhau.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(24, 92);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 21);
            this.label11.TabIndex = 1;
            this.label11.Text = "Tổng tiền:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(24, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 21);
            this.label10.TabIndex = 0;
            this.label10.Text = "Chiết khấu:";
            // 
            // AddHDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1055, 615);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataSP);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddHDForm";
            this.Text = "Thêm Hàng";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AddHDForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSP)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataSP;
        private System.Windows.Forms.TextBox txtTichDiem;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton ibtnCheckKH;
        private System.Windows.Forms.TextBox txtDG;
        private System.Windows.Forms.Label label7;
        private FontAwesome.Sharp.IconButton iBtnCheckSP;
        private System.Windows.Forms.TextBox txtSLTon;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private FontAwesome.Sharp.IconButton iBtnLoadSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.TextBox txtGKM;
        private System.Windows.Forms.Label label9;
        private FontAwesome.Sharp.IconButton iBtnLoadKH;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labTongTien;
        private System.Windows.Forms.Label labChietKhau;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private FontAwesome.Sharp.IconButton iBtnThanhToan;
        private FontAwesome.Sharp.IconButton iBtnSdd;
        private FontAwesome.Sharp.IconButton btnDelete;
        private FontAwesome.Sharp.IconButton iBtnThoat;
        private FontAwesome.Sharp.IconButton iBtnAdd;
    }
}