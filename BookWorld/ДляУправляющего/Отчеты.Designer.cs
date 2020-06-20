namespace BookWorld.ДляУправляющего
{
    partial class Отчеты
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
            this.ReportDataGrid = new System.Windows.Forms.DataGridView();
            this.CloseButton = new System.Windows.Forms.Button();
            this.FormReportButton = new System.Windows.Forms.Button();
            this.StartDatePicker = new System.Windows.Forms.DateTimePicker();
            this.EndDatePicker = new System.Windows.Forms.DateTimePicker();
            this.CreateExcelButton = new System.Windows.Forms.Button();
            this.ReportsComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ReportDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ReportDataGrid
            // 
            this.ReportDataGrid.AllowUserToAddRows = false;
            this.ReportDataGrid.AllowUserToDeleteRows = false;
            this.ReportDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReportDataGrid.Location = new System.Drawing.Point(12, 147);
            this.ReportDataGrid.Name = "ReportDataGrid";
            this.ReportDataGrid.Size = new System.Drawing.Size(864, 340);
            this.ReportDataGrid.TabIndex = 0;
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(801, 108);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "Закрыть";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // FormReportButton
            // 
            this.FormReportButton.Location = new System.Drawing.Point(119, 108);
            this.FormReportButton.Name = "FormReportButton";
            this.FormReportButton.Size = new System.Drawing.Size(121, 23);
            this.FormReportButton.TabIndex = 2;
            this.FormReportButton.Text = "Сформировать";
            this.FormReportButton.UseVisualStyleBackColor = true;
            this.FormReportButton.Click += new System.EventHandler(this.FormReportButton_Click);
            // 
            // StartDatePicker
            // 
            this.StartDatePicker.Location = new System.Drawing.Point(119, 60);
            this.StartDatePicker.Name = "StartDatePicker";
            this.StartDatePicker.Size = new System.Drawing.Size(120, 20);
            this.StartDatePicker.TabIndex = 3;
            // 
            // EndDatePicker
            // 
            this.EndDatePicker.Location = new System.Drawing.Point(273, 60);
            this.EndDatePicker.Name = "EndDatePicker";
            this.EndDatePicker.Size = new System.Drawing.Size(120, 20);
            this.EndDatePicker.TabIndex = 4;
            // 
            // CreateExcelButton
            // 
            this.CreateExcelButton.Location = new System.Drawing.Point(273, 108);
            this.CreateExcelButton.Name = "CreateExcelButton";
            this.CreateExcelButton.Size = new System.Drawing.Size(120, 23);
            this.CreateExcelButton.TabIndex = 5;
            this.CreateExcelButton.Text = "Открыть в Excel";
            this.CreateExcelButton.UseVisualStyleBackColor = true;
            this.CreateExcelButton.Click += new System.EventHandler(this.CreateExcelButton_Click);
            // 
            // ReportsComboBox
            // 
            this.ReportsComboBox.FormattingEnabled = true;
            this.ReportsComboBox.Items.AddRange(new object[] {
            "Товары для пополнения",
            "Популярность жанров",
            "Популярность типов",
            "Финансовые показатели"});
            this.ReportsComboBox.Location = new System.Drawing.Point(119, 12);
            this.ReportsComboBox.Name = "ReportsComboBox";
            this.ReportsComboBox.Size = new System.Drawing.Size(274, 21);
            this.ReportsComboBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Выберите отчёт";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Выберите период с:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(245, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "по:";
            // 
            // Отчеты
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 491);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ReportsComboBox);
            this.Controls.Add(this.CreateExcelButton);
            this.Controls.Add(this.EndDatePicker);
            this.Controls.Add(this.StartDatePicker);
            this.Controls.Add(this.FormReportButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.ReportDataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Отчеты";
            this.ShowIcon = false;
            this.Text = "Отчеты";
            this.Load += new System.EventHandler(this.Отчеты_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReportDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ReportDataGrid;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button FormReportButton;
        private System.Windows.Forms.DateTimePicker StartDatePicker;
        private System.Windows.Forms.DateTimePicker EndDatePicker;
        private System.Windows.Forms.Button CreateExcelButton;
        private System.Windows.Forms.ComboBox ReportsComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}