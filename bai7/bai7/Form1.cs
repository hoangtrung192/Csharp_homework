using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace bai7
{
    
    public partial class Form1 : Form
    {
        double[] daySo;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtSoPhanTu.Text = "";
            label2.Visible = false;
            label3.Visible = false;
            cboChucNang.SelectedIndex = -1;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtSoPhanTu.Clear();
            label2.Text = "Dãy số vừa nhập là: ";
            label2.Visible = false;
            label3.Text = "";
            label3.Visible = false;
            cboChucNang.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtSoPhanTu.Text, out int n) && n > 0)
            {
                daySo = new double[n];
                label2.Text = "Dãy số vừa nhập là: ";

                for (int i = 0; i < n; i++)
                {
                    string input = Interaction.InputBox($"Nhập phần tử thứ {i + 1}:", "Nhập mảng");
                    if (double.TryParse(input, out double val))
                    {
                        daySo[i] = val;
                        label2.Text += val + "  ";
                    }
                }
                label2.Visible = true; 
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ!");
            }
        }

        private void cboChucNang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (daySo == null || cboChucNang.SelectedIndex == -1) return;

            if (cboChucNang.SelectedItem.ToString() == "Trung bình cộng của dãy")
            {
                double tong = 0;
                foreach (var so in daySo) tong += so;
                double tbc = tong / daySo.Length;
                label3.Text = "TBC dãy số là: " + Math.Round(tbc, 3);
                label3.Visible = true;
            }
            else if (cboChucNang.SelectedItem.ToString() == "Đếm số phần tử âm")
            {
                int dem = 0;
                foreach (var so in daySo)
                {
                    if (so < 0) dem++;
                }
                label3.Text = "Có " + dem + " phần tử âm";
                label3.Visible = true;
            }
        }
    }
}
