using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace LocalDB.Models
{
    [Table("Person")]
    public class PersonModel
    {
        [Key]
        public int Id_person { get; set; }
        public string FIO_person { get; set; }
        public string passport_seria_physical_person { get; set; }
        public string passport_number_physical_person { get; set; }
        public string passport_code_physical_person { get; set; }
        public string passport_place_physical_person { get; set; }
        public DateTime passport_date_physical_person { get; set; }
        public string adress_person { get; set; }
        public string telephone_person { get; set; }
        public string title_juridical_person { get; set; }
        public string INN_juridical_person { get; set; }
        public string KPP_juridical_person { get; set; }
        public string OGRN_juridical_person { get; set; }
        public string OKPO_juridical_person { get; set; }
        public bool type { get; set; }
        public byte[] file { get; set; }
    }
}
