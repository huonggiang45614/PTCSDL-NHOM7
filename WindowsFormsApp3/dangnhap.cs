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

        private string username = "admin";
        private string password = "admin";

        public dangnhap()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(135, 206, 235);
        }

        private void btdangnhap_Click(object sender, EventArgs e)
        {
            DataTable dt = Database.Query("select * from TAIKHOAN where TENTAIKHOAN=@TENTAIKHOAN", new Dictionary<string, object>()
            {
                {"TENTAIKHOAN", txttentaikhoan.Text}
            });
            if(txttentaikhoan.Text.Equals(username) && txtmatkhau.Text.Equals(password))
            {
                trangchu f=new trangchu();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai mật khẩu hoặc tài khoản!");
            }
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show(" Bạn thật sự muốn thoát chương trình ?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK) 
            {
                e.Cancel = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
