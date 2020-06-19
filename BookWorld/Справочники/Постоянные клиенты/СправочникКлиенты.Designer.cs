namespace BookWorld.Справочники.Постоянные_клиенты
{
    partial class СправочникКлиенты
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
            this.CloseButton = new System.Windows.Forms.Button();
            this.bookWorldDataSet = new BookWorld.BookWorldDataSet();
            this.постоянные_КлиентыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new BookWorld.BookWorldDataSetTableAdapters.TableAdapterManager();
            this.постоянные_КлиентыDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.постоянные_КлиентыTableAdapter = new BookWorld.BookWorldDataSetTableAdapters.Постоянные_КлиентыTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchByFioTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ChooseButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bookWorldDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.постоянные_КлиентыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.постоянные_КлиентыDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(536, 324);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Text = "Закрыть";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = BookWorld.BookWorldDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ЖанрыTableAdapter = null;
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
            // постоянные_КлиентыDataGridView
            // 
            this.постоянные_КлиентыDataGridView.AllowUserToAddRows = false;
            this.постоянные_КлиентыDataGridView.AllowUserToDeleteRows = false;
            this.постоянные_КлиентыDataGridView.AutoGenerateColumns = false;
            this.постоянные_КлиентыDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.постоянные_КлиентыDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.постоянные_КлиентыDataGridView.DataSource = this.постоянные_КлиентыBindingSource;
            this.постоянные_КлиентыDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.постоянные_КлиентыDataGridView.Location = new System.Drawing.Point(12, 12);
            this.постоянные_КлиентыDataGridView.Name = "постоянные_КлиентыDataGridView";
            this.постоянные_КлиентыDataGridView.Size = new System.Drawing.Size(443, 273);
            this.постоянные_КлиентыDataGridView.TabIndex = 2;
            this.постоянные_КлиентыDataGridView.TabStop = false;
            this.постоянные_КлиентыDataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.постоянные_КлиентыDataGridView_CellContentDoubleClick);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Номер_Карты";
            this.dataGridViewTextBoxColumn4.HeaderText = "Номер_Карты";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ФИО";
            this.dataGridViewTextBoxColumn1.HeaderText = "ФИО";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Дата_Вручения";
            this.dataGridViewTextBoxColumn2.HeaderText = "Дата_Вручения";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Телефон";
            this.dataGridViewTextBoxColumn3.HeaderText = "Телефон";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(461, 15);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(150, 23);
            this.AddButton.TabIndex = 3;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(461, 65);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(150, 23);
            this.EditButton.TabIndex = 4;
            this.EditButton.Text = "Изменить";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // постоянные_КлиентыTableAdapter
            // 
            this.постоянные_КлиентыTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Выберите условие для поиска";
            // 
            // SearchByFioTextBox
            // 
            this.SearchByFioTextBox.Location = new System.Drawing.Point(171, 324);
            this.SearchByFioTextBox.Name = "SearchByFioTextBox";
            this.SearchByFioTextBox.Size = new System.Drawing.Size(284, 20);
            this.SearchByFioTextBox.TabIndex = 6;
            this.SearchByFioTextBox.TextChanged += new System.EventHandler(this.SearchByFioTextBox_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ФИО",
            "Телефон",
            "Номер карты"});
            this.comboBox1.Location = new System.Drawing.Point(15, 323);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ChooseButton
            // 
            this.ChooseButton.Location = new System.Drawing.Point(462, 261);
            this.ChooseButton.Name = "ChooseButton";
            this.ChooseButton.Size = new System.Drawing.Size(149, 23);
            this.ChooseButton.TabIndex = 8;
            this.ChooseButton.Text = "Выбрать";
            this.ChooseButton.UseVisualStyleBackColor = true;
            this.ChooseButton.Click += new System.EventHandler(this.ChooseButton_Click);
            // 
            // СправочникКлиенты
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 349);
            this.ControlBox = false;
            this.Controls.Add(this.ChooseButton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.SearchByFioTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.постоянные_КлиентыDataGridView);
            this.Controls.Add(this.CloseButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "СправочникКлиенты";
            this.ShowIcon = false;
            this.Text = "Постоянные клиенты";
            this.Load += new System.EventHandler(this.СправочникКлиенты_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookWorldDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.постоянные_КлиентыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.постоянные_КлиентыDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        private BookWorldDataSet bookWorldDataSet;
        private System.Windows.Forms.BindingSource постоянные_КлиентыBindingSource;
        private BookWorldDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView постоянные_КлиентыDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button EditButton;
        private BookWorldDataSetTableAdapters.Постоянные_КлиентыTableAdapter постоянные_КлиентыTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SearchByFioTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button ChooseButton;
    }
}