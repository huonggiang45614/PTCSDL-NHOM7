using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLCHQUANAO
{
    public partial class FrmQuanLyKhachHang : Form
    {
       
        public FrmQuanLyKhachHang()
        {
            InitializeComponent();
            loaddtgMathang();
        }


        private void loaddtgMathang()
        {
            dtgMathang.DataSource= Database.Query("SELECT * FROM MATHANG");
        }

        private void btthem_Click(object sender, EventArgs e)
        {

            if (!Check())
            {
                return;
            }
            Dictionary<string, object> parameter = new Dictionary<string, object>();
            String sql =
            "INSERT INTO MATHANG( TENMATHANG, GIA, IDNHACUNGCAP, SOLUONGTON, IDLOAIHANG) VALUES ( @Name, @Price, @IDNCC, @Quantity, @Type)";
            String ID = txtma.Text;
            String Name = txtten.Text;
            String Quantity = txtsl.Text;
            String Price = txtgia.Text;
            String IDNCC = cbbncc.Text;
            String Type = cbbloai.Text;
            parameter.Add("@ID", ID);
            parameter.Add("@Name", Name);
            parameter.Add("@Quantity", Quantity);
            parameter.Add("@Price", Price);
            parameter.Add("@IDNCC", IDNCC);
            parameter.Add("@Type", Type);
            try
            {
                Database.Execute(sql, parameter);
                loaddtgMathang();
                MessageBox.Show("Thêm thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ClearTextBoxes();
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            if (!Check())
            {
                return;
            }
            Dictionary<string, object> parameter = new Dictionary<string, object>();
            String sql =
                "UPDATE MATHANG SET TENMATHANG = @Name, SOLUONGTON = @Quantity, GIA = @PRICE, IDNHACUNGCAP = @IDNCC, IDLOAIHANG =@Type WHERE IDMATHANG = @ID";
            String ID = txtma.Text;
            String Name = txtten.Text;
            String Quantity = txtsl.Text;
            String Price = txtgia.Text;
            String IDNCC = cbbncc.Text;
            String Type = cbbloai.Text;
            parameter.Add("@ID", ID);
            parameter.Add("@Name", Name);
            parameter.Add("@Quantity", Quantity);
            parameter.Add("@Price", Price);
            parameter.Add("@IDNCC", IDNCC);
            parameter.Add("@Type", Type);
            try
            {
                Database.Execute(sql, parameter);
                loaddtgMathang();
                MessageBox.Show("Cập nhật thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            ClearTextBoxes();
        }
        private void ClearTextBoxes()
        {
            txtten.Clear();
            txtma.Clear();
            txtsl.Clear();
            txtgia.Clear();
            cbbloai.SelectedItem = -1;
            cbbncc.SelectedIndex = -1;
        }
        private void btxoa_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> parameter = new Dictionary<string, object>();
            String sql = "DELETE FROM MATHANG WHERE IDMATHANG = @ID";
            String ID = txtma.Text;
            parameter.Add("@ID", ID);
            try
            {
                Database.Execute(sql, parameter);
                loaddtgMathang();
                MessageBox.Show("Xoá thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }

            ClearTextBoxes();
        }

        private void dtgMathang_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtma.Text = dtgMathang.Rows[e.RowIndex].Cells["colIDMATHANG"].Value.ToString();
            txtten.Text = dtgMathang.Rows[e.RowIndex].Cells["TENMATHANG"].Value.ToString();
            txtsl.Text = dtgMathang.Rows[e.RowIndex].Cells["SOLUONGTON"].Value.ToString();
            txtgia.Text = dtgMathang.Rows[e.RowIndex].Cells["GIA"].Value.ToString();
            cbbloai.Text = dtgMathang.Rows[e.RowIndex].Cells["IDLOAIHANG"].Value.ToString();
            cbbncc.Text = dtgMathang.Rows[e.RowIndex].Cells["IDNHACUNGCAP"].Value.ToString();
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> parameter = new Dictionary<string, object>();
            String Name = txttimkiem.Text;
            parameter.Add("@Name", Name);
            dtgMathang.DataSource = Database.Query("Select * from MATHANG where TENMATHANG like '%'+@Name+'%'", parameter);
        }
        private bool Check()
        {
            errorProvider1.Clear();
            txtten.Text = txtten.Text.Trim();
            txtsl.Text = txtsl.Text.Trim();
            txtgia.Text = txtgia.Text.Trim();
            if (txtten.TextLength == 0)
            {
                errorProvider1.SetError(txtten, "Tên không được để trống");
                return false;
            }
            if (txtsl.TextLength == 0)
            {
                errorProvider1.SetError(txtsl, "Số lượng không được để trống");
                return false;
            }
            if (txtgia.TextLength == 0)
            {
                errorProvider1.SetError(txtgia, "Giá không được để trống");
                return false;
            }

            return true;
        }
    }
}
