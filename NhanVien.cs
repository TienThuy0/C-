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

namespace QLBH
{
    public partial class NhanVien : Form
    {
        public NhanVien()
        {
            InitializeComponent();
        }
        string chuoi = @"Data Source=LAPTOP-OD8JDKQL\SQLEXPRESS;Initial Catalog=QLBH_GREENFRUITS1;Integrated Security=True";
        SqlConnection strconn;

        private void NhanVien_Load(object sender, EventArgs e)
        {

        }

        private Boolean Kiemtra()
        {
            strconn = new SqlConnection(chuoi);
            strconn.Open();
            string manv = txtmanv.Text;
            string sql_ktnv = "Select * from nhanvien where manv=N'" + manv + "'";
            SqlCommand cmd = new SqlCommand(sql_ktnv, strconn);
            SqlDataReader Dr;
            Dr = cmd.ExecuteReader();
            Boolean kt = true;
            while (Dr.Read())
            {
                if (manv == Dr[0].ToString())
                {
                    kt = false;
                    MessageBox.Show("Mã nhập vào đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtmanv.Clear();
                    txtmanv.Focus();
                    break;
                }
            }
            strconn.Close();
            return kt;
        }
        private void Xoa()
        {
            txtmanv.Clear();
            txthotennv.Clear();
            txtdc.Clear();
            txtsdt.Clear();
        }
        public void DGV_hienthi()
        {
            //tạo kết nối
            strconn = new SqlConnection(chuoi);
            //mở kết nối
            strconn.Open();
            //chuỗi sql
            string sql_nhanvien = "select * from nhanvien";
            SqlDataAdapter Mydata = new SqlDataAdapter(sql_nhanvien, strconn);
            DataTable DT1 = new DataTable();
            Mydata.Fill(DT1);
            DGV_nv.DataSource = DT1;
            strconn.Close();
        }

        private void button_themnv_Click(object sender, EventArgs e)
        {

            //Khai báo và khởi tạo đối tượng 
            strconn = new SqlConnection(chuoi);
            strconn.Open();
            //Thực thi câu lệnh
            if (txtmanv.Text == "")
            {
                MessageBox.Show("Chưa nhập mã nhân viên cần thêm !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmanv.Focus();
            }
            else
            {
                string mk_TG = mk_tg.Text;
                string manv = txtmanv.Text;
                string hoten = txthotennv.Text;
                string ngaysinh = dateTime_nv.Value.ToString();
                string diachi = txtdc.Text;
                string sdt = txtsdt.Text;
                string email = txtemail.Text;

                string sqladd = "Insert into nhanvien values (N'" + manv + "',N'" + hoten + "', N'" + ngaysinh + "',N'" + diachi + "',N'" + sdt + "',N'" + email + "')";
                if (manv == "")
                {
                    MessageBox.Show("Chưa nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtmanv.Focus();
                }
                else
                {
                    SqlCommand cmd = new SqlCommand(sqladd, strconn);
                    cmd.ExecuteNonQuery();
                    DGV_hienthi();
                    Xoa();
                }
                strconn.Close();
            }

        }

        private void button_suanv_Click(object sender, EventArgs e)
        {
            strconn = new SqlConnection(chuoi);
            strconn.Open();
            if (txtmanv.Text == "")
            {
                MessageBox.Show("Chưa nhập mã nhân viên cần sửa !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmanv.Focus();
            }
            else
            {
                string mk_TG = mk_tg.Text;
                string manv = txtmanv.Text;
                string hoten = txthotennv.Text;
                string ngaysinh = dateTime_nv.Value.ToString();
                string diachi = txtdc.Text;
                string sdt = txtsdt.Text;
                string email = txtemail.Text;

                string sql_sua1 = "update nhanvien set manv=N'" + manv + "',hoten= N'" + hoten + "'," +
                    "ngaysinh=N'" + ngaysinh + "',diachi= N'" + diachi + "',sdt= N'" + sdt + "',email=N'" + email + "' " +
                    "where manv = N'" + mk_TG + "' ";
                string sql_sua2 = "update nhanvien set hoten= N'" + hoten + "'," +
                    "ngaysinh= N'" + ngaysinh + "',diachi= N'" + diachi + "',sdt= N'" + sdt + "',email=N'" + email + "' " +
                    "where manv = N'" + mk_TG + "' ";
                SqlCommand cmd1 = new SqlCommand(sql_sua1, strconn);
                SqlCommand cmd2 = new SqlCommand(sql_sua2, strconn);

                DialogResult DResult = MessageBox.Show("Có chắc chắn sửa hay không ??", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DResult == DialogResult.Yes)
                {
                    if (manv == mk_TG)
                    {
                        cmd2.ExecuteNonQuery();
                    }
                    else
                    {
                        if (Kiemtra())
                        {
                            cmd1.ExecuteNonQuery();
                        }
                    }
                    DGV_hienthi();
                    Xoa();
                }
            }
            strconn.Close();
        }

        private void button_xoanv_Click(object sender, EventArgs e)
        {
            strconn.Open();
            try
            {
                // Thực hiện lệnh
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = strconn;
                cmd.CommandType = CommandType.Text;
                // Lấy thứ tự record hiện hành
                int r = DGV_nv.CurrentCell.RowIndex;
                // Lấy MaNV của record hiện hành
                string strmanv =
                DGV_nv.Rows[r].Cells[0].Value.ToString();
                // Viết câu lệnh SQL
                cmd.CommandText = System.String.Concat("Delete From nhanvien Where manv='" + strmanv + "'");
                // Thực hiện câu lệnh SQL
                cmd.ExecuteNonQuery();
                // Cập nhật lại DataGridView
                DGV_hienthi();
                // Thông báo
                MessageBox.Show("Đã xóa xong!");
            }
            catch (SqlException)
            {
                MessageBox.Show("Không xóa được. Lỗi rồi!!!");
            }
            // Đóng kết nối
            strconn.Close();
        }

        private void button_thoatnv_Click(object sender, EventArgs e)
        {
            this.Hide();
            F_main main = new F_main();
            main.ShowDialog();
        }

        private void button_timkiem_Click(object sender, EventArgs e)
        {
            strconn = new SqlConnection(chuoi);
            strconn.Open();
            string sql_nhanvien = "SELECT manv, hoten FROM nhanvien WHERE manv='" + txtmanv.Text.Trim() + "';";
            SqlDataAdapter MyData = new SqlDataAdapter(sql_nhanvien, strconn);
            DataTable dtbTimKiem = new DataTable();
            MyData.Fill(dtbTimKiem);
            DGV_nv.DataSource = dtbTimKiem;
            strconn.Close();
        }
        private void DataGridView(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            txt_timkiemnv.Text = DGV_nv.Rows[numrow].Cells[1].Value.ToString();
        }

        private void DGV_nv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            mk_tg.Text = DGV_nv.CurrentRow.Cells[0].Value.ToString();
            txtmanv.Text = DGV_nv.CurrentRow.Cells[0].Value.ToString();
            txthotennv.Text = DGV_nv.CurrentRow.Cells[1].Value.ToString();
            dateTime_nv.Text = DGV_nv.CurrentRow.Cells[2].Value.ToString();
            txtdc.Text = DGV_nv.CurrentRow.Cells[3].Value.ToString();
            txtemail.Text = DGV_nv.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
