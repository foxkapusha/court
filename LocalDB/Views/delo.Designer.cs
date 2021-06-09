namespace LocalDB
{
    partial class delo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(delo));
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtDateCase = new System.Windows.Forms.DateTimePicker();
            this.cbStaff = new System.Windows.Forms.ComboBox();
            this.staffModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbOtvetchik = new System.Windows.Forms.ComboBox();
            this.personModelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cbIstets = new System.Windows.Forms.ComboBox();
            this.personModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbTitleCase = new System.Windows.Forms.TextBox();
            this.tbTypeCase = new System.Windows.Forms.TextBox();
            this.tbNumberCase = new System.Windows.Forms.TextBox();
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
            this.idcaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numbercaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datecaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typecaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titlecaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpersonistetsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.idpersonotvetchikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.idstaffDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.caseModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personModelBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personModelBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.caseModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(474, 202);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 42);
            this.button2.TabIndex = 10;
            this.button2.Text = "Выгрузка в Excel";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(331, 202);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(137, 41);
            this.button3.TabIndex = 11;
            this.button3.Text = "Удаление";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(157, 202);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(168, 41);
            this.button4.TabIndex = 12;
            this.button4.Text = "Сохранить изменения";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(14, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 42);
            this.button1.TabIndex = 9;
            this.button1.Text = "Добавление";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtDateCase);
            this.groupBox2.Controls.Add(this.cbStaff);
            this.groupBox2.Controls.Add(this.cbOtvetchik);
            this.groupBox2.Controls.Add(this.cbIstets);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.tbTitleCase);
            this.groupBox2.Controls.Add(this.tbTypeCase);
            this.groupBox2.Controls.Add(this.tbNumberCase);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 211);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 249);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // dtDateCase
            // 
            this.dtDateCase.Location = new System.Drawing.Point(134, 62);
            this.dtDateCase.Name = "dtDateCase";
            this.dtDateCase.Size = new System.Drawing.Size(107, 20);
            this.dtDateCase.TabIndex = 26;
            // 
            // cbStaff
            // 
            this.cbStaff.DataSource = this.staffModelBindingSource;
            this.cbStaff.DisplayMember = "last_name_staff";
            this.cbStaff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStaff.FormattingEnabled = true;
            this.cbStaff.Location = new System.Drawing.Point(400, 161);
            this.cbStaff.Name = "cbStaff";
            this.cbStaff.Size = new System.Drawing.Size(356, 21);
            this.cbStaff.TabIndex = 25;
            this.cbStaff.ValueMember = "Id_staff";
            // 
            // staffModelBindingSource
            // 
            this.staffModelBindingSource.DataSource = typeof(LocalDB.Models.StaffModel);
            // 
            // cbOtvetchik
            // 
            this.cbOtvetchik.DataSource = this.personModelBindingSource1;
            this.cbOtvetchik.DisplayMember = "FIO_person";
            this.cbOtvetchik.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOtvetchik.FormattingEnabled = true;
            this.cbOtvetchik.Location = new System.Drawing.Point(400, 127);
            this.cbOtvetchik.Name = "cbOtvetchik";
            this.cbOtvetchik.Size = new System.Drawing.Size(356, 21);
            this.cbOtvetchik.TabIndex = 24;
            this.cbOtvetchik.ValueMember = "Id_person";
            // 
            // personModelBindingSource1
            // 
            this.personModelBindingSource1.DataSource = typeof(LocalDB.Models.PersonModel);
            // 
            // cbIstets
            // 
            this.cbIstets.DataSource = this.personModelBindingSource;
            this.cbIstets.DisplayMember = "FIO_person";
            this.cbIstets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIstets.FormattingEnabled = true;
            this.cbIstets.Location = new System.Drawing.Point(400, 96);
            this.cbIstets.Name = "cbIstets";
            this.cbIstets.Size = new System.Drawing.Size(356, 21);
            this.cbIstets.TabIndex = 23;
            this.cbIstets.ValueMember = "Id_person";
            // 
            // personModelBindingSource
            // 
            this.personModelBindingSource.DataSource = typeof(LocalDB.Models.PersonModel);
            // 
            // tbTitleCase
            // 
            this.tbTitleCase.Location = new System.Drawing.Point(400, 61);
            this.tbTitleCase.Name = "tbTitleCase";
            this.tbTitleCase.Size = new System.Drawing.Size(356, 20);
            this.tbTitleCase.TabIndex = 19;
            // 
            // tbTypeCase
            // 
            this.tbTypeCase.Location = new System.Drawing.Point(400, 25);
            this.tbTypeCase.Name = "tbTypeCase";
            this.tbTypeCase.Size = new System.Drawing.Size(356, 20);
            this.tbTypeCase.TabIndex = 18;
            // 
            // tbNumberCase
            // 
            this.tbNumberCase.Location = new System.Drawing.Point(134, 101);
            this.tbNumberCase.Name = "tbNumberCase";
            this.tbNumberCase.Size = new System.Drawing.Size(107, 20);
            this.tbNumberCase.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(271, 164);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Судья";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(271, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Ответчик";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(271, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Истец";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(271, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Описание";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Номер дела";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Вид судопроизводства";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дата поступления";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 193);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск по дате";
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
            this.idcaseDataGridViewTextBoxColumn,
            this.numbercaseDataGridViewTextBoxColumn,
            this.datecaseDataGridViewTextBoxColumn,
            this.typecaseDataGridViewTextBoxColumn,
            this.titlecaseDataGridViewTextBoxColumn,
            this.idpersonistetsDataGridViewTextBoxColumn,
            this.idpersonotvetchikDataGridViewTextBoxColumn,
            this.idstaffDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.caseModelBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(7, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(763, 143);
            this.dataGridView1.TabIndex = 0;
            // 
            // idcaseDataGridViewTextBoxColumn
            // 
            this.idcaseDataGridViewTextBoxColumn.DataPropertyName = "Id_case";
            this.idcaseDataGridViewTextBoxColumn.HeaderText = "Id_case";
            this.idcaseDataGridViewTextBoxColumn.Name = "idcaseDataGridViewTextBoxColumn";
            this.idcaseDataGridViewTextBoxColumn.ReadOnly = true;
            this.idcaseDataGridViewTextBoxColumn.Visible = false;
            // 
            // numbercaseDataGridViewTextBoxColumn
            // 
            this.numbercaseDataGridViewTextBoxColumn.DataPropertyName = "number_case";
            this.numbercaseDataGridViewTextBoxColumn.HeaderText = "Номер дела";
            this.numbercaseDataGridViewTextBoxColumn.Name = "numbercaseDataGridViewTextBoxColumn";
            this.numbercaseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datecaseDataGridViewTextBoxColumn
            // 
            this.datecaseDataGridViewTextBoxColumn.DataPropertyName = "date_case";
            this.datecaseDataGridViewTextBoxColumn.HeaderText = "Дата поступления";
            this.datecaseDataGridViewTextBoxColumn.Name = "datecaseDataGridViewTextBoxColumn";
            this.datecaseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typecaseDataGridViewTextBoxColumn
            // 
            this.typecaseDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.typecaseDataGridViewTextBoxColumn.DataPropertyName = "type_case";
            this.typecaseDataGridViewTextBoxColumn.HeaderText = "Вид судопроизводства";
            this.typecaseDataGridViewTextBoxColumn.Name = "typecaseDataGridViewTextBoxColumn";
            this.typecaseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titlecaseDataGridViewTextBoxColumn
            // 
            this.titlecaseDataGridViewTextBoxColumn.DataPropertyName = "title_case";
            this.titlecaseDataGridViewTextBoxColumn.HeaderText = "Описание";
            this.titlecaseDataGridViewTextBoxColumn.Name = "titlecaseDataGridViewTextBoxColumn";
            this.titlecaseDataGridViewTextBoxColumn.ReadOnly = true;
            this.titlecaseDataGridViewTextBoxColumn.Visible = false;
            // 
            // idpersonistetsDataGridViewTextBoxColumn
            // 
            this.idpersonistetsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idpersonistetsDataGridViewTextBoxColumn.DataPropertyName = "Id_person_istets";
            this.idpersonistetsDataGridViewTextBoxColumn.DataSource = this.personModelBindingSource;
            this.idpersonistetsDataGridViewTextBoxColumn.DisplayMember = "FIO_person";
            this.idpersonistetsDataGridViewTextBoxColumn.HeaderText = "Истец";
            this.idpersonistetsDataGridViewTextBoxColumn.Name = "idpersonistetsDataGridViewTextBoxColumn";
            this.idpersonistetsDataGridViewTextBoxColumn.ReadOnly = true;
            this.idpersonistetsDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idpersonistetsDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idpersonistetsDataGridViewTextBoxColumn.ValueMember = "Id_person";
            // 
            // idpersonotvetchikDataGridViewTextBoxColumn
            // 
            this.idpersonotvetchikDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idpersonotvetchikDataGridViewTextBoxColumn.DataPropertyName = "Id_person_otvetchik";
            this.idpersonotvetchikDataGridViewTextBoxColumn.DataSource = this.personModelBindingSource;
            this.idpersonotvetchikDataGridViewTextBoxColumn.DisplayMember = "FIO_person";
            this.idpersonotvetchikDataGridViewTextBoxColumn.HeaderText = "Ответчик";
            this.idpersonotvetchikDataGridViewTextBoxColumn.Name = "idpersonotvetchikDataGridViewTextBoxColumn";
            this.idpersonotvetchikDataGridViewTextBoxColumn.ReadOnly = true;
            this.idpersonotvetchikDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idpersonotvetchikDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idpersonotvetchikDataGridViewTextBoxColumn.ValueMember = "Id_person";
            // 
            // idstaffDataGridViewTextBoxColumn
            // 
            this.idstaffDataGridViewTextBoxColumn.DataPropertyName = "Id_staff";
            this.idstaffDataGridViewTextBoxColumn.HeaderText = "Судья";
            this.idstaffDataGridViewTextBoxColumn.Name = "idstaffDataGridViewTextBoxColumn";
            this.idstaffDataGridViewTextBoxColumn.ReadOnly = true;
            this.idstaffDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idstaffDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idstaffDataGridViewTextBoxColumn.Visible = false;
            // 
            // caseModelBindingSource
            // 
            this.caseModelBindingSource.DataSource = typeof(LocalDB.Models.CaseModel);
            // 
            // delo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::LocalDB.Properties.Settings.Default.CommonBackColor;
            this.ClientSize = new System.Drawing.Size(800, 481);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::LocalDB.Properties.Settings.Default, "CommonBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "delo";
            this.Text = "Дело";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personModelBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personModelBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.caseModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbTypeCase;
        private System.Windows.Forms.TextBox tbNumberCase;
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
        private System.Windows.Forms.ComboBox cbStaff;
        private System.Windows.Forms.ComboBox cbOtvetchik;
        private System.Windows.Forms.ComboBox cbIstets;
        private System.Windows.Forms.TextBox tbTitleCase;
        private System.Windows.Forms.DateTimePicker dtDateCase;
        private System.Windows.Forms.BindingSource caseModelBindingSource;
        private System.Windows.Forms.BindingSource personModelBindingSource;
        private System.Windows.Forms.BindingSource personModelBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numbercaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datecaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typecaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titlecaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idpersonistetsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idpersonotvetchikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idstaffDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource staffModelBindingSource;
    }
}