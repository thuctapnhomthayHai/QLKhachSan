﻿namespace QL_KS.GUI
{
    partial class frmThanhToan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grbThuephong = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpNgayVao = new System.Windows.Forms.DateTimePicker();
            this.cmbKhachhang = new System.Windows.Forms.ComboBox();
            this.cmbMahd = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpNgayra = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnThanhtoan = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvThongtin = new System.Windows.Forms.DataGridView();
            this.SoPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.grbThuephong.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongtin)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.splitContainer1.Panel1.Controls.Add(this.grbThuephong);
            this.splitContainer1.Panel1.Controls.Add(this.btnThoat);
            this.splitContainer1.Panel1.Controls.Add(this.btnThanhtoan);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(556, 407);
            this.splitContainer1.SplitterDistance = 203;
            this.splitContainer1.TabIndex = 1;
            // 
            // grbThuephong
            // 
            this.grbThuephong.Controls.Add(this.label2);
            this.grbThuephong.Controls.Add(this.dtpNgayVao);
            this.grbThuephong.Controls.Add(this.cmbKhachhang);
            this.grbThuephong.Controls.Add(this.cmbMahd);
            this.grbThuephong.Controls.Add(this.label5);
            this.grbThuephong.Controls.Add(this.label4);
            this.grbThuephong.Controls.Add(this.dtpNgayra);
            this.grbThuephong.Controls.Add(this.label1);
            this.grbThuephong.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbThuephong.Location = new System.Drawing.Point(12, 12);
            this.grbThuephong.Name = "grbThuephong";
            this.grbThuephong.Size = new System.Drawing.Size(368, 155);
            this.grbThuephong.TabIndex = 1;
            this.grbThuephong.TabStop = false;
            this.grbThuephong.Text = "Thông tin thuê phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Ngày vào";
            // 
            // dtpNgayVao
            // 
            this.dtpNgayVao.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayVao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayVao.Location = new System.Drawing.Point(135, 87);
            this.dtpNgayVao.Name = "dtpNgayVao";
            this.dtpNgayVao.Size = new System.Drawing.Size(227, 25);
            this.dtpNgayVao.TabIndex = 3;
            this.dtpNgayVao.Value = new System.DateTime(2017, 5, 5, 0, 0, 0, 0);
            this.dtpNgayVao.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dtpNgayvao_KeyUp);
            // 
            // cmbKhachhang
            // 
            this.cmbKhachhang.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKhachhang.FormattingEnabled = true;
            this.cmbKhachhang.Location = new System.Drawing.Point(135, 33);
            this.cmbKhachhang.Name = "cmbKhachhang";
            this.cmbKhachhang.Size = new System.Drawing.Size(227, 25);
            this.cmbKhachhang.TabIndex = 1;
            this.cmbKhachhang.SelectedIndexChanged += new System.EventHandler(this.cmbKhachhang_SelectedIndexChanged);
            this.cmbKhachhang.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cbtenkh_KeyUp);
            // 
            // cmbMahd
            // 
            this.cmbMahd.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMahd.FormattingEnabled = true;
            this.cmbMahd.Location = new System.Drawing.Point(135, 60);
            this.cmbMahd.Name = "cmbMahd";
            this.cmbMahd.Size = new System.Drawing.Size(227, 25);
            this.cmbMahd.TabIndex = 2;
            this.cmbMahd.TextChanged += new System.EventHandler(this.cmbMahd_TextChanged);
            this.cmbMahd.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cbmahd_KeyUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Mã hóa đơn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ngày trả";
            // 
            // dtpNgayra
            // 
            this.dtpNgayra.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayra.Location = new System.Drawing.Point(135, 113);
            this.dtpNgayra.Name = "dtpNgayra";
            this.dtpNgayra.Size = new System.Drawing.Size(227, 25);
            this.dtpNgayra.TabIndex = 4;
            this.dtpNgayra.Value = new System.DateTime(2016, 5, 7, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Khách Hàng";
            // 
            // btnThoat
            // 
            this.btnThoat.BackgroundImage = global::QL_KS.Properties.Resources.cen2;
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Image = global::QL_KS.Properties.Resources.close_2_icon;
            this.btnThoat.Location = new System.Drawing.Point(406, 102);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(123, 65);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnThanhtoan
            // 
            this.btnThanhtoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnThanhtoan.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhtoan.Image = global::QL_KS.Properties.Resources.payment_icon;
            this.btnThanhtoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThanhtoan.Location = new System.Drawing.Point(406, 25);
            this.btnThanhtoan.Name = "btnThanhtoan";
            this.btnThanhtoan.Size = new System.Drawing.Size(123, 62);
            this.btnThanhtoan.TabIndex = 5;
            this.btnThanhtoan.Text = "Thanh toán";
            this.btnThanhtoan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThanhtoan.UseVisualStyleBackColor = false;
            this.btnThanhtoan.Click += new System.EventHandler(this.btnThanhtoan_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvThongtin);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(556, 200);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách dịch vụ sử dụng";
            // 
            // dgvThongtin
            // 
            this.dgvThongtin.AllowUserToAddRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.dgvThongtin.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvThongtin.BackgroundColor = System.Drawing.Color.White;
            this.dgvThongtin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongtin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SoPhong,
            this.TenDV,
            this.ThoiGian,
            this.Gia});
            this.dgvThongtin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvThongtin.Location = new System.Drawing.Point(3, 16);
            this.dgvThongtin.Name = "dgvThongtin";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.Format = "N1";
            dataGridViewCellStyle8.NullValue = "0";
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThongtin.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            this.dgvThongtin.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvThongtin.Size = new System.Drawing.Size(550, 181);
            this.dgvThongtin.TabIndex = 7;
            // 
            // SoPhong
            // 
            this.SoPhong.DataPropertyName = "SoPhong";
            this.SoPhong.HeaderText = "Số phòng";
            this.SoPhong.Name = "SoPhong";
            this.SoPhong.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.SoPhong.Width = 80;
            // 
            // TenDV
            // 
            this.TenDV.DataPropertyName = "TenDV";
            this.TenDV.HeaderText = "Dịch vụ";
            this.TenDV.Name = "TenDV";
            this.TenDV.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TenDV.Width = 150;
            // 
            // ThoiGian
            // 
            this.ThoiGian.DataPropertyName = "ThoiGian";
            this.ThoiGian.HeaderText = "Thời gian DV";
            this.ThoiGian.Name = "ThoiGian";
            this.ThoiGian.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ThoiGian.Width = 150;
            // 
            // Gia
            // 
            this.Gia.DataPropertyName = "Gia";
            this.Gia.HeaderText = "Giá DV";
            this.Gia.Name = "Gia";
            this.Gia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Gia.Width = 80;
            // 
            // frmThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 407);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmThanhToan";
            this.Text = "Thanh toán";
            this.Load += new System.EventHandler(this.frmThanhToan_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.grbThuephong.ResumeLayout(false);
            this.grbThuephong.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongtin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox grbThuephong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpNgayVao;
        private System.Windows.Forms.ComboBox cmbKhachhang;
        private System.Windows.Forms.ComboBox cmbMahd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpNgayra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnThanhtoan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvThongtin;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGian;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
    }
}