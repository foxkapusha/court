using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace LocalDB.Models
{
    [Table("Passport_staff")]
    public class PassportStaffModel
    {
        [Key]
        public int Id_passport_staff { get; set; }
        public string seria_passport_staff { get; set; }
        public int number_passport_staff { get; set; }
        public DateTime date_passport_staff { get; set; }
        public string code_passport_staff { get; set; }
        public string place_passport_staff { get; set; }
        public string adress_passport_staff { get; set; }
        public int Id_staff { get; set; }
    }
}
