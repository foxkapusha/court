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
    public partial class NotificationReport : Form
    {
        private BindingList<CaseModel> _list;
        private BindingList<PersonModel> _personList;
        private BindingList<CourtSessionModel> _courtSessionsList;

        private SqlService _sqlService;

        private bool _isBusy = false;

        public NotificationReport()
        {
            InitializeComponent();

            _list = new BindingList<CaseModel>();
            _courtSessionsList = new BindingList<CourtSessionModel>();
            _personList = new BindingList<PersonModel>();
            _sqlService = new SqlService();

            LoadCases();

            cbCase.DataSource = _list;

            tbCase.DataBindings.Add("Text", _list, "number_case", false, DataSourceUpdateMode.OnPropertyChanged);

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

            _isBusy = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var wordService = new WordService();
            wordService.GenerateNotification("№ " + cbCase.Text, tbWhoMultiline.Text, tbCase.Text, tbWho.Text, tbAction.Text,
                tbDateTime.Text);
        }

        private void cbCase_SelectedValueChanged(object sender, EventArgs e)
        {
            if (_isBusy || _personList == null)
                return;

            var otvetchik = _personList.FirstOrDefault(x =>
                x.Id_person == (cbCase.SelectedItem as CaseModel).Id_person_otvetchik);
            var istets = _personList.FirstOrDefault(x =>
                x.Id_person == (cbCase.SelectedItem as CaseModel).Id_person_istets);
            if (otvetchik != null && istets != null)
            {
                string istetsTitle = istets.FIO_person;
                string otvetchikTitle = otvetchik.FIO_person;

                if (istets.type)
                    istetsTitle = istets.title_juridical_person;
                if (otvetchik.type)
                    otvetchikTitle = otvetchik.title_juridical_person;

                tbWho.Text = istetsTitle;

                tbWhoMultiline.Text = istetsTitle + "\r\n" +
                                      istets.adress_person + "\r\n\r\n" +
                                      otvetchikTitle + "\r\n" +
                                      otvetchik.adress_person;

            }

            tbAction.Text = (cbCase.SelectedItem as CaseModel).title_case;
            var courtSession =
                _courtSessionsList.FirstOrDefault(x => x.Id_case == (cbCase.SelectedItem as CaseModel).Id_case);
            tbDateTime.Text = courtSession.date_time.ToLongDateString() + " " +
                              courtSession.date_time.ToShortTimeString();

        }

        private void cbCase_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
