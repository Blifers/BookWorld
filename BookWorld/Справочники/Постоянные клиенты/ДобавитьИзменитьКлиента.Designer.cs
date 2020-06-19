namespace BookWorld.Справочники.Постоянные_клиенты
{
    partial class ДобавитьИзменитьКлиента
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
            this.CloseButton = new System.Windows.Forms.Button();
            this.EnterButton = new System.Windows.Forms.Button();
            this.FioLabel = new System.Windows.Forms.Label();
            this.NumberLabel = new System.Windows.Forms.Label();
            this.FioTextBox = new System.Windows.Forms.TextBox();
            this.PhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(240, 164);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 3;
            this.CloseButton.Text = "Закрыть";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // EnterButton
            // 
            this.EnterButton.Location = new System.Drawing.Point(12, 120);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(303, 23);
            this.EnterButton.TabIndex = 2;
            this.EnterButton.Text = "Добавить";
            this.EnterButton.UseVisualStyleBackColor = true;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // FioLabel
            // 
            this.FioLabel.AutoSize = true;
            this.FioLabel.Location = new System.Drawing.Point(9, 23);
            this.FioLabel.Name = "FioLabel";
            this.FioLabel.Size = new System.Drawing.Size(34, 13);
            this.FioLabel.TabIndex = 2;
            this.FioLabel.Text = "ФИО";
            // 
            // NumberLabel
            // 
            this.NumberLabel.AutoSize = true;
            this.NumberLabel.Location = new System.Drawing.Point(9, 73);
            this.NumberLabel.Name = "NumberLabel";
            this.NumberLabel.Size = new System.Drawing.Size(93, 13);
            this.NumberLabel.TabIndex = 4;
            this.NumberLabel.Text = "Номер телефона";
            // 
            // FioTextBox
            // 
            this.FioTextBox.Location = new System.Drawing.Point(112, 20);
            this.FioTextBox.Name = "FioTextBox";
            this.FioTextBox.Size = new System.Drawing.Size(203, 20);
            this.FioTextBox.TabIndex = 0;
            // 
            // PhoneNumberTextBox
            // 
            this.PhoneNumberTextBox.Location = new System.Drawing.Point(112, 70);
            this.PhoneNumberTextBox.MaxLength = 12;
            this.PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            this.PhoneNumberTextBox.Size = new System.Drawing.Size(203, 20);
            this.PhoneNumberTextBox.TabIndex = 1;
            // 
            // ДобавитьИзменитьКлиента
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 204);
            this.ControlBox = false;
            this.Controls.Add(this.PhoneNumberTextBox);
            this.Controls.Add(this.FioTextBox);
            this.Controls.Add(this.NumberLabel);
            this.Controls.Add(this.FioLabel);
            this.Controls.Add(this.EnterButton);
            this.Controls.Add(this.CloseButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ДобавитьИзменитьКлиента";
            this.ShowIcon = false;
            this.Text = "ДобавитьИзменитьКлиента";
            this.Load += new System.EventHandler(this.ДобавитьИзменитьКлиента_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button EnterButton;
        private System.Windows.Forms.Label FioLabel;
        private System.Windows.Forms.Label NumberLabel;
        private System.Windows.Forms.TextBox FioTextBox;
        private System.Windows.Forms.TextBox PhoneNumberTextBox;
    }
}