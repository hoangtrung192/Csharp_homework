using System;
using System.Windows.Forms;

namespace Bai10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // TỰ ĐỘNG NỐI DÂY SỰ KIỆN
            this.Load += Form1_Load;
            btnThoat.Click += btnThoat_Click;
            btnLamLai.Click += btnLamLai_Click;
            btnGiai.Click += btnGiai_Click;
            radBacNhat.CheckedChanged += radBacNhat_CheckedChanged;
            radBacHai.CheckedChanged += radBacHai_CheckedChanged;
        }

        // 1. Khi form hiển thị: PT Bậc 1 chọn sẵn, khóa ô C và ô Kết quả
        private void Form1_Load(object sender, EventArgs e)
        {
            radBacNhat.Checked = true;
            txtC.Enabled = false;
            txtKetQua.ReadOnly = true;
        }

        // 2. Chức năng Thoát (Alt+T) với xác nhận Yes/No
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                this.Close();
            }
        }

        // 3. Chức năng Làm lại (Alt+L) xóa dữ liệu các ô
        private void btnLamLai_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            txtC.Clear();
            txtKetQua.Clear();
            txtA.Focus(); // Đưa con trỏ nháy về ô A
        }

        // 4. Khóa/Mở khóa ô nhập c tùy theo RadioButton được chọn
        private void radBacNhat_CheckedChanged(object sender, EventArgs e)
        {
            if (radBacNhat.Checked)
            {
                txtC.Enabled = false;
                txtC.Clear();
            }
        }

        private void radBacHai_CheckedChanged(object sender, EventArgs e)
        {
            if (radBacHai.Checked)
            {
                txtC.Enabled = true;
            }
        }

        // 5. Chức năng Giải phương trình (Alt+G)
        private void btnGiai_Click(object sender, EventArgs e)
        {
            // NẾU LÀ PHƯƠNG TRÌNH BẬC 1: ax + b = 0
            if (radBacNhat.Checked)
            {
                if (!double.TryParse(txtA.Text, out double a) || !double.TryParse(txtB.Text, out double b))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ a, b và phải là số hợp lệ!");
                    return;
                }

                if (a == 0)
                {
                    if (b == 0) txtKetQua.Text = "Phương trình vô số nghiệm";
                    else txtKetQua.Text = "Phương trình vô nghiệm";
                }
                else
                {
                    double x = -b / a;
                    x = Math.Round(x, 2); // Làm tròn 2 chữ số thập phân
                    txtKetQua.Text = $"Phương trình có nghiệm x = {x}";
                }
            }
            // NẾU LÀ PHƯƠNG TRÌNH BẬC 2: ax^2 + bx + c = 0
            else if (radBacHai.Checked)
            {
                if (!double.TryParse(txtA.Text, out double a) ||
                    !double.TryParse(txtB.Text, out double b) ||
                    !double.TryParse(txtC.Text, out double c))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ a, b, c và phải là số hợp lệ!");
                    return;
                }

                if (a == 0) // Quay về giải pt bậc 1: bx + c = 0
                {
                    if (b == 0)
                    {
                        if (c == 0) txtKetQua.Text = "Phương trình vô số nghiệm";
                        else txtKetQua.Text = "Phương trình vô nghiệm";
                    }
                    else
                    {
                        double x = -c / b;
                        x = Math.Round(x, 2);
                        txtKetQua.Text = $"Phương trình có nghiệm x = {x}";
                    }
                }
                else
                {
                    double delta = (b * b) - (4 * a * c);
                    if (delta < 0)
                    {
                        txtKetQua.Text = "Phương trình vô nghiệm";
                    }
                    else if (delta == 0)
                    {
                        double x = -b / (2 * a);
                        x = Math.Round(x, 2);
                        txtKetQua.Text = $"Phương trình có nghiệm kép x1 = x2 = {x}";
                    }
                    else
                    {
                        double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                        double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

                        // Làm tròn 2 chữ số thập phân
                        x1 = Math.Round(x1, 2);
                        x2 = Math.Round(x2, 2);

                        txtKetQua.Text = $"Phương trình có 2 nghiệm phân biệt:\r\n x1 = {x1} và x2 = {x2}";
                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtKetQua_TextChanged(object sender, EventArgs e)
        {

        }
    }
}