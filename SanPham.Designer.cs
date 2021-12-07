
namespace QLBH
{
    partial class SanPham
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SanPham));
            this.bt_timkiem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.mk_tg = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdonvi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.bt_them = new System.Windows.Forms.Button();
            this.txtmasp = new System.Windows.Forms.TextBox();
            this.bt_sua = new System.Windows.Forms.Button();
            this.txttensp = new System.Windows.Forms.TextBox();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.txtgiatien = new System.Windows.Forms.TextBox();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtghichu = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.nguongocnhapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLBH_GREENFRUITS1DataSet = new QLBH.QLBH_GREENFRUITS1DataSet();
            this.bt_thoat = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.masp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donvi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giatien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manguongoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghichu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.nguongocnhapTableAdapter = new QLBH.QLBH_GREENFRUITS1DataSetTableAdapters.nguongocnhapTableAdapter();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nguongocnhapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBH_GREENFRUITS1DataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_timkiem
            // 
            this.bt_timkiem.Image = ((System.Drawing.Image)(resources.GetObject("bt_timkiem.Image")));
            this.bt_timkiem.Location = new System.Drawing.Point(472, 102);
            this.bt_timkiem.Margin = new System.Windows.Forms.Padding(5);
            this.bt_timkiem.Name = "bt_timkiem";
            this.bt_timkiem.Size = new System.Drawing.Size(67, 48);
            this.bt_timkiem.TabIndex = 12;
            this.bt_timkiem.UseVisualStyleBackColor = true;
            this.bt_timkiem.Click += new System.EventHandler(this.bt_timkiem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(392, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(577, 49);
            this.label1.TabIndex = 42;
            this.label1.Text = "THÔNG TIN VỀ SẢN PHẨM";
            // 
            // mk_tg
            // 
            this.mk_tg.FormattingEnabled = true;
            this.mk_tg.Location = new System.Drawing.Point(9, 30);
            this.mk_tg.Margin = new System.Windows.Forms.Padding(5);
            this.mk_tg.Name = "mk_tg";
            this.mk_tg.Size = new System.Drawing.Size(120, 28);
            this.mk_tg.TabIndex = 47;
            this.mk_tg.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 225);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 21);
            this.label6.TabIndex = 4;
            this.label6.Text = "Đơn vị :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã sản phẩm :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 105);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên sản phẩm :";
            // 
            // txtdonvi
            // 
            this.txtdonvi.Location = new System.Drawing.Point(201, 225);
            this.txtdonvi.Margin = new System.Windows.Forms.Padding(5);
            this.txtdonvi.Name = "txtdonvi";
            this.txtdonvi.Size = new System.Drawing.Size(412, 28);
            this.txtdonvi.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 291);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Giá tiền :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 164);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "Số lượng :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 350);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 21);
            this.label8.TabIndex = 7;
            this.label8.Text = "Mã nguồn gốc :";
            // 
            // bt_them
            // 
            this.bt_them.Image = ((System.Drawing.Image)(resources.GetObject("bt_them.Image")));
            this.bt_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_them.Location = new System.Drawing.Point(29, 580);
            this.bt_them.Margin = new System.Windows.Forms.Padding(5);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(169, 39);
            this.bt_them.TabIndex = 8;
            this.bt_them.Text = "Thêm";
            this.bt_them.UseVisualStyleBackColor = true;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // txtmasp
            // 
            this.txtmasp.Location = new System.Drawing.Point(201, 40);
            this.txtmasp.Margin = new System.Windows.Forms.Padding(5);
            this.txtmasp.Name = "txtmasp";
            this.txtmasp.Size = new System.Drawing.Size(412, 28);
            this.txtmasp.TabIndex = 1;
            // 
            // bt_sua
            // 
            this.bt_sua.Image = ((System.Drawing.Image)(resources.GetObject("bt_sua.Image")));
            this.bt_sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_sua.Location = new System.Drawing.Point(238, 580);
            this.bt_sua.Margin = new System.Windows.Forms.Padding(5);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(169, 39);
            this.bt_sua.TabIndex = 9;
            this.bt_sua.Text = "Sửa";
            this.bt_sua.UseVisualStyleBackColor = true;
            this.bt_sua.Click += new System.EventHandler(this.bt_sua_Click);
            // 
            // txttensp
            // 
            this.txttensp.Location = new System.Drawing.Point(201, 98);
            this.txttensp.Margin = new System.Windows.Forms.Padding(5);
            this.txttensp.Name = "txttensp";
            this.txttensp.Size = new System.Drawing.Size(412, 28);
            this.txttensp.TabIndex = 2;
            // 
            // bt_xoa
            // 
            this.bt_xoa.Image = ((System.Drawing.Image)(resources.GetObject("bt_xoa.Image")));
            this.bt_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_xoa.Location = new System.Drawing.Point(437, 580);
            this.bt_xoa.Margin = new System.Windows.Forms.Padding(5);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(169, 39);
            this.bt_xoa.TabIndex = 10;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.UseVisualStyleBackColor = true;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // txtgiatien
            // 
            this.txtgiatien.Location = new System.Drawing.Point(201, 284);
            this.txtgiatien.Margin = new System.Windows.Forms.Padding(5);
            this.txtgiatien.Name = "txtgiatien";
            this.txtgiatien.Size = new System.Drawing.Size(412, 28);
            this.txtgiatien.TabIndex = 5;
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(201, 161);
            this.txtsoluong.Margin = new System.Windows.Forms.Padding(5);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(412, 28);
            this.txtsoluong.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtghichu);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.txtsoluong);
            this.groupBox1.Controls.Add(this.txtgiatien);
            this.groupBox1.Controls.Add(this.bt_xoa);
            this.groupBox1.Controls.Add(this.txttensp);
            this.groupBox1.Controls.Add(this.bt_sua);
            this.groupBox1.Controls.Add(this.txtmasp);
            this.groupBox1.Controls.Add(this.bt_them);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtdonvi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(599, 102);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(647, 649);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin sản phẩm";
            // 
            // txtghichu
            // 
            this.txtghichu.Location = new System.Drawing.Point(201, 418);
            this.txtghichu.Margin = new System.Windows.Forms.Padding(5);
            this.txtghichu.Multiline = true;
            this.txtghichu.Name = "txtghichu";
            this.txtghichu.Size = new System.Drawing.Size(412, 107);
            this.txtghichu.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 421);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 21);
            this.label9.TabIndex = 10;
            this.label9.Text = "Ghi chú :";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.nguongocnhapBindingSource;
            this.comboBox2.DisplayMember = "manguongoc";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(201, 350);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(5);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(412, 28);
            this.comboBox2.TabIndex = 6;
            this.comboBox2.ValueMember = "manguongoc";
            // 
            // nguongocnhapBindingSource
            // 
            this.nguongocnhapBindingSource.DataMember = "nguongocnhap";
            this.nguongocnhapBindingSource.DataSource = this.qLBH_GREENFRUITS1DataSet;
            // 
            // qLBH_GREENFRUITS1DataSet
            // 
            this.qLBH_GREENFRUITS1DataSet.DataSetName = "QLBH_GREENFRUITS1DataSet";
            this.qLBH_GREENFRUITS1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bt_thoat
            // 
            this.bt_thoat.Image = ((System.Drawing.Image)(resources.GetObject("bt_thoat.Image")));
            this.bt_thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_thoat.Location = new System.Drawing.Point(1127, 32);
            this.bt_thoat.Margin = new System.Windows.Forms.Padding(5);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(119, 49);
            this.bt_thoat.TabIndex = 13;
            this.bt_thoat.Text = "Thoát";
            this.bt_thoat.UseVisualStyleBackColor = true;
            this.bt_thoat.Click += new System.EventHandler(this.bt_thoat_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.dgvSanPham);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(14, 160);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox2.Size = new System.Drawing.Size(575, 591);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chi tiết";
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masp,
            this.tensp,
            this.soluong,
            this.donvi,
            this.giatien,
            this.manguongoc,
            this.ghichu});
            this.dgvSanPham.Location = new System.Drawing.Point(22, 30);
            this.dgvSanPham.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.RowHeadersWidth = 51;
            this.dgvSanPham.RowTemplate.Height = 24;
            this.dgvSanPham.Size = new System.Drawing.Size(537, 542);
            this.dgvSanPham.TabIndex = 0;
            this.dgvSanPham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanPham_CellContentClick);
            // 
            // masp
            // 
            this.masp.DataPropertyName = "masp";
            this.masp.HeaderText = "Mã SP";
            this.masp.MinimumWidth = 6;
            this.masp.Name = "masp";
            // 
            // tensp
            // 
            this.tensp.DataPropertyName = "tensp";
            this.tensp.HeaderText = "Tên SP";
            this.tensp.MinimumWidth = 6;
            this.tensp.Name = "tensp";
            // 
            // soluong
            // 
            this.soluong.DataPropertyName = "soluong";
            this.soluong.HeaderText = "Số lượng ";
            this.soluong.MinimumWidth = 6;
            this.soluong.Name = "soluong";
            // 
            // donvi
            // 
            this.donvi.DataPropertyName = "donvi";
            this.donvi.HeaderText = "Đơn vị";
            this.donvi.MinimumWidth = 6;
            this.donvi.Name = "donvi";
            // 
            // giatien
            // 
            this.giatien.DataPropertyName = "giatien";
            this.giatien.HeaderText = "Gía tiền";
            this.giatien.MinimumWidth = 6;
            this.giatien.Name = "giatien";
            // 
            // manguongoc
            // 
            this.manguongoc.DataPropertyName = "manguongoc";
            this.manguongoc.HeaderText = "Mã nguồn gốc";
            this.manguongoc.MinimumWidth = 6;
            this.manguongoc.Name = "manguongoc";
            // 
            // ghichu
            // 
            this.ghichu.DataPropertyName = "ghichu";
            this.ghichu.HeaderText = "Ghi chú";
            this.ghichu.MinimumWidth = 6;
            this.ghichu.Name = "ghichu";
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(42, 110);
            this.txttimkiem.Margin = new System.Windows.Forms.Padding(4);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(395, 28);
            this.txttimkiem.TabIndex = 11;
            // 
            // nguongocnhapTableAdapter
            // 
            this.nguongocnhapTableAdapter.ClearBeforeFill = true;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(1267, 27);
            this.fillByToolStrip.TabIndex = 49;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(48, 24);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1267, 763);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.txttimkiem);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.bt_thoat);
            this.Controls.Add(this.mk_tg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_timkiem);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SanPham";
            this.Text = "SanPham";
            this.Load += new System.EventHandler(this.SanPham_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nguongocnhapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBH_GREENFRUITS1DataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_timkiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox mk_tg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtdonvi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.TextBox txtmasp;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.TextBox txttensp;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.TextBox txtgiatien;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtghichu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button bt_thoat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn masp;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensp;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn donvi;
        private System.Windows.Forms.DataGridViewTextBoxColumn giatien;
        private System.Windows.Forms.DataGridViewTextBoxColumn manguongoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghichu;
        private QLBH_GREENFRUITS1DataSet qLBH_GREENFRUITS1DataSet;
        private System.Windows.Forms.BindingSource nguongocnhapBindingSource;
        private QLBH_GREENFRUITS1DataSetTableAdapters.nguongocnhapTableAdapter nguongocnhapTableAdapter;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
    }
}