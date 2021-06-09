using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;
using OfficeOpenXml.Style;

namespace LocalDB.Services
{
    public class ExcelService
    {
        public string GetSaveFileName(string partName)
        {
            var sfd = new SaveFileDialog();
            sfd.FileName = partName + " " + DateTime.Today.ToShortDateString() + ".xlsx";
            sfd.Filter = "Табличные документы (.xlsx)|*.xlsx";
            var result = sfd.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (File.Exists(sfd.FileName))
                {
                    var r = MessageBox.Show("Документ уже существует! Перезаписать?", "Ошибка", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);
                    if (r != DialogResult.Yes)
                        return "";
                    File.Delete(sfd.FileName);
                }
                return sfd.FileName;
            }
            return "";
        }

        public void GenerateStaffExcel()
        {
            var fileName = GetSaveFileName("Список сотрудников");
            if (string.IsNullOrEmpty(fileName))
                return;

            SqlService sqlService = new SqlService();
            var staff = sqlService.GetStaff();

            var newFile = new FileInfo(fileName);
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (ExcelPackage package = new ExcelPackage(newFile))
            {
                int c = 2;
                var worksheet = package.Workbook.Worksheets.Add("Лист 1");

                worksheet.Cells[1, 1].Value = "Список сотрудников";

                worksheet.Cells[c++, 1].Value = "№";
                worksheet.Cells[c++, 1].Value = "Фамилия";
                worksheet.Cells[c++, 1].Value = "Имя";
                worksheet.Cells[c++, 1].Value = "Отчество";
                worksheet.Cells[c++, 1].Value = "Расположение";
                worksheet.Cells[c++, 1].Value = "Пол";
                worksheet.Cells[c++, 1].Value = "Дата рождения";
                worksheet.Cells[c++, 1].Value = "Семейное положение";
                worksheet.Cells[c++, 1].Value = "СНИЛС";
                worksheet.Cells[c++, 1].Value = "Телефон";
                worksheet.Cells[c++, 1].Value = "ИНН";
                worksheet.Cells[c++, 1].Value = "email";
                worksheet.Cells[c++, 1].Value = "Дата принятия на работу";
                worksheet.Cells[c++, 1].Value = "№ приказа";
                worksheet.Cells[c++, 1].Value = "Дата приказа";
                worksheet.Cells[c++, 1].Value = "Дата увольнения";

                var font = worksheet.Cells[1, 1, c, 1].Style.Font;
                worksheet.Cells[1, 1, 1, staff.Count + 1].Merge = true;
                worksheet.Cells[1, 1].Style.Font.Size = 18;
                worksheet.Cells[1, 1].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                font.Bold = true;

                int r = 2;
                foreach (var model in staff)
                {
                    c = 2;
                    worksheet.Cells[c++, r].Value = model.service_number_staff;
                    worksheet.Cells[c++, r].Value = model.last_name_staff;
                    worksheet.Cells[c++, r].Value = model.name_staff;
                    worksheet.Cells[c++, r].Value = model.middle_name_staff;
                    worksheet.Cells[c++, r].Value = model.place_staff;
                    worksheet.Cells[c++, r].Value = model.gender_staff;
                    worksheet.Cells[c++, r].Value = model.date_of_birth_staff.ToShortDateString();
                    worksheet.Cells[c++, r].Value = model.marital_status_staff;
                    worksheet.Cells[c++, r].Value = model.snils_staff;
                    worksheet.Cells[c++, r].Value = model.telephone_staff;
                    worksheet.Cells[c++, r].Value = model.INN_staff;
                    worksheet.Cells[c++, r].Value = model.e_mail_staff;
                    worksheet.Cells[c++, r].Value = model.date_of_admission_staff.ToShortDateString();
                    worksheet.Cells[c++, r].Value = model.order_number_staff;
                    worksheet.Cells[c++, r].Value = model.order_data_staff.ToShortDateString();
                    worksheet.Cells[c++, r].Value = model.date_of_dismissal;
                    r++;
                }
                worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();
                worksheet.Cells[worksheet.Dimension.Address].Style.Numberformat.Format = "@";
                package.Save();
            }
            System.Diagnostics.Process.Start(fileName);
        }

        public void GeneratePhysicalExcel()
        {
            var fileName = GetSaveFileName("Физические лица");
            if (string.IsNullOrEmpty(fileName))
                return;

            SqlService sqlService = new SqlService();
            var physical = sqlService.GetPhysicalPersons();

            var newFile = new FileInfo(fileName);
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using (ExcelPackage package = new ExcelPackage(newFile))
            {
                int c = 1;
                var worksheet = package.Workbook.Worksheets.Add("Лист 1");

                worksheet.Cells[1, 1].Value = "Физические лица";

                worksheet.Cells[2, c++].Value = "ИД";
                worksheet.Cells[2, c++].Value = "ФИО";
                worksheet.Cells[2, c++].Value = "Серия";
                worksheet.Cells[2, c++].Value = "Номер";
                worksheet.Cells[2, c++].Value = "Код подразделения";
                worksheet.Cells[2, c++].Value = "Кем выдано";
                worksheet.Cells[2, c++].Value = "Дата выдачи";
                worksheet.Cells[2, c++].Value = "Адрес";
                worksheet.Cells[2, c++].Value = "Номер телефона";

                var font = worksheet.Cells[1, 1, 2, c].Style.Font;
                worksheet.Cells[1, 1, 1, c - 1].Merge = true;
                worksheet.Cells[1, 1].Style.Font.Size = 18;
                worksheet.Cells[1, 1].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                font.Bold = true;

                int r =3;

                foreach (var model in physical)
                {
                    c = 1;
                    worksheet.Cells[r, c++].Value = model.Id_person;
                    worksheet.Cells[r, c++].Value = model.FIO_person;
                    worksheet.Cells[r, c++].Value = model.passport_seria_physical_person;
                    worksheet.Cells[r, c++].Value = model.passport_number_physical_person;
                    worksheet.Cells[r, c++].Value = model.passport_code_physical_person;
                    worksheet.Cells[r, c++].Value = model.passport_place_physical_person;
                    worksheet.Cells[r, c++].Value = model.passport_date_physical_person.ToShortDateString();
                    worksheet.Cells[r, c++].Value = model.adress_person;
                    worksheet.Cells[r, c++].Value = model.telephone_person;
                    r++;
                }
                worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();
                package.Save();
            }
            System.Diagnostics.Process.Start(fileName);
        }

        public void GenerateJuridicalExcel()
        {
            var fileName = GetSaveFileName("Юридические лица");
            if (string.IsNullOrEmpty(fileName))
                return;

            SqlService sqlService = new SqlService();
            var juridical = sqlService.GetJuridicalPersons();

            var newFile = new FileInfo(fileName);
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using (ExcelPackage package = new ExcelPackage(newFile))
            {
                int c = 1;
                var worksheet = package.Workbook.Worksheets.Add("Лист 1");

                worksheet.Cells[1, 1].Value = "Юридические лица";


                worksheet.Cells[2, c++].Value = "ИД";
                worksheet.Cells[2, c++].Value = "ФИО";
                worksheet.Cells[2, c++].Value = "Адрес";
                worksheet.Cells[2, c++].Value = "Телефон";
                worksheet.Cells[2, c++].Value = "Наименование юр. лица";
                worksheet.Cells[2, c++].Value = "ИНН";
                worksheet.Cells[2, c++].Value = "КПП";
                worksheet.Cells[2, c++].Value = "ОГРН";
                worksheet.Cells[2, c++].Value = "ОКПО";
                var font = worksheet.Cells[1, 1, 2, c].Style.Font;
                worksheet.Cells[1, 1, 1, c - 1].Merge = true;
                worksheet.Cells[1, 1].Style.Font.Size = 18;
                worksheet.Cells[1, 1].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                font.Bold = true;

                int r = 3;

                foreach (var model in juridical)
                {
                    c = 1;
                    worksheet.Cells[r, c++].Value = model.Id_person;
                    worksheet.Cells[r, c++].Value = model.FIO_person;
                    worksheet.Cells[r, c++].Value = model.adress_person;
                    worksheet.Cells[r, c++].Value = model.telephone_person;
                    worksheet.Cells[r, c++].Value = model.title_juridical_person;
                    worksheet.Cells[r, c++].Value = model.INN_juridical_person;
                    worksheet.Cells[r, c++].Value = model.KPP_juridical_person;
                    worksheet.Cells[r, c++].Value = model.OGRN_juridical_person;
                    worksheet.Cells[r, c++].Value = model.OKPO_juridical_person;
                    r++;
                }
                worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();
                package.Save();
            }
            System.Diagnostics.Process.Start(fileName);
        }
        
        public void GenerateNotificationsExcel()
        {
            var fileName = GetSaveFileName("Уведомление");
            if (string.IsNullOrEmpty(fileName))
                return;

            SqlService sqlService = new SqlService();
            var notifications = sqlService.GetNotifications();
            var persons = sqlService.GetPhysicalPersons().ToList();
            persons.AddRange(sqlService.GetJuridicalPersons().ToList());

            var departureTypes = sqlService.GetDepartureTypes();

            var newFile = new FileInfo(fileName);
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using (ExcelPackage package = new ExcelPackage(newFile))
            {
                int c = 1;
                var worksheet = package.Workbook.Worksheets.Add("Лист 1");

                worksheet.Cells[1, 1].Value = "Уведомление";
                //worksheet.Cells[1, c++].Value = "ИД";
                worksheet.Cells[2, c++].Value = "Тип";
                worksheet.Cells[2, c++].Value = "Получатель";
                worksheet.Cells[2, c++].Value = "Номер отправления";
                worksheet.Cells[2, c++].Value = "Дата";
                worksheet.Cells[2, c++].Value = "Тип отправления";

                var font = worksheet.Cells[1, 1, 2, c].Style.Font;
                worksheet.Cells[1, 1, 1, c - 1].Merge = true;
                worksheet.Cells[1, 1].Style.Font.Size = 18;
                worksheet.Cells[1, 1].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                font.Bold = true;

                int r = 3;

                foreach (var model in notifications)
                {
                    c = 1;
                    //worksheet.Cells[r, c++].Value = model.Id_notification;
                    worksheet.Cells[r, c++].Value = model.type_notification;
                    worksheet.Cells[r, c++].Value =
                        persons.FirstOrDefault(x => x.Id_person == model.Id_person).FIO_person;
                    worksheet.Cells[r, c++].Value = model.treck_number_package;
                    worksheet.Cells[r, c++].Value = model.date.ToShortDateString();
                    worksheet.Cells[r, c++].Value = departureTypes
                        .FirstOrDefault(x => x.Id_departure_type == model.id_departure_type).FullString;

                    r++;
                }
                worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();
                package.Save();
            }
            System.Diagnostics.Process.Start(fileName);
        }

        public void GenerateCasesExcel()
        {
            var fileName = GetSaveFileName("Дело");
            if (string.IsNullOrEmpty(fileName))
                return;

            SqlService sqlService = new SqlService();
            var cases = sqlService.GetCases();
            var persons = sqlService.GetPhysicalPersons().ToList();
            persons.AddRange(sqlService.GetJuridicalPersons().ToList());

            var staff = sqlService.GetStaff();

            var newFile = new FileInfo(fileName);
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using (ExcelPackage package = new ExcelPackage(newFile))
            {
                int c = 1;
                var worksheet = package.Workbook.Worksheets.Add("Лист 1");

                worksheet.Cells[1, 1].Value = "Дело";

                worksheet.Cells[2, c++].Value = "Номер дела";
                worksheet.Cells[2, c++].Value = "Дата поступления";
                worksheet.Cells[2, c++].Value = "Вид судопроизводства";
                worksheet.Cells[2, c++].Value = "Описание";
                worksheet.Cells[2, c++].Value = "Истец";
                worksheet.Cells[2, c++].Value = "Ответчик";
                worksheet.Cells[2, c++].Value = "Судья";

                var font = worksheet.Cells[1, 1, 2, c].Style.Font;
                worksheet.Cells[1, 1, 1, c - 1].Merge = true;
                worksheet.Cells[1, 1].Style.Font.Size = 18;
                worksheet.Cells[1, 1].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                font.Bold = true;

                int r = 3;

                foreach (var model in cases)
                {
                    c = 1;
                    worksheet.Cells[r, c++].Value = model.number_case;
                    worksheet.Cells[r, c++].Value = model.date_case.ToShortDateString();
                    worksheet.Cells[r, c++].Value = model.type_case;
                    worksheet.Cells[r, c++].Value = model.title_case;
                    worksheet.Cells[r, c++].Value =
                        persons.FirstOrDefault(x => x.Id_person == model.Id_person_istets)?.FIO_person;
                    worksheet.Cells[r, c++].Value =
                        persons.FirstOrDefault(x => x.Id_person == model.Id_person_otvetchik)?.FIO_person;

                    var st = staff.FirstOrDefault(x => x.Id_staff == model.Id_staff);
                    worksheet.Cells[r, c++].Value = st?.last_name_staff + " " + st?.name_staff + " " + st?.middle_name_staff;


                    r++;
                }
                worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();
                package.Save();
            }
            System.Diagnostics.Process.Start(fileName);
        }

        public void GenerateCourtSessions()
        {
            var fileName = GetSaveFileName("Судебное заседание");
            if (string.IsNullOrEmpty(fileName))
                return;

            SqlService sqlService = new SqlService();
            var list = sqlService.GetCourtSessions();
            var cases = sqlService.GetCases();
            var persons = sqlService.GetPhysicalPersons().ToList();
            persons.AddRange(sqlService.GetJuridicalPersons().ToList());
            var staffs = sqlService.GetStaff();

            var newFile = new FileInfo(fileName);
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using (ExcelPackage package = new ExcelPackage(newFile))
            {
                int c = 1;
                var worksheet = package.Workbook.Worksheets.Add("Лист 1");

                worksheet.Cells[1, 1].Value = "Судебное заседание";

                worksheet.Cells[2, c++].Value = "Номер дела";
                worksheet.Cells[2, c++].Value = "Дата и время";
                worksheet.Cells[2, c++].Value = "Тип";
                worksheet.Cells[2, c++].Value = "Место проведения";
                worksheet.Cells[2, c++].Value = "Результат";
                worksheet.Cells[2, c++].Value = "Судья";
                worksheet.Cells[2, c++].Value = "Секретарь";
                worksheet.Cells[2, c++].Value = "Истец";
                worksheet.Cells[2, c++].Value = "Ответчик";

                var font = worksheet.Cells[1, 1, 2, c].Style.Font;
                worksheet.Cells[1, 1, 1, c - 1].Merge = true;
                worksheet.Cells[1, 1].Style.Font.Size = 18;
                worksheet.Cells[1, 1].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                font.Bold = true;

                int r = 3;

                foreach (var model in list)
                {
                    c = 1;
                    var judje = staffs.FirstOrDefault(x => x.Id_staff == model.Id_staff_judge);
                    var secretar = staffs.FirstOrDefault(x => x.Id_staff == model.Id_staff_secretary);
                    var istets = persons.FirstOrDefault(x => x.Id_person == model.Id_person_istets);
                    var otvetchik = persons.FirstOrDefault(x => x.Id_person == model.Id_person_otvetchik);


                    worksheet.Cells[r, c++].Value = cases.FirstOrDefault(x => x.Id_case == model.Id_case).number_case;
                    worksheet.Cells[r, c++].Value =
                        model.date_time.ToShortDateString() + " " + model.date_time.ToShortTimeString();
                    worksheet.Cells[r, c++].Value = model.type;
                    worksheet.Cells[r, c++].Value = model.place;
                    worksheet.Cells[r, c++].Value = model.result;


                    worksheet.Cells[r, c++].Value =
                        judje.last_name_staff + " " + judje.name_staff + " " + judje.middle_name_staff;

                    worksheet.Cells[r, c++].Value = secretar.last_name_staff + " " + secretar.name_staff + " " + secretar.middle_name_staff;
                    worksheet.Cells[r, c++].Value = istets.type ? istets.title_juridical_person : istets.FIO_person;
                    worksheet.Cells[r, c++].Value = otvetchik.type ? otvetchik.title_juridical_person : otvetchik.FIO_person;

                    r++;
                }
                worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();
                package.Save();
            }
            System.Diagnostics.Process.Start(fileName);
        }
    }
}
