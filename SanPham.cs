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
    public partial class SanPham : Form
    {
        public SanPham()
        {
            InitializeComponent();
        }
        string chuoi = @"Data Source=LAPTOP-OD8JDKQL\SQLEXPRESS;Initial Catalog=QLBH_GREENFRUITS1;Integrated Security=True";
        SqlConnection strconn;

        private Boolean Kiemtra()
        {
            strconn = new SqlConnection(chuoi);
            strconn.Open();
            string masp = txtmasp.Text;
            string sql_kt = "Select * from Sanpham where maSP=N'" + masp + "'";
            SqlCommand cmd = new SqlCommand(sql_kt, strconn);
            SqlDataReader Dr;
            Dr = cmd.ExecuteReader();
            Boolean kt = true;
            while (Dr.Read())
            {
                if (masp == Dr[0].ToString())
                {
                    kt = false;
                    MessageBox.Show("Mã nhập vào đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtmasp.Clear();
                    txtmasp.Focus();
                    break;
                }
            }
            strconn.Close();
            return kt;
        }

        private void bt_timkiem_Click(object sender, EventArgs e)
        {
            strconn = new SqlConnection(chuoi);
            strconn.Open();
            string sql_Sanpham = "SELECT masp, tensp, giatien FROM Sanpham WHERE maSP='" + txttimkiem.Text.Trim() + "';";
            SqlDataAdapter MyData = new SqlDataAdapter(sql_Sanpham, strconn);
            DataTable dtbTimKiem = new DataTable();
            MyData.Fill(dtbTimKiem);
            dgvSanPham.DataSource = dtbTimKiem;
            strconn.Close();
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            F_main main = new F_main();
            main.ShowDialog();
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            SqlConnection strconn = new SqlConnection(chuoi);
            //mở kết nối 
            strconn.Open();
            //lấy dữ liệu trên form
            string masp = txtmasp.Text;
            string tensp = txttensp.Text;
            string soluong = txtsoluong.Text;
            string donvi = txtdonvi.Text;
            string giatien = txtgiatien.Text;
            string manguongoc = comboBox2.Text;
            string ghichu = txtghichu.Text;


            //thực thi câu lệnh insert => tạo chuỗi sql
            string sqladd = "Insert into Sanpham values(N'" + masp + "',N'" + tensp + "',N'" + soluong + "',N'" + donvi + "',N'" + giatien + "',N'" + manguongoc + "',N'" + ghichu + "')";
            //Khởi tạo đối tượng command
            if (masp == "")
            {
                MessageBox.Show("Chưa nhập Mã sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmasp.Focus();
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
       
            private void xoa()
        {
            txtmasp.Clear();
            txttensp.Clear();
            txtgiatien.Clear();
            txtsoluong.Clear();
            txtdonvi.Clear();
            txtghichu.Clear();
        }


        private void DGV_hienthi()
        {
            //tạo kết nối
            strconn = new SqlConnection(chuoi);
            strconn.Open();//mở kết nối            
            string sql_Sanpham = "select * from Sanpham";
            SqlDataAdapter Mydata = new SqlDataAdapter(sql_Sanpham, strconn); //Khởi tạo đối tượng SQLDataAdapter
            DataTable DT = new DataTable();//Khởi tạo 1 Table            
            Mydata.Fill(DT);//Đổ dữ liệu vào bảng
            dgvSanPham.DataSource = DT;//Hiển thị dữ liệu lên DGView
            strconn.Close();
        }

        private void dgvSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            mk_tg.Text = dgvSanPham.CurrentRow.Cells[0].Value.ToString();
            txtmasp.Text = dgvSanPham.CurrentRow.Cells[0].Value.ToString();
            txttensp.Text = dgvSanPham.CurrentRow.Cells[1].Value.ToString();
            txtsoluong.Text = dgvSanPham.CurrentRow.Cells[2].Value.ToString();
            txtdonvi.Text = dgvSanPham.CurrentRow.Cells[3].Value.ToString();
            txtgiatien.Text = dgvSanPham.CurrentRow.Cells[4].Value.ToString();
            comboBox2.Text = dgvSanPham.CurrentRow.Cells[5].Value.ToString();
            txtghichu.Text = dgvSanPham.CurrentRow.Cells[6].Value.ToString();
        }
        private void DataGV(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            txttimkiem.Text = dgvSanPham.Rows[numrow].Cells[1].Value.ToString();
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
                int r = dgvSanPham.CurrentCell.RowIndex;
                // Lấy MaNV của record hiện hành
                string strmasp =
                dgvSanPham.Rows[r].Cells[0].Value.ToString();
                // Viết câu lệnh SQL
                cmd.CommandText = System.String.Concat("Delete From sanpham Where masp='" + strmasp + "'");
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

        private void SanPham_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBH_GREENFRUITS1DataSet.nguongocnhap' table. You can move, or remove it, as needed.
            this.nguongocnhapTableAdapter.Fill(this.qLBH_GREENFRUITS1DataSet.nguongocnhap);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.nguongocnhapTableAdapter.FillBy(this.qLBH_GREENFRUITS1DataSet.nguongocnhap);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            SqlConnection strconn = new SqlConnection(chuoi);
            strconn.Open();
            if (txtmasp.Text == "")
            {
                MessageBox.Show("Chưa nhập Mã khách hàng cần update!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmasp.Focus();
            }
            else
            {
                string tg = mk_tg.Text;
                string sql_sua1 = "Update SanPham set masp=N'" + txtmasp.Text + "',tensp=N'" + txttensp.Text + "'," +
                    "soluong=N'" + txtsoluong.Text + "',donvi=N'" + txtdonvi.Text + "',giatien=N'" + txtgiatien.Text + "', manguongoc=N'" + comboBox2.Text + "', ghichu=N'" + txtghichu.Text + "' where masp=N'" + tg + "'";
                string sql_sua2 = "Update SanPham set tensp=N'" + txttensp.Text + "'," +
                    "soluong=N'" + txtsoluong.Text + "',donvi=N'" + txtdonvi.Text + "',giatien=N'" + txtgiatien.Text + "', manguongoc=N'" + comboBox2.Text + "', ghichu=N'" + txtghichu.Text + "' where masp=N'" + tg + "'";
                SqlCommand cmd1 = new SqlCommand(sql_sua1, strconn);
                SqlCommand cmd2 = new SqlCommand(sql_sua2, strconn);
                DialogResult DResult = MessageBox.Show("Có chắc chắn sửa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DResult == DialogResult.Yes)
                {
                    if (txtmasp.Text == tg)
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
    }
    }
