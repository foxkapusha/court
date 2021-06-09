using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace LocalDB.Models
{
    [Table("Staff")]
    public class StaffModel
    {
        [Key]
        public int Id_staff { get; set; }
        public int service_number_staff { get; set; }
        public string last_name_staff { get; set; }
        public string name_staff { get; set; }
        public string middle_name_staff { get; set; }
        public string place_staff { get; set; }
        public string post_staff { get; set; }
        public string gender_staff { get; set; }
        public DateTime date_of_birth_staff { get; set; }
        public string marital_status_staff { get; set; }
        public string snils_staff { get; set; }
        public string telephone_staff { get; set; }
        public string INN_staff { get; set; }
        public string e_mail_staff { get; set; }
        public DateTime date_of_admission_staff { get; set; }
        public int order_number_staff { get; set; }
        public DateTime order_data_staff { get; set; }
        public DateTime? date_of_dismissal { get; set; }
        public int? Id_passport_staff { get; set; }
        public int? Id_education_staff { get; set; }

        public string login { get; set; }
        public string password { get; set; }

        public string Fio => last_name_staff + " " + name_staff + " " + middle_name_staff;
    }
}
