
namespace QLBH
{
    partial class Form1
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
            System.Windows.Forms.Label mahdLabel;
            System.Windows.Forms.Label makhLabel;
            System.Windows.Forms.Label tenkhLabel;
            System.Windows.Forms.Label tongLabel;
            System.Windows.Forms.Label ngaymuaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.qLBH_GREENFRUITS1DataSet = new QLBH.QLBH_GREENFRUITS1DataSet();
            this.sanphamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sanphamTableAdapter = new QLBH.QLBH_GREENFRUITS1DataSetTableAdapters.sanphamTableAdapter();
            this.tableAdapterManager = new QLBH.QLBH_GREENFRUITS1DataSetTableAdapters.TableAdapterManager();
            this.cTHDTableAdapter = new QLBH.QLBH_GREENFRUITS1DataSetTableAdapters.CTHDTableAdapter();
            this.hoadonTableAdapter = new QLBH.QLBH_GREENFRUITS1DataSetTableAdapters.hoadonTableAdapter();
            this.sanphamBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.sanphamBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dgSP = new System.Windows.Forms.DataGridView();
            this.colMasp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTensp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiatien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoadonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mahdTextBox = new System.Windows.Forms.TextBox();
            this.makhTextBox = new System.Windows.Forms.TextBox();
            this.tenkhTextBox = new System.Windows.Forms.TextBox();
            this.tongTextBox = new System.Windows.Forms.TextBox();
            this.cTHDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgCTHD = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMasp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSoluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTongtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_taohoadon = new System.Windows.Forms.Button();
            this.ngaymuaTextBox = new System.Windows.Forms.TextBox();
            this.button_thoat = new System.Windows.Forms.Button();
            mahdLabel = new System.Windows.Forms.Label();
            makhLabel = new System.Windows.Forms.Label();
            tenkhLabel = new System.Windows.Forms.Label();
            tongLabel = new System.Windows.Forms.Label();
            ngaymuaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qLBH_GREENFRUITS1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanphamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanphamBindingNavigator)).BeginInit();
            this.sanphamBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoadonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTHDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCTHD)).BeginInit();
            this.SuspendLayout();
            // 
            // mahdLabel
            // 
            mahdLabel.AutoSize = true;
            mahdLabel.Location = new System.Drawing.Point(527, 140);
            mahdLabel.Name = "mahdLabel";
            mahdLabel.Size = new System.Drawing.Size(55, 21);
            mahdLabel.TabIndex = 2;
            mahdLabel.Text = "mahd:";
            // 
            // makhLabel
            // 
            makhLabel.AutoSize = true;
            makhLabel.Location = new System.Drawing.Point(527, 174);
            makhLabel.Name = "makhLabel";
            makhLabel.Size = new System.Drawing.Size(54, 21);
            makhLabel.TabIndex = 4;
            makhLabel.Text = "makh:";
            // 
            // tenkhLabel
            // 
            tenkhLabel.AutoSize = true;
            tenkhLabel.Location = new System.Drawing.Point(527, 208);
            tenkhLabel.Name = "tenkhLabel";
            tenkhLabel.Size = new System.Drawing.Size(54, 21);
            tenkhLabel.TabIndex = 6;
            tenkhLabel.Text = "tenkh:";
            // 
            // tongLabel
            // 
            tongLabel.AutoSize = true;
            tongLabel.Location = new System.Drawing.Point(527, 283);
            tongLabel.Name = "tongLabel";
            tongLabel.Size = new System.Drawing.Size(47, 21);
            tongLabel.TabIndex = 10;
            tongLabel.Text = "tong:";
            // 
            // ngaymuaLabel
            // 
            ngaymuaLabel.AutoSize = true;
            ngaymuaLabel.Location = new System.Drawing.Point(527, 245);
            ngaymuaLabel.Name = "ngaymuaLabel";
            ngaymuaLabel.Size = new System.Drawing.Size(80, 21);
            ngaymuaLabel.TabIndex = 13;
            ngaymuaLabel.Text = "ngaymua:";
            // 
            // qLBH_GREENFRUITS1DataSet
            // 
            this.qLBH_GREENFRUITS1DataSet.DataSetName = "QLBH_GREENFRUITS1DataSet";
            this.qLBH_GREENFRUITS1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sanphamBindingSource
            // 
            this.sanphamBindingSource.DataMember = "sanpham";
            this.sanphamBindingSource.DataSource = this.qLBH_GREENFRUITS1DataSet;
            // 
            // sanphamTableAdapter
            // 
            this.sanphamTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CTHDTableAdapter = this.cTHDTableAdapter;
            this.tableAdapterManager.hoadonTableAdapter = this.hoadonTableAdapter;
            this.tableAdapterManager.khachhangTableAdapter = null;
            this.tableAdapterManager.nguongocnhapTableAdapter = null;
            this.tableAdapterManager.nhanvienTableAdapter = null;
            this.tableAdapterManager.sanphamTableAdapter = this.sanphamTableAdapter;
            this.tableAdapterManager.taikhoanTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLBH.QLBH_GREENFRUITS1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cTHDTableAdapter
            // 
            this.cTHDTableAdapter.ClearBeforeFill = true;
            // 
            // hoadonTableAdapter
            // 
            this.hoadonTableAdapter.ClearBeforeFill = true;
            // 
            // sanphamBindingNavigator
            // 
            this.sanphamBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.sanphamBindingNavigator.BindingSource = this.sanphamBindingSource;
            this.sanphamBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.sanphamBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.sanphamBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.sanphamBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.sanphamBindingNavigatorSaveItem});
            this.sanphamBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.sanphamBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.sanphamBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.sanphamBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.sanphamBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.sanphamBindingNavigator.Name = "sanphamBindingNavigator";
            this.sanphamBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.sanphamBindingNavigator.Size = new System.Drawing.Size(1112, 27);
            this.sanphamBindingNavigator.TabIndex = 0;
            this.sanphamBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // sanphamBindingNavigatorSaveItem
            // 
            this.sanphamBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sanphamBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("sanphamBindingNavigatorSaveItem.Image")));
            this.sanphamBindingNavigatorSaveItem.Name = "sanphamBindingNavigatorSaveItem";
            this.sanphamBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.sanphamBindingNavigatorSaveItem.Text = "Save Data";
            this.sanphamBindingNavigatorSaveItem.Click += new System.EventHandler(this.sanphamBindingNavigatorSaveItem_Click);
            // 
            // dgSP
            // 
            this.dgSP.AutoGenerateColumns = false;
            this.dgSP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMasp,
            this.colTensp,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.colGiatien,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.dgSP.DataSource = this.sanphamBindingSource;
            this.dgSP.Location = new System.Drawing.Point(0, 44);
            this.dgSP.Name = "dgSP";
            this.dgSP.RowHeadersWidth = 51;
            this.dgSP.RowTemplate.Height = 24;
            this.dgSP.Size = new System.Drawing.Size(437, 636);
            this.dgSP.TabIndex = 1;
            this.dgSP.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSP_CellDoubleClick);
            // 
            // colMasp
            // 
            this.colMasp.DataPropertyName = "masp";
            this.colMasp.HeaderText = "Mã SP";
            this.colMasp.MinimumWidth = 6;
            this.colMasp.Name = "colMasp";
            this.colMasp.Visible = false;
            // 
            // colTensp
            // 
            this.colTensp.DataPropertyName = "tensp";
            this.colTensp.HeaderText = "Tên SP";
            this.colTensp.MinimumWidth = 6;
            this.colTensp.Name = "colTensp";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "soluong";
            this.dataGridViewTextBoxColumn3.HeaderText = "Số Lượng";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "donvi";
            this.dataGridViewTextBoxColumn4.HeaderText = "Đơn Vị";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // colGiatien
            // 
            this.colGiatien.DataPropertyName = "giatien";
            this.colGiatien.HeaderText = "Gía Tiền";
            this.colGiatien.MinimumWidth = 6;
            this.colGiatien.Name = "colGiatien";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "manguongoc";
            this.dataGridViewTextBoxColumn6.HeaderText = "Mã Nguồn Gốc";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ghichu";
            this.dataGridViewTextBoxColumn7.HeaderText = "Ghi Chú";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // hoadonBindingSource
            // 
            this.hoadonBindingSource.DataMember = "hoadon";
            this.hoadonBindingSource.DataSource = this.qLBH_GREENFRUITS1DataSet;
            // 
            // mahdTextBox
            // 
            this.mahdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hoadonBindingSource, "mahd", true));
            this.mahdTextBox.Location = new System.Drawing.Point(613, 137);
            this.mahdTextBox.Name = "mahdTextBox";
            this.mahdTextBox.Size = new System.Drawing.Size(283, 28);
            this.mahdTextBox.TabIndex = 3;
            // 
            // makhTextBox
            // 
            this.makhTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hoadonBindingSource, "makh", true));
            this.makhTextBox.Location = new System.Drawing.Point(613, 171);
            this.makhTextBox.Name = "makhTextBox";
            this.makhTextBox.Size = new System.Drawing.Size(283, 28);
            this.makhTextBox.TabIndex = 5;
            // 
            // tenkhTextBox
            // 
            this.tenkhTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hoadonBindingSource, "tenkh", true));
            this.tenkhTextBox.Location = new System.Drawing.Point(613, 205);
            this.tenkhTextBox.Name = "tenkhTextBox";
            this.tenkhTextBox.Size = new System.Drawing.Size(283, 28);
            this.tenkhTextBox.TabIndex = 7;
            // 
            // tongTextBox
            // 
            this.tongTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hoadonBindingSource, "tong", true));
            this.tongTextBox.Location = new System.Drawing.Point(613, 280);
            this.tongTextBox.Name = "tongTextBox";
            this.tongTextBox.Size = new System.Drawing.Size(283, 28);
            this.tongTextBox.TabIndex = 11;
            // 
            // cTHDBindingSource
            // 
            this.cTHDBindingSource.DataMember = "FK_CTHD_hoadon";
            this.cTHDBindingSource.DataSource = this.hoadonBindingSource;
            // 
            // dgCTHD
            // 
            this.dgCTHD.AutoGenerateColumns = false;
            this.dgCTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCTHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.cMasp,
            this.cSoluong,
            this.cTongtien});
            this.dgCTHD.DataSource = this.cTHDBindingSource;
            this.dgCTHD.Location = new System.Drawing.Point(469, 321);
            this.dgCTHD.Name = "dgCTHD";
            this.dgCTHD.RowHeadersWidth = 51;
            this.dgCTHD.RowTemplate.Height = 24;
            this.dgCTHD.Size = new System.Drawing.Size(621, 345);
            this.dgCTHD.TabIndex = 12;
            this.dgCTHD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCTHD_CellContentClick);
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "macthd";
            this.dataGridViewTextBoxColumn8.HeaderText = "macthd";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "manv";
            this.dataGridViewTextBoxColumn9.HeaderText = "manv";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "mahd";
            this.dataGridViewTextBoxColumn10.HeaderText = "mahd";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // cMasp
            // 
            this.cMasp.DataPropertyName = "masp";
            this.cMasp.HeaderText = "masp";
            this.cMasp.MinimumWidth = 6;
            this.cMasp.Name = "cMasp";
            this.cMasp.Width = 125;
            // 
            // cSoluong
            // 
            this.cSoluong.DataPropertyName = "soluong";
            this.cSoluong.HeaderText = "soluong";
            this.cSoluong.MinimumWidth = 6;
            this.cSoluong.Name = "cSoluong";
            this.cSoluong.Width = 125;
            // 
            // cTongtien
            // 
            this.cTongtien.DataPropertyName = "tongtien";
            this.cTongtien.HeaderText = "tongtien";
            this.cTongtien.MinimumWidth = 6;
            this.cTongtien.Name = "cTongtien";
            this.cTongtien.Width = 125;
            // 
            // button_taohoadon
            // 
            this.button_taohoadon.Location = new System.Drawing.Point(531, 44);
            this.button_taohoadon.Name = "button_taohoadon";
            this.button_taohoadon.Size = new System.Drawing.Size(150, 41);
            this.button_taohoadon.TabIndex = 13;
            this.button_taohoadon.Text = "Tạo hóa đơn";
            this.button_taohoadon.UseVisualStyleBackColor = true;
            this.button_taohoadon.Click += new System.EventHandler(this.button_taohoadon_Click);
            // 
            // ngaymuaTextBox
            // 
            this.ngaymuaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hoadonBindingSource, "ngaymua", true));
            this.ngaymuaTextBox.Location = new System.Drawing.Point(613, 245);
            this.ngaymuaTextBox.Name = "ngaymuaTextBox";
            this.ngaymuaTextBox.Size = new System.Drawing.Size(154, 28);
            this.ngaymuaTextBox.TabIndex = 14;
            // 
            // button_thoat
            // 
            this.button_thoat.Location = new System.Drawing.Point(991, 44);
            this.button_thoat.Name = "button_thoat";
            this.button_thoat.Size = new System.Drawing.Size(79, 41);
            this.button_thoat.TabIndex = 15;
            this.button_thoat.Text = "Thoát";
            this.button_thoat.UseVisualStyleBackColor = true;
            this.button_thoat.Click += new System.EventHandler(this.button_thoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 710);
            this.Controls.Add(this.button_thoat);
            this.Controls.Add(ngaymuaLabel);
            this.Controls.Add(this.ngaymuaTextBox);
            this.Controls.Add(this.button_taohoadon);
            this.Controls.Add(this.dgCTHD);
            this.Controls.Add(mahdLabel);
            this.Controls.Add(this.mahdTextBox);
            this.Controls.Add(makhLabel);
            this.Controls.Add(this.makhTextBox);
            this.Controls.Add(tenkhLabel);
            this.Controls.Add(this.tenkhTextBox);
            this.Controls.Add(tongLabel);
            this.Controls.Add(this.tongTextBox);
            this.Controls.Add(this.dgSP);
            this.Controls.Add(this.sanphamBindingNavigator);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLBH_GREENFRUITS1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanphamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanphamBindingNavigator)).EndInit();
            this.sanphamBindingNavigator.ResumeLayout(false);
            this.sanphamBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoadonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTHDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCTHD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QLBH_GREENFRUITS1DataSet qLBH_GREENFRUITS1DataSet;
        private System.Windows.Forms.BindingSource sanphamBindingSource;
        private QLBH_GREENFRUITS1DataSetTableAdapters.sanphamTableAdapter sanphamTableAdapter;
        private QLBH_GREENFRUITS1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator sanphamBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton sanphamBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView dgSP;
        private QLBH_GREENFRUITS1DataSetTableAdapters.hoadonTableAdapter hoadonTableAdapter;
        private System.Windows.Forms.BindingSource hoadonBindingSource;
        private QLBH_GREENFRUITS1DataSetTableAdapters.CTHDTableAdapter cTHDTableAdapter;
        private System.Windows.Forms.TextBox mahdTextBox;
        private System.Windows.Forms.TextBox makhTextBox;
        private System.Windows.Forms.TextBox tenkhTextBox;
        private System.Windows.Forms.TextBox tongTextBox;
        private System.Windows.Forms.BindingSource cTHDBindingSource;
        private System.Windows.Forms.DataGridView dgCTHD;
        private System.Windows.Forms.Button button_taohoadon;
        private System.Windows.Forms.TextBox ngaymuaTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMasp;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSoluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTongtien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMasp;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTensp;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiatien;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Button button_thoat;
    }
}