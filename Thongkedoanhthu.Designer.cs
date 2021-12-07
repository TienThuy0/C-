
namespace QLBH
{
    partial class Thongkedoanhthu
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Thongkedoanhthu));
            this.dataGridViewDoanhThu = new System.Windows.Forms.DataGridView();
            this.dataGridViewAVG = new System.Windows.Forms.DataGridView();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button_thongke = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button_thoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoanhThu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAVG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDoanhThu
            // 
            this.dataGridViewDoanhThu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDoanhThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDoanhThu.Location = new System.Drawing.Point(1, 142);
            this.dataGridViewDoanhThu.Name = "dataGridViewDoanhThu";
            this.dataGridViewDoanhThu.RowHeadersWidth = 51;
            this.dataGridViewDoanhThu.RowTemplate.Height = 24;
            this.dataGridViewDoanhThu.Size = new System.Drawing.Size(661, 411);
            this.dataGridViewDoanhThu.TabIndex = 7;
            this.dataGridViewDoanhThu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDoanhThu_CellContentClick);
            // 
            // dataGridViewAVG
            // 
            this.dataGridViewAVG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAVG.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridViewAVG.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewAVG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAVG.Location = new System.Drawing.Point(663, 3);
            this.dataGridViewAVG.Name = "dataGridViewAVG";
            this.dataGridViewAVG.RowHeadersWidth = 51;
            this.dataGridViewAVG.RowTemplate.Height = 24;
            this.dataGridViewAVG.Size = new System.Drawing.Size(480, 146);
            this.dataGridViewAVG.TabIndex = 5;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(663, 142);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(480, 411);
            this.chart1.TabIndex = 8;
            this.chart1.Text = "chart1";
            // 
            // button_thongke
            // 
            this.button_thongke.Location = new System.Drawing.Point(341, 87);
            this.button_thongke.Name = "button_thongke";
            this.button_thongke.Size = new System.Drawing.Size(115, 39);
            this.button_thongke.TabIndex = 11;
            this.button_thongke.Text = "Thống kê";
            this.button_thongke.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(128, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 37);
            this.label1.TabIndex = 10;
            this.label1.Text = "THỐNG KÊ DOANH THU";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(185, 93);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(135, 28);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // button_thoat
            // 
            this.button_thoat.Image = ((System.Drawing.Image)(resources.GetObject("button_thoat.Image")));
            this.button_thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_thoat.Location = new System.Drawing.Point(523, 87);
            this.button_thoat.Name = "button_thoat";
            this.button_thoat.Size = new System.Drawing.Size(108, 39);
            this.button_thoat.TabIndex = 12;
            this.button_thoat.Text = "Thoát";
            this.button_thoat.UseVisualStyleBackColor = true;
            this.button_thoat.Click += new System.EventHandler(this.button_thoat_Click);
            // 
            // Thongkedoanhthu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1142, 552);
            this.Controls.Add(this.button_thoat);
            this.Controls.Add(this.button_thongke);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.dataGridViewDoanhThu);
            this.Controls.Add(this.dataGridViewAVG);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Thongkedoanhthu";
            this.Text = "Thongkedoanhthu";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoanhThu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAVG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDoanhThu;
        private System.Windows.Forms.DataGridView dataGridViewAVG;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button_thongke;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button_thoat;
    }
}