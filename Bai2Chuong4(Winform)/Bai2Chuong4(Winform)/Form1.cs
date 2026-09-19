namespace Bai2Chuong4_Winform_
{
    public partial class Form1 : Form
    {
        List<KHGuiTK> ds = new List<KHGuiTK>();
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtSTienGui_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        public void xoa()
        {
            txtMa.Text = "";
            txtTen.Text = "";
            txtDC.Text = "";
            txtSTienGui.Text = "";
            txtNgayGui.Text = "";
            cmbTGGui.SelectedIndex = -1;
            rdbThuong.Checked = false;
            rdbPhatLoc.Checked = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            xoa();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool Loai;
            Loai = rdbThuong.Checked || rdbPhatLoc.Checked;

            KHGuiTK x = new KHGuiTK(txtMa.Text, txtTen.Text, txtDC.Text, txtNgayGui.Text, int.Parse(cmbTGGui.Text), long.Parse(txtSTienGui.Text), Loai);
            ds.Add(x);
            lstKH.Items.Add(x.toString());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtMa_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
