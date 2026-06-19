namespace CRUDMahasiswaADO
{
    partial class labelTahun
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.labelJudul = new System.Windows.Forms.Label();
            this.lblTahun = new System.Windows.Forms.Label();
            this.dtpTanggalMasuk = new System.Windows.Forms.DateTimePicker();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.cmbTipe = new System.Windows.Forms.ComboBox();
            this.chartProdi = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnDataMhs = new System.Windows.Forms.Button();
            this.btnDataMahasiswa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartProdi)).BeginInit();
            this.SuspendLayout();
            // 
            // labelJudul
            // 
            this.labelJudul.AutoSize = true;
            this.labelJudul.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJudul.Location = new System.Drawing.Point(280, 20);
            this.labelJudul.Name = "labelJudul";
            this.labelJudul.Size = new System.Drawing.Size(234, 20);
            this.labelJudul.TabIndex = 0;
            this.labelJudul.Text = "REKAP DATA MAHASISWA";
            // 
            // lblTahun
            // 
            this.lblTahun.AutoSize = true;
            this.lblTahun.Location = new System.Drawing.Point(30, 70);
            this.lblTahun.Name = "lblTahun";
            this.lblTahun.Size = new System.Drawing.Size(105, 20);
            this.lblTahun.TabIndex = 1;
            this.lblTahun.Text = "Tahun Masuk";
            // 
            // dtpTanggalMasuk
            // 
            this.dtpTanggalMasuk.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTanggalMasuk.Location = new System.Drawing.Point(141, 70);
            this.dtpTanggalMasuk.Name = "dtpTanggalMasuk";
            this.dtpTanggalMasuk.Size = new System.Drawing.Size(120, 26);
            this.dtpTanggalMasuk.TabIndex = 2;
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.Green;
            this.btnLoad.ForeColor = System.Drawing.Color.White;
            this.btnLoad.Location = new System.Drawing.Point(267, 68);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(84, 28);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(357, 67);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(80, 29);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // cmbTipe
            // 
            this.cmbTipe.FormattingEnabled = true;
            this.cmbTipe.Location = new System.Drawing.Point(600, 68);
            this.cmbTipe.Name = "cmbTipe";
            this.cmbTipe.Size = new System.Drawing.Size(150, 28);
            this.cmbTipe.TabIndex = 5;
            // 
            // chartProdi
            // 
            this.chartProdi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.chartProdi.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartProdi.Legends.Add(legend2);
            this.chartProdi.Location = new System.Drawing.Point(30, 110);
            this.chartProdi.Name = "chartProdi";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartProdi.Series.Add(series2);
            this.chartProdi.Size = new System.Drawing.Size(814, 531);
            this.chartProdi.TabIndex = 6;
            this.chartProdi.Text = "chart1";
            // 
            // btnDataMhs
            // 
            this.btnDataMhs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDataMhs.Location = new System.Drawing.Point(705, 695);
            this.btnDataMhs.Name = "btnDataMhs";
            this.btnDataMhs.Size = new System.Drawing.Size(130, 35);
            this.btnDataMhs.TabIndex = 7;
            this.btnDataMhs.Text = "DataMahasiswa";
            this.btnDataMhs.UseVisualStyleBackColor = true;
            // 
            // btnDataMahasiswa
            // 
            this.btnDataMahasiswa.Location = new System.Drawing.Point(688, 573);
            this.btnDataMahasiswa.Name = "btnDataMahasiswa";
            this.btnDataMahasiswa.Size = new System.Drawing.Size(134, 44);
            this.btnDataMahasiswa.TabIndex = 8;
            this.btnDataMahasiswa.Text = "DataMahasiswa";
            this.btnDataMahasiswa.UseVisualStyleBackColor = true;
            this.btnDataMahasiswa.Click += new System.EventHandler(this.btnDataMahasiswa_Click);
            // 
            // labelTahun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 645);
            this.Controls.Add(this.btnDataMahasiswa);
            this.Controls.Add(this.btnDataMhs);
            this.Controls.Add(this.chartProdi);
            this.Controls.Add(this.cmbTipe);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.dtpTanggalMasuk);
            this.Controls.Add(this.lblTahun);
            this.Controls.Add(this.labelJudul);
            this.Location = new System.Drawing.Point(30, 70);
            this.Name = "labelTahun";
            this.Text = "TahunMasuk";
            this.Load += new System.EventHandler(this.labelTahun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartProdi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelJudul;
        private System.Windows.Forms.Label lblTahun;
        private System.Windows.Forms.DateTimePicker dtpTanggalMasuk;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ComboBox cmbTipe;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartProdi;
        private System.Windows.Forms.Button btnDataMhs;
        private System.Windows.Forms.Button btnDataMahasiswa;
    }
}