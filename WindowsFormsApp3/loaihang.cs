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
    public partial class loaihang : Form
    {
        public loaihang()
        {
            InitializeComponent();
            loaddgvLoaiHang();
        }
        public void loaddgvLoaiHang()
        {
            dgvLoaiHang.DataSource = Database.Query("Select * from LoaiHang");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!Check())
            {
                return;
            }
            string sql = "INSERT INTO LOAIHANG(TENLOAIHANG) VALUES (@TENLOAIHANG)";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            string TENLOAIHANG = tbxLoaiHang.Text;
            try
            {
                parameters.Add("@TENLOAIHANG", TENLOAIHANG);
                Database.Execute(sql, parameters);
                loaddgvLoaiHang();
                MessageBox.Show("Thêm thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Clear();
        }

        
        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE LOAIHANG SET TENLOAIHANG = @TENLOAIHANG WHERE IDLOAIHANG = @IDLOAIHANG";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            string IDLOAIHANG = tbxID.Text;
            string TENLOAIHANG = tbxLoaiHang.Text;
            parameters.Add("@IDLOAIHANG", IDLOAIHANG);
            parameters.Add("@TENLOAIHANG", TENLOAIHANG);
            try
            {
                Database.Execute(sql, parameters);
                loaddgvLoaiHang();
                MessageBox.Show("Thêm thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Clear();
        }
        private void dgvLoaiHang_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            tbxID.Text = dgvLoaiHang.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbxLoaiHang.Text = dgvLoaiHang.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "DELETE LOAIHANG WHERE IDLOAIHANG = @IDLOAIHANG";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            string IDLOAIHANG = tbxID.Text;
            parameters.Add("@IDLOAIHANG", IDLOAIHANG);
            try
            {
                Database.Execute(sql, parameters);
                loaddgvLoaiHang();
                MessageBox.Show("Thêm thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Clear();
        }
        private void Clear()
        {
            tbxID.Clear();
            tbxLoaiHang.Clear();
            tbxTimKiem.Clear();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> parameter = new Dictionary<string, object>();
            String TENLOAIHANG = tbxTimKiem.Text;
            parameter.Add("@TENLOAIHANG", TENLOAIHANG);
            dgvLoaiHang.DataSource = Database.Query("Select * from NHANVIEN where TENNHANVIEN like '%'+@TENLOAIHANG+'%'", parameter);
        }
        private bool Check()
        {
            errorProvider1.Clear();
            tbxLoaiHang.Text = tbxLoaiHang.Text.Trim();
            if (tbxLoaiHang.TextLength == 0)
            {
                errorProvider1.SetError(tbxLoaiHang, "Tên không được để trống");
                return false;
            }
            return true;
        }

        private void loaihang_Load(object sender, EventArgs e)
        {

        }
    }
}
