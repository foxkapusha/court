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
        public BindingList<DepartureTypeModel> GetDepartureTypes()
        {
            using (var con = Connection())
            {
                var d = con.GetAll<DepartureTypeModel>().ToList();
                return new BindingList<DepartureTypeModel>(d);
            }
        }

        public void DeleteDepartureType(int id)
        {
            using (SqlConnection con = Connection())
            {
                con.Delete(new DepartureTypeModel() {Id_departure_type = id});
            }
        }

        public int InsertDepartureType(DepartureTypeModel departureType)
        {
            using (SqlConnection con = Connection())
            {
                return (int) con.Insert(departureType);
            }
        }

        public void UpdateDepartureType(DepartureTypeModel departureType)
        {
            using (var con = Connection())
            {
                con.Update(departureType);
            }
        }
    }
}
