using System;
using System.Globalization;
using System.Windows.Forms;

namespace Bai1Chuong4_Winform_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            txtMa.Text = " ";
            txtHoTen.Text = " ";
            txtDiaChi.Text = " ";
            txtNgayChotSo.Text = " ";
            txtSoThangTruoc.Text = " ";
            txtSoThangSau.Text = " ";
            txtMa.Focus();
        }

        private void txtSoThangTruoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSoThangSau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnThemVaoDS_Click(object sender, EventArgs e)
        {
            string maKH = txtMa.Text.Trim();
            string hoTen = txtHoTen.Text.Trim();
            string diaChi = txtDiaChi.Text.Trim();
            string ngayChotSo = txtNgayChotSo.Text.Trim();
            string soThangTruoc = txtSoThangTruoc.Text.Trim();
            string soThangSau = txtSoThangSau.Text.Trim();
            if (maKH.Length != 6)
            {
                MessageBox.Show("Mã khách hàng bắt buộc phải có 6 số", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMa.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(hoTen))
            {
                MessageBox.Show("Họ tên không được để trống", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTen.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(diaChi))
            {
                MessageBox.Show("Địa chỉ không được để trống", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiaChi.Focus();
                return;
            }
            string[] formats = { "d/M/yyyy", "dd/MM/yyyy", "d-M-yyyy", "dd-MM-yyyy" };
            if (!DateTime.TryParseExact(ngayChotSo, formats, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime ngayChot) && !DateTime.TryParse(ngayChotSo, out ngayChot))
            {
                MessageBox.Show("Ngày chốt số phải đúng định dạng (ví dụ: 1/1/2026)", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNgayChotSo.Focus();
                return;
            }
            int STT = int.Parse(soThangTruoc);
            int STS = int.Parse(soThangSau);
            if (STT > STS)
            {
                MessageBox.Show("Số tháng trước phải nhỏ hơn số tháng sau", "Lỗi logic nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoThangTruoc.Focus();
                return;
            }


            int soTienDien = STS - STT;
            double tienChuaThue = tinhTienDien(soTienDien);
            double tienSauThue = tienChuaThue * 0.10;
            double tienPhaiTra = tienChuaThue + tienSauThue;

            string dongDuLieu = $"{maKH} | {hoTen} | {diaChi} | {ngayChotSo} | {soThangTruoc} | {soThangSau} | {tienPhaiTra}";
            listBox1.Items.Add(dongDuLieu);
            MessageBox.Show($"Thêm thành công!\nSố điện tiêu thụ: {soTienDien} kWh\n Tổng tiền (Bao gồm 10% VAT): {tienPhaiTra} đ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private double tinhTienDien(int soDien)
        {
            double tien;
            if (soDien < 50)
            {
                tien = soDien * 100;
            }
            else if (soDien < 100)
            {
                tien = (50 * 100) + soDien * 200;
            }
            else if (soDien < 200)
            {
                tien = (50 * 100) + (50 * 200) + soDien * 300;
            }
            else
            {
                tien = (50 * 100) + (50 * 200) + (100 * 300) + soDien * 400;
            }
            return tien;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            using (Form2 frm = new Form2())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    string tenCanTim = frm.txtTenTimKiem.Text.Trim();

                    if (string.IsNullOrWhiteSpace(tenCanTim))
                    {
                        MessageBox.Show("Vui lòng nhập họ tên cần tìm!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    bool timThay = false;


                    foreach (object item in listBox1.Items)
                    {
                        string dong = item.ToString();
                        string[] parts = dong.Split('|');


                        if (parts.Length >= 7)
                        {
                            string hoTenTrongDS = parts[1].Trim();
                            string soTien = parts[6].Trim();


                            if (hoTenTrongDS.Equals(tenCanTim, StringComparison.OrdinalIgnoreCase))
                            {
                                MessageBox.Show(
                                    "Họ tên khách hàng: " + hoTenTrongDS + "\nSố tiền phải trả: " + soTien + " đồng",
                                    "Kết quả tìm kiếm",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information
                                );
                                timThay = true;
                                break;
                            }
                        }
                    }


                    if (!timThay)
                    {
                        MessageBox.Show(
                            "Khách hàng \"" + tenCanTim + "\" hiện chưa có trong danh sách.",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );
                    }
                }
            }
        }

    }
}
