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
        public BindingList<NotificationModel> GetNotifications()
        {
            using (var con = Connection())
            {
                var d = con.GetAll<NotificationModel>().ToList();
                return new BindingList<NotificationModel>(d);
            }
        }

        public void DeleteNotification(int id)
        {
            using (var con = Connection())
            {
                con.Delete(new NotificationModel() {Id_notification = id});
            }
        }

        public int InsertNotification(NotificationModel notification)
        {
            using (var con = Connection())
            {
                return (int) con.Insert(notification);
            }
        }

        public void UpdateNotification(NotificationModel notification)
        {
            using (var con = Connection())
            {
                con.Update(notification);
            }
        }
    }
}
