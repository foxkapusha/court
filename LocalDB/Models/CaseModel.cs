using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace LocalDB.Models
{
    [Table("\"Case\"")]
    public class CaseModel
    {
        [Key]
        public int Id_case { get; set; }
        public DateTime date_case { get; set; }
        public string number_case { get; set; }
        public string type_case { get; set; }
        public string title_case { get; set; }
        public int Id_person_istets { get; set; }
        public int Id_person_otvetchik { get; set; }
        public int Id_staff { get; set; }
    }
}
