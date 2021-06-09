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
    public partial class staff : Form
    {
        private BindingList<StaffModel> _list;
        private BindingList<PassportStaffModel> _passportList;
        private BindingList<EducationModel> _educationList;

        private SqlService _sqlService;

        public staff()
        {
            InitializeComponent();

            _passportList = new BindingList<PassportStaffModel>();
            _educationList = new BindingList<EducationModel>();
            _list = new BindingList<StaffModel>();

            _sqlService = new SqlService();

            LoadStaff();
            
            dataGridView1.DataSource = _list;
            dataGridView2.DataSource = _passportList;
            dataGridView3.DataSource = _educationList;

            tbLastName.DataBindings.Add("Text", _list, "last_name_staff", false, DataSourceUpdateMode.OnPropertyChanged);
            tbFirstName.DataBindings.Add("Text", _list, "name_staff", false, DataSourceUpdateMode.OnPropertyChanged);
            tbMiddleName.DataBindings.Add("Text", _list, "middle_name_staff", false, DataSourceUpdateMode.OnPropertyChanged);
            tbGender.DataBindings.Add("Text", _list, "gender_staff", false, DataSourceUpdateMode.OnPropertyChanged);
            dtBirthday.DataBindings.Add("Value", _list, "date_of_birth_staff", false, DataSourceUpdateMode.OnPropertyChanged);
            tbMarriageStatus.DataBindings.Add("Text", _list, "marital_status_staff", false, DataSourceUpdateMode.OnPropertyChanged);
            tbSnils.DataBindings.Add("Text", _list, "snils_staff", false, DataSourceUpdateMode.OnPropertyChanged);
            tbInn.DataBindings.Add("Text", _list, "INN_staff", false, DataSourceUpdateMode.OnPropertyChanged);
            tbPhone.DataBindings.Add("Text", _list, "telephone_staff", false, DataSourceUpdateMode.OnPropertyChanged);
            tbEmail.DataBindings.Add("Text", _list, "e_mail_staff", false, DataSourceUpdateMode.OnPropertyChanged);
            tbServiceNumber.DataBindings.Add("Text", _list, "service_number_staff", false, DataSourceUpdateMode.OnPropertyChanged);
            dtDateOfAdmission.DataBindings.Add("Value", _list, "date_of_admission_staff", false, DataSourceUpdateMode.OnPropertyChanged);
            tbOrderNumber.DataBindings.Add("Text", _list, "order_number_staff", false, DataSourceUpdateMode.OnPropertyChanged);
            dtOrderDate.DataBindings.Add("Value", _list, "order_data_staff", false, DataSourceUpdateMode.OnPropertyChanged);
            tbDismissalDate.DataBindings.Add("Text", _list, "date_of_dismissal", false, DataSourceUpdateMode.OnPropertyChanged);
            tbPostStaff.DataBindings.Add("Text", _list, "post_staff", false, DataSourceUpdateMode.OnPropertyChanged);
            
            tbAdressPassport.DataBindings.Add("Text", _passportList, "adress_passport_staff", false, DataSourceUpdateMode.OnPropertyChanged);
            tbNumberPassport.DataBindings.Add("Text", _passportList, "number_passport_staff", false, DataSourceUpdateMode.OnPropertyChanged);
            tbDatePassport.DataBindings.Add("Text", _passportList, "date_passport_staff", false, DataSourceUpdateMode.OnPropertyChanged);
            tbSeriaPassport.DataBindings.Add("Text", _passportList, "seria_passport_staff", false, DataSourceUpdateMode.OnPropertyChanged);
            tbCodePassport.DataBindings.Add("Text", _passportList, "code_passport_staff", false, DataSourceUpdateMode.OnPropertyChanged);
            tbPlacePassport.DataBindings.Add("Text", _passportList, "place_passport_staff", false, DataSourceUpdateMode.OnPropertyChanged);

            tbDocumentType.DataBindings.Add("Text", _educationList, "document_type", false, DataSourceUpdateMode.OnPropertyChanged);
            tbEducationalInstitution.DataBindings.Add("Text", _educationList, "educational_institution", false, DataSourceUpdateMode.OnPropertyChanged);
            tbDirection.DataBindings.Add("Text", _educationList, "direction", false, DataSourceUpdateMode.OnPropertyChanged);
            tbYear.DataBindings.Add("Text", _educationList, "year", false, DataSourceUpdateMode.OnPropertyChanged);
            tbSeries.DataBindings.Add("Text", _educationList, "series_diploma", false, DataSourceUpdateMode.OnPropertyChanged);
            tbNumber.DataBindings.Add("Text", _educationList, "number_diploma", false, DataSourceUpdateMode.OnPropertyChanged);
            tbLinerSeries.DataBindings.Add("Text", _educationList, "liner_series", false, DataSourceUpdateMode.OnPropertyChanged);
            tbLinerNumber.DataBindings.Add("Text", _educationList, "number_liner", false, DataSourceUpdateMode.OnPropertyChanged);
            tbTypeEducation.DataBindings.Add("Text", _educationList, "type_education", false, DataSourceUpdateMode.OnPropertyChanged);
            tbQualification.DataBindings.Add("Text", _educationList, "qualification", false, DataSourceUpdateMode.OnPropertyChanged);

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var md = MessageBox.Show("Вы действительно хотите удалить сотрудника?", "Запрос", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (md == DialogResult.Yes)
            {
                var sm = dataGridView1.BindingContext[_list].Current as StaffModel;
                if (sm != null)
                {
                    _sqlService.DeleteStaff(sm.Id_staff);
                    _list.Remove(sm);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var sm = dataGridView1.BindingContext[_list].Current as StaffModel;
            if (sm != null)
            {
                _sqlService.UpdateStaff(sm);
                _list.ResetBindings();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var staff = new StaffModel();
            staff.date_of_admission_staff = DateTime.Today;
            staff.date_of_birth_staff = DateTime.Today;
            staff.order_data_staff = DateTime.Today;
            staff.date_of_dismissal = DateTime.MaxValue;
            staff.Id_staff = _sqlService.InsertStaff(staff);
            _list.Add(staff);
            
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            var sm = dataGridView1.BindingContext[_list].Current as StaffModel;
            if (sm != null)
            {
                LoadPassports(sm);

                LoadEducations(sm);
            }
        }

        private void LoadEducations(StaffModel sm)
        {
            var em = _sqlService.GetEducations(sm.Id_staff);
            _educationList.Clear();
            foreach (var model in em)
            {
                _educationList.Add(model);
            }

            ideducationstaffDataGridViewTextBoxColumn1.Visible = false;
        }

        private void LoadPassports(StaffModel sm)
        {
            var tm = _sqlService.GetPassport(sm.Id_staff);
            _passportList.Clear();
            foreach (var model in tm)
            {
                _passportList.Add(model);
            }
        }

        private void LoadStaff()
        {
            _list.Clear();

            var tm = _sqlService.GetStaff();

            foreach (var model in tm) 
            {
                _list.Add(model);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var md = MessageBox.Show("Вы действительно хотите удалить паспорт?", "Запрос", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (md == DialogResult.Yes)
            {
                var pm = dataGridView2.BindingContext[_passportList].Current as PassportStaffModel;
                if (pm != null)
                {
                    _sqlService.DeletePassport(pm.Id_passport_staff);
                    _passportList.Remove(pm);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var pm = dataGridView2.BindingContext[_passportList].Current as PassportStaffModel;
            if (pm != null)
            {
                _sqlService.UpdatePassport(pm);
                _passportList.ResetBindings();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var sm = dataGridView1.BindingContext[_list].Current as StaffModel;
            if (sm != null)
            {
                var passport = new PassportStaffModel();
                passport.Id_staff = sm.Id_staff;
                passport.date_passport_staff = DateTime.Today;
                _sqlService.InsertPassport(passport);
                LoadPassports(sm);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            var sm = dataGridView1.BindingContext[_list].Current as StaffModel;
            if (sm != null)
            {
                var model = new EducationModel();
                model.Id_staff = sm.Id_staff;
                _sqlService.InsertEducation(model);
                LoadEducations(sm);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var pm = dataGridView3.BindingContext[_educationList].Current as EducationModel;
            if (pm != null)
            {
                _sqlService.UpdateEducation(pm);
                _passportList.ResetBindings();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var md = MessageBox.Show("Вы действительно хотите удалить документ об образовании?", "Запрос", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (md == DialogResult.Yes)
            {
                var pm = dataGridView3.BindingContext[_educationList].Current as EducationModel;
                if (pm != null)
                {
                    _sqlService.DeleteEducation(pm.Id_education_staff);
                    _educationList.Remove(pm);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[2].Value.ToString().ToLower().StartsWith(textBox1.Text.ToLower()) ||
                    row.Cells[3].Value.ToString().ToLower().StartsWith(textBox1.Text.ToLower()) ||
                    row.Cells[4].Value.ToString().ToLower().StartsWith(textBox1.Text.ToLower()))
                {
                    row.Selected = true;
                    return;
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var excelService = new ExcelService();
            excelService.GenerateStaffExcel();
        }
    }
}
