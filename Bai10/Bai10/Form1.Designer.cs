namespace Bai10
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
            this.radBacNhat = new System.Windows.Forms.RadioButton();
            this.radBacHai = new System.Windows.Forms.RadioButton();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.btnGiai = new System.Windows.Forms.Button();
            this.btnLamLai = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radBacNhat
            // 
            this.radBacNhat.AutoSize = true;
            this.radBacNhat.Location = new System.Drawing.Point(55, 41);
            this.radBacNhat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radBacNhat.Name = "radBacNhat";
            this.radBacNhat.Size = new System.Drawing.Size(197, 25);
            this.radBacNhat.TabIndex = 0;
            this.radBacNhat.TabStop = true;
            this.radBacNhat.Text = "Phương trình bậc nhất";
            this.radBacNhat.UseVisualStyleBackColor = true;
            // 
            // radBacHai
            // 
            this.radBacHai.AutoSize = true;
            this.radBacHai.Location = new System.Drawing.Point(55, 87);
            this.radBacHai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radBacHai.Name = "radBacHai";
            this.radBacHai.Size = new System.Drawing.Size(187, 25);
            this.radBacHai.TabIndex = 1;
            this.radBacHai.TabStop = true;
            this.radBacHai.Text = "Phương trình bậc hai";
            this.radBacHai.UseVisualStyleBackColor = true;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(267, 294);
            this.txtA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(175, 29);
            this.txtA.TabIndex = 2;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(267, 341);
            this.txtB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(175, 29);
            this.txtB.TabIndex = 3;
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(267, 391);
            this.txtC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(175, 29);
            this.txtC.TabIndex = 4;
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(267, 443);
            this.txtKetQua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtKetQua.Multiline = true;
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(175, 50);
            this.txtKetQua.TabIndex = 5;
            this.txtKetQua.TextChanged += new System.EventHandler(this.txtKetQua_TextChanged);
            // 
            // btnGiai
            // 
            this.btnGiai.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnGiai.Location = new System.Drawing.Point(518, 294);
            this.btnGiai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGiai.Name = "btnGiai";
            this.btnGiai.Size = new System.Drawing.Size(180, 46);
            this.btnGiai.TabIndex = 6;
            this.btnGiai.Text = "&Giải phương trình";
            this.btnGiai.UseVisualStyleBackColor = true;
            // 
            // btnLamLai
            // 
            this.btnLamLai.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnLamLai.Location = new System.Drawing.Point(518, 358);
            this.btnLamLai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLamLai.Name = "btnLamLai";
            this.btnLamLai.Size = new System.Drawing.Size(180, 47);
            this.btnLamLai.TabIndex = 7;
            this.btnLamLai.Text = "&Làm lại";
            this.btnLamLai.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnThoat.Location = new System.Drawing.Point(518, 424);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(180, 43);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "&Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radBacNhat);
            this.groupBox1.Controls.Add(this.radBacHai);
            this.groupBox1.Location = new System.Drawing.Point(177, 125);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(474, 135);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn chức năng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 25F);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(169, 32);
            this.label1.MaximumSize = new System.Drawing.Size(375, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 48);
            this.label1.TabIndex = 10;
            this.label1.Text = "Giải phương trình";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(173, 297);
            this.label2.MaximumSize = new System.Drawing.Size(375, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nhập a";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(173, 446);
            this.label3.MaximumSize = new System.Drawing.Size(375, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "Kết quả";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(173, 394);
            this.label4.MaximumSize = new System.Drawing.Size(375, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 21);
            this.label4.TabIndex = 13;
            this.label4.Text = "Nhập c";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(173, 349);
            this.label5.MaximumSize = new System.Drawing.Size(375, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 21);
            this.label5.TabIndex = 14;
            this.label5.Text = "Nhập b";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLamLai);
            this.Controls.Add(this.btnGiai);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radBacNhat;
        private System.Windows.Forms.RadioButton radBacHai;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.Button btnGiai;
        private System.Windows.Forms.Button btnLamLai;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

