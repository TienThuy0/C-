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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sanphamBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sanphamBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLBH_GREENFRUITS1DataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'qLBH_GREENFRUITS1DataSet.sanpham' table. You can move, or remove it, as needed.
            this.sanphamTableAdapter.Fill(this.qLBH_GREENFRUITS1DataSet.sanpham);

        }

        private void button_taohoadon_Click(object sender, EventArgs e)
        {
            hoadonBindingSource.AddNew();
            ngaymuaTextBox.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            makhTextBox.Text = "K01";
            tenkhTextBox.Text = "Nguyễn Mai Anh";
            hoadonBindingSource.EndEdit();
            hoadonTableAdapter.Update(qLBH_GREENFRUITS1DataSet);

        }

        private void dgCTHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgSP_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            string masp = dgSP["colMasp", r].Value.ToString();
            string tensp = dgSP["colTensp", r].Value.ToString();
            int giatien = int.Parse(dgSP["colGiatien", r].Value.ToString());
            ///MessageBox.Show(masp+" "+tensp+" "+giatien);

            int i = 0;
            for (i = 0; i < dgCTHD.RowCount; i++)
            {
                if (masp == dgCTHD["cMasp", i].Value.ToString())
                    break;  //tìm thấy mã sản phẩm
            }
            if (i == dgCTHD.RowCount)
            { // ko tìm thấy mã sản phẩm
                cTHDBindingSource.AddNew();
                dgCTHD["cMasp", i].Value = masp;
                dgCTHD["cSoluong", i].Value = 1;
                dgCTHD["cTongtien", i].Value = giatien;


            }
            else    //cập nhật số lượng theo mã sản phẩm
            {
                dgCTHD["cSoluong", i].Value = 1 + int.Parse(dgCTHD["cSoluong", i].Value.ToString());

            }
        }

        private void button_thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            F_main main = new F_main();
            main.Close();
        }
    }
}
