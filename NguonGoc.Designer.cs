
namespace QLBH
{
    partial class NguonGoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NguonGoc));
            this.mk_tg = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_thoatnguongocSP = new System.Windows.Forms.Button();
            this.button_xoanguongocSP = new System.Windows.Forms.Button();
            this.button_suanguongocSP = new System.Windows.Forms.Button();
            this.button_themnguonhang = new System.Windows.Forms.Button();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_nguongoc = new System.Windows.Forms.DataGridView();
            this.button_timkiemSP = new System.Windows.Forms.Button();
            this.txt_timkiemSP = new System.Windows.Forms.TextBox();
            this.txttennguongoc = new System.Windows.Forms.TextBox();
            this.txtmanguongoc = new System.Windows.Forms.TextBox();
            this.label_ten = new System.Windows.Forms.Label();
            this.label_manguonggoc = new System.Windows.Forms.Label();
            this.groupBox_hienthiTT = new System.Windows.Forms.GroupBox();
            this.groupBox_nguongoc = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_nguongoc)).BeginInit();
            this.groupBox_hienthiTT.SuspendLayout();
            this.groupBox_nguongoc.SuspendLayout();
            this.SuspendLayout();
            // 
            // mk_tg
            // 
            this.mk_tg.Location = new System.Drawing.Point(790, 10);
            this.mk_tg.Name = "mk_tg";
            this.mk_tg.Size = new System.Drawing.Size(151, 28);
            this.mk_tg.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(215, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(528, 49);
            this.label1.TabIndex = 11;
            this.label1.Text = "NGUỒN GỐC SẢN PHẨM";
            // 
            // button_thoatnguongocSP
            // 
            this.button_thoatnguongocSP.Image = ((System.Drawing.Image)(resources.GetObject("button_thoatnguongocSP.Image")));
            this.button_thoatnguongocSP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_thoatnguongocSP.Location = new System.Drawing.Point(618, 163);
            this.button_thoatnguongocSP.Name = "button_thoatnguongocSP";
            this.button_thoatnguongocSP.Size = new System.Drawing.Size(106, 31);
            this.button_thoatnguongocSP.TabIndex = 9;
            this.button_thoatnguongocSP.Text = "Thoát";
            this.button_thoatnguongocSP.UseVisualStyleBackColor = true;
            this.button_thoatnguongocSP.Click += new System.EventHandler(this.button_thoatnguongocSP_Click);
            // 
            // button_xoanguongocSP
            // 
            this.button_xoanguongocSP.Image = ((System.Drawing.Image)(resources.GetObject("button_xoanguongocSP.Image")));
            this.button_xoanguongocSP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_xoanguongocSP.Location = new System.Drawing.Point(470, 163);
            this.button_xoanguongocSP.Name = "button_xoanguongocSP";
            this.button_xoanguongocSP.Size = new System.Drawing.Size(106, 31);
            this.button_xoanguongocSP.TabIndex = 8;
            this.button_xoanguongocSP.Text = "Xóa";
            this.button_xoanguongocSP.UseVisualStyleBackColor = true;
            this.button_xoanguongocSP.Click += new System.EventHandler(this.button_xoanguongocSP_Click);
            // 
            // button_suanguongocSP
            // 
            this.button_suanguongocSP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.button_suanguongocSP.Image = ((System.Drawing.Image)(resources.GetObject("button_suanguongocSP.Image")));
            this.button_suanguongocSP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_suanguongocSP.Location = new System.Drawing.Point(321, 163);
            this.button_suanguongocSP.Name = "button_suanguongocSP";
            this.button_suanguongocSP.Size = new System.Drawing.Size(106, 31);
            this.button_suanguongocSP.TabIndex = 7;
            this.button_suanguongocSP.Text = "Sửa";
            this.button_suanguongocSP.UseVisualStyleBackColor = true;
            this.button_suanguongocSP.Click += new System.EventHandler(this.button_suanguongocSP_Click);
            // 
            // button_themnguonhang
            // 
            this.button_themnguonhang.Image = ((System.Drawing.Image)(resources.GetObject("button_themnguonhang.Image")));
            this.button_themnguonhang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_themnguonhang.Location = new System.Drawing.Point(177, 163);
            this.button_themnguonhang.Name = "button_themnguonhang";
            this.button_themnguonhang.Size = new System.Drawing.Size(106, 31);
            this.button_themnguonhang.TabIndex = 6;
            this.button_themnguonhang.Text = "Thêm";
            this.button_themnguonhang.UseVisualStyleBackColor = true;
            this.button_themnguonhang.Click += new System.EventHandler(this.button_themnguonhang_Click);
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "tennguongoc";
            this.Column2.HeaderText = "Tên Nguồn Gốc";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "manguongoc";
            this.Column1.HeaderText = "Mã Nguồn Gốc";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // DGV_nguongoc
            // 
            this.DGV_nguongoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_nguongoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_nguongoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.DGV_nguongoc.Location = new System.Drawing.Point(21, 29);
            this.DGV_nguongoc.Name = "DGV_nguongoc";
            this.DGV_nguongoc.RowHeadersWidth = 51;
            this.DGV_nguongoc.RowTemplate.Height = 24;
            this.DGV_nguongoc.Size = new System.Drawing.Size(827, 241);
            this.DGV_nguongoc.TabIndex = 0;
            this.DGV_nguongoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_nguongoc_CellContentClick);
            // 
            // button_timkiemSP
            // 
            this.button_timkiemSP.Image = ((System.Drawing.Image)(resources.GetObject("button_timkiemSP.Image")));
            this.button_timkiemSP.Location = new System.Drawing.Point(580, 109);
            this.button_timkiemSP.Name = "button_timkiemSP";
            this.button_timkiemSP.Size = new System.Drawing.Size(55, 39);
            this.button_timkiemSP.TabIndex = 5;
            this.button_timkiemSP.UseVisualStyleBackColor = true;
            this.button_timkiemSP.Click += new System.EventHandler(this.button_timkiemSP_Click);
            // 
            // txt_timkiemSP
            // 
            this.txt_timkiemSP.Location = new System.Drawing.Point(322, 120);
            this.txt_timkiemSP.Name = "txt_timkiemSP";
            this.txt_timkiemSP.Size = new System.Drawing.Size(240, 28);
            this.txt_timkiemSP.TabIndex = 4;
            // 
            // txttennguongoc
            // 
            this.txttennguongoc.Location = new System.Drawing.Point(322, 74);
            this.txttennguongoc.Name = "txttennguongoc";
            this.txttennguongoc.Size = new System.Drawing.Size(313, 28);
            this.txttennguongoc.TabIndex = 3;
            // 
            // txtmanguongoc
            // 
            this.txtmanguongoc.Location = new System.Drawing.Point(322, 28);
            this.txtmanguongoc.Name = "txtmanguongoc";
            this.txtmanguongoc.Size = new System.Drawing.Size(313, 28);
            this.txtmanguongoc.TabIndex = 2;
            // 
            // label_ten
            // 
            this.label_ten.AutoSize = true;
            this.label_ten.Location = new System.Drawing.Point(167, 81);
            this.label_ten.Name = "label_ten";
            this.label_ten.Size = new System.Drawing.Size(132, 21);
            this.label_ten.TabIndex = 1;
            this.label_ten.Text = "Tên Nguồn Gốc";
            // 
            // label_manguonggoc
            // 
            this.label_manguonggoc.AutoSize = true;
            this.label_manguonggoc.Location = new System.Drawing.Point(172, 39);
            this.label_manguonggoc.Name = "label_manguonggoc";
            this.label_manguonggoc.Size = new System.Drawing.Size(127, 21);
            this.label_manguonggoc.TabIndex = 0;
            this.label_manguonggoc.Text = "Mã Nguồn Gốc";
            // 
            // groupBox_hienthiTT
            // 
            this.groupBox_hienthiTT.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_hienthiTT.Controls.Add(this.DGV_nguongoc);
            this.groupBox_hienthiTT.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_hienthiTT.Location = new System.Drawing.Point(67, 290);
            this.groupBox_hienthiTT.Name = "groupBox_hienthiTT";
            this.groupBox_hienthiTT.Size = new System.Drawing.Size(869, 280);
            this.groupBox_hienthiTT.TabIndex = 13;
            this.groupBox_hienthiTT.TabStop = false;
            this.groupBox_hienthiTT.Text = "Hiển Thị TT";
            // 
            // groupBox_nguongoc
            // 
            this.groupBox_nguongoc.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_nguongoc.Controls.Add(this.button_thoatnguongocSP);
            this.groupBox_nguongoc.Controls.Add(this.button_xoanguongocSP);
            this.groupBox_nguongoc.Controls.Add(this.button_suanguongocSP);
            this.groupBox_nguongoc.Controls.Add(this.button_themnguonhang);
            this.groupBox_nguongoc.Controls.Add(this.button_timkiemSP);
            this.groupBox_nguongoc.Controls.Add(this.txt_timkiemSP);
            this.groupBox_nguongoc.Controls.Add(this.txttennguongoc);
            this.groupBox_nguongoc.Controls.Add(this.txtmanguongoc);
            this.groupBox_nguongoc.Controls.Add(this.label_ten);
            this.groupBox_nguongoc.Controls.Add(this.label_manguonggoc);
            this.groupBox_nguongoc.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_nguongoc.Location = new System.Drawing.Point(67, 61);
            this.groupBox_nguongoc.Name = "groupBox_nguongoc";
            this.groupBox_nguongoc.Size = new System.Drawing.Size(874, 210);
            this.groupBox_nguongoc.TabIndex = 12;
            this.groupBox_nguongoc.TabStop = false;
            this.groupBox_nguongoc.Text = "Thông Tin ";
            this.groupBox_nguongoc.Enter += new System.EventHandler(this.groupBox_nguongoc_Enter);
            // 
            // NguonGoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1000, 580);
            this.Controls.Add(this.mk_tg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox_hienthiTT);
            this.Controls.Add(this.groupBox_nguongoc);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NguonGoc";
            this.Text = "NguonGoc";
            this.Load += new System.EventHandler(this.NguonGoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_nguongoc)).EndInit();
            this.groupBox_hienthiTT.ResumeLayout(false);
            this.groupBox_nguongoc.ResumeLayout(false);
            this.groupBox_nguongoc.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox mk_tg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_thoatnguongocSP;
        private System.Windows.Forms.Button button_xoanguongocSP;
        private System.Windows.Forms.Button button_suanguongocSP;
        private System.Windows.Forms.Button button_themnguonhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridView DGV_nguongoc;
        private System.Windows.Forms.Button button_timkiemSP;
        private System.Windows.Forms.TextBox txt_timkiemSP;
        private System.Windows.Forms.TextBox txttennguongoc;
        private System.Windows.Forms.TextBox txtmanguongoc;
        private System.Windows.Forms.Label label_ten;
        private System.Windows.Forms.Label label_manguonggoc;
        private System.Windows.Forms.GroupBox groupBox_hienthiTT;
        private System.Windows.Forms.GroupBox groupBox_nguongoc;
    }
}