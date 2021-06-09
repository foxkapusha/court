
namespace LocalDB.Views
{
    partial class DecisionReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DecisionReport));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cbCase = new System.Windows.Forms.ComboBox();
            this.tbStaffName = new System.Windows.Forms.TextBox();
            this.tbCaseNumber = new System.Windows.Forms.TextBox();
            this.tbCaseDate = new System.Windows.Forms.TextBox();
            this.tbIstetsName = new System.Windows.Forms.TextBox();
            this.tbIstetsAddress = new System.Windows.Forms.TextBox();
            this.tbOtvetchikName = new System.Windows.Forms.TextBox();
            this.tbOtvetchikAddress = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(885, 558);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(12, 564);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 42);
            this.button1.TabIndex = 12;
            this.button1.Text = "Выгрузка в Word";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbCase
            // 
            this.cbCase.DisplayMember = "number_case";
            this.cbCase.FormattingEnabled = true;
            this.cbCase.Location = new System.Drawing.Point(167, 271);
            this.cbCase.Name = "cbCase";
            this.cbCase.Size = new System.Drawing.Size(238, 21);
            this.cbCase.TabIndex = 13;
            this.cbCase.ValueMember = "Id_case";
            this.cbCase.SelectedValueChanged += new System.EventHandler(this.cbCase_SelectedValueChanged);
            // 
            // tbStaffName
            // 
            this.tbStaffName.Location = new System.Drawing.Point(642, 413);
            this.tbStaffName.Name = "tbStaffName";
            this.tbStaffName.Size = new System.Drawing.Size(174, 20);
            this.tbStaffName.TabIndex = 19;
            // 
            // tbCaseNumber
            // 
            this.tbCaseNumber.Location = new System.Drawing.Point(371, 373);
            this.tbCaseNumber.Name = "tbCaseNumber";
            this.tbCaseNumber.Size = new System.Drawing.Size(92, 20);
            this.tbCaseNumber.TabIndex = 20;
            // 
            // tbCaseDate
            // 
            this.tbCaseDate.Location = new System.Drawing.Point(214, 373);
            this.tbCaseDate.Name = "tbCaseDate";
            this.tbCaseDate.Size = new System.Drawing.Size(82, 20);
            this.tbCaseDate.TabIndex = 21;
            // 
            // tbIstetsName
            // 
            this.tbIstetsName.Location = new System.Drawing.Point(495, 87);
            this.tbIstetsName.Name = "tbIstetsName";
            this.tbIstetsName.Size = new System.Drawing.Size(321, 20);
            this.tbIstetsName.TabIndex = 22;
            // 
            // tbIstetsAddress
            // 
            this.tbIstetsAddress.Location = new System.Drawing.Point(495, 107);
            this.tbIstetsAddress.Multiline = true;
            this.tbIstetsAddress.Name = "tbIstetsAddress";
            this.tbIstetsAddress.Size = new System.Drawing.Size(321, 43);
            this.tbIstetsAddress.TabIndex = 23;
            // 
            // tbOtvetchikName
            // 
            this.tbOtvetchikName.Location = new System.Drawing.Point(495, 150);
            this.tbOtvetchikName.Name = "tbOtvetchikName";
            this.tbOtvetchikName.Size = new System.Drawing.Size(321, 20);
            this.tbOtvetchikName.TabIndex = 24;
            // 
            // tbOtvetchikAddress
            // 
            this.tbOtvetchikAddress.Location = new System.Drawing.Point(495, 170);
            this.tbOtvetchikAddress.Multiline = true;
            this.tbOtvetchikAddress.Name = "tbOtvetchikAddress";
            this.tbOtvetchikAddress.Size = new System.Drawing.Size(321, 41);
            this.tbOtvetchikAddress.TabIndex = 25;
            // 
            // DecisionReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::LocalDB.Properties.Settings.Default.CommonBackColor;
            this.ClientSize = new System.Drawing.Size(878, 614);
            this.Controls.Add(this.tbOtvetchikAddress);
            this.Controls.Add(this.tbOtvetchikName);
            this.Controls.Add(this.tbIstetsAddress);
            this.Controls.Add(this.tbIstetsName);
            this.Controls.Add(this.tbCaseDate);
            this.Controls.Add(this.tbCaseNumber);
            this.Controls.Add(this.tbStaffName);
            this.Controls.Add(this.cbCase);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::LocalDB.Properties.Settings.Default, "CommonBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Name = "DecisionReport";
            this.Text = "Сопроводительная (печать)";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbCase;
        private System.Windows.Forms.TextBox tbStaffName;
        private System.Windows.Forms.TextBox tbCaseNumber;
        private System.Windows.Forms.TextBox tbCaseDate;
        private System.Windows.Forms.TextBox tbIstetsName;
        private System.Windows.Forms.TextBox tbIstetsAddress;
        private System.Windows.Forms.TextBox tbOtvetchikName;
        private System.Windows.Forms.TextBox tbOtvetchikAddress;
    }
}