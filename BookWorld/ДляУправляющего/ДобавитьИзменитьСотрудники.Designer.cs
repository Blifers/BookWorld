namespace BookWorld.ДляУправляющего
{
    partial class ДобавитьИзменитьСотрудники
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
            this.AddEditButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.FioTextBox = new System.Windows.Forms.TextBox();
            this.HiredDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.NumberTextBox = new System.Windows.Forms.TextBox();
            this.BirthDatePicker = new System.Windows.Forms.DateTimePicker();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddEditButton
            // 
            this.AddEditButton.Location = new System.Drawing.Point(15, 275);
            this.AddEditButton.Name = "AddEditButton";
            this.AddEditButton.Size = new System.Drawing.Size(325, 23);
            this.AddEditButton.TabIndex = 5;
            this.AddEditButton.Text = "Добавить";
            this.AddEditButton.UseVisualStyleBackColor = true;
            this.AddEditButton.Click += new System.EventHandler(this.AddEditButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(265, 322);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 6;
            this.CloseButton.Text = "Закрыть";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ФИО";
            // 
            // FioTextBox
            // 
            this.FioTextBox.Location = new System.Drawing.Point(114, 15);
            this.FioTextBox.Name = "FioTextBox";
            this.FioTextBox.Size = new System.Drawing.Size(226, 20);
            this.FioTextBox.TabIndex = 0;
            // 
            // HiredDatePicker
            // 
            this.HiredDatePicker.Location = new System.Drawing.Point(114, 65);
            this.HiredDatePicker.Name = "HiredDatePicker";
            this.HiredDatePicker.Size = new System.Drawing.Size(226, 20);
            this.HiredDatePicker.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Дата рождения";
            // 
            // NumberTextBox
            // 
            this.NumberTextBox.Location = new System.Drawing.Point(114, 165);
            this.NumberTextBox.Name = "NumberTextBox";
            this.NumberTextBox.Size = new System.Drawing.Size(226, 20);
            this.NumberTextBox.TabIndex = 3;
            // 
            // BirthDatePicker
            // 
            this.BirthDatePicker.Location = new System.Drawing.Point(114, 115);
            this.BirthDatePicker.Name = "BirthDatePicker";
            this.BirthDatePicker.Size = new System.Drawing.Size(226, 20);
            this.BirthDatePicker.TabIndex = 2;
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(114, 215);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(226, 20);
            this.TitleTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Принят на работу";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Номер телефона";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Должность";
            // 
            // ДобавитьИзменитьСотрудники
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 355);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TitleTextBox);
            this.Controls.Add(this.BirthDatePicker);
            this.Controls.Add(this.NumberTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.HiredDatePicker);
            this.Controls.Add(this.FioTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.AddEditButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ДобавитьИзменитьСотрудники";
            this.ShowIcon = false;
            this.Text = "ДобавитьИзменитьСотрудники";
            this.Load += new System.EventHandler(this.ДобавитьИзменитьСотрудники_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddEditButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FioTextBox;
        private System.Windows.Forms.DateTimePicker HiredDatePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NumberTextBox;
        private System.Windows.Forms.DateTimePicker BirthDatePicker;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}