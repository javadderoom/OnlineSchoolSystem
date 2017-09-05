using Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class GradesRepository
    {
        private Connection conn;
        SchoolDBEntities db;

        public GradesRepository()
        {
            conn = new Connection();
            db = new SchoolDBEntities();
        }
        public DataTable getAllGrades()
        {
            var query =
                from r in db.Grades
                select r;
            return OnlineTools.ToDataTable(query.ToList());
        }

        public string getGradeTitleByID(int id)
        {
            string query =
               (from r in db.Grades
                where r.GradeID == id
                select r.GradeTitle).SingleOrDefault();

            return query;
        }

    }
}
