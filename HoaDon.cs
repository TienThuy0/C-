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
    public partial class HoaDon : Form
    {
        public HoaDon()
        {
            InitializeComponent();
        }
        Connect cn = new Connect();
        private void button_chon_Click(object sender, EventArgs e)
        {
            while (listBox1.SelectedItems.Count > 0)//Nếu có lựa chọn 1 item
            {
                listBox2.Items.Add(listBox1.SelectedItem);//Thêm item đó bên Listbox2 
                listBox1.Items.Remove(listBox1.SelectedItem);//xóa item vừa thêm bên listbox2 ở listbox1
            }
        }

        private void HoaDon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBH_GREENFRUITS1DataSet.khachhang' table. You can move, or remove it, as needed.
            this.khachhangTableAdapter.Fill(this.qLBH_GREENFRUITS1DataSet.khachhang);
            // Thêm tên của các sản phẩm đang bán vào listbox1
            string sql = "select * from SanPham";
            for (int i = 0; i < cn.XemDL(sql).Rows.Count; i++)
            {
                listBox1.Items.Add(cn.XemDL(sql).Rows[i][1].ToString());
            }
        }

        private void button_bochon_Click(object sender, EventArgs e)
        {
            //Ngược lại
            while (listBox2.SelectedItems.Count > 0)
            {
                listBox1.Items.Add(listBox2.SelectedItem);
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
        }

        private void button_timkiem_Click(object sender, EventArgs e)
        {
            //Quản lý cách tìm kiếm
            listBox1.Items.Clear();
            string cachtim = Cb_cachtim.SelectedItem.ToString();
            switch (cachtim)
            {
                case "Mã Sản Phẩm":
                    string sql1 = "select * from SanPham where masp like '%" + txtTuTim.Text.Trim() + "%'";
                    for (int i = 0; i < cn.XemDL(sql1).Rows.Count; i++)
                    {
                        listBox1.Items.Add(cn.XemDL(sql1).Rows[i][1].ToString().Trim());
                    }
                    break;

                case "Tên Sản Phẩm":
                    string sql = "select * from SanPham where tensp like N'%" + txtTuTim.Text.Trim() + "%'";
                    for (int i = 0; i < cn.XemDL(sql).Rows.Count; i++)
                    {
                        listBox1.Items.Add(cn.XemDL(sql).Rows[i][1].ToString().Trim());
                    }
                    break;

                default:
                    MessageBox.Show("Bạn chưa chọn cách tìm kiếm." + cachtim);
                    break;
            }
        }

        private void button_report_Click(object sender, EventArgs e)
        {
            //Thực hiện lại từ đầu
            //Xóa trắng dữ liệu trên 2 listbox
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            string sql = "select * from sanpham";

            for (int i = 0; i < cn.XemDL(sql).Rows.Count; i++)
            {
                listBox1.Items.Add(cn.XemDL(sql).Rows[i][1].ToString());
            }
        }

        private void button_taohd_Click(object sender, EventArgs e)
        {
            //Tạo hóa đơn với Tên vừa chọn
             cn.ThucThiDL("insert into HoaDon values ('" + txtMaHD.Text.Trim() + "','" + comboBox1.Text.Trim() + "',N'" + txtTenKH.Text.Trim() + "','" + dateTimePicker1.Value + "','" + 0 + "')");

            //Thực thi tạo từng chi tiết hóa đơn với các sản phẩm vừa chọn.
            for (int i = 0; i < listBox2.Items.Count; i++)//quét các item trong listbox2
            {
            //Lấy mã sản phẩm tương ứng với từng tên sản phẩm(lưu ý tên sản phẩm không được trùng)
              string masp = cn.XemDL("select MaSP from SanPham where tensp=N'" + listBox2.Items[i].ToString().Trim() + "'").Rows[0][0].ToString().Trim();
            //Tính tiền mỗi sản phẩm tương ứng với giá thành của nó
             string tongtien = cn.XemDL("select giatien from SanPham where masp='" + masp + "'").Rows[0][0].ToString().Trim();
            //thực hiện lệnh thêm cthd cho sản phẩm vừa chọn bao gồm: macthd, mahd, masp, soluong, tongtien
            cn.ThucThiDL("insert into CTHD values ('" + i.ToString() + "','" + txtMaHD.Text.ToString().Trim() + "','" + masp + "','" + 1 + "','" + Convert.ToInt32(tongtien) + "')");
            
            }
            //Lấy mahd để truyền sang from2
            CTHD.MaHD = txtMaHD.Text.Trim();
            this.Hide();
            CTHD frm = new CTHD();
            frm.ShowDialog();
        }


        private void bt_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.khachhangTableAdapter.FillBy(this.qLBH_GREENFRUITS1DataSet.khachhang);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
