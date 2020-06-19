namespace BookWorld.Продажа
{
    partial class НоваяПродажа
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
            this.товарыdataGridView = new System.Windows.Forms.DataGridView();
            this.чекdataGridView = new System.Windows.Forms.DataGridView();
            this.AddButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.AmountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.CostLabel = new System.Windows.Forms.Label();
            this.FormDocButton = new System.Windows.Forms.Button();
            this.DelRowButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.товарыdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.чекdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // товарыdataGridView
            // 
            this.товарыdataGridView.AllowUserToAddRows = false;
            this.товарыdataGridView.AllowUserToDeleteRows = false;
            this.товарыdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.товарыdataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.товарыdataGridView.Location = new System.Drawing.Point(12, 12);
            this.товарыdataGridView.MultiSelect = false;
            this.товарыdataGridView.Name = "товарыdataGridView";
            this.товарыdataGridView.Size = new System.Drawing.Size(641, 320);
            this.товарыdataGridView.TabIndex = 0;
            this.товарыdataGridView.TabStop = false;
            this.товарыdataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.товарыdataGridView_CellContentDoubleClick);
            // 
            // чекdataGridView
            // 
            this.чекdataGridView.AllowUserToAddRows = false;
            this.чекdataGridView.AllowUserToDeleteRows = false;
            this.чекdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.чекdataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.чекdataGridView.Location = new System.Drawing.Point(12, 397);
            this.чекdataGridView.MultiSelect = false;
            this.чекdataGridView.Name = "чекdataGridView";
            this.чекdataGridView.Size = new System.Drawing.Size(641, 174);
            this.чекdataGridView.TabIndex = 1;
            this.чекdataGridView.TabStop = false;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(659, 66);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(153, 23);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Добавить в чек";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(659, 397);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(152, 23);
            this.RemoveButton.TabIndex = 3;
            this.RemoveButton.Text = "Очистить всё";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(736, 540);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "Закрыть";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 358);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Поиск по товарам:";
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(118, 355);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(157, 20);
            this.SearchTextBox.TabIndex = 12;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // AmountNumericUpDown
            // 
            this.AmountNumericUpDown.Location = new System.Drawing.Point(738, 27);
            this.AmountNumericUpDown.Name = "AmountNumericUpDown";
            this.AmountNumericUpDown.Size = new System.Drawing.Size(73, 20);
            this.AmountNumericUpDown.TabIndex = 15;
            this.AmountNumericUpDown.Enter += new System.EventHandler(this.AmountNumericUpDown_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(663, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Количество";
            // 
            // ClearButton
            // 
            this.ClearButton.Image = global::BookWorld.Properties.Resources.hotpng_com;
            this.ClearButton.Location = new System.Drawing.Point(281, 345);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(45, 39);
            this.ClearButton.TabIndex = 14;
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CostLabel.Location = new System.Drawing.Point(501, 363);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(94, 21);
            this.CostLabel.TabIndex = 18;
            this.CostLabel.Text = "Стоимость";
            // 
            // FormDocButton
            // 
            this.FormDocButton.Location = new System.Drawing.Point(659, 309);
            this.FormDocButton.Name = "FormDocButton";
            this.FormDocButton.Size = new System.Drawing.Size(152, 23);
            this.FormDocButton.TabIndex = 19;
            this.FormDocButton.Text = "Оформить продажу";
            this.FormDocButton.UseVisualStyleBackColor = true;
            this.FormDocButton.Click += new System.EventHandler(this.FormDocButton_Click);
            // 
            // DelRowButton
            // 
            this.DelRowButton.Location = new System.Drawing.Point(659, 438);
            this.DelRowButton.Name = "DelRowButton";
            this.DelRowButton.Size = new System.Drawing.Size(152, 23);
            this.DelRowButton.TabIndex = 20;
            this.DelRowButton.Text = "Убрать одну позицию";
            this.DelRowButton.UseVisualStyleBackColor = true;
            this.DelRowButton.Click += new System.EventHandler(this.DelRowButton_Click);
            // 
            // НоваяПродажа
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 571);
            this.ControlBox = false;
            this.Controls.Add(this.DelRowButton);
            this.Controls.Add(this.FormDocButton);
            this.Controls.Add(this.CostLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AmountNumericUpDown);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.чекdataGridView);
            this.Controls.Add(this.товарыdataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "НоваяПродажа";
            this.ShowIcon = false;
            this.Text = "Продажа";
            this.Load += new System.EventHandler(this.НоваяПродажа_Load);
            ((System.ComponentModel.ISupportInitialize)(this.товарыdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.чекdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView товарыdataGridView;
        private System.Windows.Forms.DataGridView чекdataGridView;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.NumericUpDown AmountNumericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.Button FormDocButton;
        private System.Windows.Forms.Button DelRowButton;
    }
}