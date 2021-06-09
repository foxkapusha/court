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
    public partial class DecisionReport : Form
    {
        private BindingList<CaseModel> _list;
        private BindingList<PersonModel> _personList;
        private BindingList<CourtSessionModel> _courtSessionsList;
        private BindingList<StaffModel> _staffList;

        private SqlService _sqlService;

        private bool _isBusy = false;


        public DecisionReport()
        {
            InitializeComponent();


            _list = new BindingList<CaseModel>();
            _courtSessionsList = new BindingList<CourtSessionModel>();
            _personList = new BindingList<PersonModel>();
            _staffList = new BindingList<StaffModel>();
            _sqlService = new SqlService();

            LoadCases();

            cbCase.DataSource = _list;

            tbCaseNumber.DataBindings.Add("Text", _list, "number_case", false, DataSourceUpdateMode.OnPropertyChanged);
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

            tbCaseDate.Text = (cbCase.SelectedItem as CaseModel).date_case.ToShortDateString();

            var otvetchik = _personList.FirstOrDefault(x =>
                x.Id_person == (cbCase.SelectedItem as CaseModel).Id_person_otvetchik);
            var istets = _personList.FirstOrDefault(x =>
                x.Id_person == (cbCase.SelectedItem as CaseModel).Id_person_istets);

            if (otvetchik != null)
            {
                string otvetchikTitle = otvetchik.FIO_person;

                if (otvetchik.type)
                    otvetchikTitle = otvetchik.title_juridical_person;
                tbOtvetchikName.Text = otvetchikTitle;

                tbOtvetchikAddress.Text = otvetchik.adress_person;
            }

            if (istets != null)
            {
                string istetsTitle = istets.FIO_person;

                if (istets.type)
                    istetsTitle = istets.title_juridical_person;
                tbIstetsName.Text = istetsTitle;
                tbIstetsAddress.Text = istets.adress_person;
            }

            var staffId = (cbCase.SelectedItem as CaseModel).Id_staff;
            var staff = _staffList.FirstOrDefault(x => x.Id_staff == staffId);
            if (staff != null)
            {
                tbStaffName.Text = staff.name_staff.FirstOrDefault() + ". " +
                                   staff.middle_name_staff.FirstOrDefault() + ". " +
                                   staff.last_name_staff;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var caseText = "№ " + cbCase.Text + " " + (cbCase.SelectedItem as CaseModel).date_case.ToShortDateString();
            var wordService = new WordService();
            wordService.GenerateDecision(
                caseText,
                tbCaseNumber.Text,
                tbStaffName.Text,
                tbCaseDate.Text,
                tbIstetsName.Text,
                tbIstetsAddress.Text,
                tbOtvetchikName.Text,
                tbOtvetchikAddress.Text);
        }
    }
}
