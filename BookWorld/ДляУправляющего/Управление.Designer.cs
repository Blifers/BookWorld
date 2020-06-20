namespace BookWorld.ДляУправляющего
{
    partial class Управление
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
            this.SaveButton = new System.Windows.Forms.Button();
            this.PercentageCheckBox = new System.Windows.Forms.CheckBox();
            this.DiscountCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PercentageTextBox = new System.Windows.Forms.TextBox();
            this.DiscountTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Button();
            this.UserButton = new System.Windows.Forms.Button();
            this.WorkersButton = new System.Windows.Forms.Button();
            this.ReportsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(9, 134);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(225, 23);
            this.SaveButton.TabIndex = 0;
            this.SaveButton.Text = "Сохранить изменения";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // PercentageCheckBox
            // 
            this.PercentageCheckBox.AutoSize = true;
            this.PercentageCheckBox.Location = new System.Drawing.Point(127, 41);
            this.PercentageCheckBox.Name = "PercentageCheckBox";
            this.PercentageCheckBox.Size = new System.Drawing.Size(110, 17);
            this.PercentageCheckBox.TabIndex = 1;
            this.PercentageCheckBox.Text = "Разблокировать";
            this.PercentageCheckBox.UseVisualStyleBackColor = true;
            this.PercentageCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // DiscountCheckBox
            // 
            this.DiscountCheckBox.AutoSize = true;
            this.DiscountCheckBox.Location = new System.Drawing.Point(127, 103);
            this.DiscountCheckBox.Name = "DiscountCheckBox";
            this.DiscountCheckBox.Size = new System.Drawing.Size(110, 17);
            this.DiscountCheckBox.TabIndex = 2;
            this.DiscountCheckBox.Text = "Разблокировать";
            this.DiscountCheckBox.UseVisualStyleBackColor = true;
            this.DiscountCheckBox.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Размер наценки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Размер скидки";
            // 
            // PercentageTextBox
            // 
            this.PercentageTextBox.Enabled = false;
            this.PercentageTextBox.Location = new System.Drawing.Point(127, 15);
            this.PercentageTextBox.Name = "PercentageTextBox";
            this.PercentageTextBox.Size = new System.Drawing.Size(100, 20);
            this.PercentageTextBox.TabIndex = 5;
            // 
            // DiscountTextBox
            // 
            this.DiscountTextBox.Enabled = false;
            this.DiscountTextBox.Location = new System.Drawing.Point(127, 77);
            this.DiscountTextBox.Name = "DiscountTextBox";
            this.DiscountTextBox.Size = new System.Drawing.Size(100, 20);
            this.DiscountTextBox.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(243, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 210);
            this.panel1.TabIndex = 7;
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(300, 153);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 9;
            this.CloseButton.Text = "Закрыть";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // UserButton
            // 
            this.UserButton.Location = new System.Drawing.Point(251, 15);
            this.UserButton.Name = "UserButton";
            this.UserButton.Size = new System.Drawing.Size(124, 23);
            this.UserButton.TabIndex = 10;
            this.UserButton.Text = "Пользователи";
            this.UserButton.UseVisualStyleBackColor = true;
            this.UserButton.Click += new System.EventHandler(this.UserButton_Click);
            // 
            // WorkersButton
            // 
            this.WorkersButton.Location = new System.Drawing.Point(251, 60);
            this.WorkersButton.Name = "WorkersButton";
            this.WorkersButton.Size = new System.Drawing.Size(124, 23);
            this.WorkersButton.TabIndex = 11;
            this.WorkersButton.Text = "Сотрудники";
            this.WorkersButton.UseVisualStyleBackColor = true;
            this.WorkersButton.Click += new System.EventHandler(this.WorkersButton_Click);
            // 
            // ReportsButton
            // 
            this.ReportsButton.Location = new System.Drawing.Point(251, 105);
            this.ReportsButton.Name = "ReportsButton";
            this.ReportsButton.Size = new System.Drawing.Size(124, 23);
            this.ReportsButton.TabIndex = 12;
            this.ReportsButton.Text = "Отчеты";
            this.ReportsButton.UseVisualStyleBackColor = true;
            this.ReportsButton.Click += new System.EventHandler(this.ReportsButton_Click);
            // 
            // Управление
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 190);
            this.ControlBox = false;
            this.Controls.Add(this.ReportsButton);
            this.Controls.Add(this.WorkersButton);
            this.Controls.Add(this.UserButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DiscountTextBox);
            this.Controls.Add(this.PercentageTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DiscountCheckBox);
            this.Controls.Add(this.PercentageCheckBox);
            this.Controls.Add(this.SaveButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Управление";
            this.ShowIcon = false;
            this.Text = "Управление";
            this.Load += new System.EventHandler(this.Управление_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.CheckBox PercentageCheckBox;
        private System.Windows.Forms.CheckBox DiscountCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PercentageTextBox;
        private System.Windows.Forms.TextBox DiscountTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button UserButton;
        private System.Windows.Forms.Button WorkersButton;
        private System.Windows.Forms.Button ReportsButton;
    }
}