using System;
using System.Windows.Forms;
using System.Drawing;

namespace WinFormBaiTap
{
    /// <summary>
    /// BÀI 5: Form quản lý một dãy số - Thêm / Xóa / Tính tổng / Tìm Max
    /// Toàn bộ control được tạo bằng code (không cần Designer.cs riêng),
    /// chỉ cần tạo 1 Windows Forms App (.NET Framework hoặc .NET) rồi
    /// copy nguyên file này vào project, cho Program.cs chạy Application.Run(new Bai5Form()).
    /// </summary>
    public class Bai5Form : Form
    {
        private Label lblNhapSo;
        private TextBox txtNhapSo;
        private GroupBox grpDaySo;
        private ListBox lstDaySo;
        private Button btnThemVaoDS;
        private Button btnXoaKhoiDS;
        private Button btnLamMoi;
        private Button btnTinhTong;
        private Button btnTimMax;
        private Button btnThoat;
        private Label lblTong;
        private Label lblMax;

        public Bai5Form()
        {
            InitializeComponent();
            ResetTrangThaiBanDau();
        }

        private void InitializeComponent()
        {
            this.Text = "Day so";
            this.ClientSize = new Size(560, 260);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            lblNhapSo = new Label { Text = "Nhập số:", Location = new Point(20, 30), AutoSize = true };
            txtNhapSo = new TextBox { Location = new Point(90, 27), Width = 100 };

            btnThemVaoDS = new Button { Text = "Thêm vào &danh sách", Location = new Point(20, 70), Width = 160 };
            btnXoaKhoiDS = new Button { Text = "&Xoá khỏi danh sách", Location = new Point(20, 105), Width = 160 };
            btnLamMoi = new Button { Text = "&Làm mới", Location = new Point(20, 140), Width = 160 };

            grpDaySo = new GroupBox { Text = "Dãy số", Location = new Point(210, 20), Size = new Size(140, 200) };
            lstDaySo = new ListBox { Location = new Point(10, 20), Size = new Size(115, 165) };
            grpDaySo.Controls.Add(lstDaySo);

            btnTinhTong = new Button { Text = "Tí&nh Tổng", Location = new Point(380, 30), Width = 100 };
            btnTimMax = new Button { Text = "Tìm M&ax", Location = new Point(380, 70), Width = 100 };
            btnThoat = new Button { Text = "T&hoát", Location = new Point(380, 110), Width = 100 };

            lblTong = new Label { Location = new Point(490, 34), AutoSize = true, ForeColor = Color.Red };
            lblMax = new Label { Location = new Point(490, 74), AutoSize = true, ForeColor = Color.Red };

            this.Controls.AddRange(new Control[]
            {
                lblNhapSo, txtNhapSo,
                btnThemVaoDS, btnXoaKhoiDS, btnLamMoi,
                grpDaySo,
                btnTinhTong, btnTimMax, btnThoat,
                lblTong, lblMax
            });

            // Gắn sự kiện
            btnThemVaoDS.Click += btnThemVaoDS_Click;
            btnXoaKhoiDS.Click += btnXoaKhoiDS_Click;
            btnLamMoi.Click += btnLamMoi_Click;
            btnTinhTong.Click += btnTinhTong_Click;
            btnTimMax.Click += btnTimMax_Click;
            btnThoat.Click += btnThoat_Click;
        }

        // Yêu cầu 2 + 3: trạng thái ban đầu / khi bấm "Làm mới"
        private void ResetTrangThaiBanDau()
        {
            lstDaySo.Items.Clear();
            txtNhapSo.Clear();

            lblTong.Text = "";
            lblMax.Text = "";
            lblTong.Visible = false;
            lblMax.Visible = false;

            btnTinhTong.Enabled = false;
            btnTimMax.Enabled = false;
            btnXoaKhoiDS.Enabled = false;

            txtNhapSo.Focus();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ResetTrangThaiBanDau();
        }

        // Yêu cầu 4: Thêm vào danh sách
        private void btnThemVaoDS_Click(object sender, EventArgs e)
        {
            string noiDung = txtNhapSo.Text.Trim();

            if (string.IsNullOrEmpty(noiDung))
            {
                MessageBox.Show("Bạn phải nhập số vào!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNhapSo.Focus();
                return;
            }

            double giaTri;
            if (!double.TryParse(noiDung, out giaTri))
            {
                MessageBox.Show("Giá trị nhập vào không phải là số, vui lòng nhập lại!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNhapSo.Clear();
                txtNhapSo.Focus();
                return;
            }

            lstDaySo.Items.Add(giaTri);
            txtNhapSo.Clear();
            txtNhapSo.Focus();

            btnTinhTong.Enabled = true;
            btnTimMax.Enabled = true;
            btnXoaKhoiDS.Enabled = true;
        }

        // Yêu cầu 5: Xóa khỏi danh sách
        private void btnXoaKhoiDS_Click(object sender, EventArgs e)
        {
            if (lstDaySo.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn hãy chọn một mục trong danh sách để xóa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            lstDaySo.Items.RemoveAt(lstDaySo.SelectedIndex);

            if (lstDaySo.Items.Count == 0)
            {
                btnTinhTong.Enabled = false;
                btnTimMax.Enabled = false;
                btnXoaKhoiDS.Enabled = false;
                lblTong.Visible = false;
                lblMax.Visible = false;
            }
        }

        // Yêu cầu 6: Tính tổng
        private void btnTinhTong_Click(object sender, EventArgs e)
        {
            double tong = 0;
            foreach (var item in lstDaySo.Items)
            {
                tong += Convert.ToDouble(item);
            }

            lblTong.Text = "Tổng = " + tong;
            lblTong.Visible = true;
        }

        // Yêu cầu 7: Tìm Max
        private void btnTimMax_Click(object sender, EventArgs e)
        {
            double max = Convert.ToDouble(lstDaySo.Items[0]);
            foreach (var item in lstDaySo.Items)
            {
                double gt = Convert.ToDouble(item);
                if (gt > max) max = gt;
            }

            lblMax.Text = "Max = " + max;
            lblMax.Visible = true;
        }

        // Yêu cầu 1: Thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}