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
    public partial class trangchu : Form
    {

        private Form current = null;
        public trangchu()
        {
            InitializeComponent();
        }
        public void HidePictureBox()
        {
            pictureBox1.Visible = false;  // Giả sử pictureBox1 là tên PictureBox của bạn
        }
        private void clearForm()
        {
            pictureBox1.Visible = false;
            if (current != null)
            {
                panel2.Controls.Remove(current);
                current.Close();
                current = null;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clearForm();
            nhacungcap f = new nhacungcap () { TopLevel = false, TopMost = true };
            f.FormBorderStyle = FormBorderStyle.None;
            panel2.Controls.Add(f);
            current = f;
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clearForm();
            nhanvien f = new nhanvien() { TopLevel = false, TopMost = true };
            f.FormBorderStyle = FormBorderStyle.None;
            panel2.Controls.Add(f);
            current = f;
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clearForm();
            loaihang f = new loaihang() { TopLevel = false, TopMost = true };
            f.FormBorderStyle = FormBorderStyle.None;
            panel2.Controls.Add(f);
            current = f;
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            clearForm();
            math f = new math() { TopLevel = false, TopMost = true };
            f.FormBorderStyle = FormBorderStyle.None;
            panel2.Controls.Add(f);
            current = f;
            f.Show();
        }

        private void trangchu_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            clearForm();
            hoadon f = new hoadon() { TopLevel = false, TopMost = true };
            f.FormBorderStyle = FormBorderStyle.None;
            panel2.Controls.Add(f);
            current = f;
            f.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
