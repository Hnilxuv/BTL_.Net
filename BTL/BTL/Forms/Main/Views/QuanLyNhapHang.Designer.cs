
namespace BTL.Forms.Main.Views
{
    partial class QuanLyNhapHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataViewNV = new System.Windows.Forms.DataGridView();
            this.mnv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mancc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaynhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRefresh = new FontAwesome.Sharp.IconButton();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new FontAwesome.Sharp.IconButton();
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtmaphieudat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnguoinhap = new System.Windows.Forms.TextBox();
            this.txtthanhtoan = new System.Windows.Forms.TextBox();
            this.txtngaynhap = new System.Windows.Forms.TextBox();
            this.txtmancc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelDonGiaHienTai = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataViewSpCanDoi = new System.Windows.Forms.DataGridView();
            this.masp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensanpham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluongnhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dongianhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtmacuahang = new System.Windows.Forms.TextBox();
            this.txtMaPhieuNhap = new System.Windows.Forms.TextBox();
            this.labelTongTienCanDoi = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelTenSpCanDoi = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txttongtien = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewNV)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewSpCanDoi)).BeginInit();
            this.SuspendLayout();
            // 
            // dataViewNV
            // 
            this.dataViewNV.AllowUserToAddRows = false;
            this.dataViewNV.AllowUserToDeleteRows = false;
            this.dataViewNV.AllowUserToOrderColumns = true;
            this.dataViewNV.AllowUserToResizeRows = false;
            this.dataViewNV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataViewNV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataViewNV.BackgroundColor = System.Drawing.Color.White;
            this.dataViewNV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataViewNV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataViewNV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5, 7, 5, 7);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataViewNV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataViewNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataViewNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mnv,
            this.mch,
            this.mancc,
            this.ngaynhap,
            this.tt,
            this.nn});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataViewNV.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataViewNV.EnableHeadersVisualStyles = false;
            this.dataViewNV.GridColor = System.Drawing.Color.DimGray;
            this.dataViewNV.Location = new System.Drawing.Point(22, 103);
            this.dataViewNV.Name = "dataViewNV";
            this.dataViewNV.ReadOnly = true;
            this.dataViewNV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataViewNV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataViewNV.RowHeadersVisible = false;
            this.dataViewNV.RowHeadersWidth = 51;
            this.dataViewNV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataViewNV.RowTemplate.Height = 30;
            this.dataViewNV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataViewNV.Size = new System.Drawing.Size(1023, 217);
            this.dataViewNV.TabIndex = 18;
            this.dataViewNV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataViewNV_CellClick);
            // 
            // mnv
            // 
            this.mnv.HeaderText = "Mã phiếu nhập";
            this.mnv.MinimumWidth = 6;
            this.mnv.Name = "mnv";
            this.mnv.ReadOnly = true;
            // 
            // mch
            // 
            this.mch.HeaderText = "Mã cửa hàng";
            this.mch.MinimumWidth = 6;
            this.mch.Name = "mch";
            this.mch.ReadOnly = true;
            // 
            // mancc
            // 
            this.mancc.HeaderText = "Mã nhà cung cấp";
            this.mancc.MinimumWidth = 6;
            this.mancc.Name = "mancc";
            this.mancc.ReadOnly = true;
            // 
            // ngaynhap
            // 
            this.ngaynhap.HeaderText = "Ngày nhập";
            this.ngaynhap.MinimumWidth = 6;
            this.ngaynhap.Name = "ngaynhap";
            this.ngaynhap.ReadOnly = true;
            // 
            // tt
            // 
            this.tt.FillWeight = 80F;
            this.tt.HeaderText = "Thanh toán";
            this.tt.MinimumWidth = 6;
            this.tt.Name = "tt";
            this.tt.ReadOnly = true;
            // 
            // nn
            // 
            this.nn.HeaderText = "Người nhập";
            this.nn.MinimumWidth = 6;
            this.nn.Name = "nn";
            this.nn.ReadOnly = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.IconChar = FontAwesome.Sharp.IconChar.Redo;
            this.btnRefresh.IconColor = System.Drawing.Color.DimGray;
            this.btnRefresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRefresh.IconSize = 25;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(129, 16);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(101, 40);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Tải lại";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnDelete.IconColor = System.Drawing.Color.DimGray;
            this.btnDelete.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnDelete.IconSize = 25;
            this.btnDelete.Location = new System.Drawing.Point(238, 14);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(101, 40);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtTimKiem);
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Location = new System.Drawing.Point(22, 25);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1023, 68);
            this.panel1.TabIndex = 17;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimKiem.BackColor = System.Drawing.Color.White;
            this.txtTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTimKiem.Location = new System.Drawing.Point(637, 24);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(0);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.PlaceholderText = "Nhập mã phiếu nhập...";
            this.txtTimKiem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTimKiem.Size = new System.Drawing.Size(278, 24);
            this.txtTimKiem.TabIndex = 20;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTimKiem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTimKiem.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnTimKiem.IconColor = System.Drawing.Color.DimGray;
            this.btnTimKiem.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnTimKiem.IconSize = 23;
            this.btnTimKiem.Location = new System.Drawing.Point(919, 19);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(100, 35);
            this.btnTimKiem.TabIndex = 19;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAdd.IconColor = System.Drawing.Color.DimGray;
            this.btnAdd.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnAdd.IconSize = 25;
            this.btnAdd.Location = new System.Drawing.Point(19, 16);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(102, 40);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.txtmaphieudat);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtnguoinhap);
            this.groupBox2.Controls.Add(this.txtthanhtoan);
            this.groupBox2.Controls.Add(this.txtngaynhap);
            this.groupBox2.Controls.Add(this.txtmancc);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.labelDonGiaHienTai);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.dataViewSpCanDoi);
            this.groupBox2.Controls.Add(this.txtmacuahang);
            this.groupBox2.Controls.Add(this.txtMaPhieuNhap);
            this.groupBox2.Controls.Add(this.labelTongTienCanDoi);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.labelTenSpCanDoi);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(22, 324);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(1023, 275);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mã phiếu đặt";
            // 
            // txtmaphieudat
            // 
            this.txtmaphieudat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtmaphieudat.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtmaphieudat.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtmaphieudat.Location = new System.Drawing.Point(141, 226);
            this.txtmaphieudat.Multiline = true;
            this.txtmaphieudat.Name = "txtmaphieudat";
            this.txtmaphieudat.Size = new System.Drawing.Size(211, 30);
            this.txtmaphieudat.TabIndex = 107;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(8, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 106;
            this.label3.Text = "Mã phiếu đặt";
            // 
            // txtnguoinhap
            // 
            this.txtnguoinhap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnguoinhap.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtnguoinhap.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtnguoinhap.Location = new System.Drawing.Point(141, 196);
            this.txtnguoinhap.Multiline = true;
            this.txtnguoinhap.Name = "txtnguoinhap";
            this.txtnguoinhap.Size = new System.Drawing.Size(211, 30);
            this.txtnguoinhap.TabIndex = 105;
            // 
            // txtthanhtoan
            // 
            this.txtthanhtoan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtthanhtoan.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtthanhtoan.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtthanhtoan.Location = new System.Drawing.Point(141, 165);
            this.txtthanhtoan.Multiline = true;
            this.txtthanhtoan.Name = "txtthanhtoan";
            this.txtthanhtoan.Size = new System.Drawing.Size(211, 30);
            this.txtthanhtoan.TabIndex = 103;
            // 
            // txtngaynhap
            // 
            this.txtngaynhap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtngaynhap.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtngaynhap.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtngaynhap.Location = new System.Drawing.Point(141, 134);
            this.txtngaynhap.Multiline = true;
            this.txtngaynhap.Name = "txtngaynhap";
            this.txtngaynhap.Size = new System.Drawing.Size(211, 30);
            this.txtngaynhap.TabIndex = 102;
            // 
            // txtmancc
            // 
            this.txtmancc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtmancc.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtmancc.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtmancc.Location = new System.Drawing.Point(141, 104);
            this.txtmancc.Multiline = true;
            this.txtmancc.Name = "txtmancc";
            this.txtmancc.Size = new System.Drawing.Size(211, 30);
            this.txtmancc.TabIndex = 101;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(8, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 100;
            this.label1.Text = "Người nhập";
            // 
            // labelDonGiaHienTai
            // 
            this.labelDonGiaHienTai.AutoSize = true;
            this.labelDonGiaHienTai.BackColor = System.Drawing.Color.Transparent;
            this.labelDonGiaHienTai.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDonGiaHienTai.ForeColor = System.Drawing.Color.DimGray;
            this.labelDonGiaHienTai.Location = new System.Drawing.Point(156, 162);
            this.labelDonGiaHienTai.Name = "labelDonGiaHienTai";
            this.labelDonGiaHienTai.Size = new System.Drawing.Size(0, 21);
            this.labelDonGiaHienTai.TabIndex = 98;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(8, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 20);
            this.label8.TabIndex = 97;
            this.label8.Text = "Ngày nhập";
            // 
            // dataViewSpCanDoi
            // 
            this.dataViewSpCanDoi.AllowUserToAddRows = false;
            this.dataViewSpCanDoi.AllowUserToDeleteRows = false;
            this.dataViewSpCanDoi.AllowUserToOrderColumns = true;
            this.dataViewSpCanDoi.AllowUserToResizeRows = false;
            this.dataViewSpCanDoi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataViewSpCanDoi.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataViewSpCanDoi.BackgroundColor = System.Drawing.Color.White;
            this.dataViewSpCanDoi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataViewSpCanDoi.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataViewSpCanDoi.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataViewSpCanDoi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataViewSpCanDoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataViewSpCanDoi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masp,
            this.tensanpham,
            this.soluongnhap,
            this.dongianhap,
            this.thanhtien});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataViewSpCanDoi.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataViewSpCanDoi.EnableHeadersVisualStyles = false;
            this.dataViewSpCanDoi.GridColor = System.Drawing.Color.DimGray;
            this.dataViewSpCanDoi.Location = new System.Drawing.Point(371, 12);
            this.dataViewSpCanDoi.Name = "dataViewSpCanDoi";
            this.dataViewSpCanDoi.ReadOnly = true;
            this.dataViewSpCanDoi.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataViewSpCanDoi.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataViewSpCanDoi.RowHeadersVisible = false;
            this.dataViewSpCanDoi.RowHeadersWidth = 51;
            this.dataViewSpCanDoi.RowTemplate.Height = 30;
            this.dataViewSpCanDoi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataViewSpCanDoi.Size = new System.Drawing.Size(652, 262);
            this.dataViewSpCanDoi.TabIndex = 99;
            // 
            // masp
            // 
            this.masp.HeaderText = "Mã sản phẩm";
            this.masp.MinimumWidth = 6;
            this.masp.Name = "masp";
            this.masp.ReadOnly = true;
            // 
            // tensanpham
            // 
            this.tensanpham.HeaderText = "Tên sản phẩm";
            this.tensanpham.MinimumWidth = 6;
            this.tensanpham.Name = "tensanpham";
            this.tensanpham.ReadOnly = true;
            // 
            // soluongnhap
            // 
            this.soluongnhap.HeaderText = "Số lượng nhập";
            this.soluongnhap.MinimumWidth = 6;
            this.soluongnhap.Name = "soluongnhap";
            this.soluongnhap.ReadOnly = true;
            // 
            // dongianhap
            // 
            this.dongianhap.HeaderText = "Đơn giá nhập";
            this.dongianhap.MinimumWidth = 6;
            this.dongianhap.Name = "dongianhap";
            this.dongianhap.ReadOnly = true;
            // 
            // thanhtien
            // 
            this.thanhtien.HeaderText = "Thành tiền";
            this.thanhtien.MinimumWidth = 6;
            this.thanhtien.Name = "thanhtien";
            this.thanhtien.ReadOnly = true;
            // 
            // txtmacuahang
            // 
            this.txtmacuahang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtmacuahang.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtmacuahang.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtmacuahang.Location = new System.Drawing.Point(141, 73);
            this.txtmacuahang.Multiline = true;
            this.txtmacuahang.Name = "txtmacuahang";
            this.txtmacuahang.Size = new System.Drawing.Size(211, 30);
            this.txtmacuahang.TabIndex = 81;
            // 
            // txtMaPhieuNhap
            // 
            this.txtMaPhieuNhap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaPhieuNhap.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMaPhieuNhap.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtMaPhieuNhap.Location = new System.Drawing.Point(141, 42);
            this.txtMaPhieuNhap.Multiline = true;
            this.txtMaPhieuNhap.Name = "txtMaPhieuNhap";
            this.txtMaPhieuNhap.Size = new System.Drawing.Size(211, 30);
            this.txtMaPhieuNhap.TabIndex = 80;
            // 
            // labelTongTienCanDoi
            // 
            this.labelTongTienCanDoi.AutoSize = true;
            this.labelTongTienCanDoi.BackColor = System.Drawing.Color.Transparent;
            this.labelTongTienCanDoi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTongTienCanDoi.ForeColor = System.Drawing.Color.DimGray;
            this.labelTongTienCanDoi.Location = new System.Drawing.Point(155, 199);
            this.labelTongTienCanDoi.Name = "labelTongTienCanDoi";
            this.labelTongTienCanDoi.Size = new System.Drawing.Size(0, 21);
            this.labelTongTienCanDoi.TabIndex = 91;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(8, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 90;
            this.label5.Text = "Thanh toán";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(8, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 20);
            this.label7.TabIndex = 88;
            this.label7.Text = "Mã nhà cung cấp";
            // 
            // labelTenSpCanDoi
            // 
            this.labelTenSpCanDoi.AutoSize = true;
            this.labelTenSpCanDoi.BackColor = System.Drawing.Color.Transparent;
            this.labelTenSpCanDoi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTenSpCanDoi.ForeColor = System.Drawing.Color.DimGray;
            this.labelTenSpCanDoi.Location = new System.Drawing.Point(155, 86);
            this.labelTenSpCanDoi.Name = "labelTenSpCanDoi";
            this.labelTenSpCanDoi.Size = new System.Drawing.Size(0, 21);
            this.labelTenSpCanDoi.TabIndex = 87;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.DimGray;
            this.label13.Location = new System.Drawing.Point(8, 74);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 20);
            this.label13.TabIndex = 86;
            this.label13.Text = "Mã cửa hàng";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.Color.DimGray;
            this.label14.Location = new System.Drawing.Point(8, 42);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(113, 20);
            this.label14.TabIndex = 84;
            this.label14.Text = "Mã phiếu nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(689, 616);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 104;
            this.label2.Text = "Tổng tiền: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txttongtien
            // 
            this.txttongtien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txttongtien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txttongtien.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txttongtien.Location = new System.Drawing.Point(765, 615);
            this.txttongtien.Multiline = true;
            this.txttongtien.Name = "txttongtien";
            this.txttongtien.ReadOnly = true;
            this.txttongtien.Size = new System.Drawing.Size(281, 30);
            this.txttongtien.TabIndex = 108;
            this.txttongtien.Text = "0";
            // 
            // QuanLyNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 650);
            this.Controls.Add(this.txttongtien);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataViewNV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "QuanLyNhapHang";
            this.Text = "QuanLyNhapHang";
            this.Load += new System.EventHandler(this.QuanLyNhapHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataViewNV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewSpCanDoi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataViewNV;
        private FontAwesome.Sharp.IconButton btnRefresh;
        private FontAwesome.Sharp.IconButton btnDelete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTimKiem;
        private FontAwesome.Sharp.IconButton btnTimKiem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelDonGiaHienTai;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataViewSpCanDoi;
        private System.Windows.Forms.TextBox txtmacuahang;
        private System.Windows.Forms.TextBox txtMaPhieuNhap;
        private System.Windows.Forms.Label labelTongTienCanDoi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelTenSpCanDoi;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridViewTextBoxColumn mnv;
        private System.Windows.Forms.DataGridViewTextBoxColumn mch;
        private System.Windows.Forms.DataGridViewTextBoxColumn mancc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaynhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn tt;
        private System.Windows.Forms.DataGridViewTextBoxColumn nn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmancc;
        private System.Windows.Forms.TextBox txtthanhtoan;
        private System.Windows.Forms.TextBox txtngaynhap;
        private FontAwesome.Sharp.IconButton btnAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn masp;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensanpham;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluongnhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn dongianhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhtien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnguoinhap;
        private System.Windows.Forms.TextBox txtmaphieudat;
        private System.Windows.Forms.TextBox txttongtien;
    }
}