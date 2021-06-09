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
    public partial class court_session : Form
    {
        private BindingList<CourtSessionModel> _list;
        private BindingList<PersonModel> _personList;
        private BindingList<PersonModel> _personList2;
        private BindingList<StaffModel> _staffList;
        private BindingList<StaffModel> _staffList2;
        private BindingList<CaseModel> _caseList;

        private SqlService _sqlService;

        public court_session()
        {
            InitializeComponent();

            _list = new BindingList<CourtSessionModel>();
            _staffList = new BindingList<StaffModel>();
            _staffList2 = new BindingList<StaffModel>();
            _personList = new BindingList<PersonModel>();
            _personList2 = new BindingList<PersonModel>();
            _caseList = new BindingList<CaseModel>();
            _sqlService = new SqlService();

            LoadCourtSessions();

            dataGridView1.DataSource = _list;
            (dataGridView1.Columns[1] as DataGridViewComboBoxColumn).DataSource = _caseList;
            (dataGridView1.Columns[6] as DataGridViewComboBoxColumn).DataSource = _staffList;
            (dataGridView1.Columns[7] as DataGridViewComboBoxColumn).DataSource = _staffList;
            (dataGridView1.Columns[8] as DataGridViewComboBoxColumn).DataSource = _personList;
            (dataGridView1.Columns[9] as DataGridViewComboBoxColumn).DataSource = _personList;


            cbIstets.DataSource = _personList;
            cbOtvetchik.DataSource = _personList2;
            cbStaff.DataSource = _staffList;
            cbSecretary.DataSource = _staffList2;
            cbCase.DataSource = _caseList;

            tbDateTime.DataBindings.Add("Text", _list, "date_time", false, DataSourceUpdateMode.OnPropertyChanged);
            tbType.DataBindings.Add("Text", _list, "type", false, DataSourceUpdateMode.OnPropertyChanged);
            tbPlace.DataBindings.Add("Text", _list, "place", false, DataSourceUpdateMode.OnPropertyChanged);
            tbResult.DataBindings.Add("Text", _list, "result", false, DataSourceUpdateMode.OnPropertyChanged);
            
            cbSecretary.DataBindings.Add("SelectedValue", _list, "Id_staff_secretary", false, DataSourceUpdateMode.OnPropertyChanged);
            cbCase.DataBindings.Add("SelectedValue", _list, "Id_case", false, DataSourceUpdateMode.OnPropertyChanged);
            cbOtvetchik.DataBindings.Add("SelectedValue", _list, "Id_person_otvetchik", false, DataSourceUpdateMode.OnPropertyChanged);
            cbIstets.DataBindings.Add("SelectedValue", _list, "Id_person_istets", false, DataSourceUpdateMode.OnPropertyChanged);
            cbStaff.DataBindings.Add("SelectedValue", _list, "Id_staff_judge", false, DataSourceUpdateMode.OnPropertyChanged);


        }

        private void LoadCourtSessions()
        {
            _list.Clear();
            _personList.Clear();
            _staffList.Clear();
            _caseList.Clear();

            {
                var tm = _sqlService.GetCourtSessions();
                foreach (var model in tm)
                {
                    _list.Add(model);
                }
            }
            {
                var tm = _sqlService.GetPhysicalPersons();
                foreach (var model in tm)
                {
                    _personList.Add(model);
                }
            }
            {
                var tm = _sqlService.GetJuridicalPersons();
                foreach (var model in tm)
                {
                    _personList.Add(model);
                }

                foreach (var model in _personList)
                {
                    _personList2.Add(model);
                }
            }
            {
                var tm = _sqlService.GetStaff();
                foreach (var model in tm)
                {
                    _staffList.Add(model);
                }

                foreach (var model in _staffList)
                {
                    _staffList2.Add(model);
                }
            }
            {
                var tm = _sqlService.GetCases();
                foreach (var model in tm)
                {
                    _caseList.Add(model);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[3].Value.ToString().ToLower().Contains(textBox1.Text.ToLower()))
                {
                    row.Selected = true;
                    return;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var courtSessionModel = new CourtSessionModel();
            courtSessionModel.Id_case = _caseList.First().Id_case;
            courtSessionModel.Id_person_istets = _personList.First().Id_person;
            courtSessionModel.Id_person_otvetchik = _personList.First().Id_person;
            courtSessionModel.Id_staff_judge = _staffList.First().Id_staff;
            courtSessionModel.Id_staff_secretary = _staffList.First().Id_staff;
            courtSessionModel.date_time = DateTime.Today;
            courtSessionModel.Id_court_session = _sqlService.InsertCourtSession(courtSessionModel);
            _list.Add(courtSessionModel);
            dataGridView1.ClearSelection();
            dataGridView1.Rows[dataGridView1.RowCount - 1].Selected = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var sm = dataGridView1.BindingContext[_list].Current as CourtSessionModel;
            if (sm != null)
            {
                _sqlService.UpdateCourtSession(sm);
                _list.ResetBindings();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var md = MessageBox.Show("Вы действительно хотите удалить судебное заседание?", "Запрос", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (md == DialogResult.Yes)
            {
                var sm = dataGridView1.BindingContext[_list].Current as CourtSessionModel;
                if (sm != null)
                {
                    _sqlService.DeleteCourtSession(sm.Id_case);
                    _list.Remove(sm);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var excelService = new ExcelService();
            excelService.GenerateCourtSessions();
        }

        // добавляем напоминание в календарь outlook
        private void button5_Click(object sender, EventArgs e)
        {
            var sm = dataGridView1.BindingContext[_list].Current as CourtSessionModel;
            if (sm != null)
            {
                var caseModel = _caseList.FirstOrDefault(x => x.Id_case == sm.Id_case);
                var istets = _personList.FirstOrDefault(x => x.Id_person == caseModel.Id_person_istets);
                var otvetchik = _personList.FirstOrDefault(x => x.Id_person == caseModel.Id_person_otvetchik);

                string title = caseModel.title_case + "\r\n" + "Истец: " + (istets.type ? istets.title_juridical_person : istets.FIO_person)
                    + "\r\n" + "Ответчик: " + (otvetchik.type ? otvetchik.title_juridical_person : otvetchik.FIO_person);

                OutlookService os = new OutlookService();
                os.Connect();
                os.AddToSchedule(caseModel.number_case, title, sm.date_time);
            }
        }
    }
}
