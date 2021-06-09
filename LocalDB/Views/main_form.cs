using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LocalDB.Models;
using LocalDB.Services;
using LocalDB.Views;

namespace LocalDB
{
    public partial class main_form : Form
    {
        public StaffModel Staff { get; set; }

        private Dictionary<string, Form> _forms = new Dictionary<string, Form>();

        public main_form()
        {
            InitializeComponent();

            SqlService ss = new SqlService();
            ss.Test();

            var authorization = new Authorization();
            authorization.ShowDialog();
            Staff = authorization.Staff;
            if (Staff == null)
            {
                Application.Exit();
                Load += (s, e) => Close();
            }
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void физическиеЛицаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm<physical_person>();
        }

        private void ShowForm<T>() where T: Form, new ()
        {
            Form form = null;
            var name = typeof(T).Name;
            if (_forms.ContainsKey(name))
                form = _forms[name];
            if (form != null && form.IsDisposed)
            {
                form = new T();
                _forms[name] = form;
            }
            if (form == null)
            {
                form = new T();
                _forms.Add(name, form);
            }


            form.Show();
        }

        private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm<staff>();
        }

        private void делаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm<delo>();
        }

        private void судебноеЗаседаниеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm<court_session>();
        }

        private void уведомлениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm<notification>();
        }

        private void юридическиеЛицаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm<juridical_person>();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ShowForm<NotificationReport>();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            ShowForm<AgendaReport>();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            ShowForm<NoticeReport>();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            ShowForm<DecisionReport>();
        }

        private void настройкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm<SettingsView>();
        }
    }
}
