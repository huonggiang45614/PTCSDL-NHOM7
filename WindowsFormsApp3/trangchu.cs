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

        private void clearForm()
        {
            if(current != null)
            {
                panel2.Controls.Remove(current);
                current.Close();
                current = null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clearForm();
            ncc f = new ncc () { TopLevel = false, TopMost = true };
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
    }
}
