using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace LocalDB.Models
{
    [Table("Departure_type")]
    public class DepartureTypeModel
    {
        [Key]
        public int Id_departure_type { get; set; }
        public string departure_type_notification { get; set; }
        public string departure_type { get; set; }
        public string departure { get; set; }

        public string FullString => departure + " " + departure_type + " " + departure_type_notification;
    }
}
