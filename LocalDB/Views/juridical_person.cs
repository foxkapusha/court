using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LocalDB.Models;
using LocalDB.Services;

namespace LocalDB
{
    public partial class juridical_person : Form
    {
        private BindingList<PersonModel> _list;

        private SqlService _sqlService;

        public juridical_person()
        {
            InitializeComponent();

            _list = new BindingList<PersonModel>();
            _sqlService = new SqlService();

            LoadJuridicalPersons();

            dataGridView1.DataSource = _list;

            tbFio.DataBindings.Add("Text", _list, "FIO_person", false, DataSourceUpdateMode.OnPropertyChanged);
            tbAddress.DataBindings.Add("Text", _list, "adress_person", false, DataSourceUpdateMode.OnPropertyChanged);
            tbInn.DataBindings.Add("Text", _list, "INN_juridical_person", false, DataSourceUpdateMode.OnPropertyChanged);
            tbJuridicalName.DataBindings.Add("Text", _list, "title_juridical_person", false, DataSourceUpdateMode.OnPropertyChanged);
            tbKpp.DataBindings.Add("Text", _list, "KPP_juridical_person", false, DataSourceUpdateMode.OnPropertyChanged);
            tbOgrn.DataBindings.Add("Text", _list, "OGRN_juridical_person", false, DataSourceUpdateMode.OnPropertyChanged);
            tbOkpo.DataBindings.Add("Text", _list, "OKPO_juridical_person", false, DataSourceUpdateMode.OnPropertyChanged);
            tbPhone.DataBindings.Add("Text", _list, "telephone_person", false, DataSourceUpdateMode.OnPropertyChanged);

        }

        private void LoadJuridicalPersons()
        {
            _list.Clear();
            var tm = _sqlService.GetJuridicalPersons();
            foreach (var model in tm)
            {
                _list.Add(model);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var person = new PersonModel();
            person.passport_date_physical_person = DateTime.Today;
            person.type = true;
            person.Id_person = _sqlService.InsertPhysicalPerson(person);
            _list.Add(person);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var sm = dataGridView1.BindingContext[_list].Current as PersonModel;
            if (sm != null)
            {
                sm.passport_date_physical_person = DateTime.Today;
                _sqlService.UpdatePhysicalPerson(sm);
                _list.ResetBindings();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var md = MessageBox.Show("Вы действительно хотите удалить юридическое лицо?", "Запрос", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (md == DialogResult.Yes)
            {
                var sm = dataGridView1.BindingContext[_list].Current as PersonModel;
                if (sm != null)
                {
                    _sqlService.DeletePhysicalPerson(sm.Id_person);
                    _list.Remove(sm);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var excelService = new ExcelService();
            excelService.GenerateJuridicalExcel();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[1].Value.ToString().ToLower().Contains(textBox1.Text.ToLower()))
                {
                    row.Selected = true;
                    return;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var sm = dataGridView1.BindingContext[_list].Current as PersonModel;
            if (sm != null)
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Изображения (*.jpg, *.jpeg, *.jpe) | *.jpg; *.jpeg; *.jpe;";
                var dr = ofd.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    sm.file = File.ReadAllBytes(ofd.FileName);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var sm = dataGridView1.BindingContext[_list].Current as PersonModel;
            if (sm != null)
            {
                if (sm.file.Length < 100)
                {
                    MessageBox.Show("Нет загруженного документа!", "Ошибка", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                string fileName = "temp/" + sm.Id_person + ".jpg";
                fileName = Path.Combine(WordService.GetPath(), fileName);
                if (File.Exists(fileName))
                    File.Delete(fileName);
                File.WriteAllBytes(fileName, sm.file);
                System.Threading.Thread.Sleep(400);
                System.Diagnostics.Process.Start(fileName);
            }
        }
    }
}
