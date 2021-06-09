using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Dapper.Contrib.Extensions;
using LocalDB.Models;

namespace LocalDB.Services
{
    public partial class SqlService
    {
        public static string sqlCon = @"Data Source=.\SQLEXPRESS14;" +
                        @"AttachDbFilename=|DataDirectory|\DatabaseLocalDB.mdf;
                Integrated Security=True;
                Connect Timeout=10;
                User Instance=True";

        private SqlConnection Connection()
        {
            SqlConnection con = new SqlConnection(sqlCon);
            con.Open();
            return con;
        }

        public void Test()
        {
            using (SqlConnection con = Connection())
            {
                var k = con.Query("SELECT * FROM Person;");
                //var d = con.Query<StaffModel>(" SELECT * FROM Staff;");
            }
        }

        public BindingList<StaffModel> GetStaff()
        {
            using (SqlConnection con = Connection())
            {
                var d = con.GetAll<StaffModel>();
                return new BindingList<StaffModel>(d.ToList());
            }
        }

        public void DeleteStaff(int id)
        {
            using (SqlConnection con = Connection())
            {
                con.Delete(new StaffModel() {Id_staff = id});
            }
        }

        public int InsertStaff(StaffModel staff)
        {
            using (var con = Connection())
            {
                return (int)con.Insert(staff);
            }
        }

        public void UpdateStaff(StaffModel staff)
        {
            using (var con = Connection())
            {
                con.Update(staff);
            }
        }

        public BindingList<PassportStaffModel> GetPassport(int staffId)
        {
            using (var con = Connection())
            {
                var allPassprots = con.GetAll<PassportStaffModel>();
                var l = allPassprots.Where(x => x.Id_staff == staffId).ToList();
                return new BindingList<PassportStaffModel>(l);
            }
        }

        public void UpdatePassport(PassportStaffModel passport)
        {
            using (var con = Connection())
            {
                con.Update(passport);
            }
        }

        public void DeletePassport(int id)
        {
            using (var con = Connection())
            {
                con.Delete(new PassportStaffModel() {Id_passport_staff = id});
            }
        }

        public void InsertPassport(PassportStaffModel passport)
        {
            using (var con = Connection())
            {
                var a = con.Insert(passport);
            }
        }

        public BindingList<EducationModel> GetEducations(int staffId)
        {
            using (var con = Connection())
            {
                var allEducations = con.GetAll<EducationModel>();
                var l = allEducations.Where(x => x.Id_staff == staffId).ToList();
                return new BindingList<EducationModel>(l);
            }
        }

        public void UpdateEducation(EducationModel education)
        {
            using (var con = Connection())
            {
                con.Update(education);
            }
        }

        public void DeleteEducation(int id)
        {
            using (var con = Connection())
            {
                con.Delete(new EducationModel() { Id_education_staff = id });
            }
        }

        public void InsertEducation(EducationModel education)
        {
            using (var con = Connection())
            {
                var a = con.Insert(education);
            }
        }

        public StaffModel Authorize(string userName, string password)
        {
            var staffs = GetStaff();
            var staff = staffs.FirstOrDefault(x => x.login.ToLower() == userName && x.password == password);
            return staff;
        }
    }
}
