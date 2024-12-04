using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BTL
{
    public partial class Form1 : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = "Data Source=LAPTOP-L56TLFGS;Initial Catalog=QLCHQA;User ID=sa;Password=123123123";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table=new DataTable();
        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "SELECT*FROM NHACUNGCAP";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }
        public Form1()
        {
            InitializeComponent();
            connection=new SqlConnection(str);
            connection.Open();
            loaddata();
        }
        private bool ckform()
        {
            bool isFine = true;
            errorProvider1.Clear();
            if (tbtennhacungcap.Text.Trim() == "")
            {
                errorProvider1.SetError(tbtennhacungcap, "Chưa nhập tên nhà cung cấp");
                isFine = false;
            }
            if (tbdiachi.Text.Trim() == "")
            {
                errorProvider1.SetError(tbdiachi, "Chưa nhập địa chỉ nhà cung cấp");
                isFine= false;
            }
            if(tbsdt.TextLength != 10 || !tbsdt.Text.All(Char.IsDigit))
            {
                errorProvider1.SetError(tbsdt, "Chưa nhập số điện thoại");
                isFine = false;
            }
            return isFine;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!ckform()) return;
            try
            {
                // chuẩn hóa tên 
                tbtennhacungcap.Text = ChuanHoaTen(tbtennhacungcap.Text);
                tbdiachi.Text = ChuanHoaTen(tbdiachi.Text);
                // ktr nếu tên tồn tại
                command = connection.CreateCommand();
                command.CommandText = "SELECT*FROM NHACUNGCAP WHERE TENNHACUNGCAP=N'" + tbtennhacungcap.Text + "' AND DIACHI=N'" + tbdiachi.Text + "' AND DIENTHOAI='" + tbsdt.Text + "'";
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    errorProvider1.SetError(tbtennhacungcap, "Đã có nhà cung cấp này");
                    reader.Close();
                    return;
                }
                reader.Close();


                command = connection.CreateCommand();
                command.CommandText = "INSERT INTO NHACUNGCAP VALUES(N'" + tbtennhacungcap.Text + "',N'" + tbdiachi.Text + "','" + tbsdt.Text + "')";
                command.ExecuteNonQuery();
                loaddata();
                MessageBox.Show("Thêm thành công!");
                cleartb();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Có lỗi khi thêm dữ liệu." + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi không xác định." + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            tbidnhacungcap.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            tbtennhacungcap.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            tbdiachi.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            tbsdt.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
        }
        private void cleartb()
        {
            tbidnhacungcap.Clear();
            tbtennhacungcap.Clear();
            tbdiachi.Clear();
            tbsdt.Clear();
        }
        private string ChuanHoaTen(string ten)
        { // Tách các từ trong chuỗi tên
           string[] tu = ten.Trim().Split(' '); 
            // Chuẩn hóa từng từ
           for (int i = 0; i < tu.Length; i++) 
            { 
                if (!string.IsNullOrEmpty(tu[i])) 
                { 
                    tu[i] = char.ToUpper(tu[i][0]) + tu[i].Substring(1).ToLower(); 
                } 
            } // Kết hợp lại thành chuỗi hoàn chỉnh
            return string.Join(" ", tu);
        }
            private void btsua_Click(object sender, EventArgs e)
        {
            if (!ckform())return;
            try
            {
                //chuẩn hóa tên
                tbtennhacungcap.Text = ChuanHoaTen(tbtennhacungcap.Text);
                // ktr nếu tên tồn tại
                command = connection.CreateCommand();
                command.CommandText = "SELECT*FROM NHACUNGCAP WHERE TENNHACUNGCAP=N'" + tbtennhacungcap.Text + "' ";
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    errorProvider1.SetError(tbtennhacungcap, "Đã có nhà cung cấp này");
                    reader.Close();
                    return;
                }
                reader.Close();
              
                // Kiểm tra nếu số điện thoại trùng (ngoại trừ chính nó)
                command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM NHACUNGCAP WHERE DIENTHOAI = '" + tbsdt.Text + "' AND IDNHACUNGCAP <> '" + tbidnhacungcap.Text + "'"; 
                SqlDataReader reader1 = command.ExecuteReader();
                if (reader1.HasRows) 
                { 
                    errorProvider1.SetError(tbsdt, "Đã có số điện thoại này");
                    reader1.Close();
                    return;
                }
                reader.Close();
                command = connection.CreateCommand();
                command.CommandText = "UPDATE NHACUNGCAP SET TENNHACUNGCAP='" + tbtennhacungcap.Text + "',DIACHI='" + tbdiachi.Text + "',DIENTHOAI='" + tbsdt.Text + "' WHERE IDNHACUNGCAP='" + tbidnhacungcap.Text + "'";
                command.ExecuteNonQuery();
                loaddata();
                MessageBox.Show("Cập nhật thành công!");
                cleartb();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Có lỗi khi sửa dữ liệu." + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi không xác định." + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            if (!ckform()) return;
            try
            {
                command = connection.CreateCommand();
                command.CommandText = "DELETE FROM CHITIETDATHANG WHERE IDMATHANG IN (SELECT IDMATHANG FROM MATHANG WHERE IDNHACUNGCAP = '"+tbidnhacungcap.Text+"')";
                command.ExecuteNonQuery();
                command.CommandText = "DELETE FROM MATHANG WHERE IDNHACUNGCAP = '"+tbidnhacungcap.Text+"'";
                command.ExecuteNonQuery();
                command.CommandText = "DELETE FROM NHACUNGCAP WHERE IDNHACUNGCAP='" + tbidnhacungcap.Text + "'";
                command.ExecuteNonQuery();
                loaddata();
                MessageBox.Show("Xóa thành công!");
                cleartb();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Có lỗi khi xóa dữ liệu." + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi không xác định." + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM NHACUNGCAP WHERE TENNHACUNGCAP LIKE '%" + tbtimkiem.Text + "%'";
                DataTable tk = new DataTable();
                adapter.SelectCommand = command;
                tk.Clear();
                adapter.Fill(tk);
                dataGridView1.DataSource = tk;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Có lỗi khi tìm kiếm dữ liệu." + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi không xác định." + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
