
namespace QLBH
{
    partial class NhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhanVien));
            this.mk_tg = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTime_nv = new System.Windows.Forms.DateTimePicker();
            this.button_timkiem = new System.Windows.Forms.Button();
            this.txt_timkiemnv = new System.Windows.Forms.TextBox();
            this.button_thoatnv = new System.Windows.Forms.Button();
            this.button_xoanv = new System.Windows.Forms.Button();
            this.groupBox_nhaptt = new System.Windows.Forms.GroupBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.button_suanv = new System.Windows.Forms.Button();
            this.button_themnv = new System.Windows.Forms.Button();
            this.txtdc = new System.Windows.Forms.TextBox();
            this.txthotennv = new System.Windows.Forms.TextBox();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.txtmanv = new System.Windows.Forms.TextBox();
            this.label_emailnv = new System.Windows.Forms.Label();
            this.label_sdtnv = new System.Windows.Forms.Label();
            this.label_diachinv = new System.Windows.Forms.Label();
            this.label_ngaysinhnv = new System.Windows.Forms.Label();
            this.label_hotennv = new System.Windows.Forms.Label();
            this.label2_manv = new System.Windows.Forms.Label();
            this.groupBox_hienthiTT = new System.Windows.Forms.GroupBox();
            this.DGV_nv = new System.Windows.Forms.DataGridView();
            this.manv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox_nhaptt.SuspendLayout();
            this.groupBox_hienthiTT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_nv)).BeginInit();
            this.SuspendLayout();
            // 
            // mk_tg
            // 
            this.mk_tg.Location = new System.Drawing.Point(1184, 17);
            this.mk_tg.Margin = new System.Windows.Forms.Padding(4);
            this.mk_tg.Name = "mk_tg";
            this.mk_tg.Size = new System.Drawing.Size(26, 28);
            this.mk_tg.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(405, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(475, 49);
            this.label1.TabIndex = 19;
            this.label1.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // dateTime_nv
            // 
            this.dateTime_nv.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTime_nv.Location = new System.Drawing.Point(218, 158);
            this.dateTime_nv.Name = "dateTime_nv";
            this.dateTime_nv.Size = new System.Drawing.Size(322, 28);
            this.dateTime_nv.TabIndex = 17;
            // 
            // button_timkiem
            // 
            this.button_timkiem.Image = ((System.Drawing.Image)(resources.GetObject("button_timkiem.Image")));
            this.button_timkiem.Location = new System.Drawing.Point(357, 213);
            this.button_timkiem.Margin = new System.Windows.Forms.Padding(4);
            this.button_timkiem.Name = "button_timkiem";
            this.button_timkiem.Size = new System.Drawing.Size(69, 49);
            this.button_timkiem.TabIndex = 16;
            this.button_timkiem.UseVisualStyleBackColor = true;
            this.button_timkiem.Click += new System.EventHandler(this.button_timkiem_Click);
            // 
            // txt_timkiemnv
            // 
            this.txt_timkiemnv.Location = new System.Drawing.Point(34, 227);
            this.txt_timkiemnv.Margin = new System.Windows.Forms.Padding(4);
            this.txt_timkiemnv.Name = "txt_timkiemnv";
            this.txt_timkiemnv.Size = new System.Drawing.Size(299, 28);
            this.txt_timkiemnv.TabIndex = 15;
            // 
            // button_thoatnv
            // 
            this.button_thoatnv.Image = ((System.Drawing.Image)(resources.GetObject("button_thoatnv.Image")));
            this.button_thoatnv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_thoatnv.Location = new System.Drawing.Point(1038, 225);
            this.button_thoatnv.Margin = new System.Windows.Forms.Padding(4);
            this.button_thoatnv.Name = "button_thoatnv";
            this.button_thoatnv.Size = new System.Drawing.Size(132, 39);
            this.button_thoatnv.TabIndex = 13;
            this.button_thoatnv.Text = "Thoát";
            this.button_thoatnv.UseVisualStyleBackColor = true;
            this.button_thoatnv.Click += new System.EventHandler(this.button_thoatnv_Click);
            // 
            // button_xoanv
            // 
            this.button_xoanv.Image = ((System.Drawing.Image)(resources.GetObject("button_xoanv.Image")));
            this.button_xoanv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_xoanv.Location = new System.Drawing.Point(853, 225);
            this.button_xoanv.Margin = new System.Windows.Forms.Padding(4);
            this.button_xoanv.Name = "button_xoanv";
            this.button_xoanv.Size = new System.Drawing.Size(132, 39);
            this.button_xoanv.TabIndex = 12;
            this.button_xoanv.Text = "Xóa";
            this.button_xoanv.UseVisualStyleBackColor = true;
            this.button_xoanv.Click += new System.EventHandler(this.button_xoanv_Click);
            // 
            // groupBox_nhaptt
            // 
            this.groupBox_nhaptt.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_nhaptt.Controls.Add(this.dateTime_nv);
            this.groupBox_nhaptt.Controls.Add(this.button_timkiem);
            this.groupBox_nhaptt.Controls.Add(this.txt_timkiemnv);
            this.groupBox_nhaptt.Controls.Add(this.button_thoatnv);
            this.groupBox_nhaptt.Controls.Add(this.button_xoanv);
            this.groupBox_nhaptt.Controls.Add(this.txtemail);
            this.groupBox_nhaptt.Controls.Add(this.button_suanv);
            this.groupBox_nhaptt.Controls.Add(this.button_themnv);
            this.groupBox_nhaptt.Controls.Add(this.txtdc);
            this.groupBox_nhaptt.Controls.Add(this.txthotennv);
            this.groupBox_nhaptt.Controls.Add(this.txtsdt);
            this.groupBox_nhaptt.Controls.Add(this.txtmanv);
            this.groupBox_nhaptt.Controls.Add(this.label_emailnv);
            this.groupBox_nhaptt.Controls.Add(this.label_sdtnv);
            this.groupBox_nhaptt.Controls.Add(this.label_diachinv);
            this.groupBox_nhaptt.Controls.Add(this.label_ngaysinhnv);
            this.groupBox_nhaptt.Controls.Add(this.label_hotennv);
            this.groupBox_nhaptt.Controls.Add(this.label2_manv);
            this.groupBox_nhaptt.Location = new System.Drawing.Point(48, 95);
            this.groupBox_nhaptt.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox_nhaptt.Name = "groupBox_nhaptt";
            this.groupBox_nhaptt.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox_nhaptt.Size = new System.Drawing.Size(1199, 281);
            this.groupBox_nhaptt.TabIndex = 20;
            this.groupBox_nhaptt.TabStop = false;
            this.groupBox_nhaptt.Text = "Nhập TT";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(839, 154);
            this.txtemail.Margin = new System.Windows.Forms.Padding(4);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(322, 28);
            this.txtemail.TabIndex = 11;
            // 
            // button_suanv
            // 
            this.button_suanv.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.button_suanv.Image = ((System.Drawing.Image)(resources.GetObject("button_suanv.Image")));
            this.button_suanv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_suanv.Location = new System.Drawing.Point(667, 225);
            this.button_suanv.Margin = new System.Windows.Forms.Padding(4);
            this.button_suanv.Name = "button_suanv";
            this.button_suanv.Size = new System.Drawing.Size(132, 39);
            this.button_suanv.TabIndex = 11;
            this.button_suanv.Text = "Sửa";
            this.button_suanv.UseVisualStyleBackColor = true;
            this.button_suanv.Click += new System.EventHandler(this.button_suanv_Click);
            // 
            // button_themnv
            // 
            this.button_themnv.Image = ((System.Drawing.Image)(resources.GetObject("button_themnv.Image")));
            this.button_themnv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_themnv.Location = new System.Drawing.Point(479, 225);
            this.button_themnv.Margin = new System.Windows.Forms.Padding(4);
            this.button_themnv.Name = "button_themnv";
            this.button_themnv.Size = new System.Drawing.Size(132, 39);
            this.button_themnv.TabIndex = 10;
            this.button_themnv.Text = "Thêm";
            this.button_themnv.UseVisualStyleBackColor = true;
            this.button_themnv.Click += new System.EventHandler(this.button_themnv_Click);
            // 
            // txtdc
            // 
            this.txtdc.Location = new System.Drawing.Point(839, 55);
            this.txtdc.Margin = new System.Windows.Forms.Padding(4);
            this.txtdc.Name = "txtdc";
            this.txtdc.Size = new System.Drawing.Size(322, 28);
            this.txtdc.TabIndex = 10;
            // 
            // txthotennv
            // 
            this.txthotennv.Location = new System.Drawing.Point(218, 105);
            this.txthotennv.Margin = new System.Windows.Forms.Padding(4);
            this.txthotennv.Name = "txthotennv";
            this.txthotennv.Size = new System.Drawing.Size(322, 28);
            this.txthotennv.TabIndex = 9;
            // 
            // txtsdt
            // 
            this.txtsdt.Location = new System.Drawing.Point(839, 105);
            this.txtsdt.Margin = new System.Windows.Forms.Padding(4);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(322, 28);
            this.txtsdt.TabIndex = 7;
            // 
            // txtmanv
            // 
            this.txtmanv.Location = new System.Drawing.Point(218, 50);
            this.txtmanv.Margin = new System.Windows.Forms.Padding(4);
            this.txtmanv.Name = "txtmanv";
            this.txtmanv.Size = new System.Drawing.Size(322, 28);
            this.txtmanv.TabIndex = 6;
            // 
            // label_emailnv
            // 
            this.label_emailnv.AutoSize = true;
            this.label_emailnv.Location = new System.Drawing.Point(653, 158);
            this.label_emailnv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_emailnv.Name = "label_emailnv";
            this.label_emailnv.Size = new System.Drawing.Size(51, 21);
            this.label_emailnv.TabIndex = 5;
            this.label_emailnv.Text = "Email";
            // 
            // label_sdtnv
            // 
            this.label_sdtnv.AutoSize = true;
            this.label_sdtnv.Location = new System.Drawing.Point(653, 105);
            this.label_sdtnv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_sdtnv.Name = "label_sdtnv";
            this.label_sdtnv.Size = new System.Drawing.Size(119, 21);
            this.label_sdtnv.TabIndex = 4;
            this.label_sdtnv.Text = "Số Điện Thoại";
            // 
            // label_diachinv
            // 
            this.label_diachinv.AutoSize = true;
            this.label_diachinv.Location = new System.Drawing.Point(653, 59);
            this.label_diachinv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_diachinv.Name = "label_diachinv";
            this.label_diachinv.Size = new System.Drawing.Size(69, 21);
            this.label_diachinv.TabIndex = 3;
            this.label_diachinv.Text = "Địa Chỉ";
            // 
            // label_ngaysinhnv
            // 
            this.label_ngaysinhnv.AutoSize = true;
            this.label_ngaysinhnv.Location = new System.Drawing.Point(38, 154);
            this.label_ngaysinhnv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_ngaysinhnv.Name = "label_ngaysinhnv";
            this.label_ngaysinhnv.Size = new System.Drawing.Size(84, 21);
            this.label_ngaysinhnv.TabIndex = 2;
            this.label_ngaysinhnv.Text = "Ngày sinh";
            // 
            // label_hotennv
            // 
            this.label_hotennv.AutoSize = true;
            this.label_hotennv.Location = new System.Drawing.Point(38, 105);
            this.label_hotennv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_hotennv.Name = "label_hotennv";
            this.label_hotennv.Size = new System.Drawing.Size(67, 21);
            this.label_hotennv.TabIndex = 1;
            this.label_hotennv.Text = "Họ Tên";
            // 
            // label2_manv
            // 
            this.label2_manv.AutoSize = true;
            this.label2_manv.Location = new System.Drawing.Point(38, 59);
            this.label2_manv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2_manv.Name = "label2_manv";
            this.label2_manv.Size = new System.Drawing.Size(116, 21);
            this.label2_manv.TabIndex = 0;
            this.label2_manv.Text = "Mã Nhân Viên";
            // 
            // groupBox_hienthiTT
            // 
            this.groupBox_hienthiTT.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_hienthiTT.Controls.Add(this.DGV_nv);
            this.groupBox_hienthiTT.Location = new System.Drawing.Point(48, 397);
            this.groupBox_hienthiTT.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox_hienthiTT.Name = "groupBox_hienthiTT";
            this.groupBox_hienthiTT.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox_hienthiTT.Size = new System.Drawing.Size(1199, 345);
            this.groupBox_hienthiTT.TabIndex = 21;
            this.groupBox_hienthiTT.TabStop = false;
            this.groupBox_hienthiTT.Text = "Hiển Thị TT";
            // 
            // DGV_nv
            // 
            this.DGV_nv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_nv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_nv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.manv,
            this.hoten,
            this.ngaysinh,
            this.diachi,
            this.sdt,
            this.email});
            this.DGV_nv.Location = new System.Drawing.Point(29, 41);
            this.DGV_nv.Margin = new System.Windows.Forms.Padding(4);
            this.DGV_nv.Name = "DGV_nv";
            this.DGV_nv.RowHeadersWidth = 51;
            this.DGV_nv.RowTemplate.Height = 24;
            this.DGV_nv.Size = new System.Drawing.Size(1141, 280);
            this.DGV_nv.TabIndex = 0;
            this.DGV_nv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_nv_CellContentClick);
            // 
            // manv
            // 
            this.manv.DataPropertyName = "manv";
            this.manv.HeaderText = "Mã Nhân Viên";
            this.manv.MinimumWidth = 6;
            this.manv.Name = "manv";
            // 
            // hoten
            // 
            this.hoten.DataPropertyName = "hoten";
            this.hoten.HeaderText = "Họ Tên";
            this.hoten.MinimumWidth = 6;
            this.hoten.Name = "hoten";
            // 
            // ngaysinh
            // 
            this.ngaysinh.DataPropertyName = "ngaysinh";
            this.ngaysinh.HeaderText = "Ngày Sinh";
            this.ngaysinh.MinimumWidth = 6;
            this.ngaysinh.Name = "ngaysinh";
            // 
            // diachi
            // 
            this.diachi.DataPropertyName = "diachi";
            this.diachi.HeaderText = "Địa Chỉ";
            this.diachi.MinimumWidth = 6;
            this.diachi.Name = "diachi";
            // 
            // sdt
            // 
            this.sdt.DataPropertyName = "sdt";
            this.sdt.HeaderText = "Số Điện Thoại";
            this.sdt.MinimumWidth = 6;
            this.sdt.Name = "sdt";
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1295, 759);
            this.Controls.Add(this.mk_tg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox_nhaptt);
            this.Controls.Add(this.groupBox_hienthiTT);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NhanVien";
            this.Text = "NhanVien";
            this.Load += new System.EventHandler(this.NhanVien_Load);
            this.groupBox_nhaptt.ResumeLayout(false);
            this.groupBox_nhaptt.PerformLayout();
            this.groupBox_hienthiTT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_nv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox mk_tg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTime_nv;
        private System.Windows.Forms.Button button_timkiem;
        private System.Windows.Forms.TextBox txt_timkiemnv;
        private System.Windows.Forms.Button button_thoatnv;
        private System.Windows.Forms.Button button_xoanv;
        private System.Windows.Forms.GroupBox groupBox_nhaptt;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Button button_suanv;
        private System.Windows.Forms.Button button_themnv;
        private System.Windows.Forms.TextBox txtdc;
        private System.Windows.Forms.TextBox txthotennv;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.TextBox txtmanv;
        private System.Windows.Forms.Label label_emailnv;
        private System.Windows.Forms.Label label_sdtnv;
        private System.Windows.Forms.Label label_diachinv;
        private System.Windows.Forms.Label label_ngaysinhnv;
        private System.Windows.Forms.Label label_hotennv;
        private System.Windows.Forms.Label label2_manv;
        private System.Windows.Forms.GroupBox groupBox_hienthiTT;
        private System.Windows.Forms.DataGridView DGV_nv;
        private System.Windows.Forms.DataGridViewTextBoxColumn manv;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
    }
}