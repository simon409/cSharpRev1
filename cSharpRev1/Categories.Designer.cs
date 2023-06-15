
namespace cSharpRev1
{
    partial class Categories
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
            this.libelle_TB = new System.Windows.Forms.TextBox();
            this.taux_tva_TB = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.save = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.gestionStockDataSet = new cSharpRev1.gestionStockDataSet();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriesTableAdapter = new cSharpRev1.gestionStockDataSetTableAdapters.CategoriesTableAdapter();
            this.idCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libelleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tvaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionStockDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Libellé";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Taux TVA";
            // 
            // libelle_TB
            // 
            this.libelle_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.libelle_TB.Location = new System.Drawing.Point(170, 38);
            this.libelle_TB.Name = "libelle_TB";
            this.libelle_TB.Size = new System.Drawing.Size(235, 26);
            this.libelle_TB.TabIndex = 2;
            // 
            // taux_tva_TB
            // 
            this.taux_tva_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.taux_tva_TB.Location = new System.Drawing.Point(170, 77);
            this.taux_tva_TB.Name = "taux_tva_TB";
            this.taux_tva_TB.Size = new System.Drawing.Size(235, 26);
            this.taux_tva_TB.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCDataGridViewTextBoxColumn,
            this.libelleDataGridViewTextBoxColumn,
            this.tvaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.categoriesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 152);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(677, 253);
            this.dataGridView1.TabIndex = 4;
            // 
            // save
            // 
            this.save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.save.Location = new System.Drawing.Point(594, 35);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(95, 32);
            this.save.TabIndex = 5;
            this.save.Text = "&Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.exit.Location = new System.Drawing.Point(594, 74);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(95, 32);
            this.exit.TabIndex = 6;
            this.exit.Text = "&Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // gestionStockDataSet
            // 
            this.gestionStockDataSet.DataSetName = "gestionStockDataSet";
            this.gestionStockDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "Categories";
            this.categoriesBindingSource.DataSource = this.gestionStockDataSet;
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // idCDataGridViewTextBoxColumn
            // 
            this.idCDataGridViewTextBoxColumn.DataPropertyName = "IdC";
            this.idCDataGridViewTextBoxColumn.HeaderText = "IdC";
            this.idCDataGridViewTextBoxColumn.Name = "idCDataGridViewTextBoxColumn";
            this.idCDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // libelleDataGridViewTextBoxColumn
            // 
            this.libelleDataGridViewTextBoxColumn.DataPropertyName = "libelle";
            this.libelleDataGridViewTextBoxColumn.HeaderText = "libelle";
            this.libelleDataGridViewTextBoxColumn.Name = "libelleDataGridViewTextBoxColumn";
            // 
            // tvaDataGridViewTextBoxColumn
            // 
            this.tvaDataGridViewTextBoxColumn.DataPropertyName = "tva";
            this.tvaDataGridViewTextBoxColumn.HeaderText = "tva";
            this.tvaDataGridViewTextBoxColumn.Name = "tvaDataGridViewTextBoxColumn";
            // 
            // Categories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 417);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.save);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.taux_tva_TB);
            this.Controls.Add(this.libelle_TB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Categories";
            this.Text = "Categories";
            this.Load += new System.EventHandler(this.Categories_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionStockDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox libelle_TB;
        private System.Windows.Forms.TextBox taux_tva_TB;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button exit;
        private gestionStockDataSet gestionStockDataSet;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private gestionStockDataSetTableAdapters.CategoriesTableAdapter categoriesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn libelleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tvaDataGridViewTextBoxColumn;
    }
}