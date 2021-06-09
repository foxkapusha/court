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

namespace LocalDB.Views
{
    public partial class AgendaReport : Form
    {
        private BindingList<CaseModel> _list;
        private BindingList<PersonModel> _personList;
        private BindingList<CourtSessionModel> _courtSessionsList;
        private readonly BindingList<StaffModel> _staffList;
        private BindingList<PersonModel> _whoToSendList;

        private SqlService _sqlService;

        private bool _isBusy = false;


        public AgendaReport()
        {
            InitializeComponent();

            _list = new BindingList<CaseModel>();
            _courtSessionsList = new BindingList<CourtSessionModel>();
            _personList = new BindingList<PersonModel>();
            _staffList = new BindingList<StaffModel>();
            _whoToSendList = new BindingList<PersonModel>();

            _sqlService = new SqlService();

            LoadCases();

            cbCase.DataSource = _list;
            cbWhotosend.DataSource = _whoToSendList;

            tbCaseNumber2.DataBindings.Add("Text", _list, "number_case", false, DataSourceUpdateMode.OnPropertyChanged);
            tbWhereaddress.DataBindings.Add("Text", _whoToSendList, "adress_person", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void LoadCases()
        {
            _isBusy = true;

            _list.Clear();
            _personList.Clear();
            _courtSessionsList.Clear();

            {
                var tm = _sqlService.GetCases();
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
            }

            {
                var tm = _sqlService.GetCourtSessions();
                foreach (var model in tm)
                {
                    _courtSessionsList.Add(model);
                }
            }

            {
                var tm = _sqlService.GetStaff();
                foreach (var model in tm)
                {
                    _staffList.Add(model);
                }
            }


            _isBusy = false;
        }

        private void cbCase_SelectedValueChanged(object sender, EventArgs e)
        {
            if (_isBusy || _personList == null)
                return;

            var cs = cbCase.SelectedItem as CaseModel;

            var staff = _staffList.FirstOrDefault(x => x.Id_staff == cs.Id_staff);
            var person = _personList.FirstOrDefault(x => x.Id_person == cs.Id_person_istets);
            var person2 = _personList.FirstOrDefault(x => x.Id_person == cs.Id_person_otvetchik);


            tbJudje.Text = staff.Fio;
            _whoToSendList.Clear();
            _whoToSendList.Add(person);
            _whoToSendList.Add(person2);

            var csl = _courtSessionsList.FirstOrDefault(x => x.Id_case == cs.Id_case);
            if (csl != null)
            {
                tbHours.Text = csl.date_time.Hour.ToString() + ":" + csl.date_time.ToString("mm");
                tbMonth.Text = csl.date_time.ToString("M");
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            var wordService = new WordService();
            wordService.GenerateAgenda(cbCase.Text, tbJudje.Text, tbWhotype.Text, tbHours.Text,
                tbMonth.Text, tbYear.Text, tbCaseNumber2.Text, tbAddress.Text, tbWhereaddress.Text,
                cbWhotosend.Text, tbSecretar.Text);
        }
    }
}
