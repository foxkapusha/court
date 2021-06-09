
namespace LocalDB.Views
{
    partial class NotificationReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotificationReport));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbCase = new System.Windows.Forms.ComboBox();
            this.caseModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbAction = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbWho = new System.Windows.Forms.TextBox();
            this.tbCase = new System.Windows.Forms.TextBox();
            this.tbWhoMultiline = new System.Windows.Forms.TextBox();
            this.tbDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.caseModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(894, 618);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // cbCase
            // 
            this.cbCase.DataSource = this.caseModelBindingSource;
            this.cbCase.DisplayMember = "number_case";
            this.cbCase.FormattingEnabled = true;
            this.cbCase.Location = new System.Drawing.Point(167, 270);
            this.cbCase.Name = "cbCase";
            this.cbCase.Size = new System.Drawing.Size(238, 21);
            this.cbCase.TabIndex = 1;
            this.cbCase.ValueMember = "Id_case";
            this.cbCase.SelectedIndexChanged += new System.EventHandler(this.cbCase_SelectedIndexChanged);
            this.cbCase.SelectedValueChanged += new System.EventHandler(this.cbCase_SelectedValueChanged);
            // 
            // caseModelBindingSource
            // 
            this.caseModelBindingSource.DataSource = typeof(LocalDB.Models.CaseModel);
            // 
            // tbAction
            // 
            this.tbAction.Location = new System.Drawing.Point(123, 435);
            this.tbAction.Name = "tbAction";
            this.tbAction.Size = new System.Drawing.Size(228, 20);
            this.tbAction.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(12, 626);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 42);
            this.button1.TabIndex = 10;
            this.button1.Text = "Выгрузка в Word";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbWho
            // 
            this.tbWho.Location = new System.Drawing.Point(516, 412);
            this.tbWho.Name = "tbWho";
            this.tbWho.Size = new System.Drawing.Size(278, 20);
            this.tbWho.TabIndex = 11;
            // 
            // tbCase
            // 
            this.tbCase.Location = new System.Drawing.Point(278, 412);
            this.tbCase.Name = "tbCase";
            this.tbCase.Size = new System.Drawing.Size(110, 20);
            this.tbCase.TabIndex = 13;
            // 
            // tbWhoMultiline
            // 
            this.tbWhoMultiline.Location = new System.Drawing.Point(499, 83);
            this.tbWhoMultiline.Multiline = true;
            this.tbWhoMultiline.Name = "tbWhoMultiline";
            this.tbWhoMultiline.Size = new System.Drawing.Size(319, 126);
            this.tbWhoMultiline.TabIndex = 14;
            // 
            // tbDateTime
            // 
            this.tbDateTime.Location = new System.Drawing.Point(466, 434);
            this.tbDateTime.Name = "tbDateTime";
            this.tbDateTime.Size = new System.Drawing.Size(237, 20);
            this.tbDateTime.TabIndex = 15;
            // 
            // NotificationReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::LocalDB.Properties.Settings.Default.CommonBackColor;
            this.ClientSize = new System.Drawing.Size(883, 680);
            this.Controls.Add(this.tbDateTime);
            this.Controls.Add(this.tbWhoMultiline);
            this.Controls.Add(this.tbCase);
            this.Controls.Add(this.tbWho);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbAction);
            this.Controls.Add(this.cbCase);
            this.Controls.Add(this.pictureBox1);
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::LocalDB.Properties.Settings.Default, "CommonBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Name = "NotificationReport";
            this.Text = "Извещение (печать)";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.caseModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbCase;
        private System.Windows.Forms.BindingSource caseModelBindingSource;
        private System.Windows.Forms.TextBox tbAction;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbWho;
        private System.Windows.Forms.TextBox tbCase;
        private System.Windows.Forms.TextBox tbWhoMultiline;
        private System.Windows.Forms.TextBox tbDateTime;
    }
}