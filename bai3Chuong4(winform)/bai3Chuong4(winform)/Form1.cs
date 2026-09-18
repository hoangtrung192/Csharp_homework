using System;
using System.Windows.Forms;

namespace bai3Chuong4_winform_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            txtGiaDuThuyen.ReadOnly = true;
            txtTien.ReadOnly = true;
            cmbChonDoUong.Items.Add("Coca cola");
            cmbChonDoUong.Items.Add("Pepsi");
            cmbChonDoUong.Items.Add("Seven up");


            for (int i = 1; i <= 10; i++)
            {
                cmbSoLuong.Items.Add(i.ToString());
            }
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
            txtHoTen.Text = " ";
            rdoCaNgay.Checked = false;
            rdoNuaNgay.Checked = false;
            txtGiaDuThuyen.Text = " ";
            cmbChonDoUong.SelectedIndex = -1;
            cmbSoLuong.SelectedIndex = -1;
            txtTien.Text = " ";
            txtHoTen.Focus();

        }

        private void cmbChonDoUong_SelectedIndexChanged(object sender, EventArgs e)
        {
            tinhTienDoUong();
        }

        private void txtTien_TextChanged(object sender, EventArgs e)
        {

        }
        public void tinhTienDoUong()
        {
            if (cmbChonDoUong.SelectedIndex == -1 || cmbSoLuong.SelectedIndex == -1)
            {
                return;
            }
            double donGia = 0;
            if (cmbChonDoUong.SelectedIndex == 0)
            {
                donGia = 0.5;
            }
            else if (cmbChonDoUong.SelectedIndex == 1)
            {
                donGia = 0.8;
            }
            else if (cmbChonDoUong.SelectedIndex == 2)
            {
                donGia = 1.0;
            }

            int soLuong = int.Parse(cmbSoLuong.SelectedItem.ToString());
            double tongTienPhaiTra = donGia * soLuong;

            txtTien.Text = tongTienPhaiTra.ToString();
        }

        private void cmbSoLuong_SelectedIndexChanged(object sender, EventArgs e)
        {
            tinhTienDoUong();
        }

        private void rdoCaNgay_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoCaNgay.Checked)
            {
                txtGiaDuThuyen.Text = "200";
            }
        }

        private void rdoNuaNgay_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoNuaNgay.Checked)
            {
                txtGiaDuThuyen.Text = "100";
            }
        }

        private void btnThemVaoDS_Click(object sender, EventArgs e)
        {
            if (txtHoTen.Text == " " || (rdoCaNgay.Checked == false && rdoNuaNgay.Checked == false))
            {
                MessageBox.Show("Phải điền đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTen.Focus();
                return;
            }
            string loaiTour = rdoCaNgay.Checked ? "Cả ngày" : "Nửa ngày";
            double giaDuThuyen = double.Parse(txtGiaDuThuyen.Text);
            double tienDoUong = 0;
            if (txtTien.Text.Trim() != "")
            {
                tienDoUong = Convert.ToDouble(txtTien.Text);
            }
            double tongTien = giaDuThuyen + tienDoUong;

            string hienThi = $"{txtHoTen.Text.Trim()} | {loaiTour} | {giaDuThuyen} $| Đồ uống {tienDoUong} $| Tổng {tongTien}";
            listBox1.Items.Add(hienThi);
        }
    }
}
