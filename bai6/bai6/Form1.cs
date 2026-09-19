using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnXoa.Enabled = false;
            lblMax.Visible = false;
            txtNhapSo.Text = "";

            lstDaySo.Items.Clear();

            lstDaySo.Items.Add("4");
            lstDaySo.Items.Add("46.8");
            lstDaySo.Items.Add("95");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lstDaySo.Items.Count > 0)
            {
                double max = Convert.ToDouble(lstDaySo.Items[0]);
                foreach (var item in lstDaySo.Items)
                {
                    double so = Convert.ToDouble(item);
                    if (so > max) max = so;
                }
                lblMax.Text = "Giá trị lớn nhất của dãy là: " + max;
                lblMax.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                lstDaySo.Items.RemoveAt(lstDaySo.SelectedIndex); 
                btnXoa.Enabled = false;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNhapSo.Text, out double so))
            {
                lstDaySo.Items.Add(so); 
                txtNhapSo.Clear();
                txtNhapSo.Focus(); 
            }
            else
            {
                MessageBox.Show("Bạn phải nhập số"); 
            }
        }

        private void lstDaySo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstDaySo.SelectedIndex != -1)
            {
                btnXoa.Enabled = true; 
            }
        }
    }
}
