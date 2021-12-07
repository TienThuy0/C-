
namespace QLBH
{
    partial class HoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HoaDon));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.khachhangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLBH_GREENFRUITS1DataSet = new QLBH.QLBH_GREENFRUITS1DataSet();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.bt_thoat = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.button_taohd = new System.Windows.Forms.Button();
            this.button_bochon = new System.Windows.Forms.Button();
            this.button_report = new System.Windows.Forms.Button();
            this.button_chon = new System.Windows.Forms.Button();
            this.txtTuTim = new System.Windows.Forms.TextBox();
            this.button_timkiem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Cb_cachtim = new System.Windows.Forms.ComboBox();
            this.khachhangTableAdapter = new QLBH.QLBH_GREENFRUITS1DataSetTableAdapters.khachhangTableAdapter();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.khachhangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBH_GREENFRUITS1DataSet)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.khachhangBindingSource;
            this.comboBox1.DisplayMember = "makh";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(488, 468);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(138, 28);
            this.comboBox1.TabIndex = 41;
            this.comboBox1.ValueMember = "makh";
            // 
            // khachhangBindingSource
            // 
            this.khachhangBindingSource.DataMember = "khachhang";
            this.khachhangBindingSource.DataSource = this.qLBH_GREENFRUITS1DataSet;
            // 
            // qLBH_GREENFRUITS1DataSet
            // 
            this.qLBH_GREENFRUITS1DataSet.DataSetName = "QLBH_GREENFRUITS1DataSet";
            this.qLBH_GREENFRUITS1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(484, 370);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 21);
            this.label5.TabIndex = 40;
            this.label5.Text = "Mã hóa đơn :";
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(488, 394);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(135, 28);
            this.txtMaHD.TabIndex = 39;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(659, 120);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(416, 584);
            this.listBox2.TabIndex = 38;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(29, 120);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(416, 584);
            this.listBox1.TabIndex = 37;
            // 
            // bt_thoat
            // 
            this.bt_thoat.Image = ((System.Drawing.Image)(resources.GetObject("bt_thoat.Image")));
            this.bt_thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_thoat.Location = new System.Drawing.Point(968, 43);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(107, 33);
            this.bt_thoat.TabIndex = 36;
            this.bt_thoat.Text = "Thoát";
            this.bt_thoat.UseVisualStyleBackColor = true;
            this.bt_thoat.Click += new System.EventHandler(this.bt_thoat_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(488, 615);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(138, 28);
            this.dateTimePicker1.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(484, 591);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 21);
            this.label4.TabIndex = 34;
            this.label4.Text = "Thời gian lập :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(481, 522);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 21);
            this.label3.TabIndex = 33;
            this.label3.Text = "Tên khách hàng :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(484, 444);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 21);
            this.label2.TabIndex = 32;
            this.label2.Text = "Mã Khách Hàng :";
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(488, 546);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(135, 28);
            this.txtTenKH.TabIndex = 31;
            // 
            // button_taohd
            // 
            this.button_taohd.Location = new System.Drawing.Point(485, 671);
            this.button_taohd.Name = "button_taohd";
            this.button_taohd.Size = new System.Drawing.Size(144, 33);
            this.button_taohd.TabIndex = 30;
            this.button_taohd.Text = "Tạo hóa đơn";
            this.button_taohd.UseVisualStyleBackColor = true;
            this.button_taohd.Click += new System.EventHandler(this.button_taohd_Click);
            // 
            // button_bochon
            // 
            this.button_bochon.Location = new System.Drawing.Point(485, 183);
            this.button_bochon.Name = "button_bochon";
            this.button_bochon.Size = new System.Drawing.Size(141, 33);
            this.button_bochon.TabIndex = 29;
            this.button_bochon.Text = "<<<<<";
            this.button_bochon.UseVisualStyleBackColor = true;
            this.button_bochon.Click += new System.EventHandler(this.button_bochon_Click);
            // 
            // button_report
            // 
            this.button_report.Location = new System.Drawing.Point(488, 312);
            this.button_report.Name = "button_report";
            this.button_report.Size = new System.Drawing.Size(138, 33);
            this.button_report.TabIndex = 28;
            this.button_report.Text = "Làm lại";
            this.button_report.UseVisualStyleBackColor = true;
            this.button_report.Click += new System.EventHandler(this.button_report_Click);
            // 
            // button_chon
            // 
            this.button_chon.Location = new System.Drawing.Point(485, 120);
            this.button_chon.Name = "button_chon";
            this.button_chon.Size = new System.Drawing.Size(141, 33);
            this.button_chon.TabIndex = 27;
            this.button_chon.Text = ">>>>>";
            this.button_chon.UseVisualStyleBackColor = true;
            this.button_chon.Click += new System.EventHandler(this.button_chon_Click);
            // 
            // txtTuTim
            // 
            this.txtTuTim.Location = new System.Drawing.Point(550, 43);
            this.txtTuTim.Name = "txtTuTim";
            this.txtTuTim.Size = new System.Drawing.Size(230, 28);
            this.txtTuTim.TabIndex = 26;
            // 
            // button_timkiem
            // 
            this.button_timkiem.Image = ((System.Drawing.Image)(resources.GetObject("button_timkiem.Image")));
            this.button_timkiem.Location = new System.Drawing.Point(809, 32);
            this.button_timkiem.Name = "button_timkiem";
            this.button_timkiem.Size = new System.Drawing.Size(60, 48);
            this.button_timkiem.TabIndex = 25;
            this.button_timkiem.UseVisualStyleBackColor = true;
            this.button_timkiem.Click += new System.EventHandler(this.button_timkiem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 24;
            this.label1.Text = "Cách Tìm:";
            // 
            // Cb_cachtim
            // 
            this.Cb_cachtim.FormattingEnabled = true;
            this.Cb_cachtim.Items.AddRange(new object[] {
            "Mã Khách Hàng ",
            "Mã Sản Phẩm"});
            this.Cb_cachtim.Location = new System.Drawing.Point(166, 43);
            this.Cb_cachtim.Margin = new System.Windows.Forms.Padding(4);
            this.Cb_cachtim.Name = "Cb_cachtim";
            this.Cb_cachtim.Size = new System.Drawing.Size(249, 28);
            this.Cb_cachtim.TabIndex = 23;
            // 
            // khachhangTableAdapter
            // 
            this.khachhangTableAdapter.ClearBeforeFill = true;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(1103, 27);
            this.fillByToolStrip.TabIndex = 45;
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
            // HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1103, 724);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMaHD);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.bt_thoat);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTenKH);
            this.Controls.Add(this.button_taohd);
            this.Controls.Add(this.button_bochon);
            this.Controls.Add(this.button_report);
            this.Controls.Add(this.button_chon);
            this.Controls.Add(this.txtTuTim);
            this.Controls.Add(this.button_timkiem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cb_cachtim);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HoaDon";
            this.Text = "HoaDon";
            this.Load += new System.EventHandler(this.HoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.khachhangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBH_GREENFRUITS1DataSet)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button bt_thoat;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Button button_taohd;
        private System.Windows.Forms.Button button_bochon;
        private System.Windows.Forms.Button button_report;
        private System.Windows.Forms.Button button_chon;
        private System.Windows.Forms.TextBox txtTuTim;
        private System.Windows.Forms.Button button_timkiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Cb_cachtim;
        private QLBH_GREENFRUITS1DataSet qLBH_GREENFRUITS1DataSet;
        private System.Windows.Forms.BindingSource khachhangBindingSource;
        private QLBH_GREENFRUITS1DataSetTableAdapters.khachhangTableAdapter khachhangTableAdapter;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
    }
}