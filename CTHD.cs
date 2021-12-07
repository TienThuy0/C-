using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using app = Microsoft.Office.Interop.Excel.Application;
namespace QLBH
{
    public partial class CTHD : Form
    {
        public CTHD()
        {
            InitializeComponent();
        }

        public static string MaHD;
        Connect cn = new Connect();
        public string macthd;
        private string tongtien;
        public string soluong;
        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            //lấy mã sp tương ứng với macthd, mahd, ténp
            string masp = cn.XemDL("select masp from SanPham where tensp=N'" + txtTenSP.Text.Trim() + "'").Rows[0][0].ToString().Trim();
            //Tính tiền của sản phẩm khi đã thay đổi số lượng
            float tongtien = Convert.ToInt32(cn.XemDL("select giatien from SanPham where masp='" + masp + "'").Rows[0][0].ToString().Trim()) * Convert.ToInt32(txtSoLuong.Text.Trim());
            //thực thi câu lệnh update số lượng và tiền của sản phẩm
            cn.ThucThiDL("update CTHD set soluong ='" + Convert.ToInt32(txtSoLuong.Text.ToString()) + "', tongtien='" + tongtien + "' where macthd='" + txtCTHD.Text.ToString() + "' and  MaHD ='" + MaHD + "' and  masp ='" + masp + "'");
            //Load lại dữ liệu
            dgvSanPham.DataSource = cn.XemDL("select macthd, tensp, soluong, tongtien from HoaDon, CTHD, SanPham where HoaDon.MaHD=CTHD.MaHD and CTHD.masp=SanPham.masp and HoaDon.mahd='" + MaHD + "'");
            //Tính lại tổng tiền
            txtTongTien.Text = cn.XemDL("select sum(tongtien) as tongtien from CTHD where mahd='" + MaHD + "'").Rows[0][0].ToString();
            txtTongTien.Text = dgvSanPham.CurrentRow.Cells[3].Value.ToString();
            double value = Convert.ToDouble(txtTongTien.Text);
            txtTongTien.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0.00}", value);
        }

        private void CTHD_Load(object sender, EventArgs e)
        {
            //Thêm tên của các sản phẩm đang bán vào Listbox1
            // Load danh sách sản phẩm lên datagridview
            dgvSanPham.DataSource = cn.XemDL("select macthd, tensp, tongtien from HoaDon, CTHD, SanPham where HoaDon.MaHD=CTHD.MaHD and CTHD.masp=SanPham.MaSP and HoaDon.mahd='" + MaHD + "'");
            //Tính tổng tiền của hóa đơn
            txtTongTien.Text = cn.XemDL("select sum(tongtien) as tongtien from CTHD where mahd='" + MaHD + "'").Rows[0][0].ToString();

            //Blinding dữ liệu ta textbox
            txtCTHD.DataBindings.Clear();
            txtTenSP.DataBindings.Clear();
            txtSoLuong.DataBindings.Clear();
            txtCTHD.DataBindings.Add("Text", dgvSanPham.DataSource, "macthd");
            txtTenSP.DataBindings.Add("Text", dgvSanPham.DataSource, "tensp");
            //txtSoLuong.DataBindings.Add("Text", dgvSanPham.DataSource, "soluong");
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            //Lưu lại hóa đơn với tổng tiền vừa mới tính
            cn.ThucThiDL("update Hoadon set tongtien='" + Convert.ToInt32(txtTongTien.Text.Trim()) + "'");
            MessageBox.Show("Lưu thành công");
        }
        //đề phòng bất trắc blinding dữ liệu nếu muốn thay đổi cthd
        private void dgvSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCTHD.DataBindings.Clear();
            txtTenSP.DataBindings.Clear();
            txtSoLuong.DataBindings.Clear();
            txtCTHD.DataBindings.Add("Text", dgvSanPham.DataSource, "macthd");
            txtTenSP.DataBindings.Add("Text", dgvSanPham.DataSource, "tensp");
            txtSoLuong.DataBindings.Add("Text", dgvSanPham.DataSource, "soluong");
        }
        private void export2Excel(DataGridView g, string duongDan, string tenTap)
        {
            app obj = new app();
            obj.Application.Workbooks.Add(Type.Missing);
            obj.Columns.ColumnWidth = 25;
            for (int i = 1; i < g.Columns.Count + 1; i++)
            {
                obj.Cells[1, i] = g.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < g.Rows.Count; i++)
            {
                for (int j = 0; j < g.Columns.Count; j++)
                {
                    if (g.Rows[i].Cells[j].Value != null)
                    {
                        obj.Cells[i + 2, j + 1] = g.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }
            obj.ActiveWorkbook.SaveCopyAs(duongDan + tenTap + ".xlsx");
            obj.ActiveWorkbook.Saved = true;
        }

        private void xuấtFileExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            export2Excel(dgvSanPham, @"C:\Users\TienThuy\source\repos\QLBH", "xuatfileExcel");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
