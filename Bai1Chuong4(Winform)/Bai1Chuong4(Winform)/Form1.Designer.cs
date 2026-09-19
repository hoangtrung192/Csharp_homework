namespace Bai1Chuong4_Winform_
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
            this.txtSoThangSau = new System.Windows.Forms.TextBox();
            this.lblSoThangSau = new System.Windows.Forms.Label();
            this.txtSoThangTruoc = new System.Windows.Forms.TextBox();
            this.lblSoThangTruoc = new System.Windows.Forms.Label();
            this.txtNgayChotSo = new System.Windows.Forms.TextBox();
            this.lblNgayChot = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.lblMa = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThemMoi);
            this.groupBox1.Controls.Add(this.btnThemVaoDS);
            this.groupBox1.Controls.Add(this.txtSoThangSau);
            this.groupBox1.Controls.Add(this.lblSoThangSau);
            this.groupBox1.Controls.Add(this.txtSoThangTruoc);
            this.groupBox1.Controls.Add(this.lblSoThangTruoc);
            this.groupBox1.Controls.Add(this.txtNgayChotSo);
            this.groupBox1.Controls.Add(this.lblNgayChot);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.lblDiaChi);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.lblHoTen);
            this.groupBox1.Controls.Add(this.txtMa);
            this.groupBox1.Controls.Add(this.lblMa);
            this.groupBox1.Location = new System.Drawing.Point(27, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 414);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin khác hàng sử dụng điện";
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Location = new System.Drawing.Point(179, 320);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(96, 33);
            this.btnThemMoi.TabIndex = 13;
            this.btnThemMoi.Text = "Thêm &mới";
            this.btnThemMoi.UseVisualStyleBackColor = true;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // btnThemVaoDS
            // 
            this.btnThemVaoDS.Location = new System.Drawing.Point(45, 320);
            this.btnThemVaoDS.Name = "btnThemVaoDS";
            this.btnThemVaoDS.Size = new System.Drawing.Size(101, 33);
            this.btnThemVaoDS.TabIndex = 12;
            this.btnThemVaoDS.Text = "&Thêm vào DS";
            this.btnThemVaoDS.UseVisualStyleBackColor = true;
            this.btnThemVaoDS.Click += new System.EventHandler(this.btnThemVaoDS_Click);
            // 
            // txtSoThangSau
            // 
            this.txtSoThangSau.Location = new System.Drawing.Point(110, 221);
            this.txtSoThangSau.Name = "txtSoThangSau";
            this.txtSoThangSau.Size = new System.Drawing.Size(100, 22);
            this.txtSoThangSau.TabIndex = 11;
            this.txtSoThangSau.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoThangSau_KeyPress);
            // 
            // lblSoThangSau
            // 
            this.lblSoThangSau.AutoSize = true;
            this.lblSoThangSau.Location = new System.Drawing.Point(15, 224);
            this.lblSoThangSau.Name = "lblSoThangSau";
            this.lblSoThangSau.Size = new System.Drawing.Size(85, 16);
            this.lblSoThangSau.TabIndex = 10;
            this.lblSoThangSau.Text = "Số tháng này";
            // 
            // txtSoThangTruoc
            // 
            this.txtSoThangTruoc.Location = new System.Drawing.Point(110, 183);
            this.txtSoThangTruoc.Name = "txtSoThangTruoc";
            this.txtSoThangTruoc.Size = new System.Drawing.Size(100, 22);
            this.txtSoThangTruoc.TabIndex = 9;
            this.txtSoThangTruoc.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            this.txtSoThangTruoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoThangTruoc_KeyPress);
            // 
            // lblSoThangTruoc
            // 
            this.lblSoThangTruoc.AutoSize = true;
            this.lblSoThangTruoc.Location = new System.Drawing.Point(15, 186);
            this.lblSoThangTruoc.Name = "lblSoThangTruoc";
            this.lblSoThangTruoc.Size = new System.Drawing.Size(92, 16);
            this.lblSoThangTruoc.TabIndex = 8;
            this.lblSoThangTruoc.Text = "Số tháng trước";
            this.lblSoThangTruoc.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtNgayChotSo
            // 
            this.txtNgayChotSo.Location = new System.Drawing.Point(110, 147);
            this.txtNgayChotSo.Name = "txtNgayChotSo";
            this.txtNgayChotSo.Size = new System.Drawing.Size(100, 22);
            this.txtNgayChotSo.TabIndex = 7;
            this.txtNgayChotSo.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // lblNgayChot
            // 
            this.lblNgayChot.AutoSize = true;
            this.lblNgayChot.Location = new System.Drawing.Point(15, 150);
            this.lblNgayChot.Name = "lblNgayChot";
            this.lblNgayChot.Size = new System.Drawing.Size(86, 16);
            this.lblNgayChot.TabIndex = 6;
            this.lblNgayChot.Text = "Ngày chốt số";
            this.lblNgayChot.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(110, 113);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(100, 22);
            this.txtDiaChi.TabIndex = 5;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(15, 116);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(47, 16);
            this.lblDiaChi.TabIndex = 4;
            this.lblDiaChi.Text = "Địa chỉ";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(110, 77);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(100, 22);
            this.txtHoTen.TabIndex = 3;
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(15, 80);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(67, 16);
            this.lblHoTen.TabIndex = 2;
            this.lblHoTen.Text = "Họ tên KH";
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(110, 43);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(100, 22);
            this.txtMa.TabIndex = 1;
            // 
            // lblMa
            // 
            this.lblMa.AutoSize = true;
            this.lblMa.Location = new System.Drawing.Point(15, 46);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(47, 16);
            this.lblMa.TabIndex = 0;
            this.lblMa.Text = "Mã KH";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Location = new System.Drawing.Point(412, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(601, 363);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách khách hàng";
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(3, 18);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(595, 342);
            this.listBox1.TabIndex = 0;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(642, 414);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(107, 31);
            this.btnTimKiem.TabIndex = 14;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(791, 414);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(95, 31);
            this.btnThoat.TabIndex = 15;
            this.btnThoat.Text = "T&hoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 471);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSoThangSau;
        private System.Windows.Forms.Label lblSoThangSau;
        private System.Windows.Forms.TextBox txtSoThangTruoc;
        private System.Windows.Forms.Label lblSoThangTruoc;
        private System.Windows.Forms.TextBox txtNgayChotSo;
        private System.Windows.Forms.Label lblNgayChot;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label lblMa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnThemVaoDS;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnThoat;
    }
}

