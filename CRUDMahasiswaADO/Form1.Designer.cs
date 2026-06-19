namespace CRUDMahasiswaADO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtNIM = new System.Windows.Forms.TextBox();
            this.mahasiswaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBAkademikADODataSet = new CRUDMahasiswaADO.DBAkademikADODataSet();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.cmbJK = new System.Windows.Forms.ComboBox();
            this.dtpTanggalLahir = new System.Windows.Forms.DateTimePicker();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.txtKodeProdi = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.btnReset = new System.Windows.Forms.Button();
            this.btnTestInjection = new System.Windows.Forms.Button();
            this.lblCountMhs = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCari = new System.Windows.Forms.Button();
            this.fotoMhs = new System.Windows.Forms.PictureBox();
            this.btnUploadGambar = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnImportformExcel = new System.Windows.Forms.Button();
            this.btnImpDb = new System.Windows.Forms.Button();
            this.mahasiswaTableAdapter = new CRUDMahasiswaADO.DBAkademikADODataSetTableAdapters.MahasiswaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBAkademikADODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoMhs)).BeginInit();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(34, 56);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(38, 20);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "NIM\r\n";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(34, 96);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(51, 20);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "Nama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Alamat";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(34, 191);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(105, 20);
            this.Label5.TabIndex = 3;
            this.Label5.Text = "Tanggal Lahir";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(34, 144);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(106, 20);
            this.Label4.TabIndex = 4;
            this.Label4.Text = "Jenis Kelamin";
            // 
            // txtNIM
            // 
            this.txtNIM.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mahasiswaBindingSource, "NIM", true));
            this.txtNIM.Location = new System.Drawing.Point(198, 56);
            this.txtNIM.Name = "txtNIM";
            this.txtNIM.Size = new System.Drawing.Size(185, 26);
            this.txtNIM.TabIndex = 5;
            // 
            // mahasiswaBindingSource
            // 
            this.mahasiswaBindingSource.DataMember = "Mahasiswa";
            this.mahasiswaBindingSource.DataSource = this.dBAkademikADODataSet;
            // 
            // dBAkademikADODataSet
            // 
            this.dBAkademikADODataSet.DataSetName = "DBAkademikADODataSet";
            this.dBAkademikADODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtNama
            // 
            this.txtNama.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mahasiswaBindingSource, "Nama", true));
            this.txtNama.Location = new System.Drawing.Point(198, 96);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(185, 26);
            this.txtNama.TabIndex = 6;
            // 
            // cmbJK
            // 
            this.cmbJK.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mahasiswaBindingSource, "JenisKelamin", true));
            this.cmbJK.FormattingEnabled = true;
            this.cmbJK.Items.AddRange(new object[] {
            "L",
            "P"});
            this.cmbJK.Location = new System.Drawing.Point(198, 144);
            this.cmbJK.Name = "cmbJK";
            this.cmbJK.Size = new System.Drawing.Size(121, 28);
            this.cmbJK.TabIndex = 7;
            // 
            // dtpTanggalLahir
            // 
            this.dtpTanggalLahir.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mahasiswaBindingSource, "TanggalLahir", true));
            this.dtpTanggalLahir.Location = new System.Drawing.Point(198, 189);
            this.dtpTanggalLahir.Name = "dtpTanggalLahir";
            this.dtpTanggalLahir.Size = new System.Drawing.Size(200, 26);
            this.dtpTanggalLahir.TabIndex = 8;
            this.dtpTanggalLahir.Value = new System.DateTime(2026, 4, 9, 18, 48, 21, 0);
            // 
            // txtAlamat
            // 
            this.txtAlamat.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mahasiswaBindingSource, "Alamat", true));
            this.txtAlamat.Location = new System.Drawing.Point(198, 240);
            this.txtAlamat.Multiline = true;
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(200, 52);
            this.txtAlamat.TabIndex = 9;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(34, 323);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(86, 20);
            this.Label6.TabIndex = 10;
            this.Label6.Text = "Kode Prodi";
            // 
            // txtKodeProdi
            // 
            this.txtKodeProdi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mahasiswaBindingSource, "KodeProdi", true));
            this.txtKodeProdi.Location = new System.Drawing.Point(198, 317);
            this.txtKodeProdi.Multiline = true;
            this.txtKodeProdi.Name = "txtKodeProdi";
            this.txtKodeProdi.Size = new System.Drawing.Size(200, 26);
            this.txtKodeProdi.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 442);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(949, 216);
            this.dataGridView1.TabIndex = 18;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(541, 55);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(84, 32);
            this.btnConnect.TabIndex = 21;
            this.btnConnect.Text = "Open";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(541, 293);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(84, 34);
            this.btnLoad.TabIndex = 22;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(541, 115);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(84, 31);
            this.btnInsert.TabIndex = 23;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(541, 178);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(84, 37);
            this.btnUpdate.TabIndex = 24;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(541, 236);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(84, 28);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.mahasiswaBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(949, 33);
            this.bindingNavigator1.TabIndex = 26;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(699, 96);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(122, 37);
            this.btnReset.TabIndex = 27;
            this.btnReset.Text = "Reset Data";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnResetData_Click);
            // 
            // btnTestInjection
            // 
            this.btnTestInjection.BackColor = System.Drawing.Color.Red;
            this.btnTestInjection.ForeColor = System.Drawing.Color.White;
            this.btnTestInjection.Location = new System.Drawing.Point(699, 50);
            this.btnTestInjection.Name = "btnTestInjection";
            this.btnTestInjection.Size = new System.Drawing.Size(126, 32);
            this.btnTestInjection.TabIndex = 28;
            this.btnTestInjection.Text = "Test";
            this.btnTestInjection.UseVisualStyleBackColor = false;
            this.btnTestInjection.Click += new System.EventHandler(this.btnTestInjection_Click);
            // 
            // lblCountMhs
            // 
            this.lblCountMhs.AutoSize = true;
            this.lblCountMhs.Location = new System.Drawing.Point(695, 189);
            this.lblCountMhs.Name = "lblCountMhs";
            this.lblCountMhs.Size = new System.Drawing.Size(144, 20);
            this.lblCountMhs.TabIndex = 29;
            this.lblCountMhs.Text = "Total Mahasiswa: 0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(699, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 33);
            this.button1.TabIndex = 30;
            this.button1.Text = "Rekap data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCari
            // 
            this.btnCari.Location = new System.Drawing.Point(400, 58);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(82, 29);
            this.btnCari.TabIndex = 31;
            this.btnCari.Text = "Cari";
            this.btnCari.UseVisualStyleBackColor = true;
            // 
            // fotoMhs
            // 
            this.fotoMhs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fotoMhs.Location = new System.Drawing.Point(424, 212);
            this.fotoMhs.Name = "fotoMhs";
            this.fotoMhs.Size = new System.Drawing.Size(100, 103);
            this.fotoMhs.TabIndex = 32;
            this.fotoMhs.TabStop = false;
            // 
            // btnUploadGambar
            // 
            this.btnUploadGambar.Location = new System.Drawing.Point(400, 323);
            this.btnUploadGambar.Name = "btnUploadGambar";
            this.btnUploadGambar.Size = new System.Drawing.Size(141, 30);
            this.btnUploadGambar.TabIndex = 33;
            this.btnUploadGambar.Text = "Upload Gambar";
            this.btnUploadGambar.UseVisualStyleBackColor = true;
            this.btnUploadGambar.Click += new System.EventHandler(this.btnUploadGambar_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(541, 347);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(86, 33);
            this.btnRefresh.TabIndex = 34;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnImportformExcel
            // 
            this.btnImportformExcel.Location = new System.Drawing.Point(699, 218);
            this.btnImportformExcel.Name = "btnImportformExcel";
            this.btnImportformExcel.Size = new System.Drawing.Size(100, 71);
            this.btnImportformExcel.TabIndex = 35;
            this.btnImportformExcel.Text = "Import form Excel";
            this.btnImportformExcel.UseVisualStyleBackColor = true;
            this.btnImportformExcel.Click += new System.EventHandler(this.btnImportformExcel_Click);
            // 
            // btnImpDb
            // 
            this.btnImpDb.Location = new System.Drawing.Point(699, 306);
            this.btnImpDb.Name = "btnImpDb";
            this.btnImpDb.Size = new System.Drawing.Size(100, 59);
            this.btnImpDb.TabIndex = 36;
            this.btnImpDb.Text = "Import to Database";
            this.btnImpDb.UseVisualStyleBackColor = true;
            this.btnImpDb.Click += new System.EventHandler(this.btnImpDb_Click);
            // 
            // mahasiswaTableAdapter
            // 
            this.mahasiswaTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 697);
            this.Controls.Add(this.btnImpDb);
            this.Controls.Add(this.btnImportformExcel);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnUploadGambar);
            this.Controls.Add(this.fotoMhs);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblCountMhs);
            this.Controls.Add(this.btnTestInjection);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtKodeProdi);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.txtAlamat);
            this.Controls.Add(this.dtpTanggalLahir);
            this.Controls.Add(this.cmbJK);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.txtNIM);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBAkademikADODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoMhs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Label5;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.TextBox txtNIM;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.DateTimePicker dtpTanggalLahir;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.Label Label6;
        private System.Windows.Forms.TextBox txtKodeProdi;
        private System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.ComboBox cmbJK;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
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
        private DBAkademikADODataSet dBAkademikADODataSet;
        private System.Windows.Forms.BindingSource mahasiswaBindingSource;
        private DBAkademikADODataSetTableAdapters.MahasiswaTableAdapter mahasiswaTableAdapter;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnTestInjection;
        private System.Windows.Forms.Label lblCountMhs;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.PictureBox fotoMhs;
        private System.Windows.Forms.Button btnUploadGambar;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnImportformExcel;
        private System.Windows.Forms.Button btnImpDb;
    }
}

