namespace Bai2Chuong4_Winform_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            lblTGGui = new Label();
            button2 = new Button();
            button1 = new Button();
            groupBox3 = new GroupBox();
            rdbPhatLoc = new RadioButton();
            rdbThuong = new RadioButton();
            cmbTGGui = new ComboBox();
            txtNgayGui = new TextBox();
            lblNgayGui = new Label();
            txtSTienGui = new TextBox();
            lblSTienGui = new Label();
            txtDC = new TextBox();
            lblDC = new Label();
            txtTen = new TextBox();
            lblTen = new Label();
            txtMa = new TextBox();
            lblMa = new Label();
            groupBox2 = new GroupBox();
            lstKH = new ListBox();
            button3 = new Button();
            button4 = new Button();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblTGGui);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(cmbTGGui);
            groupBox1.Controls.Add(txtNgayGui);
            groupBox1.Controls.Add(lblNgayGui);
            groupBox1.Controls.Add(txtSTienGui);
            groupBox1.Controls.Add(lblSTienGui);
            groupBox1.Controls.Add(txtDC);
            groupBox1.Controls.Add(lblDC);
            groupBox1.Controls.Add(txtTen);
            groupBox1.Controls.Add(lblTen);
            groupBox1.Controls.Add(txtMa);
            groupBox1.Controls.Add(lblMa);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(346, 488);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nhập thông tin khách hàng gửi tiết kiệm";
            // 
            // lblTGGui
            // 
            lblTGGui.AutoSize = true;
            lblTGGui.Location = new Point(28, 352);
            lblTGGui.Name = "lblTGGui";
            lblTGGui.Size = new Size(100, 20);
            lblTGGui.TabIndex = 16;
            lblTGGui.Text = "Thời gian gửi:";
            lblTGGui.Click += label1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(205, 449);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 14;
            button2.Text = "Thêm &Mới";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(48, 449);
            button1.Name = "button1";
            button1.Size = new Size(122, 29);
            button1.TabIndex = 13;
            button1.Text = "&Thêm vào DS";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(rdbPhatLoc);
            groupBox3.Controls.Add(rdbThuong);
            groupBox3.Location = new Point(33, 389);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(282, 54);
            groupBox3.TabIndex = 12;
            groupBox3.TabStop = false;
            groupBox3.Text = "Loại tiết kiệm";
            // 
            // rdbPhatLoc
            // 
            rdbPhatLoc.AutoSize = true;
            rdbPhatLoc.Location = new Point(149, 24);
            rdbPhatLoc.Name = "rdbPhatLoc";
            rdbPhatLoc.Size = new Size(83, 24);
            rdbPhatLoc.TabIndex = 1;
            rdbPhatLoc.TabStop = true;
            rdbPhatLoc.Text = "Phát lộc";
            rdbPhatLoc.UseVisualStyleBackColor = true;
            // 
            // rdbThuong
            // 
            rdbThuong.AutoSize = true;
            rdbThuong.Location = new Point(42, 24);
            rdbThuong.Name = "rdbThuong";
            rdbThuong.Size = new Size(81, 24);
            rdbThuong.TabIndex = 0;
            rdbThuong.TabStop = true;
            rdbThuong.Text = "Thường";
            rdbThuong.UseVisualStyleBackColor = true;
            // 
            // cmbTGGui
            // 
            cmbTGGui.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTGGui.FormattingEnabled = true;
            cmbTGGui.Items.AddRange(new object[] { "1", "3", "6", "12" });
            cmbTGGui.Location = new Point(150, 349);
            cmbTGGui.Name = "cmbTGGui";
            cmbTGGui.Size = new Size(72, 28);
            cmbTGGui.TabIndex = 11;
            // 
            // txtNgayGui
            // 
            txtNgayGui.Location = new Point(150, 281);
            txtNgayGui.Name = "txtNgayGui";
            txtNgayGui.Size = new Size(125, 27);
            txtNgayGui.TabIndex = 9;
            // 
            // lblNgayGui
            // 
            lblNgayGui.AutoSize = true;
            lblNgayGui.Location = new Point(21, 288);
            lblNgayGui.Name = "lblNgayGui";
            lblNgayGui.Size = new Size(73, 20);
            lblNgayGui.TabIndex = 8;
            lblNgayGui.Text = "Ngày gửi:";
            // 
            // txtSTienGui
            // 
            txtSTienGui.Location = new Point(150, 218);
            txtSTienGui.Name = "txtSTienGui";
            txtSTienGui.Size = new Size(125, 27);
            txtSTienGui.TabIndex = 7;
            txtSTienGui.KeyPress += txtSTienGui_KeyPress;
            // 
            // lblSTienGui
            // 
            lblSTienGui.AutoSize = true;
            lblSTienGui.Location = new Point(21, 221);
            lblSTienGui.Name = "lblSTienGui";
            lblSTienGui.Size = new Size(84, 20);
            lblSTienGui.TabIndex = 6;
            lblSTienGui.Text = "Số tiền gửi:";
            // 
            // txtDC
            // 
            txtDC.Location = new Point(121, 159);
            txtDC.Name = "txtDC";
            txtDC.Size = new Size(125, 27);
            txtDC.TabIndex = 5;
            // 
            // lblDC
            // 
            lblDC.AutoSize = true;
            lblDC.Location = new Point(21, 162);
            lblDC.Name = "lblDC";
            lblDC.Size = new Size(58, 20);
            lblDC.TabIndex = 4;
            lblDC.Text = "Địa chỉ:";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(121, 98);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(125, 27);
            txtTen.TabIndex = 3;
            // 
            // lblTen
            // 
            lblTen.AutoSize = true;
            lblTen.Location = new Point(21, 101);
            lblTen.Name = "lblTen";
            lblTen.Size = new Size(81, 20);
            lblTen.TabIndex = 2;
            lblTen.Text = "Họ tên KH:";
            // 
            // txtMa
            // 
            txtMa.Location = new Point(121, 41);
            txtMa.Name = "txtMa";
            txtMa.Size = new Size(125, 27);
            txtMa.TabIndex = 1;
            txtMa.TextChanged += txtMa_TextChanged;
            txtMa.KeyPress += txtMa_KeyPress;
            // 
            // lblMa
            // 
            lblMa.AutoSize = true;
            lblMa.Location = new Point(21, 44);
            lblMa.Name = "lblMa";
            lblMa.Size = new Size(57, 20);
            lblMa.TabIndex = 0;
            lblMa.Text = "Mã KH:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lstKH);
            groupBox2.Location = new Point(357, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(663, 428);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách khác hàng";
            // 
            // lstKH
            // 
            lstKH.Dock = DockStyle.Fill;
            lstKH.FormattingEnabled = true;
            lstKH.Location = new Point(3, 23);
            lstKH.Name = "lstKH";
            lstKH.Size = new Size(657, 402);
            lstKH.TabIndex = 0;
            lstKH.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // button3
            // 
            button3.Location = new Point(705, 461);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 14;
            button3.Text = "Tìm kiếm";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(897, 461);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 15;
            button4.Text = "Thoát";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1037, 539);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtNgayGui;
        private Label lblNgayGui;
        private TextBox txtSTienGui;
        private Label lblSTienGui;
        private TextBox txtDC;
        private Label lblDC;
        private TextBox txtTen;
        private Label lblTen;
        private TextBox txtMa;
        private Label lblMa;
        private GroupBox groupBox2;
        private Button button2;
        private Button button1;
        private GroupBox groupBox3;
        private RadioButton rdbPhatLoc;
        private RadioButton rdbThuong;
        private ComboBox cmbTGGui;
        
        private ListBox lstKH;
        private Button button3;
        private Button button4;
        private Label lblTGGui;
    }
}
