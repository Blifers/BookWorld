namespace BookWorld.Справочники.Товары
{
    partial class ДобавитьТовар
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
            this.AddButton = new System.Windows.Forms.Button();
            this.SellPriceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.BuyPriceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.GenreComboBox = new System.Windows.Forms.ComboBox();
            this.жанрыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookWorldDataSet = new BookWorld.BookWorldDataSet();
            this.TypeComboBox = new System.Windows.Forms.ComboBox();
            this.типТовараBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.тип_ТовараTableAdapter = new BookWorld.BookWorldDataSetTableAdapters.Тип_ТовараTableAdapter();
            this.жанрыTableAdapter = new BookWorld.BookWorldDataSetTableAdapters.ЖанрыTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SellPriceNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BuyPriceNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.жанрыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookWorldDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.типТовараBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(325, 257);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 6;
            this.CloseButton.Text = "Закрыть";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(16, 216);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(384, 23);
            this.AddButton.TabIndex = 5;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // SellPriceNumericUpDown
            // 
            this.SellPriceNumericUpDown.Location = new System.Drawing.Point(102, 173);
            this.SellPriceNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.SellPriceNumericUpDown.Name = "SellPriceNumericUpDown";
            this.SellPriceNumericUpDown.Size = new System.Drawing.Size(298, 20);
            this.SellPriceNumericUpDown.TabIndex = 4;
            this.SellPriceNumericUpDown.Enter += new System.EventHandler(this.SellPriceNumericUpDown_ValueChanged);
            // 
            // BuyPriceNumericUpDown
            // 
            this.BuyPriceNumericUpDown.Location = new System.Drawing.Point(102, 133);
            this.BuyPriceNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.BuyPriceNumericUpDown.Name = "BuyPriceNumericUpDown";
            this.BuyPriceNumericUpDown.Size = new System.Drawing.Size(298, 20);
            this.BuyPriceNumericUpDown.TabIndex = 3;
            this.BuyPriceNumericUpDown.ValueChanged += new System.EventHandler(this.BuyPriceNumericUpDown_ValueChanged);
            this.BuyPriceNumericUpDown.Enter += new System.EventHandler(this.BuyPriceNumericUpDown_Enter);
            // 
            // GenreComboBox
            // 
            this.GenreComboBox.DataSource = this.жанрыBindingSource;
            this.GenreComboBox.DisplayMember = "Наименование";
            this.GenreComboBox.FormattingEnabled = true;
            this.GenreComboBox.Location = new System.Drawing.Point(102, 97);
            this.GenreComboBox.Name = "GenreComboBox";
            this.GenreComboBox.Size = new System.Drawing.Size(298, 21);
            this.GenreComboBox.TabIndex = 2;
            this.GenreComboBox.ValueMember = "Код_Жанра";
            // 
            // жанрыBindingSource
            // 
            this.жанрыBindingSource.DataMember = "Жанры";
            this.жанрыBindingSource.DataSource = this.bookWorldDataSet;
            // 
            // bookWorldDataSet
            // 
            this.bookWorldDataSet.DataSetName = "BookWorldDataSet";
            this.bookWorldDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TypeComboBox
            // 
            this.TypeComboBox.DataSource = this.типТовараBindingSource;
            this.TypeComboBox.DisplayMember = "Наименование";
            this.TypeComboBox.FormattingEnabled = true;
            this.TypeComboBox.Location = new System.Drawing.Point(102, 57);
            this.TypeComboBox.Name = "TypeComboBox";
            this.TypeComboBox.Size = new System.Drawing.Size(298, 21);
            this.TypeComboBox.TabIndex = 1;
            this.TypeComboBox.ValueMember = "Код_Типа";
            this.TypeComboBox.SelectedIndexChanged += new System.EventHandler(this.TypeComboBox_SelectedIndexChanged);
            // 
            // типТовараBindingSource
            // 
            this.типТовараBindingSource.DataMember = "Тип_Товара";
            this.типТовараBindingSource.DataSource = this.bookWorldDataSet;
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(102, 17);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(298, 20);
            this.TitleTextBox.TabIndex = 0;
            // 
            // тип_ТовараTableAdapter
            // 
            this.тип_ТовараTableAdapter.ClearBeforeFill = true;
            // 
            // жанрыTableAdapter
            // 
            this.жанрыTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Наименование";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Тип товара";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Жанр";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Цена покупки";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Цена продажи";
            // 
            // ДобавитьТовар
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 292);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.SellPriceNumericUpDown);
            this.Controls.Add(this.BuyPriceNumericUpDown);
            this.Controls.Add(this.GenreComboBox);
            this.Controls.Add(this.TypeComboBox);
            this.Controls.Add(this.TitleTextBox);
            this.Controls.Add(this.CloseButton);
            this.Name = "ДобавитьТовар";
            this.ShowIcon = false;
            this.Text = "Добавить товар";
            this.Load += new System.EventHandler(this.ДобавитьИзменитьТовар_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SellPriceNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BuyPriceNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.жанрыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookWorldDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.типТовараBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.NumericUpDown SellPriceNumericUpDown;
        private System.Windows.Forms.NumericUpDown BuyPriceNumericUpDown;
        private System.Windows.Forms.ComboBox GenreComboBox;
        private System.Windows.Forms.ComboBox TypeComboBox;
        private System.Windows.Forms.TextBox TitleTextBox;
        private BookWorldDataSet bookWorldDataSet;
        private System.Windows.Forms.BindingSource типТовараBindingSource;
        private BookWorldDataSetTableAdapters.Тип_ТовараTableAdapter тип_ТовараTableAdapter;
        private System.Windows.Forms.BindingSource жанрыBindingSource;
        private BookWorldDataSetTableAdapters.ЖанрыTableAdapter жанрыTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}