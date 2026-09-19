using System;
using System.Windows.Forms;

namespace Bai9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // THỦ THUẬT ÉP NỐI DÂY SỰ KIỆN TỰ ĐỘNG
            // Code này đảm bảo 100% các nút sẽ hoạt động mà không cần dùng bảng Properties

            this.Load -= Form1_Load; // Gỡ dây cũ (nếu có) để tránh chạy 2 lần
            this.Load += Form1_Load; // Nối dây mới

            btnThem.Click -= btnThem_Click;
            btnThem.Click += btnThem_Click;

            btnXoa.Click -= btnXoa_Click;
            btnXoa.Click += btnXoa_Click;

            btnTinhTong.Click -= btnTinhTong_Click;
            btnTinhTong.Click += btnTinhTong_Click;

            btnThoat.Click -= btnThoat_Click;
            btnThoat.Click += btnThoat_Click;

            cboTenSach.SelectedIndexChanged -= cboTenSach_SelectedIndexChanged;
            cboTenSach.SelectedIndexChanged += cboTenSach_SelectedIndexChanged;

            radTienMat.CheckedChanged -= radTienMat_CheckedChanged;
            radTienMat.CheckedChanged += radTienMat_CheckedChanged;

            radATM.CheckedChanged -= radATM_CheckedChanged;
            radATM.CheckedChanged += radATM_CheckedChanged;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Xóa dữ liệu cũ tránh bị trùng lặp khi Load
            cboTenSach.Items.Clear();
            cboTenSach.Items.Add("Tin đại cương");
            cboTenSach.Items.Add("Tiếng Anh F2");
            cboTenSach.Items.Add("Giải tích F1");
            cboTenSach.Items.Add("Đại số tuyến tính");

            txtGiamGia.Text = "5";
            radTienMat.Checked = true;
        }

        private void cboTenSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboTenSach.Text)
            {
                case "Tin đại cương":
                    txtGia.Text = "22000";
                    break;
                case "Tiếng Anh F2":
                    txtGia.Text = "27000";
                    break;
                case "Giải tích F1":
                    txtGia.Text = "25000";
                    break;
                case "Đại số tuyến tính":
                    txtGia.Text = "26000";
                    break;
            }
        }

        private void radTienMat_CheckedChanged(object sender, EventArgs e)
        {
            if (radTienMat.Checked) txtGiamGia.Text = "5";
        }

        private void radATM_CheckedChanged(object sender, EventArgs e)
        {
            if (radATM.Checked) txtGiamGia.Text = "10";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cboTenSach.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn tên sách!");
                return;
            }

            if (!int.TryParse(txtSoLuong.Text, out int soLuong) || soLuong <= 0)
            {
                MessageBox.Show("Số lượng phải là số nguyên lớn hơn 0!");
                txtSoLuong.Focus();
                return;
            }

            // Ép kiểu an toàn, loại bỏ ký tự % nếu ông lỡ gõ vào
            double gia = double.Parse(txtGia.Text);
            string giamGiaRaw = txtGiamGia.Text.Replace("%", "").Trim();
            double giamGia = double.Parse(giamGiaRaw);

            double thanhTien = soLuong * gia * (1 - giamGia / 100.0);

            string thongTin = $"{cboTenSach.Text},{soLuong}-{thanhTien}";
            lstSachDaMua.Items.Add(thongTin);

            txtSoLuong.Clear();
            cboTenSach.SelectedIndex = -1;
            txtGia.Clear();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lstSachDaMua.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn hãy chọn phần tử để xóa");
            }
            else
            {
                DialogResult rs = MessageBox.Show("Bạn có muốn xóa cuốn sách đó không?", "Xác nhận", MessageBoxButtons.YesNo);
                if (rs == DialogResult.Yes)
                {
                    lstSachDaMua.Items.RemoveAt(lstSachDaMua.SelectedIndex);
                }
            }
        }

        private void btnTinhTong_Click(object sender, EventArgs e)
        {
            double tongTien = 0;

            foreach (var item in lstSachDaMua.Items)
            {
                string[] parts = item.ToString().Split('-');
                if (parts.Length == 2)
                {
                    tongTien += double.Parse(parts[1]);
                }
            }

            txtTongTien.Text = tongTien.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                this.Close();
            }
        }

        // =========================================================
        // GIỮ NGUYÊN CÁC HÀM RỖNG DƯỚI ĐÂY - TUYỆT ĐỐI KHÔNG XÓA
        // Việc này để xoa dịu Visual Studio, giúp giao diện không bị sập
        // =========================================================
        private void radTienMat_CheckedChanged_1(object sender, EventArgs e) { }
        private void cboTenSach_SelectedIndexChanged_1(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void txtGia_TextChanged(object sender, EventArgs e) { }
        private void txtSoLuong_TextChanged(object sender, EventArgs e) { }
    }
}