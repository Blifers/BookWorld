namespace BookWorld.Приход
{
    partial class ПросмотрПриходов
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
            this.bookWorldDataSet = new BookWorld.BookWorldDataSet();
            this.приходBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.приходTableAdapter = new BookWorld.BookWorldDataSetTableAdapters.ПриходTableAdapter();
            this.tableAdapterManager = new BookWorld.BookWorldDataSetTableAdapters.TableAdapterManager();
            this.приходDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GoodsDataGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bookWorldDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.приходBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.приходDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoodsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // bookWorldDataSet
            // 
            this.bookWorldDataSet.DataSetName = "BookWorldDataSet";
            this.bookWorldDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // приходBindingSource
            // 
            this.приходBindingSource.DataMember = "Приход";
            this.приходBindingSource.DataSource = this.bookWorldDataSet;
            // 
            // приходTableAdapter
            // 
            this.приходTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = BookWorld.BookWorldDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ЖанрыTableAdapter = null;
            this.tableAdapterManager.ПользователиTableAdapter = null;
            this.tableAdapterManager.Постоянные_КлиентыTableAdapter = null;
            this.tableAdapterManager.ПриходTableAdapter = this.приходTableAdapter;
            this.tableAdapterManager.ПродажаTableAdapter = null;
            this.tableAdapterManager.Состав_ПриходаTableAdapter = null;
            this.tableAdapterManager.Состав_ПродажиTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            this.tableAdapterManager.Тип_ТовараTableAdapter = null;
            this.tableAdapterManager.ТоварыTableAdapter = null;
            // 
            // приходDataGridView
            // 
            this.приходDataGridView.AllowUserToAddRows = false;
            this.приходDataGridView.AllowUserToDeleteRows = false;
            this.приходDataGridView.AutoGenerateColumns = false;
            this.приходDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.приходDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.приходDataGridView.DataSource = this.приходBindingSource;
            this.приходDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.приходDataGridView.Location = new System.Drawing.Point(12, 12);
            this.приходDataGridView.Name = "приходDataGridView";
            this.приходDataGridView.Size = new System.Drawing.Size(573, 210);
            this.приходDataGridView.TabIndex = 1;
            this.приходDataGridView.TabStop = false;
            this.приходDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.приходDataGridView_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Номер_Прихода";
            this.dataGridViewTextBoxColumn1.HeaderText = "Номер_Прихода";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Дата";
            this.dataGridViewTextBoxColumn2.HeaderText = "Дата";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Комментарий";
            this.dataGridViewTextBoxColumn3.HeaderText = "Комментарий";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // GoodsDataGrid
            // 
            this.GoodsDataGrid.AllowUserToAddRows = false;
            this.GoodsDataGrid.AllowUserToDeleteRows = false;
            this.GoodsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GoodsDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.GoodsDataGrid.Location = new System.Drawing.Point(12, 253);
            this.GoodsDataGrid.Name = "GoodsDataGrid";
            this.GoodsDataGrid.Size = new System.Drawing.Size(573, 376);
            this.GoodsDataGrid.TabIndex = 2;
            this.GoodsDataGrid.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(221, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Список товаров";
            // 
            // ПросмотрПриходов
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 641);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GoodsDataGrid);
            this.Controls.Add(this.приходDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ПросмотрПриходов";
            this.ShowIcon = false;
            this.Text = "Просмотр документа приход";
            this.Load += new System.EventHandler(this.ПросмотрПриходов_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookWorldDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.приходBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.приходDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoodsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BookWorldDataSet bookWorldDataSet;
        private System.Windows.Forms.BindingSource приходBindingSource;
        private BookWorldDataSetTableAdapters.ПриходTableAdapter приходTableAdapter;
        private BookWorldDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView приходDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridView GoodsDataGrid;
        private System.Windows.Forms.Label label1;
    }
}