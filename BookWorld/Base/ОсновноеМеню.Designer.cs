namespace BookWorld
{
    partial class ОсновноеМеню
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.жанрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.типТовараToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.товарыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.постоянныеКлиентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.продажаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новаяПродажаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотрДокументовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.приходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новыйПриходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотрДокументовToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.отчётыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.управлениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справочникиToolStripMenuItem,
            this.продажаToolStripMenuItem,
            this.приходToolStripMenuItem,
            this.отчётыToolStripMenuItem,
            this.управлениеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.жанрыToolStripMenuItem,
            this.типТовараToolStripMenuItem,
            this.товарыToolStripMenuItem,
            this.постоянныеКлиентыToolStripMenuItem});
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // жанрыToolStripMenuItem
            // 
            this.жанрыToolStripMenuItem.Name = "жанрыToolStripMenuItem";
            this.жанрыToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.жанрыToolStripMenuItem.Text = "Жанры";
            this.жанрыToolStripMenuItem.Click += new System.EventHandler(this.жанрыToolStripMenuItem_Click);
            // 
            // типТовараToolStripMenuItem
            // 
            this.типТовараToolStripMenuItem.Name = "типТовараToolStripMenuItem";
            this.типТовараToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.типТовараToolStripMenuItem.Text = "Тип товара";
            this.типТовараToolStripMenuItem.Click += new System.EventHandler(this.типТовараToolStripMenuItem_Click);
            // 
            // товарыToolStripMenuItem
            // 
            this.товарыToolStripMenuItem.Name = "товарыToolStripMenuItem";
            this.товарыToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.товарыToolStripMenuItem.Text = "Товары";
            this.товарыToolStripMenuItem.Click += new System.EventHandler(this.товарыToolStripMenuItem_Click);
            // 
            // постоянныеКлиентыToolStripMenuItem
            // 
            this.постоянныеКлиентыToolStripMenuItem.Name = "постоянныеКлиентыToolStripMenuItem";
            this.постоянныеКлиентыToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.постоянныеКлиентыToolStripMenuItem.Text = "Постоянные клиенты";
            this.постоянныеКлиентыToolStripMenuItem.Click += new System.EventHandler(this.постоянныеКлиентыToolStripMenuItem_Click);
            // 
            // продажаToolStripMenuItem
            // 
            this.продажаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новаяПродажаToolStripMenuItem,
            this.просмотрДокументовToolStripMenuItem});
            this.продажаToolStripMenuItem.Name = "продажаToolStripMenuItem";
            this.продажаToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.продажаToolStripMenuItem.Text = "Продажа";
            // 
            // новаяПродажаToolStripMenuItem
            // 
            this.новаяПродажаToolStripMenuItem.Name = "новаяПродажаToolStripMenuItem";
            this.новаяПродажаToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.новаяПродажаToolStripMenuItem.Text = "Новая продажа";
            this.новаяПродажаToolStripMenuItem.Click += new System.EventHandler(this.новаяПродажаToolStripMenuItem_Click);
            // 
            // просмотрДокументовToolStripMenuItem
            // 
            this.просмотрДокументовToolStripMenuItem.Name = "просмотрДокументовToolStripMenuItem";
            this.просмотрДокументовToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.просмотрДокументовToolStripMenuItem.Text = "Просмотр документов";
            // 
            // приходToolStripMenuItem
            // 
            this.приходToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новыйПриходToolStripMenuItem,
            this.просмотрДокументовToolStripMenuItem1});
            this.приходToolStripMenuItem.Name = "приходToolStripMenuItem";
            this.приходToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.приходToolStripMenuItem.Text = "Приход";
            // 
            // новыйПриходToolStripMenuItem
            // 
            this.новыйПриходToolStripMenuItem.Name = "новыйПриходToolStripMenuItem";
            this.новыйПриходToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.новыйПриходToolStripMenuItem.Text = "Новый приход";
            this.новыйПриходToolStripMenuItem.Click += new System.EventHandler(this.новыйПриходToolStripMenuItem_Click);
            // 
            // просмотрДокументовToolStripMenuItem1
            // 
            this.просмотрДокументовToolStripMenuItem1.Name = "просмотрДокументовToolStripMenuItem1";
            this.просмотрДокументовToolStripMenuItem1.Size = new System.Drawing.Size(199, 22);
            this.просмотрДокументовToolStripMenuItem1.Text = "Просмотр документов";
            // 
            // отчётыToolStripMenuItem
            // 
            this.отчётыToolStripMenuItem.Name = "отчётыToolStripMenuItem";
            this.отчётыToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.отчётыToolStripMenuItem.Text = "Отчёты";
            this.отчётыToolStripMenuItem.Click += new System.EventHandler(this.отчётыToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(382, 415);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Дата";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(627, 415);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Время";
            // 
            // управлениеToolStripMenuItem
            // 
            this.управлениеToolStripMenuItem.Name = "управлениеToolStripMenuItem";
            this.управлениеToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.управлениеToolStripMenuItem.Text = "Управление";
            this.управлениеToolStripMenuItem.Click += new System.EventHandler(this.управлениеToolStripMenuItem_Click);
            // 
            // ОсновноеМеню
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ОсновноеМеню";
            this.ShowIcon = false;
            this.Text = "Основное меню";
            this.Load += new System.EventHandler(this.ОсновноеМеню_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem жанрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem типТовараToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem товарыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem продажаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem приходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчётыToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem постоянныеКлиентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новаяПродажаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem просмотрДокументовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новыйПриходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem просмотрДокументовToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem управлениеToolStripMenuItem;
    }
}

