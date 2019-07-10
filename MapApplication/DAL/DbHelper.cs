using MapApplication.Context;
using MapApplication.Entities;
using System.Collections.Generic;
using System.Linq;


namespace MapApplication.DAL
{
    public static class DbHelper
    {
        public static List<Bank> BanksLoad()
        {
            using (BankContext db = new BankContext())
            {
                var banks = db.Banks.ToList<Bank>();
                return banks;
            }
        }


        public static List<Departmen> DepsLoad()
        {
            using (BankContext db = new BankContext())
            {
                var departments = db.Departments.ToList<Departmen>();
                return departments;
            }
        }


        public static List<Course> CoursesLoad()
        {
            using (BankContext db = new BankContext())
            {
                var courses = db.Courses.ToList<Course>();
                return courses;
            }
        }
    }
}
