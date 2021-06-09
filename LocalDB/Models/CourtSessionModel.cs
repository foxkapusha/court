using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace LocalDB.Models
{
    [Table("Court_session")]
    public class CourtSessionModel
    {
        [Key]
        public int Id_court_session { get; set; }
        public int Id_case { get; set; }
        public DateTime date_time { get; set; }
        public string type { get; set; }
        public string result { get; set; }
        public string place { get; set; }
        public int Id_staff_judge { get; set; }
        public int Id_staff_secretary { get; set; }
        public int Id_person_istets { get; set; }
        public int Id_person_otvetchik { get; set; }
    }
}
