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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void button_dangnhap_Click(object sender, EventArgs e)
        {
            if (this.txt_dangnhap.Text == "" || this.txt_mk.Text == "")
            {
                MessageBox.Show(" Vui lòng nhập tài khoản ! ");
            }
            else
            {
                if (this.txt_dangnhap.Text == "nguyenthuytien")
                    if (this.txt_mk.Text == "123456")
                    {
                        this.Hide();
                        F_main DN = new F_main();
                        DN.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu sai ! \n Vui lòng nhập lại !", "Thông báo");
                    }
                else
                {
                    MessageBox.Show("Tên tài khoản hoặc mật khẩu sai ! \n Vui lòng nhập lại !", "Thông báo");
                }
            }
            this.txt_dangnhap.Focus();
        }

        private void button_thoat_Click(object sender, EventArgs e)
        {
            DialogResult exit;
            exit = (MessageBox.Show("Bạn có muốn thoát ?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning));
            if (exit == DialogResult.Yes)
                Application.Exit();
        }
    }
}
