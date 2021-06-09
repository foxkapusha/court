
namespace LocalDB.Views
{
    partial class NoticeReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoticeReport));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbCase = new System.Windows.Forms.ComboBox();
            this.tbWho = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbStaffName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbDays = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-4, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(889, 627);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // cbCase
            // 
            this.cbCase.DisplayMember = "number_case";
            this.cbCase.FormattingEnabled = true;
            this.cbCase.Location = new System.Drawing.Point(164, 267);
            this.cbCase.Name = "cbCase";
            this.cbCase.Size = new System.Drawing.Size(238, 21);
            this.cbCase.TabIndex = 12;
            this.cbCase.ValueMember = "Id_case";
            this.cbCase.SelectedValueChanged += new System.EventHandler(this.cbCase_SelectedValueChanged);
            // 
            // tbWho
            // 
            this.tbWho.Location = new System.Drawing.Point(493, 105);
            this.tbWho.Multiline = true;
            this.tbWho.Name = "tbWho";
            this.tbWho.Size = new System.Drawing.Size(253, 38);
            this.tbWho.TabIndex = 15;
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(493, 167);
            this.tbAddress.Multiline = true;
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(253, 84);
            this.tbAddress.TabIndex = 16;
            // 
            // tbStaffName
            // 
            this.tbStaffName.Location = new System.Drawing.Point(653, 511);
            this.tbStaffName.Name = "tbStaffName";
            this.tbStaffName.Size = new System.Drawing.Size(174, 20);
            this.tbStaffName.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(10, 630);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 42);
            this.button1.TabIndex = 11;
            this.button1.Text = "Выгрузка в Word";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbDays
            // 
            this.tbDays.Location = new System.Drawing.Point(445, 390);
            this.tbDays.Name = "tbDays";
            this.tbDays.Size = new System.Drawing.Size(20, 20);
            this.tbDays.TabIndex = 19;
            this.tbDays.Text = "20";
            // 
            // NoticeReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::LocalDB.Properties.Settings.Default.CommonBackColor;
            this.ClientSize = new System.Drawing.Size(876, 683);
            this.Controls.Add(this.tbDays);
            this.Controls.Add(this.tbStaffName);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.tbWho);
            this.Controls.Add(this.cbCase);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::LocalDB.Properties.Settings.Default, "CommonBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Name = "NoticeReport";
            this.Text = "Уведомление (печать)";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbCase;
        private System.Windows.Forms.TextBox tbWho;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbStaffName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbDays;
    }
}