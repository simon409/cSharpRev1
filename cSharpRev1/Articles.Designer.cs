
namespace cSharpRev1
{
    partial class Articles
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
            this.exit = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.prix_TB = new System.Windows.Forms.TextBox();
            this.des_TB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gestionStockDataSet1 = new cSharpRev1.gestionStockDataSet1();
            this.articlesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.articlesTableAdapter = new cSharpRev1.gestionStockDataSet1TableAdapters.ArticlesTableAdapter();
            this.refDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qte_TB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cat_CB = new System.Windows.Forms.ComboBox();
            this.gestionStockDataSet = new cSharpRev1.gestionStockDataSet();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriesTableAdapter = new cSharpRev1.gestionStockDataSetTableAdapters.CategoriesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionStockDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articlesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionStockDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.exit.Location = new System.Drawing.Point(644, 79);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(95, 32);
            this.exit.TabIndex = 13;
            this.exit.Text = "&Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // save
            // 
            this.save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.save.Location = new System.Drawing.Point(644, 40);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(95, 32);
            this.save.TabIndex = 12;
            this.save.Text = "&Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.refDataGridViewTextBoxColumn,
            this.desDataGridViewTextBoxColumn,
            this.prixDataGridViewTextBoxColumn,
            this.qtesDataGridViewTextBoxColumn,
            this.idcDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.articlesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 221);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(776, 253);
            this.dataGridView1.TabIndex = 11;
            // 
            // prix_TB
            // 
            this.prix_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.prix_TB.Location = new System.Drawing.Point(240, 84);
            this.prix_TB.Name = "prix_TB";
            this.prix_TB.Size = new System.Drawing.Size(235, 26);
            this.prix_TB.TabIndex = 10;
            // 
            // des_TB
            // 
            this.des_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.des_TB.Location = new System.Drawing.Point(240, 43);
            this.des_TB.Name = "des_TB";
            this.des_TB.Size = new System.Drawing.Size(235, 26);
            this.des_TB.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Prix";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Désignation";
            // 
            // gestionStockDataSet1
            // 
            this.gestionStockDataSet1.DataSetName = "gestionStockDataSet1";
            this.gestionStockDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // articlesBindingSource
            // 
            this.articlesBindingSource.DataMember = "Articles";
            this.articlesBindingSource.DataSource = this.gestionStockDataSet1;
            // 
            // articlesTableAdapter
            // 
            this.articlesTableAdapter.ClearBeforeFill = true;
            // 
            // refDataGridViewTextBoxColumn
            // 
            this.refDataGridViewTextBoxColumn.DataPropertyName = "ref";
            this.refDataGridViewTextBoxColumn.HeaderText = "ref";
            this.refDataGridViewTextBoxColumn.Name = "refDataGridViewTextBoxColumn";
            this.refDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // desDataGridViewTextBoxColumn
            // 
            this.desDataGridViewTextBoxColumn.DataPropertyName = "des";
            this.desDataGridViewTextBoxColumn.HeaderText = "des";
            this.desDataGridViewTextBoxColumn.Name = "desDataGridViewTextBoxColumn";
            this.desDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prixDataGridViewTextBoxColumn
            // 
            this.prixDataGridViewTextBoxColumn.DataPropertyName = "prix";
            this.prixDataGridViewTextBoxColumn.HeaderText = "prix";
            this.prixDataGridViewTextBoxColumn.Name = "prixDataGridViewTextBoxColumn";
            this.prixDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qtesDataGridViewTextBoxColumn
            // 
            this.qtesDataGridViewTextBoxColumn.DataPropertyName = "qtes";
            this.qtesDataGridViewTextBoxColumn.HeaderText = "qtes";
            this.qtesDataGridViewTextBoxColumn.Name = "qtesDataGridViewTextBoxColumn";
            this.qtesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idcDataGridViewTextBoxColumn
            // 
            this.idcDataGridViewTextBoxColumn.DataPropertyName = "idc";
            this.idcDataGridViewTextBoxColumn.HeaderText = "idc";
            this.idcDataGridViewTextBoxColumn.Name = "idcDataGridViewTextBoxColumn";
            this.idcDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qte_TB
            // 
            this.qte_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.qte_TB.Location = new System.Drawing.Point(240, 123);
            this.qte_TB.Name = "qte_TB";
            this.qte_TB.Size = new System.Drawing.Size(235, 26);
            this.qte_TB.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(71, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Qantité en stock";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(71, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Catégorie";
            // 
            // cat_CB
            // 
            this.cat_CB.DataSource = this.categoriesBindingSource;
            this.cat_CB.DisplayMember = "libelle";
            this.cat_CB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cat_CB.FormattingEnabled = true;
            this.cat_CB.Location = new System.Drawing.Point(240, 162);
            this.cat_CB.Name = "cat_CB";
            this.cat_CB.Size = new System.Drawing.Size(235, 28);
            this.cat_CB.TabIndex = 17;
            this.cat_CB.ValueMember = "IdC";
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
            // Articles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 486);
            this.Controls.Add(this.cat_CB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.qte_TB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.save);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.prix_TB);
            this.Controls.Add(this.des_TB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Articles";
            this.Text = "Articles";
            this.Load += new System.EventHandler(this.Articles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionStockDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articlesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionStockDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox prix_TB;
        private System.Windows.Forms.TextBox des_TB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private gestionStockDataSet1 gestionStockDataSet1;
        private System.Windows.Forms.BindingSource articlesBindingSource;
        private gestionStockDataSet1TableAdapters.ArticlesTableAdapter articlesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn refDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn desDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox qte_TB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cat_CB;
        private gestionStockDataSet gestionStockDataSet;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private gestionStockDataSetTableAdapters.CategoriesTableAdapter categoriesTableAdapter;
    }
}