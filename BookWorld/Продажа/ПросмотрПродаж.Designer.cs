namespace BookWorld.Продажа
{
    partial class ПросмотрПродаж
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
            this.продажаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.продажаTableAdapter = new BookWorld.BookWorldDataSetTableAdapters.ПродажаTableAdapter();
            this.tableAdapterManager = new BookWorld.BookWorldDataSetTableAdapters.TableAdapterManager();
            this.продажаDataGridView = new System.Windows.Forms.DataGridView();
            this.GoodsDataGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bookWorldDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.продажаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.продажаDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoodsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // bookWorldDataSet
            // 
            this.bookWorldDataSet.DataSetName = "BookWorldDataSet";
            this.bookWorldDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // продажаBindingSource
            // 
            this.продажаBindingSource.DataMember = "Продажа";
            this.продажаBindingSource.DataSource = this.bookWorldDataSet;
            // 
            // продажаTableAdapter
            // 
            this.продажаTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = BookWorld.BookWorldDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ЖанрыTableAdapter = null;
            this.tableAdapterManager.ПользователиTableAdapter = null;
            this.tableAdapterManager.Постоянные_КлиентыTableAdapter = null;
            this.tableAdapterManager.ПриходTableAdapter = null;
            this.tableAdapterManager.ПродажаTableAdapter = this.продажаTableAdapter;
            this.tableAdapterManager.Состав_ПриходаTableAdapter = null;
            this.tableAdapterManager.Состав_ПродажиTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            this.tableAdapterManager.Тип_ТовараTableAdapter = null;
            this.tableAdapterManager.ТоварыTableAdapter = null;
            // 
            // продажаDataGridView
            // 
            this.продажаDataGridView.AllowUserToAddRows = false;
            this.продажаDataGridView.AllowUserToDeleteRows = false;
            this.продажаDataGridView.AutoGenerateColumns = false;
            this.продажаDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.продажаDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4});
            this.продажаDataGridView.DataSource = this.продажаBindingSource;
            this.продажаDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.продажаDataGridView.Location = new System.Drawing.Point(12, 12);
            this.продажаDataGridView.Name = "продажаDataGridView";
            this.продажаDataGridView.Size = new System.Drawing.Size(503, 320);
            this.продажаDataGridView.TabIndex = 1;
            this.продажаDataGridView.TabStop = false;
            this.продажаDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.продажаDataGridView_CellContentClick);
            // 
            // GoodsDataGrid
            // 
            this.GoodsDataGrid.AllowUserToAddRows = false;
            this.GoodsDataGrid.AllowUserToDeleteRows = false;
            this.GoodsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GoodsDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.GoodsDataGrid.Location = new System.Drawing.Point(12, 363);
            this.GoodsDataGrid.Name = "GoodsDataGrid";
            this.GoodsDataGrid.Size = new System.Drawing.Size(503, 161);
            this.GoodsDataGrid.TabIndex = 3;
            this.GoodsDataGrid.TabStop = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Чек";
            this.dataGridViewTextBoxColumn3.HeaderText = "Чек";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Дата";
            this.dataGridViewTextBoxColumn1.HeaderText = "Дата";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Номер_Карты";
            this.dataGridViewTextBoxColumn2.HeaderText = "Номер_Карты";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Сумма_Чека";
            this.dataGridViewTextBoxColumn4.HeaderText = "Сумма_Чека";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(183, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Список товаров";
            // 
            // ПросмотрПродаж
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 544);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GoodsDataGrid);
            this.Controls.Add(this.продажаDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ПросмотрПродаж";
            this.ShowIcon = false;
            this.Text = "Просмотр продаж";
            this.Load += new System.EventHandler(this.ПросмотрПродаж_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookWorldDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.продажаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.продажаDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoodsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BookWorldDataSet bookWorldDataSet;
        private System.Windows.Forms.BindingSource продажаBindingSource;
        private BookWorldDataSetTableAdapters.ПродажаTableAdapter продажаTableAdapter;
        private BookWorldDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView продажаDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridView GoodsDataGrid;
        private System.Windows.Forms.Label label1;
    }
}