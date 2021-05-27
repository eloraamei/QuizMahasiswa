namespace QuizMahasiswa
{
    partial class ReportBarang011
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnExportintoExcel = new System.Windows.Forms.Button();
            this.btnExportintoPDF = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.quizMahasiswaDataSet = new QuizMahasiswa.QuizMahasiswaDataSet();
            this.tblbarangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_barangTableAdapter = new QuizMahasiswa.QuizMahasiswaDataSetTableAdapters.tbl_barangTableAdapter();
            this.idbarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namabarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namasupplierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizMahasiswaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblbarangBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(325, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Report Barang";
            // 
            // btnExportintoExcel
            // 
            this.btnExportintoExcel.AutoSize = true;
            this.btnExportintoExcel.Location = new System.Drawing.Point(558, 101);
            this.btnExportintoExcel.Name = "btnExportintoExcel";
            this.btnExportintoExcel.Size = new System.Drawing.Size(122, 27);
            this.btnExportintoExcel.TabIndex = 7;
            this.btnExportintoExcel.Text = "Export into Excel";
            this.btnExportintoExcel.UseVisualStyleBackColor = true;
            this.btnExportintoExcel.Click += new System.EventHandler(this.btnExportintoExcel_Click);
            // 
            // btnExportintoPDF
            // 
            this.btnExportintoPDF.AutoSize = true;
            this.btnExportintoPDF.Location = new System.Drawing.Point(120, 101);
            this.btnExportintoPDF.Name = "btnExportintoPDF";
            this.btnExportintoPDF.Size = new System.Drawing.Size(116, 27);
            this.btnExportintoPDF.TabIndex = 6;
            this.btnExportintoPDF.Text = "Export into PDF";
            this.btnExportintoPDF.UseVisualStyleBackColor = true;
            this.btnExportintoPDF.Click += new System.EventHandler(this.btnExportintoPDF_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idbarangDataGridViewTextBoxColumn,
            this.namabarangDataGridViewTextBoxColumn,
            this.hargaDataGridViewTextBoxColumn,
            this.stokDataGridViewTextBoxColumn,
            this.namasupplierDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblbarangBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(120, 157);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(560, 235);
            this.dataGridView1.TabIndex = 8;
            // 
            // quizMahasiswaDataSet
            // 
            this.quizMahasiswaDataSet.DataSetName = "QuizMahasiswaDataSet";
            this.quizMahasiswaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblbarangBindingSource
            // 
            this.tblbarangBindingSource.DataMember = "tbl_barang";
            this.tblbarangBindingSource.DataSource = this.quizMahasiswaDataSet;
            // 
            // tbl_barangTableAdapter
            // 
            this.tbl_barangTableAdapter.ClearBeforeFill = true;
            // 
            // idbarangDataGridViewTextBoxColumn
            // 
            this.idbarangDataGridViewTextBoxColumn.DataPropertyName = "id_barang";
            this.idbarangDataGridViewTextBoxColumn.HeaderText = "ID Barang";
            this.idbarangDataGridViewTextBoxColumn.Name = "idbarangDataGridViewTextBoxColumn";
            this.idbarangDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // namabarangDataGridViewTextBoxColumn
            // 
            this.namabarangDataGridViewTextBoxColumn.DataPropertyName = "nama_barang";
            this.namabarangDataGridViewTextBoxColumn.HeaderText = "Nama Barang";
            this.namabarangDataGridViewTextBoxColumn.Name = "namabarangDataGridViewTextBoxColumn";
            // 
            // hargaDataGridViewTextBoxColumn
            // 
            this.hargaDataGridViewTextBoxColumn.DataPropertyName = "harga";
            this.hargaDataGridViewTextBoxColumn.HeaderText = "Harga";
            this.hargaDataGridViewTextBoxColumn.Name = "hargaDataGridViewTextBoxColumn";
            // 
            // stokDataGridViewTextBoxColumn
            // 
            this.stokDataGridViewTextBoxColumn.DataPropertyName = "stok";
            this.stokDataGridViewTextBoxColumn.HeaderText = "Stok";
            this.stokDataGridViewTextBoxColumn.Name = "stokDataGridViewTextBoxColumn";
            // 
            // namasupplierDataGridViewTextBoxColumn
            // 
            this.namasupplierDataGridViewTextBoxColumn.DataPropertyName = "nama_supplier";
            this.namasupplierDataGridViewTextBoxColumn.HeaderText = "Nama Supplier";
            this.namasupplierDataGridViewTextBoxColumn.Name = "namasupplierDataGridViewTextBoxColumn";
            // 
            // ReportBarang011
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExportintoExcel);
            this.Controls.Add(this.btnExportintoPDF);
            this.Name = "ReportBarang011";
            this.Text = "ReportBarang011";
            this.Load += new System.EventHandler(this.ReportBarang011_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizMahasiswaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblbarangBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExportintoExcel;
        private System.Windows.Forms.Button btnExportintoPDF;
        private System.Windows.Forms.DataGridView dataGridView1;
        private QuizMahasiswaDataSet quizMahasiswaDataSet;
        private System.Windows.Forms.BindingSource tblbarangBindingSource;
        private QuizMahasiswaDataSetTableAdapters.tbl_barangTableAdapter tbl_barangTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idbarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namabarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namasupplierDataGridViewTextBoxColumn;
    }
}