using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp3
{

    public partial class nhanvien : Form
    {
        public nhanvien()
        {
            InitializeComponent();
            loadData();
            dateTimePicker1.Value = DateTime.Now;
        }

        public void loadData()
        {
            dataGridView1.DataSource = Database.Query("Select * from NHANVIEN");
            comboBox1.DataSource = Database.Query("select GIOITINH from NHANVIEN");
            comboBox1.ValueMember = "GIOITINH";
        }


        private void btn_ADD_Click(object sender, EventArgs e)
        {
            if (!Check())
            {
                return;
            }
            Dictionary<string, object> parameter = new Dictionary<string, object>();
            String sql =
                "EXEC ThemNhanVien @TENNHANVIEN = @Name, @GIOITINH = @Gender, @NGAYSINH = @DoB, @SODIENTHOAI = @Number, @DIACHI = @Address";
            String Name = tbx_Name.Text;
            String Address = tbx_Address.Text;
            String Number = tbx_Number.Text;
            String Gender = comboBox1.Text;
            String DoB = dateTimePicker1.Value.Date.ToString("yyyy-MM-dd");
            try
            {
                parameter.Add("@Name", Name);
                parameter.Add("@Address", Address);
                parameter.Add("@Number", Number);
                parameter.Add("@Gender", Gender);
                parameter.Add("@DoB", DoB);

                Database.Execute(sql, parameter);
                loadData();
                MessageBox.Show("Thêm thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ClearTextBoxes();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tbx_ID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbx_Name.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            DateTime dateTime = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
            dateTimePicker1.Value = dateTime.Date;
            tbx_Number.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            tbx_Address.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void btn_EDIT_Click(object sender, EventArgs e)
        {
            if (!Check())
            {
                return;
            }
            Dictionary<string, object> parameter = new Dictionary<string, object>();
            String sql =
                "EXEC SuaNhanVien @IDNHANVIEN = @ID, @TENNHANVIEN = @Name, @GIOITINH = @Gender, @NGAYSINH = @DoB, @SODIENTHOAI = @Number, @DIACHI = @Address";
            String ID = tbx_ID.Text;
            String Name = tbx_Name.Text;
            String Address = tbx_Address.Text;
            String Number = tbx_Number.Text;
            String Gender = comboBox1.Text;
            String DoB = dateTimePicker1.Value.Date.ToString("yyyy-MM-dd");
            parameter.Add("@ID", ID);
            parameter.Add("@Name", Name);
            parameter.Add("@Address", Address);
            parameter.Add("@Number", Number);
            parameter.Add("@Gender", Gender);
            parameter.Add("@DoB", DoB);
            try
            {
                Database.Execute(sql, parameter);
                loadData();
                MessageBox.Show("Cập nhật thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            ClearTextBoxes();
        }

        private void tbx_SEARCH_TextChanged(object sender, EventArgs e)
        {
            Dictionary<string, object> parameter = new Dictionary<string, object>();
            String Name = tbx_SEARCH.Text;
            parameter.Add("@Name", Name);
            dataGridView1.DataSource = Database.Query("Select * from NHANVIEN where TENNHANVIEN like '%'+@Name+'%'", parameter);
        }

        private void btn_DEL_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> parameter = new Dictionary<string, object>();
            String sql = "EXEC XoaNhanVien @IDNHANVIEN = @ID";
            String ID = tbx_ID.Text;
            parameter.Add("@ID", ID);
            try
            {
                Database.Execute(sql, parameter);
                loadData();
                MessageBox.Show("Xoá thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }

            ClearTextBoxes();
        }
        private void ClearTextBoxes()
        {
            dateTimePicker1.Value = DateTime.Now;
            tbx_Name.Clear();
            tbx_Address.Clear();
            tbx_Number.Clear();
            tbx_ID.Clear();
            comboBox1.Text = string.Empty;
        }

        private bool Check()
        {
            errorProvider1.Clear();
            tbx_Name.Text = tbx_Name.Text.Trim();
            tbx_Address.Text = tbx_Address.Text.Trim();
            tbx_Number.Text = tbx_Number.Text.Trim();
            if (tbx_Name.TextLength == 0)
            {
                errorProvider1.SetError(tbx_Name, "Tên không được để trống");
                return false;
            }
            if (tbx_Address.TextLength == 0)
            {
                errorProvider1.SetError(tbx_Address, "Địa chỉ không được để trống");
                return false;
            }
            if (tbx_Number.TextLength != 10 || !tbx_Number.Text.All(Char.IsDigit))
            {
                errorProvider1.SetError(tbx_Number, "Số điện thoại không hợp lệ");
                return false;
            }

            return true;
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void nhanvien_Load(object sender, EventArgs e)
        {

        }
    }
}
