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
    public class vStudentRepository
    {
        private SchoolDBEntities db = new SchoolDBEntities();
        private Connection conn;

        public vStudentRepository()
        {
            conn = new Connection();
        }

        public vStudent GetStudentByUsername(string user)
        {
            vStudent stu = db.vStudents.Where(p => p.UserName == "javad").Single();
            return stu;
        }

        public vStudent FindByNatinalCode(string nationalCode)
        {
            vStudent result = null;

            using (SchoolDBEntities sd = conn.GetContext())
            {
                //--  SELECT * FROM vPhoneList WHERE PhobeID = phoneID

                result = (from r in sd.vStudents
                          where r.NationalCode == nationalCode
                          select r).FirstOrDefault();
                return result;
            }
        }

        public vStudent FindByIdentityCode(string identityCode)
        {
            vStudent result = null;

            using (SchoolDBEntities sd = conn.GetContext())
            {
                //--  SELECT * FROM vPhoneList WHERE PhobeID = phoneID

                result = (from r in sd.vStudents
                          where r.IdentityCode == identityCode
                          select r).FirstOrDefault();
                return result;
            }
        }

        //public DataTable FindByStudentCode(int Code)
        //{
        //    List<vStudent> result = new List<vStudent>();

        //    using (SchoolDBEntities sd = conn.GetContext())
        //    {
        //        IEnumerable<vStudent> pl =
        //            from r in sd.vStudents
        //            where r.StudentCode.Contains(Code)

        //            select r;

        //        result = pl.ToList();
        //    }
        //    return OnlineTools.ToDataTable(result);
        //}

        //public List<vStudent> FindByStudentCodeList(string Code)
        //{
        //    List<vStudent> result = new List<vStudent>();

        //    using (SchoolDBEntities sd = conn.GetContext())
        //    {
        //        IEnumerable<vStudent> pl =
        //            from r in sd.vStudents
        //            where r.StudentCode.Contains(Code)

        //            select r;

        //        result = pl.ToList();
        //    }
        //    return result;
        ////}

        public Student FindByStudentCode(string id)
        {
            SchoolDBEntities db = new SchoolDBEntities();

            return db.Students.Where(p => p.StudentCode == id).Single();
        }

        public void SaveStudent(Student student)
        {
            using (SchoolDBEntities pb = conn.GetContext())
            {
                if (student.StuID > 0)
                {
                    //==== UPDATE ====
                    pb.Students.Attach(student);
                    pb.Entry(student).State = EntityState.Modified;
                }
                else
                {
                    //==== INSERT ====
                    pb.Students.Add(student);
                }

                pb.SaveChanges();
            }
        }

        public DataTable FindByName(string Name)
        {
            List<vStudent> result = new List<vStudent>();

            using (SchoolDBEntities sd = conn.GetContext())
            {
                IEnumerable<vStudent> pl =
                    from r in sd.vStudents
                    where r.FirstName.Contains(Name)

                    select r;

                result = pl.ToList();
                return OnlineTools.ToDataTable(result);
            }
        }

        public DataTable FindByFullName(string fullName)
        {
            List<vStudent> result = new List<vStudent>();

            using (SchoolDBEntities sd = conn.GetContext())
            {
                IEnumerable<vStudent> pl =
                    from r in sd.vStudents
                    where r.FirstName.Contains(fullName) || r.LastName.Contains(fullName)

                    select r;

                result = pl.ToList();
                return OnlineTools.ToDataTable(result);
            }
        }

        public DataTable FindByFullName(string firstName, string lastName)
        {
            List<vStudent> result = new List<vStudent>();

            using (SchoolDBEntities sd = conn.GetContext())
            {
                IEnumerable<vStudent> pl =
                    from r in sd.vStudents
                    where r.FirstName.Contains(firstName) && r.LastName.Contains(lastName)

                    select r;

                result = pl.ToList();
                return OnlineTools.ToDataTable(result);
            }
        }

        public DataTable FindByBirthDate(string date)
        {
            List<vStudent> result = new List<vStudent>();

            using (SchoolDBEntities sd = conn.GetContext())
            {
                IEnumerable<vStudent> pl =
                    from r in sd.vStudents
                    where r.BirthDate == date

                    select r;

                result = pl.ToList();
                return OnlineTools.ToDataTable(result);
            }
        }

        public DataTable FindByHand(bool hand)
        {
            List<vStudent> result = new List<vStudent>();

            using (SchoolDBEntities sd = conn.GetContext())
            {
                IEnumerable<vStudent> pl =
                    from r in sd.vStudents
                    where r.Hand == hand

                    select r;

                result = pl.ToList();
                return OnlineTools.ToDataTable(result);
            }
        }

        public DataTable GetAllStudents()
        {
            List<vStudent> result = new List<vStudent>();

            using (SchoolDBEntities sd = conn.GetContext())
            {
                IEnumerable<vStudent> pl =
                    from r in sd.vStudents

                    orderby r.LastName
                    select r;

                result = pl.ToList();
                return OnlineTools.ToDataTable(result);
            }
        }

        public void DeleteStudent(String stuCode)

        {
            SchoolDBEntities pb = conn.GetContext();

            Student selectedStudent = new Student();
            selectedStudent = pb.Students.Where(p => p.StudentCode == stuCode).Single();

            if (selectedStudent != null)
            {
                pb.Students.Remove(selectedStudent);
                pb.SaveChanges();
            }
        }

        public void DeleteStudents(List<string> StudeCodes)
        {
            SchoolDBEntities pb = conn.GetContext();

            var selectedStudents =
            from r in pb.Students
            join at in StudeCodes
            on r.StudentCode equals at
            select r;

            foreach (var student in selectedStudents)
            {
                pb.Students.Remove(student as Student);
            }

            pb.SaveChanges();
        }

        public void DeleteAll()
        {
            using (SchoolDBEntities pb = conn.GetContext())
            {
                System.Configuration.ConnectionStringSettingsCollection connectionStrings =
                    WebConfigurationManager.ConnectionStrings as ConnectionStringSettingsCollection;

                if (connectionStrings.Count > 0)
                {
                    System.Data.Linq.DataContext db = new System.Data.Linq.DataContext(connectionStrings["ConnectionString"].ConnectionString);

                    db.ExecuteCommand("TRUNCATE TABLE Students");
                }
            }
        }
    }
}