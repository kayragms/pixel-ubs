namespace piXel_UBS
{
    partial class goruntu
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kisiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ubsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ubsDataSet = new piXel_UBS.ubsDataSet();
            this.ubsDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.kisiTableAdapter = new piXel_UBS.ubsDataSetTableAdapters.kisiTableAdapter();
            this.isimsoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dogumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.veliadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.velitelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.okulDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sınıfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rutbeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aktifDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hobileriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kisiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ubsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ubsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ubsDataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.isimsoDataGridViewTextBoxColumn,
            this.tcDataGridViewTextBoxColumn,
            this.telDataGridViewTextBoxColumn,
            this.dogumDataGridViewTextBoxColumn,
            this.veliadDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.velitelDataGridViewTextBoxColumn,
            this.okulDataGridViewTextBoxColumn,
            this.sınıfDataGridViewTextBoxColumn,
            this.hastaDataGridViewTextBoxColumn,
            this.ilcDataGridViewTextBoxColumn,
            this.mailDataGridViewTextBoxColumn,
            this.rutbeDataGridViewTextBoxColumn,
            this.alanDataGridViewTextBoxColumn,
            this.aktifDataGridViewTextBoxColumn,
            this.hobileriDataGridViewTextBoxColumn,
            this.adresDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kisiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1230, 602);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // kisiBindingSource
            // 
            this.kisiBindingSource.DataMember = "kisi";
            this.kisiBindingSource.DataSource = this.ubsDataSetBindingSource;
            // 
            // ubsDataSetBindingSource
            // 
            this.ubsDataSetBindingSource.DataSource = this.ubsDataSet;
            this.ubsDataSetBindingSource.Position = 0;
            // 
            // ubsDataSet
            // 
            this.ubsDataSet.DataSetName = "ubsDataSet";
            this.ubsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ubsDataSetBindingSource1
            // 
            this.ubsDataSetBindingSource1.DataSource = this.ubsDataSet;
            this.ubsDataSetBindingSource1.Position = 0;
            // 
            // kisiTableAdapter
            // 
            this.kisiTableAdapter.ClearBeforeFill = true;
            // 
            // isimsoDataGridViewTextBoxColumn
            // 
            this.isimsoDataGridViewTextBoxColumn.DataPropertyName = "isimso";
            this.isimsoDataGridViewTextBoxColumn.HeaderText = "isimso";
            this.isimsoDataGridViewTextBoxColumn.Name = "isimsoDataGridViewTextBoxColumn";
            // 
            // tcDataGridViewTextBoxColumn
            // 
            this.tcDataGridViewTextBoxColumn.DataPropertyName = "tc";
            this.tcDataGridViewTextBoxColumn.HeaderText = "tc";
            this.tcDataGridViewTextBoxColumn.Name = "tcDataGridViewTextBoxColumn";
            // 
            // telDataGridViewTextBoxColumn
            // 
            this.telDataGridViewTextBoxColumn.DataPropertyName = "tel";
            this.telDataGridViewTextBoxColumn.HeaderText = "tel";
            this.telDataGridViewTextBoxColumn.Name = "telDataGridViewTextBoxColumn";
            // 
            // dogumDataGridViewTextBoxColumn
            // 
            this.dogumDataGridViewTextBoxColumn.DataPropertyName = "dogum";
            this.dogumDataGridViewTextBoxColumn.HeaderText = "dogum";
            this.dogumDataGridViewTextBoxColumn.Name = "dogumDataGridViewTextBoxColumn";
            // 
            // veliadDataGridViewTextBoxColumn
            // 
            this.veliadDataGridViewTextBoxColumn.DataPropertyName = "veliad";
            this.veliadDataGridViewTextBoxColumn.HeaderText = "veliad";
            this.veliadDataGridViewTextBoxColumn.Name = "veliadDataGridViewTextBoxColumn";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // velitelDataGridViewTextBoxColumn
            // 
            this.velitelDataGridViewTextBoxColumn.DataPropertyName = "velitel";
            this.velitelDataGridViewTextBoxColumn.HeaderText = "velitel";
            this.velitelDataGridViewTextBoxColumn.Name = "velitelDataGridViewTextBoxColumn";
            // 
            // okulDataGridViewTextBoxColumn
            // 
            this.okulDataGridViewTextBoxColumn.DataPropertyName = "okul";
            this.okulDataGridViewTextBoxColumn.HeaderText = "okul";
            this.okulDataGridViewTextBoxColumn.Name = "okulDataGridViewTextBoxColumn";
            // 
            // sınıfDataGridViewTextBoxColumn
            // 
            this.sınıfDataGridViewTextBoxColumn.DataPropertyName = "sınıf";
            this.sınıfDataGridViewTextBoxColumn.HeaderText = "sınıf";
            this.sınıfDataGridViewTextBoxColumn.Name = "sınıfDataGridViewTextBoxColumn";
            // 
            // hastaDataGridViewTextBoxColumn
            // 
            this.hastaDataGridViewTextBoxColumn.DataPropertyName = "hasta";
            this.hastaDataGridViewTextBoxColumn.HeaderText = "hasta";
            this.hastaDataGridViewTextBoxColumn.Name = "hastaDataGridViewTextBoxColumn";
            // 
            // ilcDataGridViewTextBoxColumn
            // 
            this.ilcDataGridViewTextBoxColumn.DataPropertyName = "ilc";
            this.ilcDataGridViewTextBoxColumn.HeaderText = "ilc";
            this.ilcDataGridViewTextBoxColumn.Name = "ilcDataGridViewTextBoxColumn";
            // 
            // mailDataGridViewTextBoxColumn
            // 
            this.mailDataGridViewTextBoxColumn.DataPropertyName = "mail";
            this.mailDataGridViewTextBoxColumn.HeaderText = "mail";
            this.mailDataGridViewTextBoxColumn.Name = "mailDataGridViewTextBoxColumn";
            // 
            // rutbeDataGridViewTextBoxColumn
            // 
            this.rutbeDataGridViewTextBoxColumn.DataPropertyName = "rutbe";
            this.rutbeDataGridViewTextBoxColumn.HeaderText = "rutbe";
            this.rutbeDataGridViewTextBoxColumn.Name = "rutbeDataGridViewTextBoxColumn";
            // 
            // alanDataGridViewTextBoxColumn
            // 
            this.alanDataGridViewTextBoxColumn.DataPropertyName = "alan";
            this.alanDataGridViewTextBoxColumn.HeaderText = "alan";
            this.alanDataGridViewTextBoxColumn.Name = "alanDataGridViewTextBoxColumn";
            // 
            // aktifDataGridViewTextBoxColumn
            // 
            this.aktifDataGridViewTextBoxColumn.DataPropertyName = "aktif";
            this.aktifDataGridViewTextBoxColumn.HeaderText = "aktif";
            this.aktifDataGridViewTextBoxColumn.Name = "aktifDataGridViewTextBoxColumn";
            // 
            // hobileriDataGridViewTextBoxColumn
            // 
            this.hobileriDataGridViewTextBoxColumn.DataPropertyName = "hobileri";
            this.hobileriDataGridViewTextBoxColumn.HeaderText = "hobileri";
            this.hobileriDataGridViewTextBoxColumn.Name = "hobileriDataGridViewTextBoxColumn";
            // 
            // adresDataGridViewTextBoxColumn
            // 
            this.adresDataGridViewTextBoxColumn.DataPropertyName = "adres";
            this.adresDataGridViewTextBoxColumn.HeaderText = "adres";
            this.adresDataGridViewTextBoxColumn.Name = "adresDataGridViewTextBoxColumn";
            // 
            // goruntu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 623);
            this.Controls.Add(this.dataGridView1);
            this.Name = "goruntu";
            this.Text = "goruntu";
            this.Load += new System.EventHandler(this.goruntu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kisiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ubsDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ubsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ubsDataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource ubsDataSetBindingSource;
        private ubsDataSet ubsDataSet;
        private System.Windows.Forms.BindingSource ubsDataSetBindingSource1;
        private System.Windows.Forms.BindingSource kisiBindingSource;
        private ubsDataSetTableAdapters.kisiTableAdapter kisiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn isimsoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dogumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn veliadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn velitelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn okulDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sınıfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rutbeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aktifDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hobileriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
    }
}