using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH
{
    public partial class F_main : Form
    {
        public F_main()
        {
            InitializeComponent();
        }

        private void button_nhaphang_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThongTin TT = new ThongTin();
            TT.ShowDialog();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            NhanVien NV = new NhanVien();
            NV.ShowDialog();
        }

        private void button_sanpham_Click(object sender, EventArgs e)
        {
            this.Hide();
            SanPham SP = new SanPham();
            SP.ShowDialog();
        }

        private void button_hoadon_Click(object sender, EventArgs e)
        {
            this.Hide();
            HoaDon HD = new HoaDon();
            HD.ShowDialog();
        }

        private void button_nguonhang_Click(object sender, EventArgs e)
        {
            this.Hide();
            NguonGoc NG = new NguonGoc();
            NG.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangNhap dn = new DangNhap();
            dn.ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Hide();
            KhachHang KH = new KhachHang();
            KH.ShowDialog();
        }

        private void doanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Thongkedoanhthu DT = new Thongkedoanhthu();
            DT.ShowDialog();
        }
    }
}
