namespace BookWorld.Продажа
{
    partial class ПостоянныеКлиенты
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
            this.постоянные_КлиентыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.постоянные_КлиентыTableAdapter = new BookWorld.BookWorldDataSetTableAdapters.Постоянные_КлиентыTableAdapter();
            this.tableAdapterManager = new BookWorld.BookWorldDataSetTableAdapters.TableAdapterManager();
            this.постоянные_КлиентыDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bookWorldDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.постоянные_КлиентыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.постоянные_КлиентыDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bookWorldDataSet
            // 
            this.bookWorldDataSet.DataSetName = "BookWorldDataSet";
            this.bookWorldDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // постоянные_КлиентыBindingSource
            // 
            this.постоянные_КлиентыBindingSource.DataMember = "Постоянные_Клиенты";
            this.постоянные_КлиентыBindingSource.DataSource = this.bookWorldDataSet;
            // 
            // постоянные_КлиентыTableAdapter
            // 
            this.постоянные_КлиентыTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = BookWorld.BookWorldDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Движение_ТоваровTableAdapter = null;
            this.tableAdapterManager.ЖанрыTableAdapter = null;
            this.tableAdapterManager.ПользователиTableAdapter = null;
            this.tableAdapterManager.Постоянные_КлиентыTableAdapter = this.постоянные_КлиентыTableAdapter;
            this.tableAdapterManager.ПриходTableAdapter = null;
            this.tableAdapterManager.ПродажаTableAdapter = null;
            this.tableAdapterManager.Состав_ПриходаTableAdapter = null;
            this.tableAdapterManager.Состав_ПродажиTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            this.tableAdapterManager.Тип_ТовараTableAdapter = null;
            this.tableAdapterManager.ТоварыTableAdapter = null;
            // 
            // постоянные_КлиентыDataGridView
            // 
            this.постоянные_КлиентыDataGridView.AutoGenerateColumns = false;
            this.постоянные_КлиентыDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.постоянные_КлиентыDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.постоянные_КлиентыDataGridView.DataSource = this.постоянные_КлиентыBindingSource;
            this.постоянные_КлиентыDataGridView.Location = new System.Drawing.Point(12, 12);
            this.постоянные_КлиентыDataGridView.Name = "постоянные_КлиентыDataGridView";
            this.постоянные_КлиентыDataGridView.Size = new System.Drawing.Size(444, 220);
            this.постоянные_КлиентыDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Номер_Карта";
            this.dataGridViewTextBoxColumn1.HeaderText = "Номер_Карта";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ФИО";
            this.dataGridViewTextBoxColumn2.HeaderText = "ФИО";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Дата_Вручения";
            this.dataGridViewTextBoxColumn3.HeaderText = "Дата_Вручения";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Телефон";
            this.dataGridViewTextBoxColumn4.HeaderText = "Телефон";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // ПостоянныеКлиенты
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.постоянные_КлиентыDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ПостоянныеКлиенты";
            this.ShowIcon = false;
            this.Text = "Постоянные клиенты";
            this.Load += new System.EventHandler(this.ПостоянныеКлиенты_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookWorldDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.постоянные_КлиентыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.постоянные_КлиентыDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BookWorldDataSet bookWorldDataSet;
        private System.Windows.Forms.BindingSource постоянные_КлиентыBindingSource;
        private BookWorldDataSetTableAdapters.Постоянные_КлиентыTableAdapter постоянные_КлиентыTableAdapter;
        private BookWorldDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView постоянные_КлиентыDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}