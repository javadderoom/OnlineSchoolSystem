using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using System.Data;
using System.Web.Configuration;
using System.Configuration;

namespace DataAccess.Repository
{
    public class StudentRepository
    {
        private SchoolDBEntities db = new SchoolDBEntities();
        private Connection conn;

        public StudentRepository()
        {
            conn = new Connection();
        }

        public int studentCountbyGradeID(int id)
        {
            int query =
               (from r in db.Students
                where r.CGrade == id
                select r).Count();

            return query;
        }
    }
}