using System;
using System.Windows.Forms;

namespace Bai8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Yêu cầu 1: Nút Thoát (Alt + h) - 1 điểm
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }

        // Yêu cầu 2: Nút Thêm (Alt + T) - 2.5 điểm
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNhapSo.Text.Trim(), out int so))
            {
                lstDaySo.Items.Add(so);
                txtNhapSo.Clear();
                txtNhapSo.Focus();
            }
            else
            {
                MessageBox.Show("bạn phải nhập số nguyên vào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNhapSo.SelectAll();
                txtNhapSo.Focus();
            }
        }

        // Yêu cầu 3: Nút Xóa (Alt + X) - 2 điểm
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lstDaySo.SelectedIndex == -1)
            {
                MessageBox.Show("Ban phải chọn phần tử để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult dr = MessageBox.Show("Bạn có muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    lstDaySo.Items.RemoveAt(lstDaySo.SelectedIndex);
                }
            }
        }

        // Yêu cầu 4: Tăng mỗi số lên 3 - 1 điểm
        private void btnTang_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstDaySo.Items.Count; i++)
            {
                int val = Convert.ToInt32(lstDaySo.Items[i]);
                lstDaySo.Items[i] = val + 3;
            }
        }

        // Yêu cầu 5: Chọn số chẵn đầu - 1 điểm
        private void btnChonChan_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstDaySo.Items.Count; i++)
            {
                int val = Convert.ToInt32(lstDaySo.Items[i]);
                if (val % 2 == 0)
                {
                    lstDaySo.SelectedIndex = i;
                    return;
                }
            }
            MessageBox.Show("Không có số chẵn nào trong danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}