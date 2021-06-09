using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LocalDB.Models;
using LocalDB.Services;

namespace LocalDB
{
    public partial class notification : Form
    {
        private BindingList<NotificationModel> _list;
        private BindingList<PersonModel> _personList;
        private BindingList<DepartureTypeModel> _departureTypeList;
        private SqlService _sqlService;

        public notification()
        {
            InitializeComponent();

            _list = new BindingList<NotificationModel>();
            _personList = new BindingList<PersonModel>();
            _departureTypeList = new BindingList<DepartureTypeModel>();
            _sqlService = new SqlService();

            LoadNotifications();

            dataGridView1.DataSource = _list;
            (dataGridView1.Columns[2] as DataGridViewComboBoxColumn).DataSource = _personList;
            (dataGridView1.Columns[5] as DataGridViewComboBoxColumn).DataSource = _departureTypeList;
            cbPerson.DataSource = _personList;
            cbDepartureTypes.DataSource = _departureTypeList;

            tbDocumentType.DataBindings.Add("Text", _list, "type_notification", false, DataSourceUpdateMode.OnPropertyChanged);
            tbTrackNumber.DataBindings.Add("Text", _list, "treck_number_package", false, DataSourceUpdateMode.OnPropertyChanged);
            cbPerson.DataBindings.Add("SelectedValue", _list, "Id_person", false, DataSourceUpdateMode.OnPropertyChanged);
            dtDate.DataBindings.Add("Value", _list, "date", false, DataSourceUpdateMode.OnPropertyChanged);
            cbDepartureTypes.DataBindings.Add("SelectedValue", _list, "id_departure_type", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void LoadNotifications()
        {
            _list.Clear();
            _personList.Clear();
            var tm = _sqlService.GetNotifications();
            foreach (var model in tm)
            {
                _list.Add(model);
            }

            var pm = _sqlService.GetPhysicalPersons();
            foreach (var model in pm)
            {
                _personList.Add(model);
            }

            pm = _sqlService.GetJuridicalPersons();
            foreach (var model in pm)
            {
                _personList.Add(model);
            }

            var dt = _sqlService.GetDepartureTypes();
            foreach (var model in dt)
            {
                _departureTypeList.Add(model);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[3].Value != null && row.Cells[3].Value.ToString().ToLower().Contains(textBox1.Text.ToLower()))
                {
                    row.Selected = true;
                    return;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var notification = new NotificationModel();
            notification.Id_person = _personList.First().Id_person;
            notification.date = DateTime.Today;
            notification.id_departure_type = _departureTypeList.FirstOrDefault().Id_departure_type;
            notification.Id_notification = _sqlService.InsertNotification(notification);
            _list.Add(notification);
            dataGridView1.ClearSelection();
            dataGridView1.Rows[dataGridView1.RowCount - 1].Selected = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var sm = dataGridView1.BindingContext[_list].Current as NotificationModel;
            if (sm != null)
            {
                _sqlService.UpdateNotification(sm);
                _list.ResetBindings();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var md = MessageBox.Show("Вы действительно хотите удалить уведомление?", "Запрос", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (md == DialogResult.Yes)
            {
                var sm = dataGridView1.BindingContext[_list].Current as NotificationModel;
                if (sm != null)
                {
                    _sqlService.DeleteNotification(sm.Id_notification);
                    _list.Remove(sm);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var excelService = new ExcelService();
            excelService.GenerateNotificationsExcel();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
