using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class dangnhap : Form
    {
        public dangnhap()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(135, 206, 235);
            txttentaikhoan.Text = "admin";
            txtmatkhau.Text = "admin";
        }

        private void btdangnhap_Click(object sender, EventArgs e)
        {
            if (!check()) return;
            var pa = new Dictionary<string, object>();
            pa.Add("TENTAIKHOAN", txttentaikhoan.Text);
            DataTable dt = Database.Query("select * from TAIKHOAN where TENTAIKHOAN=@TENTAIKHOAN", pa);
            if (dt.Rows.Count == 0 || !dt.Rows[0]["MATKHAU"].ToString().Equals(txtmatkhau.Text))
            {
                MessageBox.Show("Sai mật khẩu hoặc tài khoản!");
            }
            else
            {
                trangchu f = new trangchu();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show(" Bạn thật sự muốn thoát chương trình ?", "Thông báo", MessageBoxButtons.OKCancel) !=
                System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private bool check()
        {
            errorProvider1.Clear();
            txtmatkhau.Text = txtmatkhau.Text.Trim();
            txttentaikhoan.Text = txttentaikhoan.Text.Trim();
            if (txttentaikhoan.TextLength == 0)
            {
                errorProvider1.SetError(txttentaikhoan, "Hãy nhập tên tài khoản.");
                return false;
            }

            if (txtmatkhau.TextLength == 0)
            {
                errorProvider1.SetError(txtmatkhau, "Hãy nhập mật khẩu.");
                return false;
            }

            return true;
        }

        private void txtmatkhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btdangnhap_Click(sender, EventArgs.Empty);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}