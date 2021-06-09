using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using Dapper.Contrib.Extensions;
using LocalDB.Models;

namespace LocalDB.Services
{
    public partial class SqlService
    {
        public BindingList<PersonModel> GetPhysicalPersons()
        {
            using (var con = Connection())
            {
                var d = con.GetAll<PersonModel>().Where(x => x.type == false).ToList();
                return new BindingList<PersonModel>(d);
            }
        }

        public void DeletePhysicalPerson(int id)
        {
            using (SqlConnection con = Connection())
            {
                con.Delete(new PersonModel() {Id_person = id});
            }
        }

        public int InsertPhysicalPerson(PersonModel person)
        {
            using (var con = Connection())
            {
                return (int) con.Insert(person);
            }
        }

        public void UpdatePhysicalPerson(PersonModel person)
        {
            using (var con = Connection())
            {
                con.Update(person);
            }
        }
    }
}
