
namespace LocalDB.Views
{
    partial class AgendaReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgendaReport));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cbCase = new System.Windows.Forms.ComboBox();
            this.caseModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbJudje = new System.Windows.Forms.TextBox();
            this.tbWhotype = new System.Windows.Forms.TextBox();
            this.tbHours = new System.Windows.Forms.TextBox();
            this.tbMonth = new System.Windows.Forms.TextBox();
            this.tbYear = new System.Windows.Forms.TextBox();
            this.tbCaseNumber2 = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbSecretar = new System.Windows.Forms.TextBox();
            this.tbWhereaddress = new System.Windows.Forms.TextBox();
            this.cbWhotosend = new System.Windows.Forms.ComboBox();
            this.personModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.caseModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-4, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(591, 415);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(12, 436);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 42);
            this.button1.TabIndex = 11;
            this.button1.Text = "Выгрузка в Word";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbCase
            // 
            this.cbCase.DataSource = this.caseModelBindingSource;
            this.cbCase.DisplayMember = "number_case";
            this.cbCase.FormattingEnabled = true;
            this.cbCase.Location = new System.Drawing.Point(344, 88);
            this.cbCase.Name = "cbCase";
            this.cbCase.Size = new System.Drawing.Size(121, 21);
            this.cbCase.TabIndex = 13;
            this.cbCase.ValueMember = "Id_case";
            this.cbCase.SelectedValueChanged += new System.EventHandler(this.cbCase_SelectedValueChanged);
            // 
            // caseModelBindingSource
            // 
            this.caseModelBindingSource.DataSource = typeof(LocalDB.Models.CaseModel);
            // 
            // tbJudje
            // 
            this.tbJudje.Location = new System.Drawing.Point(23, 146);
            this.tbJudje.Name = "tbJudje";
            this.tbJudje.Size = new System.Drawing.Size(228, 20);
            this.tbJudje.TabIndex = 14;
            // 
            // tbWhotype
            // 
            this.tbWhotype.Location = new System.Drawing.Point(23, 198);
            this.tbWhotype.Name = "tbWhotype";
            this.tbWhotype.Size = new System.Drawing.Size(228, 20);
            this.tbWhotype.TabIndex = 15;
            this.tbWhotype.Text = "истца";
            // 
            // tbHours
            // 
            this.tbHours.Location = new System.Drawing.Point(33, 224);
            this.tbHours.Name = "tbHours";
            this.tbHours.Size = new System.Drawing.Size(39, 20);
            this.tbHours.TabIndex = 16;
            // 
            // tbMonth
            // 
            this.tbMonth.Location = new System.Drawing.Point(106, 224);
            this.tbMonth.Name = "tbMonth";
            this.tbMonth.Size = new System.Drawing.Size(87, 20);
            this.tbMonth.TabIndex = 17;
            // 
            // tbYear
            // 
            this.tbYear.Location = new System.Drawing.Point(218, 224);
            this.tbYear.Name = "tbYear";
            this.tbYear.Size = new System.Drawing.Size(22, 20);
            this.tbYear.TabIndex = 18;
            this.tbYear.Text = "21";
            // 
            // tbCaseNumber2
            // 
            this.tbCaseNumber2.Location = new System.Drawing.Point(79, 250);
            this.tbCaseNumber2.Name = "tbCaseNumber2";
            this.tbCaseNumber2.Size = new System.Drawing.Size(172, 20);
            this.tbCaseNumber2.TabIndex = 19;
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(23, 295);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(228, 20);
            this.tbAddress.TabIndex = 20;
            this.tbAddress.Text = "г. Рубцовск, ул. Октябрьская, 159, каб. 7";
            // 
            // tbSecretar
            // 
            this.tbSecretar.Location = new System.Drawing.Point(140, 353);
            this.tbSecretar.Name = "tbSecretar";
            this.tbSecretar.Size = new System.Drawing.Size(228, 20);
            this.tbSecretar.TabIndex = 21;
            this.tbSecretar.Text = "Кудина Ксения Владимировна";
            // 
            // tbWhereaddress
            // 
            this.tbWhereaddress.Location = new System.Drawing.Point(310, 146);
            this.tbWhereaddress.Multiline = true;
            this.tbWhereaddress.Name = "tbWhereaddress";
            this.tbWhereaddress.Size = new System.Drawing.Size(228, 51);
            this.tbWhereaddress.TabIndex = 22;
            // 
            // cbWhotosend
            // 
            this.cbWhotosend.DataSource = this.personModelBindingSource;
            this.cbWhotosend.DisplayMember = "FIO_person";
            this.cbWhotosend.FormattingEnabled = true;
            this.cbWhotosend.Location = new System.Drawing.Point(310, 238);
            this.cbWhotosend.Name = "cbWhotosend";
            this.cbWhotosend.Size = new System.Drawing.Size(228, 21);
            this.cbWhotosend.TabIndex = 24;
            this.cbWhotosend.ValueMember = "Id_person";
            // 
            // personModelBindingSource
            // 
            this.personModelBindingSource.DataSource = typeof(LocalDB.Models.PersonModel);
            // 
            // AgendaReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::LocalDB.Properties.Settings.Default.CommonBackColor;
            this.ClientSize = new System.Drawing.Size(581, 492);
            this.Controls.Add(this.cbWhotosend);
            this.Controls.Add(this.tbWhereaddress);
            this.Controls.Add(this.tbSecretar);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.tbCaseNumber2);
            this.Controls.Add(this.tbYear);
            this.Controls.Add(this.tbMonth);
            this.Controls.Add(this.tbHours);
            this.Controls.Add(this.tbWhotype);
            this.Controls.Add(this.tbJudje);
            this.Controls.Add(this.cbCase);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::LocalDB.Properties.Settings.Default, "CommonBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Name = "AgendaReport";
            this.Text = "Судебная повестка (печать)";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.caseModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbCase;
        private System.Windows.Forms.TextBox tbJudje;
        private System.Windows.Forms.TextBox tbWhotype;
        private System.Windows.Forms.TextBox tbHours;
        private System.Windows.Forms.TextBox tbMonth;
        private System.Windows.Forms.TextBox tbYear;
        private System.Windows.Forms.TextBox tbCaseNumber2;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbSecretar;
        private System.Windows.Forms.TextBox tbWhereaddress;
        private System.Windows.Forms.BindingSource caseModelBindingSource;
        private System.Windows.Forms.ComboBox cbWhotosend;
        private System.Windows.Forms.BindingSource personModelBindingSource;
    }
}