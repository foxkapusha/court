namespace LocalDB
{
    partial class notification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(notification));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.cbDepartureTypes = new System.Windows.Forms.ComboBox();
            this.departureTypeModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbPerson = new System.Windows.Forms.ComboBox();
            this.personModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tbTrackNumber = new System.Windows.Forms.TextBox();
            this.tbDocumentType = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idnotificationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typenotificationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpersonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.trecknumberpackageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_departure_type = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.notificationModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departureTypeModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personModelBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notificationModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtDate);
            this.groupBox2.Controls.Add(this.cbDepartureTypes);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cbPerson);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.tbTrackNumber);
            this.groupBox2.Controls.Add(this.tbDocumentType);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 211);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(726, 224);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // dtDate
            // 
            this.dtDate.Location = new System.Drawing.Point(173, 118);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(450, 20);
            this.dtDate.TabIndex = 25;
            // 
            // cbDepartureTypes
            // 
            this.cbDepartureTypes.DataSource = this.departureTypeModelBindingSource;
            this.cbDepartureTypes.DisplayMember = "FullString";
            this.cbDepartureTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDepartureTypes.FormattingEnabled = true;
            this.cbDepartureTypes.Location = new System.Drawing.Point(173, 146);
            this.cbDepartureTypes.Name = "cbDepartureTypes";
            this.cbDepartureTypes.Size = new System.Drawing.Size(450, 21);
            this.cbDepartureTypes.TabIndex = 24;
            this.cbDepartureTypes.ValueMember = "Id_departure_type";
            // 
            // departureTypeModelBindingSource
            // 
            this.departureTypeModelBindingSource.DataSource = typeof(LocalDB.Models.DepartureTypeModel);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Тип отправления";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Дата";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbPerson
            // 
            this.cbPerson.DataSource = this.personModelBindingSource;
            this.cbPerson.DisplayMember = "FIO_person";
            this.cbPerson.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPerson.FormattingEnabled = true;
            this.cbPerson.Location = new System.Drawing.Point(173, 28);
            this.cbPerson.Name = "cbPerson";
            this.cbPerson.Size = new System.Drawing.Size(450, 21);
            this.cbPerson.TabIndex = 21;
            this.cbPerson.ValueMember = "Id_person";
            // 
            // personModelBindingSource
            // 
            this.personModelBindingSource.DataSource = typeof(LocalDB.Models.PersonModel);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(486, 176);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 42);
            this.button2.TabIndex = 10;
            this.button2.Text = "Выгрузка в Excel";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(173, 176);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(137, 41);
            this.button4.TabIndex = 12;
            this.button4.Text = "Редактирование";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(327, 176);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(137, 41);
            this.button3.TabIndex = 11;
            this.button3.Text = "Удаление";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(14, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 42);
            this.button1.TabIndex = 9;
            this.button1.Text = "Добавление";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbTrackNumber
            // 
            this.tbTrackNumber.Location = new System.Drawing.Point(173, 90);
            this.tbTrackNumber.Name = "tbTrackNumber";
            this.tbTrackNumber.Size = new System.Drawing.Size(450, 20);
            this.tbTrackNumber.TabIndex = 20;
            // 
            // tbDocumentType
            // 
            this.tbDocumentType.Location = new System.Drawing.Point(173, 61);
            this.tbDocumentType.Name = "tbDocumentType";
            this.tbDocumentType.Size = new System.Drawing.Size(450, 20);
            this.tbDocumentType.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Трек-номер";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Тип документа";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Получатель";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(726, 193);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск по треку";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(416, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idnotificationDataGridViewTextBoxColumn,
            this.typenotificationDataGridViewTextBoxColumn,
            this.idpersonDataGridViewTextBoxColumn,
            this.trecknumberpackageDataGridViewTextBoxColumn,
            this.date,
            this.id_departure_type});
            this.dataGridView1.DataSource = this.notificationModelBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(7, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(713, 143);
            this.dataGridView1.TabIndex = 0;
            // 
            // idnotificationDataGridViewTextBoxColumn
            // 
            this.idnotificationDataGridViewTextBoxColumn.DataPropertyName = "Id_notification";
            this.idnotificationDataGridViewTextBoxColumn.HeaderText = "ИД";
            this.idnotificationDataGridViewTextBoxColumn.Name = "idnotificationDataGridViewTextBoxColumn";
            this.idnotificationDataGridViewTextBoxColumn.ReadOnly = true;
            this.idnotificationDataGridViewTextBoxColumn.Visible = false;
            // 
            // typenotificationDataGridViewTextBoxColumn
            // 
            this.typenotificationDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.typenotificationDataGridViewTextBoxColumn.DataPropertyName = "type_notification";
            this.typenotificationDataGridViewTextBoxColumn.HeaderText = "Тип";
            this.typenotificationDataGridViewTextBoxColumn.Name = "typenotificationDataGridViewTextBoxColumn";
            this.typenotificationDataGridViewTextBoxColumn.ReadOnly = true;
            this.typenotificationDataGridViewTextBoxColumn.Width = 51;
            // 
            // idpersonDataGridViewTextBoxColumn
            // 
            this.idpersonDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idpersonDataGridViewTextBoxColumn.DataPropertyName = "Id_person";
            this.idpersonDataGridViewTextBoxColumn.DataSource = this.personModelBindingSource;
            this.idpersonDataGridViewTextBoxColumn.DisplayMember = "FIO_person";
            this.idpersonDataGridViewTextBoxColumn.HeaderText = "Получатель";
            this.idpersonDataGridViewTextBoxColumn.Name = "idpersonDataGridViewTextBoxColumn";
            this.idpersonDataGridViewTextBoxColumn.ReadOnly = true;
            this.idpersonDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idpersonDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idpersonDataGridViewTextBoxColumn.ValueMember = "Id_person";
            this.idpersonDataGridViewTextBoxColumn.Width = 91;
            // 
            // trecknumberpackageDataGridViewTextBoxColumn
            // 
            this.trecknumberpackageDataGridViewTextBoxColumn.DataPropertyName = "treck_number_package";
            this.trecknumberpackageDataGridViewTextBoxColumn.HeaderText = "Номер отправления";
            this.trecknumberpackageDataGridViewTextBoxColumn.Name = "trecknumberpackageDataGridViewTextBoxColumn";
            this.trecknumberpackageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // date
            // 
            this.date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.date.DataPropertyName = "date";
            this.date.HeaderText = "Дата";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Width = 58;
            // 
            // id_departure_type
            // 
            this.id_departure_type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.id_departure_type.DataPropertyName = "id_departure_type";
            this.id_departure_type.DataSource = this.departureTypeModelBindingSource;
            this.id_departure_type.DisplayMember = "FullString";
            this.id_departure_type.HeaderText = "Тип отправления";
            this.id_departure_type.Name = "id_departure_type";
            this.id_departure_type.ReadOnly = true;
            this.id_departure_type.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.id_departure_type.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.id_departure_type.ValueMember = "Id_departure_type";
            this.id_departure_type.Width = 109;
            // 
            // notificationModelBindingSource
            // 
            this.notificationModelBindingSource.DataSource = typeof(LocalDB.Models.NotificationModel);
            // 
            // notification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::LocalDB.Properties.Settings.Default.CommonBackColor;
            this.ClientSize = new System.Drawing.Size(748, 447);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::LocalDB.Properties.Settings.Default, "CommonBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "notification";
            this.Text = "Уведомление";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departureTypeModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personModelBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notificationModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbTrackNumber;
        private System.Windows.Forms.TextBox tbDocumentType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource notificationModelBindingSource;
        private System.Windows.Forms.BindingSource personModelBindingSource;
        private System.Windows.Forms.ComboBox cbPerson;
        private System.Windows.Forms.DateTimePicker dtDate;
        private System.Windows.Forms.ComboBox cbDepartureTypes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource departureTypeModelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idnotificationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typenotificationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idpersonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trecknumberpackageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewComboBoxColumn id_departure_type;
    }
}