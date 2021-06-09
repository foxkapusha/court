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
    public partial class delo : Form
    {
        private BindingList<CaseModel> _list;
        private BindingList<PersonModel> _personList;
        private BindingList<PersonModel> _personList2;
        private BindingList<StaffModel> _staffList;

        private SqlService _sqlService;

        public delo()
        {
            InitializeComponent();

            _list = new BindingList<CaseModel>();
            _staffList = new BindingList<StaffModel>();
            _personList = new BindingList<PersonModel>();
            _personList2 = new BindingList<PersonModel>();
            _sqlService = new SqlService();

            LoadCases();

            dataGridView1.DataSource = _list;
            (dataGridView1.Columns[5] as DataGridViewComboBoxColumn).DataSource = _personList;
            (dataGridView1.Columns[6] as DataGridViewComboBoxColumn).DataSource = _personList;
            (dataGridView1.Columns[7] as DataGridViewComboBoxColumn).DataSource = _staffList;

            dataGridView1.DataSource = _list;
            cbIstets.DataSource = _personList;
            cbOtvetchik.DataSource = _personList2;
            cbStaff.DataSource = _staffList;

            tbNumberCase.DataBindings.Add("Text", _list, "number_case", false, DataSourceUpdateMode.OnPropertyChanged);
            tbTypeCase.DataBindings.Add("Text", _list, "type_case", false, DataSourceUpdateMode.OnPropertyChanged);
            tbTitleCase.DataBindings.Add("Text", _list, "title_case", false, DataSourceUpdateMode.OnPropertyChanged);
            dtDateCase.DataBindings.Add("Value", _list, "date_case", false, DataSourceUpdateMode.OnPropertyChanged);
            
            cbIstets.DataBindings.Add("SelectedValue", _list, "Id_person_istets", false, DataSourceUpdateMode.OnPropertyChanged);
            cbOtvetchik.DataBindings.Add("SelectedValue", _list, "Id_person_otvetchik", false, DataSourceUpdateMode.OnPropertyChanged);
            cbStaff.DataBindings.Add("SelectedValue", _list, "Id_staff", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void LoadCases()
        {
            _list.Clear();
            _personList.Clear();
            _staffList.Clear();
            var tm = _sqlService.GetCases();
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

            foreach (var model in _personList)
            {
                _personList2.Add(model);
            }

            var sm = _sqlService.GetStaff();
            foreach (var model in sm)
            {
                _staffList.Add(model);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var md = MessageBox.Show("Вы действительно хотите удалить дело?", "Запрос", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (md == DialogResult.Yes)
            {
                var sm = dataGridView1.BindingContext[_list].Current as CaseModel;
                if (sm != null)
                {
                    _sqlService.DeleteCase(sm.Id_case);
                    _list.Remove(sm);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var caseModel = new CaseModel();
            caseModel.Id_staff = _staffList.First().Id_staff;
            caseModel.Id_person_istets = _personList.First().Id_person;
            caseModel.Id_person_otvetchik = _personList.First().Id_person;
            caseModel.date_case = DateTime.Today;
            caseModel.Id_case = _sqlService.InsertCase(caseModel);
            _list.Add(caseModel);
            dataGridView1.ClearSelection();
            dataGridView1.Rows[dataGridView1.RowCount - 1].Selected = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var sm = dataGridView1.BindingContext[_list].Current as CaseModel;
            if (sm != null)
            {
                _sqlService.UpdateCase(sm);
                _list.ResetBindings();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var excelService = new ExcelService();
            excelService.GenerateCasesExcel();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DateTime result;
            var dt = DateTime.TryParse(textBox1.Text, out result);
            if (dt)
            {
                dataGridView1.ClearSelection();
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[2].Value.ToString().ToLower().Contains(result.ToShortDateString()))
                    {
                        row.Selected = true;
                        return;
                    }
                }
            }
        }
    }
}
