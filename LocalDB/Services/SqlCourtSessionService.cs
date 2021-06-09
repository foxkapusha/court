using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;
using LocalDB.Models;

namespace LocalDB.Services
{
    public partial class SqlService
    {
        public BindingList<CourtSessionModel> GetCourtSessions()
        {
            using (var con = Connection())
            {
                var d = con.GetAll<CourtSessionModel>().ToList();
                return new BindingList<CourtSessionModel>(d);
            }
        }

        public void DeleteCourtSession(int id)
        {
            using (var con = Connection())
            {
                con.Delete(new CourtSessionModel() {Id_court_session = id});
            }
        }

        public int InsertCourtSession(CourtSessionModel courtSession)
        {
            using (var con = Connection())
            {
                return (int) con.Insert(courtSession);
            }
        }

        public void UpdateCourtSession(CourtSessionModel courtSession)
        {
            using (var con = Connection())
            {
                con.Update(courtSession);
            }
        }
    }
}
