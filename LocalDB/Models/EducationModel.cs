using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace LocalDB.Models
{
    [Table("Education")]
    public class EducationModel
    {
        [Key]
        public int Id_education_staff { get; set; }
        public string document_type { get; set; }
        public string educational_institution { get; set; }
        public string direction { get; set; }
        public string series_diploma { get; set; }
        public string number_diploma { get; set; }
        public string liner_series { get; set; }
        public string number_liner { get; set; }
        public string type_education { get; set; }
        public string year { get; set; }
        public string qualification { get; set; }
        public int Id_staff { get; set; }
    }
}
