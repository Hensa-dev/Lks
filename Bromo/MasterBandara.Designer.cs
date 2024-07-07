namespace Bromo
{
    partial class MasterBandara
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
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodeIATADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kotaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.negaraIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlahTerminalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bandaraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bromoDataMasterBandara = new Bromo.BromoDataMasterBandara();
            this.bandaraTableAdapter = new Bromo.BromoDataMasterBandaraTableAdapters.BandaraTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Nama = new System.Windows.Forms.TextBox();
            this.KodeAI = new System.Windows.Forms.TextBox();
            this.Kota = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Alamat = new System.Windows.Forms.RichTextBox();
            this.JumlahT = new System.Windows.Forms.NumericUpDown();
            this.Simpan = new System.Windows.Forms.Button();
            this.Batal = new System.Windows.Forms.Button();
            this.Bandara = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandaraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bromoDataMasterBandara)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JumlahT)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Master Bandara";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(441, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Semua bandara terdaftar yang akan muncul disini";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.namaDataGridViewTextBoxColumn,
            this.kodeIATADataGridViewTextBoxColumn,
            this.kotaDataGridViewTextBoxColumn,
            this.negaraIDDataGridViewTextBoxColumn,
            this.jumlahTerminalDataGridViewTextBoxColumn,
            this.alamatDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bandaraBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(35, 136);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(809, 216);
            this.dataGridView1.TabIndex = 2;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 150;
            // 
            // namaDataGridViewTextBoxColumn
            // 
            this.namaDataGridViewTextBoxColumn.DataPropertyName = "Nama";
            this.namaDataGridViewTextBoxColumn.HeaderText = "Nama";
            this.namaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.namaDataGridViewTextBoxColumn.Name = "namaDataGridViewTextBoxColumn";
            this.namaDataGridViewTextBoxColumn.Width = 150;
            // 
            // kodeIATADataGridViewTextBoxColumn
            // 
            this.kodeIATADataGridViewTextBoxColumn.DataPropertyName = "KodeIATA";
            this.kodeIATADataGridViewTextBoxColumn.HeaderText = "KodeIATA";
            this.kodeIATADataGridViewTextBoxColumn.MinimumWidth = 8;
            this.kodeIATADataGridViewTextBoxColumn.Name = "kodeIATADataGridViewTextBoxColumn";
            this.kodeIATADataGridViewTextBoxColumn.Width = 150;
            // 
            // kotaDataGridViewTextBoxColumn
            // 
            this.kotaDataGridViewTextBoxColumn.DataPropertyName = "Kota";
            this.kotaDataGridViewTextBoxColumn.HeaderText = "Kota";
            this.kotaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.kotaDataGridViewTextBoxColumn.Name = "kotaDataGridViewTextBoxColumn";
            this.kotaDataGridViewTextBoxColumn.Width = 150;
            // 
            // negaraIDDataGridViewTextBoxColumn
            // 
            this.negaraIDDataGridViewTextBoxColumn.DataPropertyName = "NegaraID";
            this.negaraIDDataGridViewTextBoxColumn.HeaderText = "NegaraID";
            this.negaraIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.negaraIDDataGridViewTextBoxColumn.Name = "negaraIDDataGridViewTextBoxColumn";
            this.negaraIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // jumlahTerminalDataGridViewTextBoxColumn
            // 
            this.jumlahTerminalDataGridViewTextBoxColumn.DataPropertyName = "JumlahTerminal";
            this.jumlahTerminalDataGridViewTextBoxColumn.HeaderText = "JumlahTerminal";
            this.jumlahTerminalDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.jumlahTerminalDataGridViewTextBoxColumn.Name = "jumlahTerminalDataGridViewTextBoxColumn";
            this.jumlahTerminalDataGridViewTextBoxColumn.Width = 150;
            // 
            // alamatDataGridViewTextBoxColumn
            // 
            this.alamatDataGridViewTextBoxColumn.DataPropertyName = "Alamat";
            this.alamatDataGridViewTextBoxColumn.HeaderText = "Alamat";
            this.alamatDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.alamatDataGridViewTextBoxColumn.Name = "alamatDataGridViewTextBoxColumn";
            this.alamatDataGridViewTextBoxColumn.Width = 150;
            // 
            // bandaraBindingSource
            // 
            this.bandaraBindingSource.DataMember = "Bandara";
            this.bandaraBindingSource.DataSource = this.bromoDataMasterBandara;
            // 
            // bromoDataMasterBandara
            // 
            this.bromoDataMasterBandara.DataSetName = "BromoDataMasterBandara";
            this.bromoDataMasterBandara.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bandaraTableAdapter
            // 
            this.bandaraTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 394);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nama";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 438);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Kode AITA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 480);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Kota";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 524);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Bandara";
            // 
            // Nama
            // 
            this.Nama.Location = new System.Drawing.Point(127, 394);
            this.Nama.Name = "Nama";
            this.Nama.Size = new System.Drawing.Size(222, 26);
            this.Nama.TabIndex = 7;
            // 
            // KodeAI
            // 
            this.KodeAI.Location = new System.Drawing.Point(127, 438);
            this.KodeAI.Name = "KodeAI";
            this.KodeAI.Size = new System.Drawing.Size(222, 26);
            this.KodeAI.TabIndex = 8;
            // 
            // Kota
            // 
            this.Kota.Location = new System.Drawing.Point(127, 480);
            this.Kota.Name = "Kota";
            this.Kota.Size = new System.Drawing.Size(222, 26);
            this.Kota.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(409, 397);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Jumlah Terminal";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(412, 438);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Alamat";
            // 
            // Alamat
            // 
            this.Alamat.Location = new System.Drawing.Point(550, 441);
            this.Alamat.Name = "Alamat";
            this.Alamat.Size = new System.Drawing.Size(250, 124);
            this.Alamat.TabIndex = 13;
            this.Alamat.Text = "";
            // 
            // JumlahT
            // 
            this.JumlahT.Location = new System.Drawing.Point(550, 394);
            this.JumlahT.Name = "JumlahT";
            this.JumlahT.Size = new System.Drawing.Size(250, 26);
            this.JumlahT.TabIndex = 14;
            // 
            // Simpan
            // 
            this.Simpan.Location = new System.Drawing.Point(697, 584);
            this.Simpan.Name = "Simpan";
            this.Simpan.Size = new System.Drawing.Size(103, 35);
            this.Simpan.TabIndex = 15;
            this.Simpan.Text = "Simpan";
            this.Simpan.UseVisualStyleBackColor = true;
            this.Simpan.Click += new System.EventHandler(this.Simpan_Click);
            // 
            // Batal
            // 
            this.Batal.Location = new System.Drawing.Point(588, 584);
            this.Batal.Name = "Batal";
            this.Batal.Size = new System.Drawing.Size(103, 35);
            this.Batal.TabIndex = 16;
            this.Batal.Text = "Batal";
            this.Batal.UseVisualStyleBackColor = true;
            this.Batal.Click += new System.EventHandler(this.Batal_Click);
            // 
            // Bandara
            // 
            this.Bandara.Location = new System.Drawing.Point(127, 524);
            this.Bandara.Name = "Bandara";
            this.Bandara.Size = new System.Drawing.Size(222, 26);
            this.Bandara.TabIndex = 17;
            // 
            // MasterBandara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 689);
            this.Controls.Add(this.Bandara);
            this.Controls.Add(this.Batal);
            this.Controls.Add(this.Simpan);
            this.Controls.Add(this.JumlahT);
            this.Controls.Add(this.Alamat);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Kota);
            this.Controls.Add(this.KodeAI);
            this.Controls.Add(this.Nama);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MasterBandara";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MasterBandara";
            this.Load += new System.EventHandler(this.MasterBandara_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandaraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bromoDataMasterBandara)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JumlahT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private BromoDataMasterBandara bromoDataMasterBandara;
        private System.Windows.Forms.BindingSource bandaraBindingSource;
        private BromoDataMasterBandaraTableAdapters.BandaraTableAdapter bandaraTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodeIATADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kotaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn negaraIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlahTerminalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamatDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Nama;
        private System.Windows.Forms.TextBox KodeAI;
        private System.Windows.Forms.TextBox Kota;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox Alamat;
        private System.Windows.Forms.NumericUpDown JumlahT;
        private System.Windows.Forms.Button Simpan;
        private System.Windows.Forms.Button Batal;
        private System.Windows.Forms.TextBox Bandara;
    }
}