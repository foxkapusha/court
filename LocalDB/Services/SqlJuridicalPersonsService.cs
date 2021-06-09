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
        public BindingList<PersonModel> GetJuridicalPersons()
        {
            using (var con = Connection())
            {
                var d = con.GetAll<PersonModel>().Where(x => x.type == true).ToList();
                return new BindingList<PersonModel>(d);
            }
        }

        public void DeleteJuridicalPerson(int id)
        {
            using (SqlConnection con = Connection())
            {
                con.Delete(new PersonModel() { Id_person = id });
            }
        }

        public int InsertJuridicalPerson(PersonModel person)
        {
            using (var con = Connection())
            {
                return (int)con.Insert(person);
            }
        }

        public void UpdateJuridicalPerson(PersonModel person)
        {
            using (var con = Connection())
            {
                con.Update(person);
            }
        }
    }
}
