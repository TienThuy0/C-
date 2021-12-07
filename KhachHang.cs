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
    public partial class KhachHang : Form
    {
        public KhachHang()
        {
            InitializeComponent();
        }
        string chuoi = @"Data Source=LAPTOP-OD8JDKQL\SQLEXPRESS;Initial Catalog=QLBH_GREENFRUITS1;Integrated Security=True";
        SqlConnection strconn;
        private void bt_them_Click(object sender, EventArgs e)
        {
            //khai báo và khởi tạo đối tượng
            strconn = new SqlConnection(chuoi);
            strconn.Open();
            //lấy dữ liệu trên form
            string makh = txtmakh.Text;
            string tenkh = txttenkh.Text;
            string diachi = txtdc.Text;
            string sdt = txtsdt.Text;
            //thực thi câu lệnh
            string sqladd = "Insert into khachhang values (N'" + makh + "',N'" + tenkh + "',N'" + diachi + "',N'" + sdt + "')";
            if (makh == "")
            {
                MessageBox.Show("Chưa nhập mã khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmakh.Focus();
            }
            else
            {
                SqlCommand cmd = new SqlCommand(sqladd, strconn);
                cmd.ExecuteNonQuery();
                DGV_hienthi();
                xoa();
            }
            strconn.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void KhachHang_Load(object sender, EventArgs e)
        {
            DGV_hienthi();
        }
        private Boolean Kiemtra()
        {
            strconn = new SqlConnection(chuoi);
            strconn.Open();
            string makh = txtmakh.Text;
            string sql_kt = "Select * from Khachhang where makh=N'" + makh + "'";
            SqlCommand cmd = new SqlCommand(sql_kt, strconn);
            SqlDataReader Dr;
            Dr = cmd.ExecuteReader();
            Boolean kt = true;
            while (Dr.Read())
            {
                if (makh == Dr[0].ToString())
                {
                    kt = false;
                    MessageBox.Show("Mã nhập vào đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtmakh.Clear();
                    txtmakh.Focus();
                    break;
                }
            }
            strconn.Close();
            return kt;

        }
        private void DGV_hienthi()
        {
            //tạo kết nối
            strconn = new SqlConnection(chuoi);
            strconn.Open();
            string sql_Khachhang = "select * from Khachhang";
            SqlDataAdapter Mydata = new SqlDataAdapter(sql_Khachhang, strconn); //Khởi tạo đối tượng SQLDataAdapter
            DataTable DT = new DataTable();//Khởi tạo 1 Table            
            Mydata.Fill(DT);//Đổ dữ liệu vào bảng
            DGV_KH.DataSource = DT;
            strconn.Close();
        }
        private void xoa()
        {
            txtmakh.Clear();
            txttenkh.Clear();
            txtdc.Clear();
            txtsdt.Clear();

        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            SqlConnection strconn = new SqlConnection(chuoi);
            strconn.Open();
            if (txtmakh.Text == "")
            {
                MessageBox.Show("Chưa nhập Mã khách hàng cần update!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmakh.Focus();
            }
            else
            {
                string tg = mk_tg.Text;
                string sql_sua1 = "Update Khachhang set makh=N'" + txtmakh.Text + "',tenkh=N'" + txttenkh.Text + "'," +
                    "diachi=N'" + txtdc.Text + "',sdt=N'" + txtsdt.Text + "' where makh=N'" + tg + "'";
                string sql_sua2 = "Update Khachhang set tenkh=N'" + txttenkh.Text + "'," +
                    "diachi=N'" + txtdc.Text + "',sdt=N'" + txtsdt.Text + "' where makh=N'" + tg + "'";
                SqlCommand cmd1 = new SqlCommand(sql_sua1, strconn);
                SqlCommand cmd2 = new SqlCommand(sql_sua2, strconn);
                DialogResult DResult = MessageBox.Show("Có chắc chắn sửa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DResult == DialogResult.Yes)
                {
                    if (txtmakh.Text == tg)
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
                    xoa();
                }
            }
            strconn.Close();
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {

            strconn.Open();
            try
            {
                // Thực hiện lệnh
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = strconn;
                cmd.CommandType = CommandType.Text;
                // Lấy thứ tự record hiện hành
                int r = DGV_KH.CurrentCell.RowIndex;
                // Lấy MaNV của record hiện hành
                string strmakh = DGV_KH.Rows[r].Cells[0].Value.ToString();
                // Viết câu lệnh SQL
                cmd.CommandText = System.String.Concat("Delete From KhachHang Where makh='" + strmakh + "'");
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

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            F_main main = new F_main();
            main.ShowDialog();
        }

        private void DGV_KH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            mk_tg.Text = DGV_KH.CurrentRow.Cells[0].Value.ToString();
            txtmakh.Text = DGV_KH.CurrentRow.Cells[0].Value.ToString();
            txttenkh.Text = DGV_KH.CurrentRow.Cells[1].Value.ToString();
            txtdc.Text = DGV_KH.CurrentRow.Cells[2].Value.ToString();
            txtsdt.Text = DGV_KH.CurrentRow.Cells[3].Value.ToString();
        }

        private void bt_timkiem_Click(object sender, EventArgs e)
        {
            strconn = new SqlConnection(chuoi);
            strconn.Open();
            string sql_Khachhang = "SELECT makh, tenkh FROM Khachhang WHERE makh='" + txttimkiem.Text.Trim() + "';";
            SqlDataAdapter MyData = new SqlDataAdapter(sql_Khachhang, strconn);
            DataTable dtbTimKiem = new DataTable();
            MyData.Fill(dtbTimKiem);
            DGV_KH.DataSource = dtbTimKiem;
            strconn.Close();
        }
        private void DataGV(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            txttimkiem.Text = DGV_KH.Rows[numrow].Cells[1].Value.ToString();
        }
    }
}
