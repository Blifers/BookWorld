namespace BookWorld.Справочники
{
    partial class СправочникЖанры
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
            this.жанрыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.жанрыTableAdapter = new BookWorld.BookWorldDataSetTableAdapters.ЖанрыTableAdapter();
            this.tableAdapterManager = new BookWorld.BookWorldDataSetTableAdapters.TableAdapterManager();
            this.жанрыDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExitButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bookWorldDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.жанрыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.жанрыDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bookWorldDataSet
            // 
            this.bookWorldDataSet.DataSetName = "BookWorldDataSet";
            this.bookWorldDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // жанрыBindingSource
            // 
            this.жанрыBindingSource.DataMember = "Жанры";
            this.жанрыBindingSource.DataSource = this.bookWorldDataSet;
            // 
            // жанрыTableAdapter
            // 
            this.жанрыTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = BookWorld.BookWorldDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Движение_ТоваровTableAdapter = null;
            this.tableAdapterManager.ЖанрыTableAdapter = this.жанрыTableAdapter;
            this.tableAdapterManager.ПользователиTableAdapter = null;
            this.tableAdapterManager.Постоянные_КлиентыTableAdapter = null;
            this.tableAdapterManager.ПриходTableAdapter = null;
            this.tableAdapterManager.ПродажаTableAdapter = null;
            this.tableAdapterManager.Состав_ПриходаTableAdapter = null;
            this.tableAdapterManager.Состав_ПродажиTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            this.tableAdapterManager.Тип_ТовараTableAdapter = null;
            this.tableAdapterManager.ТоварыTableAdapter = null;
            // 
            // жанрыDataGridView
            // 
            this.жанрыDataGridView.AllowUserToAddRows = false;
            this.жанрыDataGridView.AllowUserToDeleteRows = false;
            this.жанрыDataGridView.AutoGenerateColumns = false;
            this.жанрыDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.жанрыDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.жанрыDataGridView.DataSource = this.жанрыBindingSource;
            this.жанрыDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.жанрыDataGridView.Location = new System.Drawing.Point(0, 0);
            this.жанрыDataGridView.MultiSelect = false;
            this.жанрыDataGridView.Name = "жанрыDataGridView";
            this.жанрыDataGridView.Size = new System.Drawing.Size(323, 307);
            this.жанрыDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Код_Жанра";
            this.dataGridViewTextBoxColumn1.HeaderText = "Код_Жанра";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 30;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Наименование";
            this.dataGridViewTextBoxColumn2.HeaderText = "Наименование";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 250;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(446, 278);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Закрыть";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(330, 15);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(189, 23);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(330, 65);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(189, 23);
            this.EditButton.TabIndex = 1;
            this.EditButton.Text = "Изменить";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(330, 115);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(189, 23);
            this.DeleteButton.TabIndex = 2;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // СправочникЖанры
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(529, 309);
            this.ControlBox = false;
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.жанрыDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "СправочникЖанры";
            this.ShowIcon = false;
            this.Text = "Жанры";
            this.Load += new System.EventHandler(this.СправочникЖанры_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookWorldDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.жанрыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.жанрыDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BookWorldDataSet bookWorldDataSet;
        private System.Windows.Forms.BindingSource жанрыBindingSource;
        private BookWorldDataSetTableAdapters.ЖанрыTableAdapter жанрыTableAdapter;
        private BookWorldDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView жанрыDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button DeleteButton;
    }
}