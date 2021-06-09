namespace LocalDB
{
    partial class court_session
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(court_session));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbSecretary = new System.Windows.Forms.ComboBox();
            this.staffModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.cbCase = new System.Windows.Forms.ComboBox();
            this.caseModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbOtvetchik = new System.Windows.Forms.ComboBox();
            this.personModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cbIstets = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.cbStaff = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.tbPlace = new System.Windows.Forms.TextBox();
            this.tbType = new System.Windows.Forms.TextBox();
            this.tbDateTime = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idcourtsessionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.datetimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idstaffjudgeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.idstaffsecretaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.idpersonistetsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.idpersonotvetchikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.courtSessionModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.caseModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personModelBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courtSessionModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.cbSecretary);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cbCase);
            this.groupBox2.Controls.Add(this.cbOtvetchik);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.cbIstets);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.cbStaff);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tbResult);
            this.groupBox2.Controls.Add(this.tbPlace);
            this.groupBox2.Controls.Add(this.tbType);
            this.groupBox2.Controls.Add(this.tbDateTime);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 211);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 277);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // cbSecretary
            // 
            this.cbSecretary.DataSource = this.staffModelBindingSource;
            this.cbSecretary.DisplayMember = "last_name_staff";
            this.cbSecretary.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSecretary.FormattingEnabled = true;
            this.cbSecretary.Location = new System.Drawing.Point(406, 131);
            this.cbSecretary.Name = "cbSecretary";
            this.cbSecretary.Size = new System.Drawing.Size(356, 21);
            this.cbSecretary.TabIndex = 30;
            this.cbSecretary.ValueMember = "Id_staff";
            // 
            // staffModelBindingSource
            // 
            this.staffModelBindingSource.DataSource = typeof(LocalDB.Models.StaffModel);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(271, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Секретарь";
            // 
            // cbCase
            // 
            this.cbCase.DataSource = this.caseModelBindingSource;
            this.cbCase.DisplayMember = "number_case";
            this.cbCase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCase.FormattingEnabled = true;
            this.cbCase.Location = new System.Drawing.Point(134, 65);
            this.cbCase.Name = "cbCase";
            this.cbCase.Size = new System.Drawing.Size(107, 21);
            this.cbCase.TabIndex = 28;
            this.cbCase.ValueMember = "Id_case";
            // 
            // caseModelBindingSource
            // 
            this.caseModelBindingSource.DataSource = typeof(LocalDB.Models.CaseModel);
            // 
            // cbOtvetchik
            // 
            this.cbOtvetchik.DataSource = this.personModelBindingSource;
            this.cbOtvetchik.DisplayMember = "FIO_person";
            this.cbOtvetchik.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOtvetchik.FormattingEnabled = true;
            this.cbOtvetchik.Location = new System.Drawing.Point(406, 198);
            this.cbOtvetchik.Name = "cbOtvetchik";
            this.cbOtvetchik.Size = new System.Drawing.Size(356, 21);
            this.cbOtvetchik.TabIndex = 27;
            this.cbOtvetchik.ValueMember = "Id_person";
            // 
            // personModelBindingSource
            // 
            this.personModelBindingSource.DataSource = typeof(LocalDB.Models.PersonModel);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(471, 229);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 42);
            this.button2.TabIndex = 10;
            this.button2.Text = "Выгрузка в Excel";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(10, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 42);
            this.button1.TabIndex = 9;
            this.button1.Text = "Добавление";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbIstets
            // 
            this.cbIstets.DataSource = this.personModelBindingSource;
            this.cbIstets.DisplayMember = "FIO_person";
            this.cbIstets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIstets.FormattingEnabled = true;
            this.cbIstets.Location = new System.Drawing.Point(406, 162);
            this.cbIstets.Name = "cbIstets";
            this.cbIstets.Size = new System.Drawing.Size(356, 21);
            this.cbIstets.TabIndex = 26;
            this.cbIstets.ValueMember = "Id_person";
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(328, 230);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(137, 41);
            this.button3.TabIndex = 11;
            this.button3.Text = "Удаление";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cbStaff
            // 
            this.cbStaff.DataSource = this.staffModelBindingSource;
            this.cbStaff.DisplayMember = "last_name_staff";
            this.cbStaff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStaff.FormattingEnabled = true;
            this.cbStaff.Location = new System.Drawing.Point(406, 97);
            this.cbStaff.Name = "cbStaff";
            this.cbStaff.Size = new System.Drawing.Size(356, 21);
            this.cbStaff.TabIndex = 25;
            this.cbStaff.ValueMember = "Id_staff";
            // 
            // button4
            // 
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(153, 230);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(168, 41);
            this.button4.TabIndex = 12;
            this.button4.Text = "Сохранить изменения";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(271, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Истец";
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(406, 65);
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(356, 20);
            this.tbResult.TabIndex = 20;
            // 
            // tbPlace
            // 
            this.tbPlace.Location = new System.Drawing.Point(406, 29);
            this.tbPlace.Name = "tbPlace";
            this.tbPlace.Size = new System.Drawing.Size(356, 20);
            this.tbPlace.TabIndex = 19;
            // 
            // tbType
            // 
            this.tbType.Location = new System.Drawing.Point(134, 132);
            this.tbType.Name = "tbType";
            this.tbType.Size = new System.Drawing.Size(107, 20);
            this.tbType.TabIndex = 18;
            // 
            // tbDateTime
            // 
            this.tbDateTime.Location = new System.Drawing.Point(134, 97);
            this.tbDateTime.Name = "tbDateTime";
            this.tbDateTime.Size = new System.Drawing.Size(107, 20);
            this.tbDateTime.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(271, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Судья";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(271, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Ответчик";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(271, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Результат";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Тип";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Дата и время";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Место проведения";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер дела";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 193);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск по типу";
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
            this.idcourtsessionDataGridViewTextBoxColumn,
            this.idcaseDataGridViewTextBoxColumn,
            this.datetimeDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.resultDataGridViewTextBoxColumn,
            this.placeDataGridViewTextBoxColumn,
            this.idstaffjudgeDataGridViewTextBoxColumn,
            this.idstaffsecretaryDataGridViewTextBoxColumn,
            this.idpersonistetsDataGridViewTextBoxColumn,
            this.idpersonotvetchikDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.courtSessionModelBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(7, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(763, 143);
            this.dataGridView1.TabIndex = 0;
            // 
            // idcourtsessionDataGridViewTextBoxColumn
            // 
            this.idcourtsessionDataGridViewTextBoxColumn.DataPropertyName = "Id_court_session";
            this.idcourtsessionDataGridViewTextBoxColumn.HeaderText = "Id_court_session";
            this.idcourtsessionDataGridViewTextBoxColumn.Name = "idcourtsessionDataGridViewTextBoxColumn";
            this.idcourtsessionDataGridViewTextBoxColumn.ReadOnly = true;
            this.idcourtsessionDataGridViewTextBoxColumn.Visible = false;
            // 
            // idcaseDataGridViewTextBoxColumn
            // 
            this.idcaseDataGridViewTextBoxColumn.DataPropertyName = "Id_case";
            this.idcaseDataGridViewTextBoxColumn.DataSource = this.caseModelBindingSource;
            this.idcaseDataGridViewTextBoxColumn.DisplayMember = "number_case";
            this.idcaseDataGridViewTextBoxColumn.HeaderText = "Номер дела";
            this.idcaseDataGridViewTextBoxColumn.Name = "idcaseDataGridViewTextBoxColumn";
            this.idcaseDataGridViewTextBoxColumn.ReadOnly = true;
            this.idcaseDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idcaseDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idcaseDataGridViewTextBoxColumn.ValueMember = "Id_case";
            // 
            // datetimeDataGridViewTextBoxColumn
            // 
            this.datetimeDataGridViewTextBoxColumn.DataPropertyName = "date_time";
            this.datetimeDataGridViewTextBoxColumn.HeaderText = "Дата и время";
            this.datetimeDataGridViewTextBoxColumn.Name = "datetimeDataGridViewTextBoxColumn";
            this.datetimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Тип";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeDataGridViewTextBoxColumn.Visible = false;
            // 
            // resultDataGridViewTextBoxColumn
            // 
            this.resultDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.resultDataGridViewTextBoxColumn.DataPropertyName = "result";
            this.resultDataGridViewTextBoxColumn.HeaderText = "Результат";
            this.resultDataGridViewTextBoxColumn.Name = "resultDataGridViewTextBoxColumn";
            this.resultDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // placeDataGridViewTextBoxColumn
            // 
            this.placeDataGridViewTextBoxColumn.DataPropertyName = "place";
            this.placeDataGridViewTextBoxColumn.HeaderText = "Место проведения";
            this.placeDataGridViewTextBoxColumn.Name = "placeDataGridViewTextBoxColumn";
            this.placeDataGridViewTextBoxColumn.ReadOnly = true;
            this.placeDataGridViewTextBoxColumn.Visible = false;
            // 
            // idstaffjudgeDataGridViewTextBoxColumn
            // 
            this.idstaffjudgeDataGridViewTextBoxColumn.DataPropertyName = "Id_staff_judge";
            this.idstaffjudgeDataGridViewTextBoxColumn.DataSource = this.staffModelBindingSource;
            this.idstaffjudgeDataGridViewTextBoxColumn.DisplayMember = "last_name_staff";
            this.idstaffjudgeDataGridViewTextBoxColumn.HeaderText = "Судья";
            this.idstaffjudgeDataGridViewTextBoxColumn.Name = "idstaffjudgeDataGridViewTextBoxColumn";
            this.idstaffjudgeDataGridViewTextBoxColumn.ReadOnly = true;
            this.idstaffjudgeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idstaffjudgeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idstaffjudgeDataGridViewTextBoxColumn.ValueMember = "Id_staff";
            this.idstaffjudgeDataGridViewTextBoxColumn.Visible = false;
            // 
            // idstaffsecretaryDataGridViewTextBoxColumn
            // 
            this.idstaffsecretaryDataGridViewTextBoxColumn.DataPropertyName = "Id_staff_secretary";
            this.idstaffsecretaryDataGridViewTextBoxColumn.DataSource = this.staffModelBindingSource;
            this.idstaffsecretaryDataGridViewTextBoxColumn.DisplayMember = "last_name_staff";
            this.idstaffsecretaryDataGridViewTextBoxColumn.HeaderText = "Секретарь";
            this.idstaffsecretaryDataGridViewTextBoxColumn.Name = "idstaffsecretaryDataGridViewTextBoxColumn";
            this.idstaffsecretaryDataGridViewTextBoxColumn.ReadOnly = true;
            this.idstaffsecretaryDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idstaffsecretaryDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idstaffsecretaryDataGridViewTextBoxColumn.ValueMember = "Id_staff";
            this.idstaffsecretaryDataGridViewTextBoxColumn.Visible = false;
            // 
            // idpersonistetsDataGridViewTextBoxColumn
            // 
            this.idpersonistetsDataGridViewTextBoxColumn.DataPropertyName = "Id_person_istets";
            this.idpersonistetsDataGridViewTextBoxColumn.DataSource = this.personModelBindingSource;
            this.idpersonistetsDataGridViewTextBoxColumn.DisplayMember = "FIO_person";
            this.idpersonistetsDataGridViewTextBoxColumn.HeaderText = "Истец";
            this.idpersonistetsDataGridViewTextBoxColumn.Name = "idpersonistetsDataGridViewTextBoxColumn";
            this.idpersonistetsDataGridViewTextBoxColumn.ReadOnly = true;
            this.idpersonistetsDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idpersonistetsDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idpersonistetsDataGridViewTextBoxColumn.ValueMember = "Id_person";
            this.idpersonistetsDataGridViewTextBoxColumn.Visible = false;
            // 
            // idpersonotvetchikDataGridViewTextBoxColumn
            // 
            this.idpersonotvetchikDataGridViewTextBoxColumn.DataPropertyName = "Id_person_otvetchik";
            this.idpersonotvetchikDataGridViewTextBoxColumn.DataSource = this.personModelBindingSource;
            this.idpersonotvetchikDataGridViewTextBoxColumn.DisplayMember = "FIO_person";
            this.idpersonotvetchikDataGridViewTextBoxColumn.HeaderText = "Ответчик";
            this.idpersonotvetchikDataGridViewTextBoxColumn.Name = "idpersonotvetchikDataGridViewTextBoxColumn";
            this.idpersonotvetchikDataGridViewTextBoxColumn.ReadOnly = true;
            this.idpersonotvetchikDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idpersonotvetchikDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idpersonotvetchikDataGridViewTextBoxColumn.ValueMember = "Id_person";
            this.idpersonotvetchikDataGridViewTextBoxColumn.Visible = false;
            // 
            // courtSessionModelBindingSource
            // 
            this.courtSessionModelBindingSource.DataSource = typeof(LocalDB.Models.CourtSessionModel);
            // 
            // button5
            // 
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(625, 229);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(137, 42);
            this.button5.TabIndex = 31;
            this.button5.Text = "Напоминание";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // court_session
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::LocalDB.Properties.Settings.Default.CommonBackColor;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::LocalDB.Properties.Settings.Default, "CommonBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "court_session";
            this.Text = "Судебное заседание";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.caseModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personModelBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courtSessionModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.TextBox tbPlace;
        private System.Windows.Forms.TextBox tbType;
        private System.Windows.Forms.TextBox tbDateTime;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource courtSessionModelBindingSource;
        private System.Windows.Forms.ComboBox cbOtvetchik;
        private System.Windows.Forms.ComboBox cbStaff;
        private System.Windows.Forms.ComboBox cbIstets;
        private System.Windows.Forms.ComboBox cbCase;
        private System.Windows.Forms.ComboBox cbSecretary;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource staffModelBindingSource;
        private System.Windows.Forms.BindingSource caseModelBindingSource;
        private System.Windows.Forms.BindingSource personModelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcourtsessionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idcaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datetimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idstaffjudgeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idstaffsecretaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idpersonistetsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idpersonotvetchikDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button5;
    }
}