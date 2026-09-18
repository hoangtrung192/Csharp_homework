namespace Bai8
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
            this.lblNhapSo = new System.Windows.Forms.Label();
            this.txtNhapSo = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnTang = new System.Windows.Forms.Button();
            this.btnChonChan = new System.Windows.Forms.Button();
            this.grpDaySo = new System.Windows.Forms.GroupBox();
            this.lstDaySo = new System.Windows.Forms.ListBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.grpDaySo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNhapSo
            // 
            this.lblNhapSo.AutoSize = true;
            this.lblNhapSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhapSo.Location = new System.Drawing.Point(25, 40);
            this.lblNhapSo.Name = "lblNhapSo";
            this.lblNhapSo.Size = new System.Drawing.Size(95, 18);
            this.lblNhapSo.TabIndex = 0;
            this.lblNhapSo.Text = "Nhập một số:";
            // 
            // txtNhapSo
            // 
            this.txtNhapSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhapSo.Location = new System.Drawing.Point(130, 37);
            this.txtNhapSo.Name = "txtNhapSo";
            this.txtNhapSo.Size = new System.Drawing.Size(125, 24);
            this.txtNhapSo.TabIndex = 1;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(75, 85);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(160, 32);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "&Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnTang
            // 
            this.btnTang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTang.Location = new System.Drawing.Point(75, 130);
            this.btnTang.Name = "btnTang";
            this.btnTang.Size = new System.Drawing.Size(160, 32);
            this.btnTang.TabIndex = 3;
            this.btnTang.Text = "Tăng mỗi số lên 3";
            this.btnTang.UseVisualStyleBackColor = true;
            this.btnTang.Click += new System.EventHandler(this.btnTang_Click);
            // 
            // btnChonChan
            // 
            this.btnChonChan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonChan.Location = new System.Drawing.Point(75, 175);
            this.btnChonChan.Name = "btnChonChan";
            this.btnChonChan.Size = new System.Drawing.Size(160, 32);
            this.btnChonChan.TabIndex = 4;
            this.btnChonChan.Text = "Chọn số chẵn đầu";
            this.btnChonChan.UseVisualStyleBackColor = true;
            this.btnChonChan.Click += new System.EventHandler(this.btnChonChan_Click);
            // 
            // grpDaySo
            // 
            this.grpDaySo.Controls.Add(this.lstDaySo);
            this.grpDaySo.Controls.Add(this.btnXoa);
            this.grpDaySo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDaySo.Location = new System.Drawing.Point(280, 25);
            this.grpDaySo.Name = "grpDaySo";
            this.grpDaySo.Size = new System.Drawing.Size(205, 225);
            this.grpDaySo.TabIndex = 5;
            this.grpDaySo.TabStop = false;
            this.grpDaySo.Text = "Dãy số";
            // 
            // lstDaySo
            // 
            this.lstDaySo.FormattingEnabled = true;
            this.lstDaySo.ItemHeight = 18;
            this.lstDaySo.Location = new System.Drawing.Point(25, 25);
            this.lstDaySo.Name = "lstDaySo";
            this.lstDaySo.Size = new System.Drawing.Size(155, 148);
            this.lstDaySo.TabIndex = 0;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(42, 180);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(120, 30);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "&Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(365, 265);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(120, 32);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "T&hoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 315);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.grpDaySo);
            this.Controls.Add(this.btnChonChan);
            this.Controls.Add(this.btnTang);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtNhapSo);
            this.Controls.Add(this.lblNhapSo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lam viec tren day so";
            this.grpDaySo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNhapSo;
        private System.Windows.Forms.TextBox txtNhapSo;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnTang;
        private System.Windows.Forms.Button btnChonChan;
        private System.Windows.Forms.GroupBox grpDaySo;
        private System.Windows.Forms.ListBox lstDaySo;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
    }
}
