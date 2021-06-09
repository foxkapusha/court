using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using NetOffice.OutlookApi;

namespace LocalDB.Services
{
    public class OutlookService
    {
        private object _addressBook;
        private Application _application;

        public bool Connect()
        {
            _addressBook = null;
            try
            {
                Assembly.LoadFrom(Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), "NetOffice.dll"));
                Assembly.LoadFrom(Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), "OfficeApi.dll"));
                Assembly.LoadFrom(Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), "OutlookApi.dll"));

                var assemblies = NetOffice.Core.Default.Assemblies;
                NetOffice.Core.Default.Initialize();
                assemblies = NetOffice.Core.Default.Assemblies;

                _application = new NetOffice.OutlookApi.Application();
                return true;
            }
            catch (System.Exception e)
            {
                return false;
            }
        }

        public void AddToSchedule(string message, string subMessage, DateTime dateTime)
        {
            var calendarFolder = _application.Session.GetDefaultFolder(NetOffice.OutlookApi.Enums.OlDefaultFolders.olFolderCalendar);
            var items = calendarFolder.Items;

            if (items.Any(x => (x as NetOffice.OutlookApi.AppointmentItem).ConversationTopic.ToLower() == message))
                return;

            var newAppointment = calendarFolder.Items.Add() as AppointmentItem;
            newAppointment.Start = dateTime;
            newAppointment.End = dateTime.AddHours(1);
            newAppointment.Body = subMessage;
            newAppointment.Subject = "Дело: " + message;
            newAppointment.Save();
        }
    }
}
