﻿using System;
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
    public partial class Thongkedoanhthu : Form
    {
        public Thongkedoanhthu()
        {
            InitializeComponent();
        }

        private void dataGridViewDoanhThu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_thongke_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button_thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            F_main main = new F_main();
            main.ShowDialog();
        }
    }
}
