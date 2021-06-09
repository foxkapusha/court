using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;
using LocalDB.Models;

namespace LocalDB.Services
{
    public partial class SqlService
    {
        public BindingList<CaseModel> GetCases()
        {
            using (var con = Connection())
            {
                var d = con.GetAll<CaseModel>().ToList();
                return new BindingList<CaseModel>(d);
            }
        }

        public void DeleteCase(int id)
        {
            using (SqlConnection con = Connection())
            {
                con.Delete(new CaseModel() {Id_case = id});
            }
        }

        public int InsertCase(CaseModel caseModel)
        {
            using (var con = Connection())
            {
                return (int) con.Insert(caseModel);
            }
        }

        public void UpdateCase(CaseModel caseModel)
        {
            using (var con = Connection())
            {
                con.Update(caseModel);
            }
        }
    }
}
