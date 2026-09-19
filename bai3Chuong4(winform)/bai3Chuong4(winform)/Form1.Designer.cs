namespace bai3Chuong4_winform_
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btnThemVaoDS = new System.Windows.Forms.Button();
            this.txtTien = new System.Windows.Forms.TextBox();
            this.cmbSoLuong = new System.Windows.Forms.ComboBox();
            this.cmbChonDoUong = new System.Windows.Forms.ComboBox();
            this.lblTien = new System.Windows.Forms.Label();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.lblChon = new System.Windows.Forms.Label();
            this.rdoNuaNgay = new System.Windows.Forms.RadioButton();
            this.rdoCaNgay = new System.Windows.Forms.RadioButton();
            this.txtGiaDuThuyen = new System.Windows.Forms.TextBox();
            this.lblGiaDuThuyen = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThemMoi);
            this.groupBox1.Controls.Add(this.btnThemVaoDS);
            this.groupBox1.Controls.Add(this.txtTien);
            this.groupBox1.Controls.Add(this.cmbSoLuong);
            this.groupBox1.Controls.Add(this.cmbChonDoUong);
            this.groupBox1.Controls.Add(this.lblTien);
            this.groupBox1.Controls.Add(this.lblSoLuong);
            this.groupBox1.Controls.Add(this.lblChon);
            this.groupBox1.Controls.Add(this.rdoNuaNgay);
            this.groupBox1.Controls.Add(this.rdoCaNgay);
            this.groupBox1.Controls.Add(this.txtGiaDuThuyen);
            this.groupBox1.Controls.Add(this.lblGiaDuThuyen);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.lblHoTen);
            this.groupBox1.Location = new System.Drawing.Point(21, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 336);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin khách đặt tour";
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Location = new System.Drawing.Point(172, 254);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(113, 30);
            this.btnThemMoi.TabIndex = 13;
            this.btnThemMoi.Text = "Thêm &mới";
            this.btnThemMoi.UseVisualStyleBackColor = true;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // btnThemVaoDS
            // 
            this.btnThemVaoDS.Location = new System.Drawing.Point(18, 254);
            this.btnThemVaoDS.Name = "btnThemVaoDS";
            this.btnThemVaoDS.Size = new System.Drawing.Size(120, 30);
            this.btnThemVaoDS.TabIndex = 12;
            this.btnThemVaoDS.Text = "&Thêm vào DS";
            this.btnThemVaoDS.UseVisualStyleBackColor = true;
            this.btnThemVaoDS.Click += new System.EventHandler(this.btnThemVaoDS_Click);
            // 
            // txtTien
            // 
            this.txtTien.Location = new System.Drawing.Point(236, 185);
            this.txtTien.Multiline = true;
            this.txtTien.Name = "txtTien";
            this.txtTien.Size = new System.Drawing.Size(61, 25);
            this.txtTien.TabIndex = 11;
            this.txtTien.TextChanged += new System.EventHandler(this.txtTien_TextChanged);
            // 
            // cmbSoLuong
            // 
            this.cmbSoLuong.FormattingEnabled = true;
            this.cmbSoLuong.Location = new System.Drawing.Point(156, 186);
            this.cmbSoLuong.Name = "cmbSoLuong";
            this.cmbSoLuong.Size = new System.Drawing.Size(53, 24);
            this.cmbSoLuong.TabIndex = 10;
            this.cmbSoLuong.SelectedIndexChanged += new System.EventHandler(this.cmbSoLuong_SelectedIndexChanged);
            // 
            // cmbChonDoUong
            // 
            this.cmbChonDoUong.FormattingEnabled = true;
            this.cmbChonDoUong.Location = new System.Drawing.Point(27, 186);
            this.cmbChonDoUong.Name = "cmbChonDoUong";
            this.cmbChonDoUong.Size = new System.Drawing.Size(94, 24);
            this.cmbChonDoUong.TabIndex = 9;
            this.cmbChonDoUong.SelectedIndexChanged += new System.EventHandler(this.cmbChonDoUong_SelectedIndexChanged);
            // 
            // lblTien
            // 
            this.lblTien.AutoSize = true;
            this.lblTien.Location = new System.Drawing.Point(233, 157);
            this.lblTien.Name = "lblTien";
            this.lblTien.Size = new System.Drawing.Size(34, 16);
            this.lblTien.TabIndex = 8;
            this.lblTien.Text = "Tiền";
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Location = new System.Drawing.Point(153, 157);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(60, 16);
            this.lblSoLuong.TabIndex = 7;
            this.lblSoLuong.Text = "Số lượng";
            // 
            // lblChon
            // 
            this.lblChon.AutoSize = true;
            this.lblChon.Location = new System.Drawing.Point(24, 157);
            this.lblChon.Name = "lblChon";
            this.lblChon.Size = new System.Drawing.Size(90, 16);
            this.lblChon.TabIndex = 6;
            this.lblChon.Text = "Chọn đồ uống";
            // 
            // rdoNuaNgay
            // 
            this.rdoNuaNgay.AutoSize = true;
            this.rdoNuaNgay.Location = new System.Drawing.Point(127, 78);
            this.rdoNuaNgay.Name = "rdoNuaNgay";
            this.rdoNuaNgay.Size = new System.Drawing.Size(86, 20);
            this.rdoNuaNgay.TabIndex = 5;
            this.rdoNuaNgay.TabStop = true;
            this.rdoNuaNgay.Text = "Nửa ngày";
            this.rdoNuaNgay.UseVisualStyleBackColor = true;
            this.rdoNuaNgay.CheckedChanged += new System.EventHandler(this.rdoNuaNgay_CheckedChanged);
            // 
            // rdoCaNgay
            // 
            this.rdoCaNgay.AutoSize = true;
            this.rdoCaNgay.Location = new System.Drawing.Point(18, 78);
            this.rdoCaNgay.Name = "rdoCaNgay";
            this.rdoCaNgay.Size = new System.Drawing.Size(78, 20);
            this.rdoCaNgay.TabIndex = 4;
            this.rdoCaNgay.TabStop = true;
            this.rdoCaNgay.Text = "Cả ngày";
            this.rdoCaNgay.UseVisualStyleBackColor = true;
            this.rdoCaNgay.CheckedChanged += new System.EventHandler(this.rdoCaNgay_CheckedChanged);
            // 
            // txtGiaDuThuyen
            // 
            this.txtGiaDuThuyen.Location = new System.Drawing.Point(127, 115);
            this.txtGiaDuThuyen.Name = "txtGiaDuThuyen";
            this.txtGiaDuThuyen.Size = new System.Drawing.Size(100, 22);
            this.txtGiaDuThuyen.TabIndex = 3;
            // 
            // lblGiaDuThuyen
            // 
            this.lblGiaDuThuyen.AutoSize = true;
            this.lblGiaDuThuyen.Location = new System.Drawing.Point(24, 118);
            this.lblGiaDuThuyen.Name = "lblGiaDuThuyen";
            this.lblGiaDuThuyen.Size = new System.Drawing.Size(88, 16);
            this.lblGiaDuThuyen.TabIndex = 2;
            this.lblGiaDuThuyen.Text = "Giá du thuyền";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(127, 37);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(100, 22);
            this.txtHoTen.TabIndex = 1;
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(24, 40);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(55, 16);
            this.lblHoTen.TabIndex = 0;
            this.lblHoTen.Text = "Họ Tên:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Location = new System.Drawing.Point(345, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(527, 284);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách khách hàng đặt tour";
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(3, 18);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(521, 263);
            this.listBox1.TabIndex = 0;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(711, 325);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(133, 30);
            this.btnThoat.TabIndex = 14;
            this.btnThoat.Text = "T&hoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 382);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Cong ty du thuyen Ho Tay";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTien;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.Label lblChon;
        private System.Windows.Forms.RadioButton rdoNuaNgay;
        private System.Windows.Forms.RadioButton rdoCaNgay;
        private System.Windows.Forms.TextBox txtGiaDuThuyen;
        private System.Windows.Forms.Label lblGiaDuThuyen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnThemVaoDS;
        private System.Windows.Forms.TextBox txtTien;
        private System.Windows.Forms.ComboBox cmbSoLuong;
        private System.Windows.Forms.ComboBox cmbChonDoUong;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnThoat;
    }
}

