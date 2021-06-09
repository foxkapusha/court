namespace LocalDB
{
    partial class physical_person
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(physical_person));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idpersonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIOpersonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passportseriaphysicalpersonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passportnumberphysicalpersonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passportcodephysicalpersonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passportplacephysicalpersonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passportdatephysicalpersonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresspersonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephonepersonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titlejuridicalpersonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNNjuridicalpersonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kPPjuridicalpersonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oGRNjuridicalpersonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oKPOjuridicalpersonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.personModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tbPassportCode = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.tbPassportDate = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.tbPassportPlace = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbPassportSeries = new System.Windows.Forms.TextBox();
            this.tbPassportNumber = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbFio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personModelBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(707, 193);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск по ФИО";
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
            this.idpersonDataGridViewTextBoxColumn,
            this.fIOpersonDataGridViewTextBoxColumn,
            this.passportseriaphysicalpersonDataGridViewTextBoxColumn,
            this.passportnumberphysicalpersonDataGridViewTextBoxColumn,
            this.passportcodephysicalpersonDataGridViewTextBoxColumn,
            this.passportplacephysicalpersonDataGridViewTextBoxColumn,
            this.passportdatephysicalpersonDataGridViewTextBoxColumn,
            this.adresspersonDataGridViewTextBoxColumn,
            this.telephonepersonDataGridViewTextBoxColumn,
            this.titlejuridicalpersonDataGridViewTextBoxColumn,
            this.iNNjuridicalpersonDataGridViewTextBoxColumn,
            this.kPPjuridicalpersonDataGridViewTextBoxColumn,
            this.oGRNjuridicalpersonDataGridViewTextBoxColumn,
            this.oKPOjuridicalpersonDataGridViewTextBoxColumn,
            this.typeDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.personModelBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(7, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(694, 143);
            this.dataGridView1.TabIndex = 0;
            // 
            // idpersonDataGridViewTextBoxColumn
            // 
            this.idpersonDataGridViewTextBoxColumn.DataPropertyName = "Id_person";
            this.idpersonDataGridViewTextBoxColumn.HeaderText = "ИД";
            this.idpersonDataGridViewTextBoxColumn.Name = "idpersonDataGridViewTextBoxColumn";
            this.idpersonDataGridViewTextBoxColumn.ReadOnly = true;
            this.idpersonDataGridViewTextBoxColumn.Visible = false;
            // 
            // fIOpersonDataGridViewTextBoxColumn
            // 
            this.fIOpersonDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.fIOpersonDataGridViewTextBoxColumn.DataPropertyName = "FIO_person";
            this.fIOpersonDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.fIOpersonDataGridViewTextBoxColumn.Name = "fIOpersonDataGridViewTextBoxColumn";
            this.fIOpersonDataGridViewTextBoxColumn.ReadOnly = true;
            this.fIOpersonDataGridViewTextBoxColumn.Width = 59;
            // 
            // passportseriaphysicalpersonDataGridViewTextBoxColumn
            // 
            this.passportseriaphysicalpersonDataGridViewTextBoxColumn.DataPropertyName = "passport_seria_physical_person";
            this.passportseriaphysicalpersonDataGridViewTextBoxColumn.HeaderText = "Паспорт серия";
            this.passportseriaphysicalpersonDataGridViewTextBoxColumn.Name = "passportseriaphysicalpersonDataGridViewTextBoxColumn";
            this.passportseriaphysicalpersonDataGridViewTextBoxColumn.ReadOnly = true;
            this.passportseriaphysicalpersonDataGridViewTextBoxColumn.Visible = false;
            // 
            // passportnumberphysicalpersonDataGridViewTextBoxColumn
            // 
            this.passportnumberphysicalpersonDataGridViewTextBoxColumn.DataPropertyName = "passport_number_physical_person";
            this.passportnumberphysicalpersonDataGridViewTextBoxColumn.HeaderText = "Паспорт номер";
            this.passportnumberphysicalpersonDataGridViewTextBoxColumn.Name = "passportnumberphysicalpersonDataGridViewTextBoxColumn";
            this.passportnumberphysicalpersonDataGridViewTextBoxColumn.ReadOnly = true;
            this.passportnumberphysicalpersonDataGridViewTextBoxColumn.Visible = false;
            // 
            // passportcodephysicalpersonDataGridViewTextBoxColumn
            // 
            this.passportcodephysicalpersonDataGridViewTextBoxColumn.DataPropertyName = "passport_code_physical_person";
            this.passportcodephysicalpersonDataGridViewTextBoxColumn.HeaderText = "Паспорт код подразделения";
            this.passportcodephysicalpersonDataGridViewTextBoxColumn.Name = "passportcodephysicalpersonDataGridViewTextBoxColumn";
            this.passportcodephysicalpersonDataGridViewTextBoxColumn.ReadOnly = true;
            this.passportcodephysicalpersonDataGridViewTextBoxColumn.Visible = false;
            // 
            // passportplacephysicalpersonDataGridViewTextBoxColumn
            // 
            this.passportplacephysicalpersonDataGridViewTextBoxColumn.DataPropertyName = "passport_place_physical_person";
            this.passportplacephysicalpersonDataGridViewTextBoxColumn.HeaderText = "Паспорт кем выдано";
            this.passportplacephysicalpersonDataGridViewTextBoxColumn.Name = "passportplacephysicalpersonDataGridViewTextBoxColumn";
            this.passportplacephysicalpersonDataGridViewTextBoxColumn.ReadOnly = true;
            this.passportplacephysicalpersonDataGridViewTextBoxColumn.Visible = false;
            // 
            // passportdatephysicalpersonDataGridViewTextBoxColumn
            // 
            this.passportdatephysicalpersonDataGridViewTextBoxColumn.DataPropertyName = "passport_date_physical_person";
            this.passportdatephysicalpersonDataGridViewTextBoxColumn.HeaderText = "Паспорт дата выдачи";
            this.passportdatephysicalpersonDataGridViewTextBoxColumn.Name = "passportdatephysicalpersonDataGridViewTextBoxColumn";
            this.passportdatephysicalpersonDataGridViewTextBoxColumn.ReadOnly = true;
            this.passportdatephysicalpersonDataGridViewTextBoxColumn.Visible = false;
            // 
            // adresspersonDataGridViewTextBoxColumn
            // 
            this.adresspersonDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.adresspersonDataGridViewTextBoxColumn.DataPropertyName = "adress_person";
            this.adresspersonDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.adresspersonDataGridViewTextBoxColumn.Name = "adresspersonDataGridViewTextBoxColumn";
            this.adresspersonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telephonepersonDataGridViewTextBoxColumn
            // 
            this.telephonepersonDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.telephonepersonDataGridViewTextBoxColumn.DataPropertyName = "telephone_person";
            this.telephonepersonDataGridViewTextBoxColumn.HeaderText = "Телефонный номер";
            this.telephonepersonDataGridViewTextBoxColumn.Name = "telephonepersonDataGridViewTextBoxColumn";
            this.telephonepersonDataGridViewTextBoxColumn.ReadOnly = true;
            this.telephonepersonDataGridViewTextBoxColumn.Width = 121;
            // 
            // titlejuridicalpersonDataGridViewTextBoxColumn
            // 
            this.titlejuridicalpersonDataGridViewTextBoxColumn.DataPropertyName = "title_juridical_person";
            this.titlejuridicalpersonDataGridViewTextBoxColumn.HeaderText = "title_juridical_person";
            this.titlejuridicalpersonDataGridViewTextBoxColumn.Name = "titlejuridicalpersonDataGridViewTextBoxColumn";
            this.titlejuridicalpersonDataGridViewTextBoxColumn.ReadOnly = true;
            this.titlejuridicalpersonDataGridViewTextBoxColumn.Visible = false;
            // 
            // iNNjuridicalpersonDataGridViewTextBoxColumn
            // 
            this.iNNjuridicalpersonDataGridViewTextBoxColumn.DataPropertyName = "INN_juridical_person";
            this.iNNjuridicalpersonDataGridViewTextBoxColumn.HeaderText = "INN_juridical_person";
            this.iNNjuridicalpersonDataGridViewTextBoxColumn.Name = "iNNjuridicalpersonDataGridViewTextBoxColumn";
            this.iNNjuridicalpersonDataGridViewTextBoxColumn.ReadOnly = true;
            this.iNNjuridicalpersonDataGridViewTextBoxColumn.Visible = false;
            // 
            // kPPjuridicalpersonDataGridViewTextBoxColumn
            // 
            this.kPPjuridicalpersonDataGridViewTextBoxColumn.DataPropertyName = "KPP_juridical_person";
            this.kPPjuridicalpersonDataGridViewTextBoxColumn.HeaderText = "KPP_juridical_person";
            this.kPPjuridicalpersonDataGridViewTextBoxColumn.Name = "kPPjuridicalpersonDataGridViewTextBoxColumn";
            this.kPPjuridicalpersonDataGridViewTextBoxColumn.ReadOnly = true;
            this.kPPjuridicalpersonDataGridViewTextBoxColumn.Visible = false;
            // 
            // oGRNjuridicalpersonDataGridViewTextBoxColumn
            // 
            this.oGRNjuridicalpersonDataGridViewTextBoxColumn.DataPropertyName = "OGRN_juridical_person";
            this.oGRNjuridicalpersonDataGridViewTextBoxColumn.HeaderText = "OGRN_juridical_person";
            this.oGRNjuridicalpersonDataGridViewTextBoxColumn.Name = "oGRNjuridicalpersonDataGridViewTextBoxColumn";
            this.oGRNjuridicalpersonDataGridViewTextBoxColumn.ReadOnly = true;
            this.oGRNjuridicalpersonDataGridViewTextBoxColumn.Visible = false;
            // 
            // oKPOjuridicalpersonDataGridViewTextBoxColumn
            // 
            this.oKPOjuridicalpersonDataGridViewTextBoxColumn.DataPropertyName = "OKPO_juridical_person";
            this.oKPOjuridicalpersonDataGridViewTextBoxColumn.HeaderText = "OKPO_juridical_person";
            this.oKPOjuridicalpersonDataGridViewTextBoxColumn.Name = "oKPOjuridicalpersonDataGridViewTextBoxColumn";
            this.oKPOjuridicalpersonDataGridViewTextBoxColumn.ReadOnly = true;
            this.oKPOjuridicalpersonDataGridViewTextBoxColumn.Visible = false;
            // 
            // typeDataGridViewCheckBoxColumn
            // 
            this.typeDataGridViewCheckBoxColumn.DataPropertyName = "type";
            this.typeDataGridViewCheckBoxColumn.HeaderText = "type";
            this.typeDataGridViewCheckBoxColumn.Name = "typeDataGridViewCheckBoxColumn";
            this.typeDataGridViewCheckBoxColumn.ReadOnly = true;
            this.typeDataGridViewCheckBoxColumn.Visible = false;
            // 
            // personModelBindingSource
            // 
            this.personModelBindingSource.DataSource = typeof(LocalDB.Models.PersonModel);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.tbPassportCode);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.tbPassportDate);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.tbPassportPlace);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.tbPassportSeries);
            this.groupBox2.Controls.Add(this.tbPassportNumber);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tbPhone);
            this.groupBox2.Controls.Add(this.tbAddress);
            this.groupBox2.Controls.Add(this.tbFio);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 211);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(707, 265);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // button6
            // 
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(172, 170);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(144, 42);
            this.button6.TabIndex = 19;
            this.button6.Text = "Просмотреть";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(11, 170);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(155, 42);
            this.button5.TabIndex = 18;
            this.button5.Text = "Загрузить согласие";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(467, 217);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 42);
            this.button2.TabIndex = 4;
            this.button2.Text = "Выгрузка в Excel";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbPassportCode
            // 
            this.tbPassportCode.Location = new System.Drawing.Point(457, 168);
            this.tbPassportCode.Name = "tbPassportCode";
            this.tbPassportCode.Size = new System.Drawing.Size(202, 20);
            this.tbPassportCode.TabIndex = 17;
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(324, 217);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(137, 41);
            this.button3.TabIndex = 5;
            this.button3.Text = "Удаление";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tbPassportDate
            // 
            this.tbPassportDate.Location = new System.Drawing.Point(457, 144);
            this.tbPassportDate.Name = "tbPassportDate";
            this.tbPassportDate.Size = new System.Drawing.Size(202, 20);
            this.tbPassportDate.TabIndex = 16;
            // 
            // button4
            // 
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(154, 217);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(162, 41);
            this.button4.TabIndex = 6;
            this.button4.Text = "Сохранить изменения";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tbPassportPlace
            // 
            this.tbPassportPlace.Location = new System.Drawing.Point(457, 101);
            this.tbPassportPlace.Multiline = true;
            this.tbPassportPlace.Name = "tbPassportPlace";
            this.tbPassportPlace.Size = new System.Drawing.Size(202, 37);
            this.tbPassportPlace.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(11, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 42);
            this.button1.TabIndex = 3;
            this.button1.Text = "Добавление";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbPassportSeries
            // 
            this.tbPassportSeries.Location = new System.Drawing.Point(457, 75);
            this.tbPassportSeries.Name = "tbPassportSeries";
            this.tbPassportSeries.Size = new System.Drawing.Size(202, 20);
            this.tbPassportSeries.TabIndex = 14;
            // 
            // tbPassportNumber
            // 
            this.tbPassportNumber.Location = new System.Drawing.Point(457, 49);
            this.tbPassportNumber.Name = "tbPassportNumber";
            this.tbPassportNumber.Size = new System.Drawing.Size(202, 20);
            this.tbPassportNumber.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(342, 175);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Код подразделения";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(7, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(187, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "КОНТАКТНАЯ ИНФОРМАЦИЯ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(342, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Дата выдачи";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(342, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Место выдачи";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(342, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Серия";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(339, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Номер";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(339, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "ПАСПОРТНЫЕ ДАННЫЕ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Телефон";
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(65, 144);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(227, 20);
            this.tbPhone.TabIndex = 4;
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(65, 83);
            this.tbAddress.Multiline = true;
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(227, 48);
            this.tbAddress.TabIndex = 3;
            // 
            // tbFio
            // 
            this.tbFio.Location = new System.Drawing.Point(65, 49);
            this.tbFio.Name = "tbFio";
            this.tbFio.Size = new System.Drawing.Size(227, 20);
            this.tbFio.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Адрес";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ФИО";
            // 
            // physical_person
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::LocalDB.Properties.Settings.Default.CommonBackColor;
            this.ClientSize = new System.Drawing.Size(740, 479);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::LocalDB.Properties.Settings.Default, "CommonBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "physical_person";
            this.Text = "Физические лица";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personModelBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbFio;
        private System.Windows.Forms.TextBox tbPassportCode;
        private System.Windows.Forms.TextBox tbPassportDate;
        private System.Windows.Forms.TextBox tbPassportPlace;
        private System.Windows.Forms.TextBox tbPassportSeries;
        private System.Windows.Forms.TextBox tbPassportNumber;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource personModelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpersonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIOpersonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passportseriaphysicalpersonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passportnumberphysicalpersonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passportcodephysicalpersonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passportplacephysicalpersonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passportdatephysicalpersonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresspersonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephonepersonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titlejuridicalpersonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNNjuridicalpersonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kPPjuridicalpersonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oGRNjuridicalpersonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oKPOjuridicalpersonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn typeDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}