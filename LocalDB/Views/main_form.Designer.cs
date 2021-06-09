namespace LocalDB
{
    partial class main_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main_form));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сотрудникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.физическиеЛицаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.юридическиеЛицаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.судопроизводствоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.делаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.судебноеЗаседаниеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.уведомлениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.шаблоныДокументовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справочникиToolStripMenuItem,
            this.судопроизводствоToolStripMenuItem,
            this.шаблоныДокументовToolStripMenuItem,
            this.настройкиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.закрытьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // закрытьToolStripMenuItem
            // 
            this.закрытьToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.закрытьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("закрытьToolStripMenuItem.Image")));
            this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            this.закрытьToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.закрытьToolStripMenuItem.Text = "Закрыть";
            this.закрытьToolStripMenuItem.Click += new System.EventHandler(this.закрытьToolStripMenuItem_Click);
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сотрудникиToolStripMenuItem,
            this.физическиеЛицаToolStripMenuItem,
            this.юридическиеЛицаToolStripMenuItem});
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // сотрудникиToolStripMenuItem
            // 
            this.сотрудникиToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("сотрудникиToolStripMenuItem.Image")));
            this.сотрудникиToolStripMenuItem.Name = "сотрудникиToolStripMenuItem";
            this.сотрудникиToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.сотрудникиToolStripMenuItem.Text = "Сотрудники";
            this.сотрудникиToolStripMenuItem.Click += new System.EventHandler(this.сотрудникиToolStripMenuItem_Click);
            // 
            // физическиеЛицаToolStripMenuItem
            // 
            this.физическиеЛицаToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("физическиеЛицаToolStripMenuItem.Image")));
            this.физическиеЛицаToolStripMenuItem.Name = "физическиеЛицаToolStripMenuItem";
            this.физическиеЛицаToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.физическиеЛицаToolStripMenuItem.Text = "Физические лица";
            this.физическиеЛицаToolStripMenuItem.Click += new System.EventHandler(this.физическиеЛицаToolStripMenuItem_Click);
            // 
            // юридическиеЛицаToolStripMenuItem
            // 
            this.юридическиеЛицаToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("юридическиеЛицаToolStripMenuItem.Image")));
            this.юридическиеЛицаToolStripMenuItem.Name = "юридическиеЛицаToolStripMenuItem";
            this.юридическиеЛицаToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.юридическиеЛицаToolStripMenuItem.Text = "Юридические лица";
            this.юридическиеЛицаToolStripMenuItem.Click += new System.EventHandler(this.юридическиеЛицаToolStripMenuItem_Click);
            // 
            // судопроизводствоToolStripMenuItem
            // 
            this.судопроизводствоToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.делаToolStripMenuItem,
            this.судебноеЗаседаниеToolStripMenuItem,
            this.уведомлениеToolStripMenuItem});
            this.судопроизводствоToolStripMenuItem.Name = "судопроизводствоToolStripMenuItem";
            this.судопроизводствоToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.судопроизводствоToolStripMenuItem.Text = "Судопроизводство";
            // 
            // делаToolStripMenuItem
            // 
            this.делаToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("делаToolStripMenuItem.Image")));
            this.делаToolStripMenuItem.Name = "делаToolStripMenuItem";
            this.делаToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.делаToolStripMenuItem.Text = "Дело";
            this.делаToolStripMenuItem.Click += new System.EventHandler(this.делаToolStripMenuItem_Click);
            // 
            // судебноеЗаседаниеToolStripMenuItem
            // 
            this.судебноеЗаседаниеToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("судебноеЗаседаниеToolStripMenuItem.Image")));
            this.судебноеЗаседаниеToolStripMenuItem.Name = "судебноеЗаседаниеToolStripMenuItem";
            this.судебноеЗаседаниеToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.судебноеЗаседаниеToolStripMenuItem.Text = "Судебное заседание";
            this.судебноеЗаседаниеToolStripMenuItem.Click += new System.EventHandler(this.судебноеЗаседаниеToolStripMenuItem_Click);
            // 
            // уведомлениеToolStripMenuItem
            // 
            this.уведомлениеToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("уведомлениеToolStripMenuItem.Image")));
            this.уведомлениеToolStripMenuItem.Name = "уведомлениеToolStripMenuItem";
            this.уведомлениеToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.уведомлениеToolStripMenuItem.Text = "Уведомление";
            this.уведомлениеToolStripMenuItem.Click += new System.EventHandler(this.уведомлениеToolStripMenuItem_Click);
            // 
            // шаблоныДокументовToolStripMenuItem
            // 
            this.шаблоныДокументовToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5});
            this.шаблоныДокументовToolStripMenuItem.Name = "шаблоныДокументовToolStripMenuItem";
            this.шаблоныДокументовToolStripMenuItem.Size = new System.Drawing.Size(141, 20);
            this.шаблоныДокументовToolStripMenuItem.Text = "Шаблоны документов";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem2.Image")));
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem2.Text = "Извещение";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem3.Image")));
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem3.Text = "Судебная повестка";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem4.Image")));
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem4.Text = "Уведомление";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem5.Image")));
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem5.Text = "Сопроводительное";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = global::LocalDB.Properties.Settings.Default.CommonBackColor;
            this.pictureBox1.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::LocalDB.Properties.Settings.Default, "CommonBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 511);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            this.настройкиToolStripMenuItem.Click += new System.EventHandler(this.настройкиToolStripMenuItem_Click);
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "main_form";
            this.Text = "Информационная система";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сотрудникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem физическиеЛицаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem юридическиеЛицаToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem судопроизводствоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem делаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem судебноеЗаседаниеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem уведомлениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem шаблоныДокументовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
    }
}

