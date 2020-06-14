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
            this.AmountTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.товарыdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.чекdataGridView)).BeginInit();
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
            this.товарыdataGridView.Size = new System.Drawing.Size(496, 150);
            this.товарыdataGridView.TabIndex = 0;
            this.товарыdataGridView.TabStop = false;
            // 
            // чекdataGridView
            // 
            this.чекdataGridView.AllowUserToAddRows = false;
            this.чекdataGridView.AllowUserToDeleteRows = false;
            this.чекdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.чекdataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.чекdataGridView.Location = new System.Drawing.Point(12, 284);
            this.чекdataGridView.MultiSelect = false;
            this.чекdataGridView.Name = "чекdataGridView";
            this.чекdataGridView.Size = new System.Drawing.Size(496, 150);
            this.чекdataGridView.TabIndex = 1;
            this.чекdataGridView.TabStop = false;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(514, 12);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(514, 411);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(75, 23);
            this.RemoveButton.TabIndex = 3;
            this.RemoveButton.Text = "Убрать";
            this.RemoveButton.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(709, 411);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "Закрыть";
            this.ExitButton.UseVisualStyleBackColor = true;
            // 
            // AmountTextBox
            // 
            this.AmountTextBox.Location = new System.Drawing.Point(13, 169);
            this.AmountTextBox.Name = "AmountTextBox";
            this.AmountTextBox.Size = new System.Drawing.Size(100, 20);
            this.AmountTextBox.TabIndex = 5;
            // 
            // НоваяПродажа
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 442);
            this.ControlBox = false;
            this.Controls.Add(this.AmountTextBox);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView товарыdataGridView;
        private System.Windows.Forms.DataGridView чекdataGridView;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.TextBox AmountTextBox;
    }
}