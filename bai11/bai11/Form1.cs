using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace bai11
{
    public partial class Form1 : Form
    {
        private Font fontMacDinh;
        private Color mauMacDinh;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fontMacDinh = textBox1.Font;
            mauMacDinh = textBox1.ForeColor;
        }

        // Một hàm viết thêm để dùng chung cho việc cập nhật Font chữ, Kích thước và Hiệu ứng
        private void CapNhatDinhDangChu()
        {
            // Lấy tên font từ comboBox1, nếu chưa chọn thì giữ nguyên font của textBox1
            string tenFont = comboBox1.SelectedItem != null ? comboBox1.SelectedItem.ToString() : textBox1.Font.FontFamily.Name;

            // Lấy kích thước từ comboBox2, nếu chưa chọn thì giữ nguyên kích thước của textBox1
            float kichThuoc = textBox1.Font.Size;
            if (comboBox2.SelectedItem != null)
            {
                float.TryParse(comboBox2.SelectedItem.ToString(), out kichThuoc);
            }

            // Gắn hiệu ứng (Đậm, Nghiêng, Gạch chân) dựa vào trạng thái CheckBox
            FontStyle kieuChu = FontStyle.Regular;
            if (checkBox1.Checked) kieuChu |= FontStyle.Bold;
            if (checkBox2.Checked) kieuChu |= FontStyle.Italic;
            if (checkBox3.Checked) kieuChu |= FontStyle.Underline;

            // Cập nhật lại TextBox[cite: 3]
            try
            {
                textBox1.Font = new Font(tenFont, kichThuoc, kieuChu);
            }
            catch
            {
                // Bỏ qua lỗi nếu máy không có font đã chọn
            }
        }

        private void button1_Click(object sender, EventArgs e) // button lam lai
        {
            // Bỏ chọn tất cả các CheckBox (Hiệu ứng và Màu)[cite: 3]
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;

            // Đưa ComboBox về rỗng[cite: 3]
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox1.Text = "";
            comboBox2.Text = "";

            // Đưa TextBox về định dạng ban đầu[cite: 3]
            textBox1.Font = fontMacDinh;
            textBox1.ForeColor = mauMacDinh;
        }

        private void button2_Click(object sender, EventArgs e) // button thoat
        {
            // Hỏi xác nhận Yes/No trước khi thoát[cite: 3]
            if (MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close(); // Nếu chọn Yes thì thoát[cite: 3]
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // checkbox bold
            CapNhatDinhDangChu(); // Gọi hàm cập nhật hiệu ứng chữ[cite: 3]
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            // checkbox italic
            CapNhatDinhDangChu(); // Gọi hàm cập nhật hiệu ứng chữ[cite: 3]
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            // checkbox underline   
            CapNhatDinhDangChu(); // Gọi hàm cập nhật hiệu ứng chữ[cite: 3]
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            // color red
            if (checkBox4.Checked)
            {
                textBox1.ForeColor = Color.Red; // Đổi màu chữ thành Đỏ[cite: 3]
                checkBox5.Checked = false; // Tắt màu Xanh
                checkBox6.Checked = false; // Tắt màu Đen
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            // color green
            if (checkBox5.Checked)
            {
                textBox1.ForeColor = Color.Green; // Đổi màu chữ thành Xanh lá[cite: 3]
                checkBox4.Checked = false; // Tắt màu Đỏ
                checkBox6.Checked = false; // Tắt màu Đen
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            // color black
            if (checkBox6.Checked)
            {
                textBox1.ForeColor = Color.Black; // Đổi màu chữ thành Đen[cite: 3]
                checkBox4.Checked = false; // Tắt màu Đỏ
                checkBox5.Checked = false; // Tắt màu Xanh
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // cb box font
            CapNhatDinhDangChu(); // Gọi hàm cập nhật Font chữ[cite: 3]
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // cb box size
            CapNhatDinhDangChu(); // Gọi hàm cập nhật cỡ chữ[cite: 3]
        }
    }
}