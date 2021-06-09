using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace LocalDB.Models
{
    [Table("Notification")]
    public class NotificationModel
    {
        [Key]
        public int Id_notification { get; set; }
        public string type_notification { get; set; }
        public int Id_person { get; set; }
        public string treck_number_package { get; set; }
        public int id_departure_type { get; set; }
        public DateTime date { get; set; }
    }
}
