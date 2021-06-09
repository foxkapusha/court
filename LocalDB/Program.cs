using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using LocalDB.Services;

namespace LocalDB
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SqlService.sqlCon = Properties.Settings.Default.SqlConnectionString;

            foreach (var process in Process.GetProcessesByName("SQL Server Windows NT - 64 Bit"))
            {
                process.Kill();
            }
            foreach (var process in Process.GetProcessesByName("SQL Server Windows NT - 32 Bit"))
            {
                process.Kill();
            }
            foreach (var process in Process.GetProcessesByName("SQL Server Windows NT"))
            {
                process.Kill();
            }

            if (File.Exists("DatabaseLocalDB_log.ldf"))
                File.Delete("DatabaseLocalDB_log.ldf");

            Application.Run(new main_form());
        }
    }
}
