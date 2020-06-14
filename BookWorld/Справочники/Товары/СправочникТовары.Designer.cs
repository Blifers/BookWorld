namespace BookWorld.Справочники
{
    partial class СправочникТовары
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
            this.товарыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.товарыTableAdapter = new BookWorld.BookWorldDataSetTableAdapters.ТоварыTableAdapter();
            this.tableAdapterManager = new BookWorld.BookWorldDataSetTableAdapters.TableAdapterManager();
            this.товарыDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NewGoodsButton = new System.Windows.Forms.Button();
            this.NewSellButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bookWorldDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарыDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bookWorldDataSet
            // 
            this.bookWorldDataSet.DataSetName = "BookWorldDataSet";
            this.bookWorldDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // товарыBindingSource
            // 
            this.товарыBindingSource.DataMember = "Товары";
            this.товарыBindingSource.DataSource = this.bookWorldDataSet;
            // 
            // товарыTableAdapter
            // 
            this.товарыTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = BookWorld.BookWorldDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Движение_ТоваровTableAdapter = null;
            this.tableAdapterManager.ЖанрыTableAdapter = null;
            this.tableAdapterManager.ПользователиTableAdapter = null;
            this.tableAdapterManager.Постоянные_КлиентыTableAdapter = null;
            this.tableAdapterManager.ПриходTableAdapter = null;
            this.tableAdapterManager.ПродажаTableAdapter = null;
            this.tableAdapterManager.Состав_ПриходаTableAdapter = null;
            this.tableAdapterManager.Состав_ПродажиTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            this.tableAdapterManager.Тип_ТовараTableAdapter = null;
            this.tableAdapterManager.ТоварыTableAdapter = this.товарыTableAdapter;
            // 
            // товарыDataGridView
            // 
            this.товарыDataGridView.AllowUserToAddRows = false;
            this.товарыDataGridView.AllowUserToDeleteRows = false;
            this.товарыDataGridView.AutoGenerateColumns = false;
            this.товарыDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.товарыDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.товарыDataGridView.DataSource = this.товарыBindingSource;
            this.товарыDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.товарыDataGridView.Location = new System.Drawing.Point(11, 1);
            this.товарыDataGridView.MultiSelect = false;
            this.товарыDataGridView.Name = "товарыDataGridView";
            this.товарыDataGridView.Size = new System.Drawing.Size(644, 262);
            this.товарыDataGridView.TabIndex = 1;
            this.товарыDataGridView.TabStop = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Код_Товара";
            this.dataGridViewTextBoxColumn1.HeaderText = "Код_Товара";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Тип_Товара";
            this.dataGridViewTextBoxColumn2.HeaderText = "Тип_Товара";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Жанр";
            this.dataGridViewTextBoxColumn3.HeaderText = "Жанр";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Наименование";
            this.dataGridViewTextBoxColumn4.HeaderText = "Наименование";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Цена";
            this.dataGridViewTextBoxColumn5.HeaderText = "Цена";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Остаток";
            this.dataGridViewTextBoxColumn6.HeaderText = "Остаток";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // NewGoodsButton
            // 
            this.NewGoodsButton.Location = new System.Drawing.Point(674, 43);
            this.NewGoodsButton.Name = "NewGoodsButton";
            this.NewGoodsButton.Size = new System.Drawing.Size(123, 23);
            this.NewGoodsButton.TabIndex = 0;
            this.NewGoodsButton.Text = "Новый приход";
            this.NewGoodsButton.UseVisualStyleBackColor = true;
            // 
            // NewSellButton
            // 
            this.NewSellButton.Location = new System.Drawing.Point(703, 139);
            this.NewSellButton.Name = "NewSellButton";
            this.NewSellButton.Size = new System.Drawing.Size(75, 23);
            this.NewSellButton.TabIndex = 1;
            this.NewSellButton.Text = "Продажа";
            this.NewSellButton.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(703, 240);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 2;
            this.DeleteButton.Text = "Списать";
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(770, 403);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Закрыть";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // СправочникТовары
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 450);
            this.ControlBox = false;
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.NewSellButton);
            this.Controls.Add(this.NewGoodsButton);
            this.Controls.Add(this.товарыDataGridView);
            this.Name = "СправочникТовары";
            this.ShowIcon = false;
            this.Text = "Товары";
            this.Load += new System.EventHandler(this.СправочникТовары_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookWorldDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарыDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BookWorldDataSet bookWorldDataSet;
        private System.Windows.Forms.BindingSource товарыBindingSource;
        private BookWorldDataSetTableAdapters.ТоварыTableAdapter товарыTableAdapter;
        private BookWorldDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView товарыDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button NewGoodsButton;
        private System.Windows.Forms.Button NewSellButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button ExitButton;
    }
}