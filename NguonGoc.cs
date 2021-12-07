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
    public partial class NguonGoc : Form
    {
        public NguonGoc()
        {
            InitializeComponent();
        }
        string chuoi = @"Data Source=LAPTOP-OD8JDKQL\SQLEXPRESS;Initial Catalog=QLBH_GREENFRUITS1;Integrated Security=True";
        SqlConnection strconn;
        private void NguonGoc_Load(object sender, EventArgs e)
        {
            DGV_hienthi();
        }

        private void button_thoatnguongocSP_Click(object sender, EventArgs e)
        {
            this.Hide();
            F_main main = new F_main();
            main.ShowDialog();
        }

        private void button_themnguonhang_Click(object sender, EventArgs e)
        {
            //khai báo và khởi tạo 
            strconn = new SqlConnection(chuoi);
            strconn.Open();
            //lấy dữ liệu trên form
            string manguongoc = txtmanguongoc.Text;
            string tennguongoc = txttennguongoc.Text;
            //thực thi câu lệnh
            string sqladd = "Insert into nguongocnhap values (N'" + manguongoc + "',N'" + tennguongoc + "')";
            if (manguongoc == "")
            {
                MessageBox.Show("Chưa nhập mã nguồn gốc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmanguongoc.Focus();
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
        private Boolean Kiemtra()
        {
            strconn = new SqlConnection(chuoi);
            strconn.Open();
            string manguongoc = txtmanguongoc.Text;
            string sql_ktng = "Select * from nguongocnhap where manguongoc=N'" + manguongoc + "'";
            SqlCommand cmd = new SqlCommand(sql_ktng, strconn);
            SqlDataReader Dr;
            Dr = cmd.ExecuteReader();
            Boolean kt = true;
            while (Dr.Read())
            {
                if (manguongoc == Dr[0].ToString())
                {
                    kt = false;
                    MessageBox.Show("Mã nhập vào đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtmanguongoc.Clear();
                    txtmanguongoc.Focus();
                    break;
                }
            }
            strconn.Close();
            return kt;
        }
        private void Xoa()
        {
            txtmanguongoc.Clear();
            txttennguongoc.Clear();

        }
        public void DGV_hienthi()
        {
            //tạo kết nối
            strconn = new SqlConnection(chuoi);
            //mở kết nối
            strconn.Open();
            //chuỗi sql
            string sql_nguongocnhap = "select * from nguongocnhap";
            SqlDataAdapter Mydata1 = new SqlDataAdapter(sql_nguongocnhap, strconn);
            DataTable DT3 = new DataTable();
            Mydata1.Fill(DT3);
            DGV_nguongoc.DataSource = DT3;
            strconn.Close();
        }

        private void button_suanguongocSP_Click(object sender, EventArgs e)
        {
            strconn = new SqlConnection(chuoi);
            strconn.Open();
            if (txtmanguongoc.Text == "")
            {
                MessageBox.Show("Chưa nhập mã khách hàng cần sửa !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmanguongoc.Focus();
            }
            else
            {
                string mk_TG = mk_tg.Text;
                string manguongoc = txtmanguongoc.Text;
                string tennguongoc = txttennguongoc.Text;

                string sql_sua1 = "update nguongocnhap set manguongoc= N'" + manguongoc + "', tennguongoc= N'" + tennguongoc + "'" +
                    "where manguongoc = N'" + mk_TG + "' ";
                string sql_sua2 = "update nguongocnhap set tennguongoc= N'" + tennguongoc + "'" +
                    "where manguongoc = N'" + mk_TG + "' ";
                SqlCommand cmd1 = new SqlCommand(sql_sua1, strconn);
                SqlCommand cmd2 = new SqlCommand(sql_sua2, strconn);

                DialogResult DResult = MessageBox.Show("Có chắc chắn sửa hay không ??", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DResult == DialogResult.Yes)
                {
                    if (manguongoc == mk_TG)
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

        private void button_xoanguongocSP_Click(object sender, EventArgs e)
        {

            strconn.Open();
            try
            {
                // Thực hiện lệnh
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = strconn;
                cmd.CommandType = CommandType.Text;
                // Lấy thứ tự record hiện hành
                int i = DGV_nguongoc.CurrentCell.RowIndex;
                // Lấy MaKH của record hiện hành
                string Strmanguongoc =
                DGV_nguongoc.Rows[i].Cells[0].Value.ToString();
                // Viết câu lệnh SQL
                cmd.CommandText = System.String.Concat("Delete From nguongocnhap Where manguongoc='" + Strmanguongoc + "'");
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
        private void DataGridView(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            txt_timkiemSP.Text = DGV_nguongoc.Rows[numrow].Cells[1].Value.ToString();
        }

        private void button_timkiemSP_Click(object sender, EventArgs e)
        {
            strconn = new SqlConnection(chuoi);
            strconn.Open();
            string sql_nguongoc = "SELECT manguongoc, tennguongoc FROM nguongocnhap WHERE manguongoc='" + txtmanguongoc.Text.Trim() + "';";
            SqlDataAdapter MyData = new SqlDataAdapter(sql_nguongoc, strconn);
            DataTable dtbTimKiem = new DataTable();
            MyData.Fill(dtbTimKiem);
            DGV_nguongoc.DataSource = dtbTimKiem;
            strconn.Close();
        }

        private void DGV_nguongoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmanguongoc.Text = DGV_nguongoc.CurrentRow.Cells[0].Value.ToString();
            txttennguongoc.Text = DGV_nguongoc.CurrentRow.Cells[0].Value.ToString();
        }

        private void groupBox_nguongoc_Enter(object sender, EventArgs e)
        {

        }
    }
}

